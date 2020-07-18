using System;

namespace Dispatch {
	public class Dispatcher<TState> where TState: IState {
		TState state;
		TState prev;

		public Dispatcher(TState state, TState prev) {
			this.state = state;
			this.prev = prev;
		}

		public void Run(Action<TState> action) {
			action.Invoke(state);
			state.TriggerChange();
			action.Invoke(prev);
		}
	}
}