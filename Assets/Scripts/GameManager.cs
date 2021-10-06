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
    private ActionReceiverList _actionRecs;

    public Actor _testActor;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    public ActionReceiverList ActionReceivers
    {
        get { return _actionRecs; }
    }

    private void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        _turnOrder = new TurnOrder();
        _actorDict = new ActorDictionary();
        _actionRecs = new ActionReceiverList();

        SetupGame();
    }

    private void Update()
    {
        InputReader.Instance.ReadInput();
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

        Actor actor = _testActor;
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
