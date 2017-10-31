using Android.App;
using Android.Widget;
using Android.OS;
using ApptentiveSDK.Android;
using System;

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
            messageCenterButton.Click += delegate {
                Apptentive.ShowMessageCenter(this);
            };

            var engageButton = FindViewById<Button>(Resource.Id.engageButton);
            engageButton.Click += delegate {
                var eventName = eventNameEditText.Text;
                Apptentive.Engage(this, eventName);
            };

            unreadMessagesTextView = FindViewById<TextView>(Resource.Id.unreadMessagesText);
            UpdateUnreadMessagesCount();

            Apptentive.AddUnreadMessagesListener(this);
        }

        private void UpdateUnreadMessagesCount()
        {
            unreadMessagesTextView.Text = "Unread messages: " + Apptentive.UnreadMessageCount;
        }

        public void OnUnreadMessageCountChanged(int count)
        {
            RunOnUiThread(delegate () {
                UpdateUnreadMessagesCount();
            });
        }
    }
}

