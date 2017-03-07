// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamariniOSPopup
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnOk { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPopup { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNotification { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewPopup { get; set; }

        [Action ("BtnOk_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnOk_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnPopup_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnPopup_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnOk != null) {
                btnOk.Dispose ();
                btnOk = null;
            }

            if (btnPopup != null) {
                btnPopup.Dispose ();
                btnPopup = null;
            }

            if (lblNotification != null) {
                lblNotification.Dispose ();
                lblNotification = null;
            }

            if (viewPopup != null) {
                viewPopup.Dispose ();
                viewPopup = null;
            }
        }
    }
}