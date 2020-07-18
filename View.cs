namespace Fack {
	public class View<TState> : ReleasedMonoBehaviour, IView<TState>
	where TState : IState {
		public virtual TState State {get; set;}
		public virtual TState LastState {get; set;}

		public void OnEnable() {
			State.OnChange += State_OnChange;
			OnShow();
			Render(State, default(TState));
		}

		public void OnDisable() {
			State.OnChange -= State_OnChange;
			OnHide();
		}

		void State_OnChange() {
			Render(State, LastState);
		}

		public virtual void OnShow() {}
		public virtual void OnHide() {}
		public virtual void Render(TState state, TState lastState) {}
	}

}
