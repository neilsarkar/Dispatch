using System;

public class UIState {
	public static UIState Singleton = new UIState();
	public static UIState Previous = new UIState();

	public Action OnChange;
	public void TriggerChange() { OnChange?.Invoke(); }

	public int Cool { get; set; }
	public bool Nice { get; set; }

	public static void Reset() {
		Singleton = new UIState();
		Previous = new UIState();
	}
}