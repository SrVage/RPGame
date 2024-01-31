using Code.Abstract;
using Leopotam.Ecs;
using UnityEngine;

namespace Client
{
	internal sealed class MoveHeroSystem:IEcsRunSystem
	{
		private readonly EcsFilter<GameObjectRef> _transform = null;
		public void Run()
		{
			foreach (var tdx in _transform)
			{
				ref var transform = ref _transform.Get1(tdx).Transform;
				transform.position += Vector3.forward * Time.deltaTime;
			}
		}
	}
}