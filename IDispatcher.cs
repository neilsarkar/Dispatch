using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fack {
	public interface IDispatcher<TState, TAction> {
		void Run(TAction action);
		void Run(IAction<TState> action);
	}
}
