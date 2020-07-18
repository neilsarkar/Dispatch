# Dispatch

A unity utility for redux-style dispatching of actions that update a state.

Adding this overhead allows us to add features that are useful in react-redux such as logging and history.

```csharp
using System;
using Dispatch;

// state holds a bunch of fields and properties
public class MyState : State {
	public int Cool;
	public List<int> Great = new List<int>();
}

// dispatcher runs actions that update the state and trigger OnChange
public static class MyActions {
	public static Action<MyState> IncrementCool => (state) => {
		state.Cool++;
	}

	public static Action<MyState> SetGreat(List<int> great) => (state) => {
		state.Great = great;
	}
}
```