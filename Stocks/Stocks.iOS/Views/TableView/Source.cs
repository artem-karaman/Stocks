using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Binding.iOS.Views;
using Stocks.iOS.Views.TableView.Cells;
using UIKit;

namespace Stocks.iOS.Views.TableView
{
	public class Source : MvxTableViewSource
	{
		public Source(UITableView tableView) : base(tableView)
		{
			tableView.RegisterNibForCellReuse(StockTableViewCell.Nib, StockTableViewCell.Key);
		}

		protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
		{
			return tableView.DequeueReusableCell(StockTableViewCell.Key);
		}
	}
}