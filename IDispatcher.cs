using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fack {
	public interface IDispatcher<TState, TAction> {
		TState State { get; }
		void Run(TAction action);
		void Run<TPayload>(TAction action, TPayload payload);
	}
}
