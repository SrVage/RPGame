using UnityEngine;

namespace Code.Abstract
{
	public interface IHeroFactory
	{
		void CreateHero();
		GameObject Hero { get; }
	}
}