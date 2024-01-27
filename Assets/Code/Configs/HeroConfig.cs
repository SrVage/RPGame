using Cinemachine;
using UnityEngine;

namespace Code.Configs
{
	[CreateAssetMenu(menuName = "Configs/Characters/Hero", fileName = "HeroConfig")]
	public class HeroConfig:ScriptableObject
	{
		public GameObject HeroPrefab;
		public CinemachineVirtualCamera Camera;
	}
}