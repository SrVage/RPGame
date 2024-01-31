using Leopotam.Ecs;
using UnityEngine;

namespace Code.BaseComponents.RendererComponent
{
	[RequireComponent(typeof(Renderer))]
	public class RendererComponentInitializer:BaseComponentInitializer
	{
		[SerializeField] private Renderer _renderer;
		public override void Init(EcsEntity entity)
		{
			entity.Get<RendererComponent>().Value = _renderer ? _renderer : GetComponent<Renderer>();
		}
	}
}