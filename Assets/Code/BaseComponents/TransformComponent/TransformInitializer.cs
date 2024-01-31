using Leopotam.Ecs;

namespace Code.BaseComponents.TransformComponent
{
	public class TransformInitializer:BaseComponentInitializer
	{
		public override void Init(EcsEntity entity)
		{
			entity.Get<TransformComponent>().Value = transform;
		}
	}
}