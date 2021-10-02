using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorDictionary : MonoBehaviour
{
    Dictionary<ActorKey, Actor> _dict;

    public void Setup()
    {
        _dict = new Dictionary<ActorKey, Actor>();
    }

    public void AddActor(ActorKey key, Actor actor)
    {
        _dict.Add(key, actor);
    }
    
    public void RemoveActor(ActorKey key)
    {
        _dict.Remove(key);
    }

    public Actor GetActor(ActorKey key)
    {
        return _dict[key];
    }

}
