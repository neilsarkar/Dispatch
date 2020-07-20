using System;

namespace Dispatch {
	public class State : IState {
		public event StateChangeEvent OnChange;
		public void TriggerChange() { OnChange?.Invoke(); }
	}
}