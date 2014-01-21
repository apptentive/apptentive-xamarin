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

			ATConnect sharedConnection = ATConnect.SharedConnection;

			sharedConnection.ApiKey = "b49e8cdeeb9d8cd10d2546bb6b68f0205345e67c015b7c2c3ebf0428fe946db8";
			sharedConnection.InitialUserName = "Xam R. In";
			sharedConnection.InitialUserEmailAddress = "xamarin@example.com";

			ATAppRatingFlow.SharedRatingFlow.AppID = "343200656";

			NSDictionary config = NSDictionary.FromObjectsAndKeys(new NSObject[] {new NSString("fake_api_key")},new NSObject[] {new NSString("ABC-123-XYZ")});
			sharedConnection.AddIntegration (new NSString("xamarin_demo_integration_configuration"), config);


			sharedConnection.SendAttachmentText (new NSString ("Attachment text message from Xamarin"));

			sharedConnection.AddCustomPersonData (new NSString ("WA"), new NSString ("state"));
			sharedConnection.AddCustomDeviceData (new NSString ("Sprint"), new NSString ("carrier"));

			sharedConnection.AddCustomPersonData (new NSString ("removeThis"), new NSString ("removeThis"));
			sharedConnection.RemoveCustomPersonData (new NSString ("removeThis"));
			sharedConnection.AddCustomDeviceData (new NSString ("removeThis"), new NSString ("removeThis"));
			sharedConnection.RemoveCustomDeviceData (new NSString ("removeThis"));

			this.ratingFlowButton.TouchUpInside += ShowRatingFlowIfConditionsAreMet;
			this.messageCenterButton.TouchUpInside += PresentMessageCenter;
			this.upgradeMessageButton.TouchUpInside += EngageUpgradeMessage;
			this.surveyNoTagsButton.TouchUpInside += ShowSurveyWithNoTags;
			this.surveyWithTagsButton.TouchUpInside += ShowSurveyWithTagXamarin;
		}

		private void ShowRatingFlowIfConditionsAreMet (object sender, EventArgs e)
		{
			ATAppRatingFlow.SharedRatingFlow.ShowRatingFlowIfConditionsAreMet (this);
		}

		private void PresentMessageCenter (object sender, EventArgs e)
		{
			ATConnect.SharedConnection.PresentMessageCenter (this);
		}

		private void EngageUpgradeMessage (object sender, EventArgs e)
		{
			ATConnect.SharedConnection.Engage ("app.launch", this);
		}

		private void ShowSurveyWithNoTags (object sender, EventArgs e)
		{
			ATSurveys.PresentSurveyControllerWithNoTags(this);
		}

		private void ShowSurveyWithTagXamarin (object sender, EventArgs e)
		{
			NSSet tags = NSSet.MakeNSObjectSet<NSString> (new NSString [] {new NSString("xamarin")});
			ATSurveys.PresentSurveyController(tags, this);
		}
	}
}

