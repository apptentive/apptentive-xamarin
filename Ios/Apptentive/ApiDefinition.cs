using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Apptentive {
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
	//
	[BaseType (typeof (NSObject))]
	public partial interface ATConnect {
		[Notification]
		[Field ("ATMessageCenterUnreadCountChangedNotification", "__Internal")]
		NSString DidStartNotification { get; }

		[Field("ATIntegrationKeyUrbanAirship", "__Internal")]
		NSString ATIntegrationKeyUrbanAirship { get; }

		[Static, Export ("sharedConnection")]
		ATConnect SharedConnection { get; }

		[Export ("apiKey")]
		string ApiKey { get; set; }

		[Export ("unreadMessageCount")]
		string UnreadMessageCount { get; set; }

		[Export ("presentMessageCenterFromViewController:")]
		void PresentMessageCenter (UIViewController viewController);

		[Export ("engage:fromViewController:")]
		void Engage (string codePoint, UIViewController viewController);

		[Export ("didReceiveRemoteNotification:fromViewController:")]
		void DidReceiveRemoteNotification (NSDictionary userInfo, UIViewController viewController);

		/*!
 		* Attach text, images, or files to the user's feedback.
		* These attachments will appear in your online Apptentive dashboard,
		* but will *not* appear in Message Center on the device.
		*/
		/*
		//TODO: Enable in 1.2.6
		[Export ("sendAttachmentText")]
		void SendAttachmentText (NSString attachmentText);

		[Export ("sendAttachmentImage")]
		void SendAttachmentText (UIImage attachmentImage);

		[Export ("sendAttachmentFile:withMimeType:")]
		void SendAttachmentFile (NSData file, NSString mimeType);
		*/

		/*! Adds an additional data field to any feedback sent. Object should be an NSDate, NSNumber, or NSString. */
		[Export ("addCustomPersonData:withKey:")]
		void AddCustomPersonData (NSObject personData, NSString key);

		[Export ("addCustomDeviceData:withKey:")]
		void AddCustomDeviceData (NSObject deviceData, NSString key);


		/*! Removes an additional data field from the feedback sent. */
		[Export ("removeCustomPersonDataWithKey:")]
		void RemoveCustomPersonData (NSString key);

		[Export ("removeCustomDeviceDataWithKey:")]
		void RemoveCustomDeviceData (NSString key);


		/*! Add or remove a token for 3rd-party integration services. */
		[Export ("addIntegration:withConfiguration:")]
		void AddIntegration (NSString integration, NSDictionary configuration);

		[Export ("removeIntegration:")]
		void RemoveIntegration (NSString key);

		[Export ("showTagline")]
		bool ShowTagline { get; set; }

		[Export ("showEmailField")]
		bool ShowEmailField { get; set; }

		[Export ("initialUserName")]
		string InitialUserName { get; set; }

		[Export ("initialUserEmailAddress")]
		string InitialUserEmailAddress { get; set; }

		[Export ("customPlaceholderText")]
		string CustomPlaceholderText { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface ATAppRatingFlow {
		[Static, Export ("sharedRatingFlow")]
		ATAppRatingFlow SharedRatingFlow { get; }

		[Export ("appID")]
		string AppID { get; set; }

		[Export ("showRatingFlowFromViewControllerIfConditionsAreMet:")]
		void ShowRatingFlowIfConditionsAreMet (UIViewController viewController);

		[Export ("logSignificantEvent")]
		void LogSignificantEvent ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface ATSurveys {
		[Notification]
		[Field ("ATSurveyNewSurveyAvailableNotification", "__Internal")]
		NSString DidStartNotification { get; }

		[Static, Export ("hasSurveyAvailableWithTags:")]
		bool HasSurveyAvailable(NSSet tags);

		[Static, Export ("presentSurveyControllerWithTags:fromViewController:")]
		void PresentSurveyController(NSSet tags, UIViewController viewController);

		[Static, Export ("hasSurveyAvailableWithNoTags")]
		bool HasSurveyAvailableWithNoTags();

		[Static, Export ("presentSurveyControllerWithNoTagsFromViewController:")]
		void PresentSurveyControllerWithNoTags(UIViewController viewController);
	}
}