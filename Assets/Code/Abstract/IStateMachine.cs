using Code.Services.States;

namespace Code.Abstract
{
	public interface IStateMachine
	{
		void ChangeState<T>() where T: class, IState;
	}
}