using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOrderList
{
    List<Actor> _turnOrder;
    private int _headIndex;

    private void Awake()
    {
        _turnOrder = new List<Actor>();
        _headIndex = -1;
    }

    public void Insert(Actor actor)
    {

        if (_headIndex == -1)
        {
            _turnOrder.Add(actor);
            _headIndex = 0;

            _turnOrder[_headIndex].Attach();
        }
        else
        {
            _turnOrder.Insert(_headIndex, actor);
        }
    }

    public void Insert(Actor actor, int index)
    {
        if (_headIndex == -1)
        {
            _turnOrder.Add(actor);
            _headIndex = 0;
        }

        //新しいものはリストの最後のインデックスの後なら最後のものになって
        if (index > _turnOrder.Count - 1)
        {
            if (_headIndex == 0)
            {
                _turnOrder.Add(actor);
                ++_headIndex;
            }
            else
            {
                _turnOrder.Insert(_headIndex - 1, actor);
                ++_headIndex;
            }
        }

    }

    public void Remove(Actor actor)
    {
        int actorIndex = _turnOrder.IndexOf(actor);
        _turnOrder[_headIndex].Detach();
        if (actorIndex < _headIndex)
        {
            --_headIndex;
        }
        _turnOrder.Remove(actor);
    }

    public void AdvanceHead(int steps = 1)
    {
        _turnOrder[_headIndex].Detach();

        _headIndex += steps;
        _headIndex %= _turnOrder.Count;

        _turnOrder[_headIndex].Attach();
    }
}
