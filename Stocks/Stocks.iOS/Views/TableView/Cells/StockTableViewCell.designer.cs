// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Stocks.iOS.Views.TableView.Cells
{
    [Register ("StockTableViewCell")]
    partial class StockTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AmountTextLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AmountTitleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NameTextLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NameTitleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VolumeTextLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VolumeTitleLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AmountTextLabel != null) {
                AmountTextLabel.Dispose ();
                AmountTextLabel = null;
            }

            if (AmountTitleLabel != null) {
                AmountTitleLabel.Dispose ();
                AmountTitleLabel = null;
            }

            if (NameTextLabel != null) {
                NameTextLabel.Dispose ();
                NameTextLabel = null;
            }

            if (NameTitleLabel != null) {
                NameTitleLabel.Dispose ();
                NameTitleLabel = null;
            }

            if (VolumeTextLabel != null) {
                VolumeTextLabel.Dispose ();
                VolumeTextLabel = null;
            }

            if (VolumeTitleLabel != null) {
                VolumeTitleLabel.Dispose ();
                VolumeTitleLabel = null;
            }
        }
    }
}