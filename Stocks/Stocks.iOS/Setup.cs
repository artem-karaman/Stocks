using MvvmCross.iOS.Platform;
using MvvmCross.Core.ViewModels;
using UIKit;
using Stocks.Core;

namespace Stocks.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{
		}

		protected override IMvxApplication CreateApp() => new App();
	}
}
