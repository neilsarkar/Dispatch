namespace Fack {
	public interface IView<TState> {
		TState State { get; }
		void Render(TState state, TState lastState);
	}
}
