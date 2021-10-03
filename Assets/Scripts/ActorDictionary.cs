using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorDictionary : MonoBehaviour
{
    Dictionary<ActorKey, Actor> _dict;

    public void Setup(List<Actor> actors, List<ActorKey> actorkeys)
    {
        _dict = new Dictionary<ActorKey, Actor>();
        for (int i = 0; i < actors.Count; ++i)
        {
            AddActor(actorkeys[i], actors[i]);
        }
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
