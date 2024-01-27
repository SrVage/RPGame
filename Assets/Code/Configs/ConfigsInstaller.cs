using UnityEngine;
using Zenject;

namespace Code.Configs
{
	public class ConfigsInstaller:MonoInstaller<ConfigsInstaller>
	{
		[SerializeField] private HeroConfig _heroConfig;
		public override void InstallBindings()
		{
			Container.Bind<HeroConfig>().FromInstance(_heroConfig).AsSingle();
		}
	}
}