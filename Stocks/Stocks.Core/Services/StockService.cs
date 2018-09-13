using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stocks.Core.Constants;
using Stocks.Core.Contracts;
using Stocks.Core.DTO;

namespace Stocks.Core.Services
{
	public class StockService : IStockService
	{
		public async Task<DTO.Stocks> GetStocks()
		{
			DTO.Stocks stocks = new DTO.Stocks();

			try
			{
				var client = new HttpClient();
				var json = await client.GetStringAsync(UrlConstants.StockUrl);
				stocks = JsonConvert.DeserializeObject<DTO.Stocks>(json.ToString());
			}
			catch (System.Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}

			return stocks;
		}
	}
}
