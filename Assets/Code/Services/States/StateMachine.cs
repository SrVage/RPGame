using System;
using System.Collections.Generic;
using Code.Abstract;
using Zenject;

namespace Code.Services.States
{
	internal class StateMachine:IStateMachine
	{
		private Dictionary<Type, IState> _states;
		private IState _activeState;

		public StateMachine(DiContainer container)
		{
			_states = new Dictionary<Type, IState>()
			{
				{typeof(InitializeState), new InitializeState(container)}
			};
			ChangeState<InitializeState>();
		}
		
		public void ChangeState<T>() where T: class, IState
		{
			if (_activeState != null)
				_activeState.Exit();
			var state = _states[typeof(T)];
			state.Enter();
			_activeState = state;
		}
	}
}