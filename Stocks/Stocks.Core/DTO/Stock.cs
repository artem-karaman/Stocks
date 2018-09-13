using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Core.DTO
{
	public class Stock
	{
		public string Name { get; set; }
		public Price Price { get; set; }
		public double Percent_Change { get; set; }
		public int Volume { get; set; }
		public string Symbol { get; set; }
	}
}
