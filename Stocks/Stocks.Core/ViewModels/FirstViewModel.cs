using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using Newtonsoft.Json;
using Stocks.Core.Contracts;
using Stocks.Core.DTO;

namespace Stocks.Core.ViewModels
{
	public class FirstViewModel : MvxViewModel
	{
		private IStockService _stockService;
		private List<Stock> _stocks;
		private IMvxAsyncCommand _refreshStocksCommand;
		public string Title => "Stocks View";

		public List<Stock> Stocks
		{
			get { return _stocks; }
			set
			{
				_stocks = value;
				RaisePropertyChanged(() => Stocks);
			}
		}


		public FirstViewModel(IStockService stockService)
		{
			_stockService = stockService;
			StartTimer();
		}

		public async override void Start()
		{
			base.Start();
			await Initialize();
		}

		public async override Task Initialize()
		{
			await RefreshData();
		}

		private async Task RefreshData()
		{
			var stocks = await _stockService.GetStocks();

			Stocks = stocks.Stock;
		}

		private async void StartTimer()
		{
			while (true)
			{
				await Task.Delay(15000);
				await RefreshData();
			}
		}

		public IMvxAsyncCommand RefreshStocksCommand
		{
			get
			{
				return _refreshStocksCommand ?? (_refreshStocksCommand = new MvxAsyncCommand(async () => await RefreshData()));
			}
		}
	}
}
