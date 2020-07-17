using System;

namespace Fack {
	public class FackException : Exception {
		public FackException(string message) : base(message) {}
	}
}