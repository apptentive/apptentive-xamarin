using Android.App;
using Android.Widget;
using Android.OS;
using ApptentiveSDK.Android;
using System;
using Android.Content;

namespace ApptentiveSample
{
    [Activity(Label = "ApptentiveSample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity, IUnreadMessagesListener
    {
        TextView unreadMessagesTextView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Controls
            var eventNameEditText = FindViewById<EditText>(Resource.Id.eventEditText);

            var messageCenterButton = FindViewById<Button>(Resource.Id.messageCenterButton);
            messageCenterButton.Click += delegate
            {
                Apptentive.ShowMessageCenter(this);
            };

            var engageButton = FindViewById<Button>(Resource.Id.engageButton);
            engageButton.Click += delegate
            {
                var eventName = eventNameEditText.Text;
                Apptentive.Engage(this, eventName);
            };

            var canShowInteractionButton = FindViewById<Button>(Resource.Id.canShowInteractionButton);
            canShowInteractionButton.Click += delegate
            {
                var eventName = eventNameEditText.Text;
                var canShowInteraction = Apptentive.CanShowInteraction(eventName);
                Toast.MakeText(this, canShowInteraction ? "Yes" : "No", ToastLength.Long).Show();
            };

            var userDataButton = FindViewById<Button>(Resource.Id.userDataButton);
            userDataButton.Click += delegate
            {
                var intent = new Intent(this, typeof(UserDataActivity));
                StartActivity(intent);
            };

            var customDataButton = FindViewById<Button>(Resource.Id.customDataButton);
            customDataButton.Click += delegate
            {
                var intent = new Intent(this, typeof(CustomDataActivity));
                StartActivity(intent);
            };

            var authenticationButton = FindViewById<Button>(Resource.Id.authenticationButton);
            authenticationButton.Click += delegate
            {
                var intent = new Intent(this, typeof(LoginActivity));
                intent.PutExtra(LoginActivity.EXTRA_JWT_SECRET, "Your Secret Key");
                StartActivity(intent);
            };

            unreadMessagesTextView = FindViewById<TextView>(Resource.Id.unreadMessagesText);
            UpdateUnreadMessagesCount();

            Apptentive.AddUnreadMessagesListener(this);
        }

        void UpdateUnreadMessagesCount()
        {
            unreadMessagesTextView.Text = "Unread messages: " + Apptentive.UnreadMessageCount;
        }

        #region IUnreadMessagesListener

        public void OnUnreadMessageCountChanged(int count)
        {
            RunOnUiThread(delegate ()
            {
                UpdateUnreadMessagesCount();
            });
        }

        #endregion
    }
}

