using Leopotam.Ecs;
using UnityEngine;

namespace Code.Abstract
{
    public abstract class MonoBehaviourEntity:MonoBehaviour
    {
        public virtual EcsEntity Initial(EcsWorld world)
        {
            EcsEntity entity = world.NewEntity();
            gameObject.AddComponent<EntityRef>().Entity = entity;
            entity.Get<GameObjectRef>().GameObject = gameObject;
            entity.Get<GameObjectRef>().Transform = transform;
            Destroy(gameObject.GetComponent<MonoBehaviourEntity>());
            return entity;
        }
    }
}