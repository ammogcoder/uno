#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.ConversationalAgent
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ConversationalAgentSystemStateChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSystemStateChangeType SystemStateChangeType
		{
			get
			{
				throw new global::System.NotImplementedException("The member ConversationalAgentSystemStateChangeType ConversationalAgentSystemStateChangedEventArgs.SystemStateChangeType is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSystemStateChangedEventArgs.SystemStateChangeType.get
	}
}
