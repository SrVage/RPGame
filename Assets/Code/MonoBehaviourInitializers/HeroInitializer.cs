using Client;
using Code.Abstract;
using Leopotam.Ecs;
using UnityEngine;

namespace Code.MonoBehaviourInitializers
{
	public class HeroInitializer:MonoBehaviourEntity
	{
		public override EcsEntity Initial(EcsWorld world)
		{
			var entity = base.Initial(world);
			Debug.LogWarning(entity);
			entity.Get<HeroTag>();
			return entity;
		}
	}
}