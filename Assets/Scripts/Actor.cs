using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : ActionReceiver
{
    private string _name;

    private void Awake()
    {}

    public override void MoveUp()
    {
        transform.Translate(Vector2.up);
    }
    public override void MoveLeft()
    {
        transform.Translate(Vector2.left);
    }
    public  override void MoveDown()
    {
        transform.Translate(Vector2.down);
    }
    public  override void MoveRight()
    {
        transform.Translate(Vector2.right);
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}
