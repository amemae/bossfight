using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader
{
    private static InputReader _instance;

    public static InputReader Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new InputReader();
            }
            return _instance;
        }
    }

    public void ReadInput()
    {
        GameManager.Actions action = GameManager.Actions.NONE;
        if (Input.GetKeyDown(_moveUp))
        {
            action = GameManager.Actions.MOVE_UP;
        }
        if (Input.GetKeyDown(_moveLeft))
        {
            action = GameManager.Actions.MOVE_LEFT;
        }
        if (Input.GetKeyDown(_moveDown))
        {
            action = GameManager.Actions.MOVE_DOWN;
        }
        if (Input.GetKeyDown(_moveRight))
        {
            action = GameManager.Actions.MOVE_RIGHT;
        }

        ActionInterpreter.Instance.Interpret(action);
    }

    private string _moveUp = "w";
    private string _moveLeft = "a";
    private string _moveDown = "s";
    private string _moveRight = "d";
    /*private string _menuUp = "up";
    private string _menuLeft = "left";
    private string _menuDown = "down";
    private string _menuRight = "right";
    private string _confirm = "enter";*/
}
