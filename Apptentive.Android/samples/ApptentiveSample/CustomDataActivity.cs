
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ApptentiveSDK.Android;

namespace ApptentiveSample
{
    [Activity(Label = "CustomDataActivity")]
    public class CustomDataActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CustomData);

            var customDataKeyEditText = FindViewById<EditText>(Resource.Id.userDataKeyEditText);
            var customDataValueEditText = FindViewById<EditText>(Resource.Id.userDataValueEditText);
            FindViewById<Button>(Resource.Id.addUserDataButton).Click += delegate {
                Apptentive.AddCustomPersonData(customDataKeyEditText.Text, customDataValueEditText.Text);
            };

            var deviceDataKeyEditText = FindViewById<EditText>(Resource.Id.deviceDataKeyEditText);
            var deviceDataValueEditText = FindViewById<EditText>(Resource.Id.deviceDataValueEditText);
            FindViewById<Button>(Resource.Id.addUserDataButton).Click += delegate {
                Apptentive.AddCustomPersonData(deviceDataKeyEditText.Text, deviceDataValueEditText.Text);
            };
        }
    }
}
