using System;

namespace Fack {
	public abstract class Dispatcher<TState, TAction> : IDispatcher<TState, TAction> where TState: IState where TAction : System.Enum {
		TState state;
		TState prev;
		Func<TAction, IAction<TState>> defaultAction;

		public Dispatcher(TState state, TState prev, Func<TAction, IAction<TState>> defaultAction) {
			this.state = state;
			this.prev = prev;
			this.defaultAction = defaultAction;
		}

		public void Run(TAction action) {
			Run(defaultAction?.Invoke(action));
		}

		public void Run(IAction<TState> action) {
			Run(action, state);
			state.TriggerChange();
			Run(action, prev);
		}

		void Run(IAction<TState> action, TState state) {
			action.Execute(state);
		}
	}
}