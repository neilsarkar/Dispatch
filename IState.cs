namespace Fack {
	public delegate void StateChangeEvent();

	public interface IState {
		event StateChangeEvent OnChange;
		void TriggerChange();
	}
}
