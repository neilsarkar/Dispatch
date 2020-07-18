namespace Fack {
	public interface IView<TState> where TState : IState {
		TState State { get; }
		void Render(TState state, TState lastState);
	}
}
