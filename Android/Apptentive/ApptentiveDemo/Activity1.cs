using Android.App;
using Android.Widget;
using Android.OS;

using Com.Apptentive.Android.Sdk;

namespace ApptentiveDemo
{
    [Activity( Label = "ApptentiveDemo", MainLauncher = true, Icon = "@drawable/icon" )]
    public class Activity1 : Activity
    {
        protected override void OnCreate ( Bundle bundle )
        {
            base.OnCreate( bundle );
            SetContentView( Resource.Layout.Main );

            Button button = FindViewById<Button>( Resource.Id.leave_feedback );
            button.Click += delegate
            {
                Apptentive.ShowMessageCenter( this );
            };
        }

        protected override void OnStart ()
        {
            base.OnStart();
            Apptentive.OnStart( this );
        }

        protected override void OnStop ()
        {
            base.OnStop();
            Apptentive.OnStop( this );
        }
    }
}