using Code.BaseComponents;
using Leopotam.Ecs;
using UnityEngine;

namespace Code.Abstract
{
    public abstract class MonoBehaviourEntity:MonoBehaviour
    {
        [SerializeField] protected BaseComponentInitializer[] _components;
        private void Awake() => 
            _components = GetComponentsInChildren<BaseComponentInitializer>();

        public virtual EcsEntity Initial(EcsWorld world)
        { 
            EcsEntity entity = world.NewEntity();
            gameObject.AddComponent<EntityRef>().Entity = entity;
            foreach (var component in _components)
            {
                component.Init(entity);
            }
            Destroy(this);
            return entity;
        }
    }
}