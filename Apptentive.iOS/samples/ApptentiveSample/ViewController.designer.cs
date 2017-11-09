// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ApptentiveSample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AuthenticationButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CanShowInteractionButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CustomDataButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EngageButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField EventNameTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MessageCenterButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel UnreadMessagesTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton UserDataButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AuthenticationButton != null) {
                AuthenticationButton.Dispose ();
                AuthenticationButton = null;
            }

            if (CanShowInteractionButton != null) {
                CanShowInteractionButton.Dispose ();
                CanShowInteractionButton = null;
            }

            if (CustomDataButton != null) {
                CustomDataButton.Dispose ();
                CustomDataButton = null;
            }

            if (EngageButton != null) {
                EngageButton.Dispose ();
                EngageButton = null;
            }

            if (EventNameTextField != null) {
                EventNameTextField.Dispose ();
                EventNameTextField = null;
            }

            if (MessageCenterButton != null) {
                MessageCenterButton.Dispose ();
                MessageCenterButton = null;
            }

            if (UnreadMessagesTextView != null) {
                UnreadMessagesTextView.Dispose ();
                UnreadMessagesTextView = null;
            }

            if (UserDataButton != null) {
                UserDataButton.Dispose ();
                UserDataButton = null;
            }
        }
    }
}