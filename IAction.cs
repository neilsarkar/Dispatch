namespace Fack {
	public interface IAction<TState> {
		void Execute(TState state);
	}
}