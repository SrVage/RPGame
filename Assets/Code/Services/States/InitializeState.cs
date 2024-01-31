using System.Threading.Tasks;
using Client;
using Code.Abstract;
using Leopotam.Ecs;
using UnityEngine;
using Zenject;

namespace Code.Services.States
{
	public class InitializeState:IState
	{
		private readonly IHeroFactory _heroFactory;
		private readonly DiContainer _container;

		public InitializeState(DiContainer container)
		{
			_container = container;
			_heroFactory = container.Resolve<IHeroFactory>();
		}
		public async void Enter()
		{
			_container.Resolve<EcsStartup>();
			await Task.Delay(10);
			_heroFactory.CreateHero();
			var spawnPoint = _container.ResolveId<Transform>("Spawn");
			_heroFactory.Hero.transform.position = spawnPoint.position;
		}

		public void Exit()
		{
			
		}
	}
}