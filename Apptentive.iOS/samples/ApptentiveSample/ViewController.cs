using System;

using UIKit;
using ApptentiveSDK.iOS;

namespace ApptentiveSample
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

            EngageButton.TouchUpInside += delegate {
                var eventName = EventNameTextField.Text;
                Apptentive.Shared.Engage(eventName, this);
            };

            MessageCenterButton.TouchUpInside += delegate {
                Apptentive.Shared.PresentMessageCenter(this);
            };

            CanShowInteractionButton.TouchUpInside += delegate {
                var eventName = EventNameTextField.Text;
                var canShow = Apptentive.Shared.CanShowInteraction(eventName);
                var alertController = UIAlertController.Create("Apptentive", canShow ? "Yes" : "No", UIAlertControllerStyle.Alert);
                alertController.AddAction(UIAlertAction.Create("Close", UIAlertActionStyle.Cancel, (obj) => alertController.DismissViewController(true, null)));
                PresentViewController(alertController, true, null);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            DataViewController VC = (DataViewController)segue.DestinationViewController;

            if (sender == UserDataButton) {
                VC.Source = DataViewControllerSource.Person;
            } else {
                VC.Source = DataViewControllerSource.Device;
            }
        }
    }
}
