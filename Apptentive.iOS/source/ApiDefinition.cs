using System;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;

namespace ApptentiveSDK.iOS
{
    // typedef void (^ApptentiveAuthenticationFailureCallback)(ApptentiveAuthenticationFailureReason, NSString * _Nonnull);
    delegate void ApptentiveAuthenticationFailureCallback(ApptentiveAuthenticationFailureReason reason, string message);

    [Static]
    partial interface Constants
    {
        // extern const NSNotificationName _Nonnull ApptentiveMessageCenterUnreadCountChangedNotification;
        [Field("ApptentiveMessageCenterUnreadCountChangedNotification", "__Internal")]
        NSString ApptentiveMessageCenterUnreadCountChangedNotification { get; }

        // extern const NSNotificationName _Nonnull ApptentiveAppRatingFlowUserAgreedToRateAppNotification;
        [Field("ApptentiveAppRatingFlowUserAgreedToRateAppNotification", "__Internal")]
        NSString ApptentiveAppRatingFlowUserAgreedToRateAppNotification { get; }

        // extern const NSNotificationName _Nonnull ApptentiveSurveyShownNotification;
        [Field("ApptentiveSurveyShownNotification", "__Internal")]
        NSString ApptentiveSurveyShownNotification { get; }

        // extern const NSNotificationName _Nonnull ApptentiveSurveySentNotification;
        [Field("ApptentiveSurveySentNotification", "__Internal")]
        NSString ApptentiveSurveySentNotification { get; }

        // extern NSString *const _Nonnull ApptentiveErrorDomain;
        [Field("ApptentiveErrorDomain", "__Internal")]
        NSString ApptentiveErrorDomain { get; }

        // extern NSString *const _Nonnull ApptentiveSurveyIDKey;
        [Field("ApptentiveSurveyIDKey", "__Internal")]
        NSString ApptentiveSurveyIDKey { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleBody;
        [Field("ApptentiveTextStyleBody", "__Internal")]
        NSString ApptentiveTextStyleBody { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleHeaderTitle;
        [Field("ApptentiveTextStyleHeaderTitle", "__Internal")]
        NSString ApptentiveTextStyleHeaderTitle { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleHeaderMessage;
        [Field("ApptentiveTextStyleHeaderMessage", "__Internal")]
        NSString ApptentiveTextStyleHeaderMessage { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleMessageDate;
        [Field("ApptentiveTextStyleMessageDate", "__Internal")]
        NSString ApptentiveTextStyleMessageDate { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleMessageSender;
        [Field("ApptentiveTextStyleMessageSender", "__Internal")]
        NSString ApptentiveTextStyleMessageSender { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleMessageStatus;
        [Field("ApptentiveTextStyleMessageStatus", "__Internal")]
        NSString ApptentiveTextStyleMessageStatus { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleMessageCenterStatus;
        [Field("ApptentiveTextStyleMessageCenterStatus", "__Internal")]
        NSString ApptentiveTextStyleMessageCenterStatus { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleSurveyInstructions;
        [Field("ApptentiveTextStyleSurveyInstructions", "__Internal")]
        NSString ApptentiveTextStyleSurveyInstructions { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleDoneButton;
        [Field("ApptentiveTextStyleDoneButton", "__Internal")]
        NSString ApptentiveTextStyleDoneButton { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleButton;
        [Field("ApptentiveTextStyleButton", "__Internal")]
        NSString ApptentiveTextStyleButton { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleSubmitButton;
        [Field("ApptentiveTextStyleSubmitButton", "__Internal")]
        NSString ApptentiveTextStyleSubmitButton { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveTextStyleTextInput;
        [Field("ApptentiveTextStyleTextInput", "__Internal")]
        NSString ApptentiveTextStyleTextInput { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorHeaderBackground;
        [Field("ApptentiveColorHeaderBackground", "__Internal")]
        NSString ApptentiveColorHeaderBackground { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorFooterBackground;
        [Field("ApptentiveColorFooterBackground", "__Internal")]
        NSString ApptentiveColorFooterBackground { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorFailure;
        [Field("ApptentiveColorFailure", "__Internal")]
        NSString ApptentiveColorFailure { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorSeparator;
        [Field("ApptentiveColorSeparator", "__Internal")]
        NSString ApptentiveColorSeparator { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorBackground;
        [Field("ApptentiveColorBackground", "__Internal")]
        NSString ApptentiveColorBackground { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorCollectionBackground;
        [Field("ApptentiveColorCollectionBackground", "__Internal")]
        NSString ApptentiveColorCollectionBackground { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorTextInputBackground;
        [Field("ApptentiveColorTextInputBackground", "__Internal")]
        NSString ApptentiveColorTextInputBackground { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorTextInputPlaceholder;
        [Field("ApptentiveColorTextInputPlaceholder", "__Internal")]
        NSString ApptentiveColorTextInputPlaceholder { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorMessageBackground;
        [Field("ApptentiveColorMessageBackground", "__Internal")]
        NSString ApptentiveColorMessageBackground { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorReplyBackground;
        [Field("ApptentiveColorReplyBackground", "__Internal")]
        NSString ApptentiveColorReplyBackground { get; }

        // extern ApptentiveStyleIdentifier _Nonnull ApptentiveColorContextBackground;
        [Field("ApptentiveColorContextBackground", "__Internal")]
        NSString ApptentiveColorContextBackground { get; }

        // extern double ApptentiveVersionNumber;
        // [Field("ApptentiveVersionNumber", "__Internal")]
        // double ApptentiveVersionNumber { get; }

        // extern const unsigned char [] ApptentiveVersionString;
        // [Field("ApptentiveVersionString", "__Internal")]
        // byte[] ApptentiveVersionString { get; }
    }

    // @interface ApptentiveConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface ApptentiveConfiguration
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull apptentiveKey;
        [Export("apptentiveKey")]
        string ApptentiveKey { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull apptentiveSignature;
        [Export("apptentiveSignature")]
        string ApptentiveSignature { get; }

        // @property (assign, nonatomic) ApptentiveLogLevel logLevel;
        [Export("logLevel", ArgumentSemantic.Assign)]
        ApptentiveLogLevel LogLevel { get; set; }

        // @property (copy, nonatomic) NSURL * _Nonnull baseURL;
        [Export("baseURL", ArgumentSemantic.Copy)]
        NSUrl BaseURL { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable distributionName;
        [NullAllowed, Export("distributionName")]
        string DistributionName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable distributionVersion;
        [NullAllowed, Export("distributionVersion")]
        string DistributionVersion { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable appID;
        [NullAllowed, Export("appID")]
        string AppID { get; set; }

        // +(instancetype _Nullable)configurationWithApptentiveKey:(NSString * _Nonnull)apptentiveKey apptentiveSignature:(NSString * _Nonnull)apptentiveSignature;
        [Static]
        [Export("configurationWithApptentiveKey:apptentiveSignature:")]
        [return: NullAllowed]
        ApptentiveConfiguration ConfigurationWithApptentiveKey(string apptentiveKey, string apptentiveSignature);
    }

    // @interface Apptentive : NSObject
    [BaseType(typeof(NSObject))]
    interface Apptentive
    {
        // @property (readonly, nonatomic, class) Apptentive * _Nonnull shared;
        [Static]
        [Export("shared")]
        Apptentive Shared { get; }

        // +(void)registerWithConfiguration:(ApptentiveConfiguration * _Nonnull)configuration;
        [Static]
        [Export("registerWithConfiguration:")]
        void Register(ApptentiveConfiguration configuration);

        // @property (readonly, nonatomic) NSString * _Nonnull apptentiveKey;
        [Export("apptentiveKey")]
        string ApptentiveKey { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull apptentiveSignature;
        [Export("apptentiveSignature")]
        string ApptentiveSignature { get; }

        // @property (copy, nonatomic) NSString * _Nullable appID;
        [NullAllowed, Export("appID")]
        string AppID { get; set; }

        // -(BOOL)engage:(NSString * _Nonnull)event fromViewController:(UIViewController * _Nullable)viewController;
        [Export("engage:fromViewController:")]
        bool Engage(string @event, [NullAllowed] UIViewController viewController);

        // -(BOOL)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData fromViewController:(UIViewController * _Nullable)viewController;
        [Export("engage:withCustomData:fromViewController:")]
        bool Engage(string @event, [NullAllowed] NSDictionary customData, [NullAllowed] UIViewController viewController);

        // -(BOOL)engage:(NSString * _Nonnull)event withCustomData:(NSDictionary * _Nullable)customData withExtendedData:(NSArray<NSDictionary *> * _Nullable)extendedData fromViewController:(UIViewController * _Nullable)viewController;
        [Export("engage:withCustomData:withExtendedData:fromViewController:")]
        bool Engage(string @event, [NullAllowed] NSDictionary customData, [NullAllowed] NSDictionary[] extendedData, [NullAllowed] UIViewController viewController);

        // -(BOOL)canShowInteractionForEvent:(NSString * _Nonnull)event;
        [Export("canShowInteractionForEvent:")]
        bool CanShowInteraction(string @event);

        // +(NSDictionary * _Nonnull)extendedDataDate:(NSDate * _Nonnull)date;
        [Static]
        [Export("extendedDataDate:")]
        NSDictionary ExtendedDataDate(NSDate date);

        // +(NSDictionary * _Nonnull)extendedDataLocationForLatitude:(double)latitude longitude:(double)longitude;
        [Static]
        [Export("extendedDataLocationForLatitude:longitude:")]
        NSDictionary ExtendedDataLocation(double latitude, double longitude);

        // +(NSDictionary * _Nonnull)extendedDataCommerceWithTransactionID:(NSString * _Nullable)transactionID affiliation:(NSString * _Nullable)affiliation revenue:(NSNumber * _Nullable)revenue shipping:(NSNumber * _Nullable)shipping tax:(NSNumber * _Nullable)tax currency:(NSString * _Nullable)currency commerceItems:(NSArray<NSDictionary *> * _Nullable)commerceItems;
        [Static]
        [Export("extendedDataCommerceWithTransactionID:affiliation:revenue:shipping:tax:currency:commerceItems:")]
        NSDictionary ExtendedDataCommerce([NullAllowed] string transactionID, [NullAllowed] string affiliation, [NullAllowed] NSNumber revenue, [NullAllowed] NSNumber shipping, [NullAllowed] NSNumber tax, [NullAllowed] string currency, [NullAllowed] NSDictionary[] commerceItems);

        // +(NSDictionary * _Nonnull)extendedDataCommerceItemWithItemID:(NSString * _Nullable)itemID name:(NSString * _Nullable)name category:(NSString * _Nullable)category price:(NSNumber * _Nullable)price quantity:(NSNumber * _Nullable)quantity currency:(NSString * _Nullable)currency;
        [Static]
        [Export("extendedDataCommerceItemWithItemID:name:category:price:quantity:currency:")]
        NSDictionary ExtendedDataCommerce([NullAllowed] string itemID, [NullAllowed] string name, [NullAllowed] string category, [NullAllowed] NSNumber price, [NullAllowed] NSNumber quantity, [NullAllowed] string currency);

        // @property (readonly, nonatomic) BOOL canShowMessageCenter;
        [Export("canShowMessageCenter")]
        bool CanShowMessageCenter { get; }

        // -(BOOL)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController;
        [Export("presentMessageCenterFromViewController:")]
        bool PresentMessageCenter([NullAllowed] UIViewController viewController);

        // -(BOOL)presentMessageCenterFromViewController:(UIViewController * _Nullable)viewController withCustomData:(NSDictionary * _Nullable)customData;
        [Export("presentMessageCenterFromViewController:withCustomData:")]
        bool PresentMessageCenter([NullAllowed] UIViewController viewController, [NullAllowed] NSDictionary customData);

        // -(void)dismissMessageCenterAnimated:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
        [Export("dismissMessageCenterAnimated:completion:")]
        void DismissMessageCenter(bool animated, [NullAllowed] Action completion);

        // @property (readonly, nonatomic) NSUInteger unreadMessageCount;
        [Export("unreadMessageCount")]
        nuint UnreadMessageCount { get; }

        // -(UIView * _Nonnull)unreadMessageCountAccessoryView:(BOOL)apptentiveHeart;
        [Export("unreadMessageCountAccessoryView:")]
        UIView UnreadMessageCountAccessoryView(bool apptentiveHeart);

        // -(void)openAppStore;
        [Export("openAppStore")]
        void OpenAppStore();

        // -(void)setPushNotificationIntegration:(ApptentivePushProvider)pushProvider withDeviceToken:(NSData * _Nonnull)deviceToken;
        [Export("setPushNotificationIntegration:withDeviceToken:")]
        void SetPushNotificationIntegration(ApptentivePushProvider pushProvider, NSData deviceToken);

        // -(BOOL)didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo fromViewController:(UIViewController * _Nonnull)viewController;
        [Export("didReceiveRemoteNotification:fromViewController:")]
        bool DidReceiveRemoteNotification(NSDictionary userInfo, UIViewController viewController);

        // -(BOOL)didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo fromViewController:(UIViewController * _Nonnull)viewController fetchCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler;
        [Export("didReceiveRemoteNotification:fromViewController:fetchCompletionHandler:")]
        bool DidReceiveRemoteNotification(NSDictionary userInfo, UIViewController viewController, Action<UIBackgroundFetchResult> completionHandler);

        // -(BOOL)didReceiveLocalNotification:(UILocalNotification * _Nonnull)notification fromViewController:(UIViewController * _Nonnull)viewController;
        [Export("didReceiveLocalNotification:fromViewController:")]
        bool DidReceiveLocalNotification(UILocalNotification notification, UIViewController viewController);

        // -(BOOL)didReceveUserNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler;
        [Export("didReceveUserNotificationResponse:withCompletionHandler:")]
        bool DidReceveUserNotification(UNNotificationResponse response, Action completionHandler);

        // -(void)sendAttachmentText:(NSString * _Nonnull)text;
        [Export("sendAttachmentText:")]
        void SendAttachment(string text);

        // -(void)sendAttachmentImage:(UIImage * _Nonnull)image;
        [Export("sendAttachmentImage:")]
        void SendAttachment(UIImage image);

        // -(void)sendAttachmentFile:(NSData * _Nonnull)fileData withMimeType:(NSString * _Nonnull)mimeType;
        [Export("sendAttachmentFile:withMimeType:")]
        void SendAttachment(NSData fileData, string mimeType);

        // @property (copy, nonatomic) NSString * _Nullable personName;
        [NullAllowed, Export("personName")]
        string PersonName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable personEmailAddress;
        [NullAllowed, Export("personEmailAddress")]
        string PersonEmailAddress { get; set; }

        // -(void)removeCustomPersonDataWithKey:(NSString * _Nonnull)key;
        [Export("removeCustomPersonDataWithKey:")]
        void RemoveCustomPersonData(string key);

        // -(void)removeCustomDeviceDataWithKey:(NSString * _Nonnull)key;
        [Export("removeCustomDeviceDataWithKey:")]
        void RemoveCustomDeviceData(string key);

        // -(void)addCustomDeviceDataString:(NSString * _Nonnull)string withKey:(NSString * _Nonnull)key;
        [Export("addCustomDeviceDataString:withKey:")]
        void AddCustomDeviceData(string @string, string key);

        // -(void)addCustomDeviceDataNumber:(NSNumber * _Nonnull)number withKey:(NSString * _Nonnull)key;
        [Export("addCustomDeviceDataNumber:withKey:")]
        void AddCustomDeviceData(NSNumber number, string key);

        // -(void)addCustomDeviceDataBool:(BOOL)boolValue withKey:(NSString * _Nonnull)key;
        [Export("addCustomDeviceDataBool:withKey:")]
        void AddCustomDeviceData(bool boolValue, string key);

        // -(void)addCustomPersonDataString:(NSString * _Nonnull)string withKey:(NSString * _Nonnull)key;
        [Export("addCustomPersonDataString:withKey:")]
        void AddCustomPersonData(string @string, string key);

        // -(void)addCustomPersonDataNumber:(NSNumber * _Nonnull)number withKey:(NSString * _Nonnull)key;
        [Export("addCustomPersonDataNumber:withKey:")]
        void AddCustomPersonData(NSNumber number, string key);

        // -(void)addCustomPersonDataBool:(BOOL)boolValue withKey:(NSString * _Nonnull)key;
        [Export("addCustomPersonDataBool:withKey:")]
        void AddCustomPersonData(bool boolValue, string key);

        // -(void)dismissAllInteractions:(BOOL)animated;
        [Export("dismissAllInteractions:")]
        void DismissAllInteractions(bool animated);

        // @property (nonatomic, strong) id<ApptentiveStyle> _Nonnull styleSheet;
        [Export("styleSheet", ArgumentSemantic.Strong)]
        ApptentiveStyle StyleSheet { get; set; }

        // -(void)logInWithToken:(NSString * _Nonnull)token completion:(void (^ _Nonnull)(BOOL, NSError * _Nonnull))completion;
        [Export("logInWithToken:completion:")]
        void LogIn(string token, Action<bool, NSError> completion);

        // -(void)logOut;
        [Export("logOut")]
        void LogOut();

        // @property (copy, nonatomic) ApptentiveAuthenticationFailureCallback _Nonnull authenticationFailureCallback;
        [Export("authenticationFailureCallback", ArgumentSemantic.Copy)]
        ApptentiveAuthenticationFailureCallback AuthenticationFailureCallback { get; set; }

        // @property (assign, nonatomic) ApptentiveLogLevel logLevel;
        [Export("logLevel", ArgumentSemantic.Assign)]
        ApptentiveLogLevel LogLevel { get; set; }
    }

    // @protocol ApptentiveStyle <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ApptentiveStyle
    {
        // @required -(UIFont * _Nonnull)fontForStyle:(ApptentiveStyleIdentifier _Nonnull)textStyle;
        [Abstract]
        [Export("fontForStyle:")]
        UIFont FontForStyle(string textStyle);

        // @required -(UIColor * _Nonnull)colorForStyle:(ApptentiveStyleIdentifier _Nonnull)style;
        [Abstract]
        [Export("colorForStyle:")]
        UIColor ColorForStyle(string style);
    }

    // @interface ApptentiveStyleSheet : NSObject <ApptentiveStyle>
    [BaseType(typeof(NSObject))]
    interface ApptentiveStyleSheet /* : IApptentiveStyle */
    {
        // @property (copy, nonatomic) NSString * _Nonnull fontFamily;
        [Export("fontFamily")]
        string FontFamily { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable lightFaceAttribute;
        [NullAllowed, Export("lightFaceAttribute")]
        string LightFaceAttribute { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable regularFaceAttribute;
        [NullAllowed, Export("regularFaceAttribute")]
        string RegularFaceAttribute { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable mediumFaceAttribute;
        [NullAllowed, Export("mediumFaceAttribute")]
        string MediumFaceAttribute { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable boldFaceAttribute;
        [NullAllowed, Export("boldFaceAttribute")]
        string BoldFaceAttribute { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull primaryColor;
        [Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secondaryColor;
        [Export("secondaryColor", ArgumentSemantic.Strong)]
        UIColor SecondaryColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull failureColor;
        [Export("failureColor", ArgumentSemantic.Strong)]
        UIColor FailureColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull separatorColor;
        [Export("separatorColor", ArgumentSemantic.Strong)]
        UIColor SeparatorColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull collectionBackgroundColor;
        [Export("collectionBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CollectionBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull placeholderColor;
        [Export("placeholderColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderColor { get; set; }

        // @property (assign, nonatomic) CGFloat sizeAdjustment;
        [Export("sizeAdjustment")]
        nfloat SizeAdjustment { get; set; }

        // -(void)setFontDescriptor:(UIFontDescriptor * _Nonnull)fontDescriptor forStyle:(NSString * _Nonnull)style;
        [Export("setFontDescriptor:forStyle:")]
        void SetFontDescriptor(UIFontDescriptor fontDescriptor, string style);

        // -(void)setColor:(UIColor * _Nonnull)color forStyle:(NSString * _Nonnull)style;
        [Export("setColor:forStyle:")]
        void SetColor(UIColor color, string style);
    }
}
