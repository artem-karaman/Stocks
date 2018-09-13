using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using Stocks.Core.Converters;
using UIKit;

namespace Stocks.iOS.Views.TableView.Cells
{
	public partial class StockTableViewCell : MvxTableViewCell
	{
		public static readonly NSString Key = new NSString("StockTableViewCell");
		public static readonly UINib Nib;

		static StockTableViewCell()
		{
			Nib = UINib.FromName("StockTableViewCell", NSBundle.MainBundle);
		}

		protected StockTableViewCell(IntPtr handle) : base(handle)
		{
			this.DelayBind(() => 
			{
				var set = this.CreateBindingSet<StockTableViewCell, Stocks.Core.DTO.Stock>();
				set.Bind(NameTextLabel).To(vm => vm.Name);
				set.Bind(VolumeTextLabel).To(vm => vm.Volume);
				set.Bind(AmountTextLabel).To(vm => vm.Price.Amount).WithConversion(new DecimalToStringValueConverter());
				set.Apply();

			});
		}

		public override void AwakeFromNib()
		{
			UISettings();
		}

		private void UISettings()
		{
			NameTitleLabel.Text = "Name: ";
			VolumeTitleLabel.Text = "Volume: ";
			AmountTitleLabel.Text = "Amount: ";
		}
	}
}
