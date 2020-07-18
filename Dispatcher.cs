namespace Fack {
	public class Dispatcher<TState, TAction> : IDispatcher<TState, TAction> where TState: IState where TAction : System.Enum {
		TState state;
		TState prev;

		public Dispatcher(TState state, TState prev) {
			this.state = state;
			this.prev = prev;
		}

		public virtual void Run(TAction action) {}

		public void Run(IAction<TState> action) {
			Run(action, state);
			state.TriggerChange();
			Run(action, prev);
		}

		void Run(IAction<TState> action, TState state) {
			action.Execute(state);
		}

		// Run(new UIActions.Run(action));
	}
}