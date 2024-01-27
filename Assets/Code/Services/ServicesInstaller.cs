using Code.Abstract;
using Code.Services.Factory;
using Code.Services.States;
using Leopotam.Ecs;
using UnityEngine;
using UnityEngine.Rendering;
using Zenject;

namespace Code.Services
{
	public class ServicesInstaller:MonoInstaller<ServicesInstaller>
	{
		[SerializeField] private Transform _spawnPoint;
		public override void InstallBindings()
		{
			EcsWorld world = new EcsWorld();
			Container.Bind<Transform>().WithId("Spawn").FromInstance(_spawnPoint).AsSingle();
			Container.Bind<EcsWorld>().FromInstance(world).AsSingle();
			Container.Bind<IStateMachine>().To<StateMachine>().AsSingle().NonLazy();
			Container.Bind<IHeroFactory>().To<HeroFactory>().AsSingle();
		}
	}
}