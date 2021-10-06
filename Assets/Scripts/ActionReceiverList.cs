using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionReceiverList : IEnumerable<ActionReceiver>
{
    private List<ActionReceiver> _actionRecs;

    public ActionReceiverList()
    {
        _actionRecs = new List<ActionReceiver>();
    }

    public void Add(ActionReceiver actionReceiver)
    {
        _actionRecs.Add(actionReceiver);
    }


    public void Remove(ActionReceiver actionReceiver)
    {
        _actionRecs.Remove(actionReceiver);
    }

    public IEnumerator<ActionReceiver> GetEnumerator()
    {
        return _actionRecs.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _actionRecs.GetEnumerator();
    }
}
