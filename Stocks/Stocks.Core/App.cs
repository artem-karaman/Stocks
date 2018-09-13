using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using Stocks.Core.Contracts;
using Stocks.Core.Services;
using Stocks.Core.ViewModels;

namespace Stocks.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			RegisterAppStart<FirstViewModel>();

			RegisterIocServices();
		}

		private void RegisterIocServices()
		{
			Mvx.LazyConstructAndRegisterSingleton<IStockService, StockService>();
		}
	}
}
