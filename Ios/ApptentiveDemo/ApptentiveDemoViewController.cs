using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using ApptentiveDemo;
using Apptentive;

namespace ApptentiveDemo
{
	public partial class ApptentiveDemoViewController : UIViewController
	{
		public ApptentiveDemoViewController () : base ("ApptentiveDemoViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.View.BackgroundColor = UIColor.Blue;

			this.changeColorButton.TouchUpInside += handleButtonPress;

			// Perform any additional setup after loading the view, typically from a nib.
		}

		private void handleButtonPress (object sender, EventArgs e)
		{
			this.View.BackgroundColor = UIColor.Purple;

			//Apptentive testing
			ATConnect sharedConnection = ATConnect.SharedConnection;
			sharedConnection.InitialUserEmailAddress = "peter@apptentive.com";
			Console.WriteLine("InitialUserEmailAddress: " + sharedConnection.InitialUserEmailAddress);
		}
	}
}

