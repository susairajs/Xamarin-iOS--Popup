using System;

using UIKit;

namespace XamariniOSPopup
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BtnOk_TouchUpInside(UIButton sender)
		{
			viewPopup.Hidden = true;
		}

		partial void BtnPopup_TouchUpInside(UIButton sender)
		{
			viewPopup.Hidden = false;

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
