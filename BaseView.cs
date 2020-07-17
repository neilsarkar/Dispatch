using Fack;

public class BaseView : ReleasedMonoBehaviour, IView<UIState> {
	UIState state;
	public UIState State => state != null ? state : state = UIState.Singleton;

	UIState lastState;
	public void OnEnable() {
		State.OnChange += State_OnChange;
		OnShow();
		Render(State, null);
	}

	public void OnDisable() {
		State.OnChange -= State_OnChange;
		OnHide();
	}

	void State_OnChange() {
		Render(State, UIState.Previous);
	}

	public virtual void OnShow() {}
	public virtual void OnHide() {}
	public virtual void Render(UIState state, UIState lastState) {}
}
