using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionReceiver : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.AttachActionReceiver(this);
    }

    public void Attach()
    {
        GameManager.Instance.AttachActionReceiver(this);
    }

    public void Detach()
    {
        GameManager.Instance.DetachActionReceiver(this);
    }

    public void ReceiveMessage()
    {

    }

    virtual public void MoveUp()
    {

    }

    virtual public void MoveLeft()
    {

    }

    virtual public void MoveDown()
    {

    }

    virtual public void MoveRight()
    {

    }
}
