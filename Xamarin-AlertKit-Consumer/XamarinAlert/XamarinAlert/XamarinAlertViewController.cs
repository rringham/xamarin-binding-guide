using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using AlertKit;

namespace XamarinAlert
{
	public partial class XamarinAlertViewController : UIViewController, IAKAlertDelegate
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		private AKAlert akAlert;

		public XamarinAlertViewController (IntPtr handle) : base (handle)
		{
		}

		[Action ("AlertButtonPressed:")]
		public void AlertButtonPressed (NSObject sender)
		{
			akAlert = new AKAlert (new NSString("Oh no, somethign alert-worthy has occurred in our Xamarin host app!"));
			akAlert.Delegate = this;
			akAlert.Alert ();
		}

		public void SuccessfullyAlertedUser ()
		{
			this.View.BackgroundColor = UIColor.Blue;
		}
	}
}