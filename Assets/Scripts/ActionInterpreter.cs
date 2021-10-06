using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionInterpreter
{
    private static ActionInterpreter _instance;
    public static ActionInterpreter Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ActionInterpreter();
            }
            return _instance;
        }
    }

    public void Interpret (GameManager.Actions action)
    {
        switch(action)
        {
            case GameManager.Actions.MOVE_UP:
                foreach (ActionReceiver rec in GameManager.Instance.ActionReceivers)
                {
                    rec.MoveUp();
                }
                break;
            case GameManager.Actions.MOVE_LEFT:
                foreach (ActionReceiver rec in GameManager.Instance.ActionReceivers)
                {
                    rec.MoveLeft();
                }
                break;
            case GameManager.Actions.MOVE_DOWN:
                foreach (ActionReceiver rec in GameManager.Instance.ActionReceivers)
                {
                    rec.MoveDown();
                }
                break;
            case GameManager.Actions.MOVE_RIGHT:
                foreach (ActionReceiver rec in GameManager.Instance.ActionReceivers)
                {
                    rec.MoveRight();
                }
                break;
        }
    }
}
