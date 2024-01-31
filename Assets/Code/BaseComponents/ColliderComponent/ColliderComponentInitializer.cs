using Leopotam.Ecs;
using UnityEngine;

namespace Code.BaseComponents.ColliderComponent
{
	[RequireComponent(typeof(Collider))]
	public class ColliderComponentInitializer:BaseComponentInitializer
	{
		[SerializeField] private Collider _collider;
		public override void Init(EcsEntity entity)
		{
			entity.Get<ColliderComponent>().Value = _collider ? _collider : GetComponent<Collider>();
		}
	}
}