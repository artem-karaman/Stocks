using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Converters;

namespace Stocks.Core.Converters
{
	public class DecimalToStringValueConverter : MvxValueConverter<decimal, string>
	{
		protected override string Convert(decimal value, Type targetType, object parameter, CultureInfo culture)
		{
			return value.ToString("#,#0.00");
		}
	}
}
