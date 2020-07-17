using Fack;

public class Dispatcher : IDispatcher<UIState, UIAction> {
	UIState state;
	public UIState State => state;
	UIState prev;

	public Dispatcher(UIState state, UIState prev) {
		this.state = state;
		this.prev = prev;
	}

	public void Run(UIAction action) {
		Run(action, state);
		state.TriggerChange();
		Run(action, prev);
	}

	void Run(UIAction action, UIState state) {
		switch(action) {
			case UIAction.IncrementCool :
				state.Cool++;
				break;
		}
	}

	public void Run<TPayload>(UIAction action, TPayload payload) {
		throw new System.NotImplementedException();
	}
}