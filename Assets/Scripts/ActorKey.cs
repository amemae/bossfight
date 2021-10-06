using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorKey
{
    private string _key;
    private string _secondaryKey;

    public ActorKey(string key, string secondaryKey = "")
    {
        _key = key;
        _secondaryKey = key;
    }
}
