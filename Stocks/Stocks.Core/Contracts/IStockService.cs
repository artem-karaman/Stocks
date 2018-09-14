using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Core.Contracts
{
	public interface IStockService
	{
		Task<DTO.Stocks> GetStocks(string url);
	}
}
