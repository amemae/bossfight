using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : ActionReceiver
{
    private string _name;

    private void Start()
    {
            
    }

    public void MoveUp()
    {
        transform.Translate(Vector2.up);
    }
    public void MoveLeft()
    {
        transform.Translate(Vector2.left);
    }
    public void MoveDown()
    {
        transform.Translate(Vector2.down);
    }
    public void MoveRight()
    {
        transform.Translate(Vector2.right);
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}
