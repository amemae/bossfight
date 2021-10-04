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

    public void MoveUp()
    {

    }

    public void MoveLeft()
    {

    }

    public void MoveDown()
    {

    }

    public void MoveRight()
    {

    }
}
