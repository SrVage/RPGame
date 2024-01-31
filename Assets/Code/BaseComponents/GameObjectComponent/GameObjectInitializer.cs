using Leopotam.Ecs;

namespace Code.BaseComponents.GameObjectComponent
{
	public class GameObjectInitializer:BaseComponentInitializer
	{
		public override void Init(EcsEntity entity)
		{
			entity.Get<GameObjectComponent>().Value = gameObject;
		}
	}
}