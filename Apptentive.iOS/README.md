# Apptentive Xamarin iOS SDK

## Register Apptentive
Register Apptentive in your Application class.

```
using ApptentiveSDK.iOS;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        ...
    
        var configuration = new ApptentiveConfiguration("Your Apptentive Key", "Your Apptentive Signature");
        Apptentive.Register(configuration);

        return true;
    }
}
```
Make sure you use the Apptentive App Key and Signature for the iOS app you created in the Apptentive console. Sharing these keys between two apps, or using keys from the wrong platform is not supported, and will lead to incorrect behavior. You can find them [here](https://be.apptentive.com/apps/current/settings/api).

## Message Center

See: [How to Use Message Center](https://learn.apptentive.com/knowledge-base/how-to-use-message-center/)

### Showing Message Center

With the Apptentive Message Center your customers can send feedback, and you can reply, all without making them leave the app. Handling support inside the app will increase the number of support messages received and ensure a better customer experience.

Message Center lets customers see all the messages they have send you, read all of your replies, and even send screenshots that may help debug issues.

Add [Message Center](http://learn.apptentive.com/knowledge-base/apptentive-android-sdk-features/#message-center) to talk to your customers.

Find a place in your app where you can add a button that opens Message Center. Your setings page is a good place.

```
public partial class ViewController : UIViewController
{
    ...
    
    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        MessageCenterButton.TouchUpInside += delegate {
            Apptentive.Shared.PresentMessageCenter(this);
        };
    }
}
```

### Checking Unread Message Count

You can also check to see how many messages are waiting to be read in the customer’s Message Center.
```
var unreadMessageCount = Apptentive.Shared.UnreadMessageCount;
if (unreadMessageCount > 0)
{
    Console.WriteLine("You have {0} unread messages", unreadMessageCount);
}
```

### Unread Message Count Notification

You can receive a callback when a new unread message comes in. You can use this callback to notify your customer, and display a badge letting them know how many unread messages are waiting for them. Because this listener could be called at any time, you should store the value returned from this method, and then perform any user interaction you desire at the appropriate time.
```
public partial class ViewController : UIViewController
{
    public override void ViewDidLoad()
    {
        base.ViewDidLoad();
        
        ...
        
        NSNotificationCenter.DefaultCenter.AddObserver(Constants.ApptentiveMessageCenterUnreadCountChangedNotification, (NSNotification obj) => {
            UnreadMessagesTextView.Text = "Unread messages: " + Apptentive.Shared.UnreadMessageCount;
        });
    }
}
```

## Events

Events record user interaction. You can use them to determine if and when an Interaction will be shown to your customer. You will use these Events later to target Interactions, and to determine whether an Interaction can be shown. You trigger an Event with the `Engage()` method. This will record the Event, and then check to see if any Interactions targeted to that Event are allowed to be displayed, based on the logic you set up in the Apptentive Dashboard.
  
```
var engageButton = FindViewById<Button>(...);
engageButton.Click += delegate {
    Apptentive.Shared.Engage("my_event", this); // assuming 'this' is a ViewController
};
```
