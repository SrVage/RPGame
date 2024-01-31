using Leopotam.Ecs;
using UnityEngine;

namespace Code.BaseComponents
{
	public abstract class BaseComponentInitializer:MonoBehaviour
	{
		public abstract void Init(EcsEntity entity);
	}
}