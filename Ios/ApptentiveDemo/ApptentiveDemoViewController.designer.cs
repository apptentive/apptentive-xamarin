// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace ApptentiveDemo
{
	[Register ("ApptentiveDemoViewController")]
	partial class ApptentiveDemoViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton messageCenterButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton ratingFlowButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton surveyNoTagsButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton surveyWithTagsButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton upgradeMessageButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (messageCenterButton != null) {
				messageCenterButton.Dispose ();
				messageCenterButton = null;
			}

			if (ratingFlowButton != null) {
				ratingFlowButton.Dispose ();
				ratingFlowButton = null;
			}

			if (upgradeMessageButton != null) {
				upgradeMessageButton.Dispose ();
				upgradeMessageButton = null;
			}

			if (surveyNoTagsButton != null) {
				surveyNoTagsButton.Dispose ();
				surveyNoTagsButton = null;
			}

			if (surveyWithTagsButton != null) {
				surveyWithTagsButton.Dispose ();
				surveyWithTagsButton = null;
			}
		}
	}
}
