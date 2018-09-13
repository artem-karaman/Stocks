using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Stocks.Core.ViewModels;
using Stocks.iOS.Views.TableView;
using UIKit;


namespace Stocks.iOS.ViewController
{
	public class FirstViewController : MvxTableViewController<FirstViewModel>
	{
		UIBarButtonItem _refreshButton;
		MvxFluentBindingDescriptionSet<FirstViewController, FirstViewModel> _bindingSet;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			CreateUIElements();

			Bind();
		}

		private void CreateUIElements()
		{
			_refreshButton = new UIBarButtonItem() { Image = UIImage.FromBundle("") };
		}

		void Bind()
		{
			_bindingSet = this.CreateBindingSet<FirstViewController, FirstViewModel>();

			var source = new Source(TableView);
			TableView.Source = source;

			_bindingSet.Bind().For(vc => vc.Title).To(vm => vm.Title);
			_bindingSet.Bind(source).To(vm => vm.Stocks);

			_bindingSet.Apply();
		}
	}
}