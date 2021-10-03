using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOrder : MonoBehaviour
{
    private TurnOrderList _list;
    void Awake()
    {
        _list = new TurnOrderList();
    }

    public void AddActor(Actor actor)
    {
        _list.Insert(actor);
    }

    public void AddActor(Actor actor, int index)
    {
        _list.Insert(actor, index);
    }
    public void RemoveActor(Actor actor)
    {
        _list.Remove(actor);
    }

    public void NextTurn()
    {
        _list.AdvanceHead();
    }
}
