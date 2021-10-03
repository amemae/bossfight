using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    ActorDictionary _actorDict;
    TurnOrder _turnOrder;
    void Awake()
    {
        _actorDict = new ActorDictionary();
        _turnOrder = new TurnOrder();

        SetupGame();
    }

    private void SetupGame()
    {
        SetupActors();
    }

    private void SetupActors()
    {
        //Example and test code
        List<Actor> actorList = new List<Actor>();
        List<ActorKey> actorKeyList = new List<ActorKey>();

        Actor actor = new Actor();
        actor.Name = "Ghosty";
        actorList.Add(actor);

        ActorKey actorKey = new ActorKey(actor.Name);
        actorKeyList.Add(actorKey);

        _turnOrder.AddActor(actor);
    }
    
}
