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

    void AddActor(Actor actor)
    {
        _list.Insert(actor);
    }

    void AddActor(Actor actor, int index)
    {
        _list.Insert(actor, index);
    }
    void RemoveActor(Actor actor)
    {
        _list.Remove(actor);
    }

    void NextTurn()
    {
        _list.AdvanceHead();
    }
}
