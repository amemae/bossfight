using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Actions
    {
        MOVE_UP,
        MOVE_LEFT,
        MOVE_DOWN,
        MOVE_RIGHT,
        NONE
    }

    private static GameManager _instance;
    private ActorDictionary _actorDict;
    private TurnOrder _turnOrder;
    private List<ActionReceiver> _actionRecs;
    private ActionInterpreter _actionInter;
    
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }
            return _instance;
        }
    }

    public List<ActionReceiver> ActionReceivers
    {
        get { return _actionRecs; }
    }

    public ActionInterpreter ActionInterpreter
    {
        get { return _actionInter; }
    }

    void Awake()
    {
        _actorDict = new ActorDictionary();
        _turnOrder = new TurnOrder();

        SetupGame();
    }

    private void Update()
    {
        
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
    
    public void AttachActionReceiver(ActionReceiver actRec)
    {
        _actionRecs.Add(actRec);
    }

    public void DetachActionReceiver(ActionReceiver actRec)
    {
        _actionRecs.Remove(actRec);
    }
}
