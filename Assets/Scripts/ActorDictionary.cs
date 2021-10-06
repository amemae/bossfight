using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorDictionary
{
    Dictionary<ActorKey, Actor> _dict;


    public void AddActor(ActorKey key, Actor actor)
    {
        _dict.Add(key, actor);
    }

    public void AddActor(List<ActorKey> actorKeys, List<Actor> actors)
    {
        _dict = new Dictionary<ActorKey, Actor>();
        for (int i = 0; i < actors.Count; ++i)
        {
            AddActor(actorKeys[i], actors[i]);
        }
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
