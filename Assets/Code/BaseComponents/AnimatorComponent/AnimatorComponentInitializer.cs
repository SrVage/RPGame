using Leopotam.Ecs;
using UnityEngine;

namespace Code.BaseComponents.AnimatorComponent
{
	[RequireComponent(typeof(Animator))]
	public class AnimatorComponentInitializer:BaseComponentInitializer
	{
		[SerializeField] private Animator _animator;
		public override void Init(EcsEntity entity)
		{
			entity.Get<AnimatorComponent>().Value = _animator ? _animator : GetComponent<Animator>();
		}
	}
}