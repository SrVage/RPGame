using Code.Abstract;
using Code.Configs;
using Leopotam.Ecs;
using UnityEngine;

namespace Code.Services.Factory
{
	internal class HeroFactory:IHeroFactory
	{
		public GameObject Hero { get; private set; }
		private readonly HeroConfig _heroConfig = null;
		private readonly EcsWorld _world = null;

		public HeroFactory(HeroConfig heroConfig, EcsWorld world)
		{
			_heroConfig = heroConfig;
			_world = world;
		}
		public void CreateHero()
		{
			Hero = Object.Instantiate(_heroConfig.HeroPrefab);
			BindCamera(Hero.transform);
			Hero.GetComponent<MonoBehaviourEntity>().Initial(_world);
		}

		private void BindCamera(Transform heroTransform)
		{
			var camera = Object.Instantiate(_heroConfig.Camera);
			camera.Follow = heroTransform;
		}
	}
}