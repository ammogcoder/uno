#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WindowManagement
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FullScreenPresentationConfiguration : global::Windows.UI.WindowManagement.AppWindowPresentationConfiguration
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsExclusive
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool FullScreenPresentationConfiguration.IsExclusive is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.WindowManagement.FullScreenPresentationConfiguration", "bool FullScreenPresentationConfiguration.IsExclusive");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public FullScreenPresentationConfiguration() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.WindowManagement.FullScreenPresentationConfiguration", "FullScreenPresentationConfiguration.FullScreenPresentationConfiguration()");
		}
		#endif
		// Forced skipping of method Windows.UI.WindowManagement.FullScreenPresentationConfiguration.FullScreenPresentationConfiguration()
		// Forced skipping of method Windows.UI.WindowManagement.FullScreenPresentationConfiguration.IsExclusive.get
		// Forced skipping of method Windows.UI.WindowManagement.FullScreenPresentationConfiguration.IsExclusive.set
	}
}
