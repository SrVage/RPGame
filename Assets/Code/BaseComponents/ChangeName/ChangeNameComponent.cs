using Leopotam.Ecs;
using Leopotam.Ecs.UnityIntegration;
using UnityEngine;

namespace Code.BaseComponents.ChangeName
{
	public class ChangeNameComponent:MonoBehaviour
	{
		[SerializeField] private string _text;
		public void Init(EcsEntity entity)
		{
#if UNITY_EDITOR
			foreach (var entityObserver in FindObjectsOfType<EcsEntityObserver>())
			{
				if (entityObserver.Entity == entity)
				{
					entityObserver.gameObject.name = _text + entityObserver.gameObject.name;
					Debug.Log("Change name");
				}
			}
#endif
		}
	}
}