
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

using System.IdentityModel.Tokens;
using System.Security.Claims;

namespace ApptentiveSample
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        public static readonly string EXTRA_JWT_SECRET = "jwtSecret";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var secret = this.Intent.GetStringExtra(EXTRA_JWT_SECRET);
            if (string.IsNullOrEmpty(secret))
            {
                Console.WriteLine("Missing JWT secret. Finishing login activity...");
                Finish();
                return;
            }

            // Create your application here
            SetContentView(Resource.Layout.Login);

            // Controls
            SetupLoginButton(Resource.Id.loginAsAlexButton, secret, "Alex");
            SetupLoginButton(Resource.Id.loginAsFrankButton, secret, "Frank");
            SetupLoginButton(Resource.Id.loginAsSkyButton, secret, "Sky");

            var logoutButton = FindViewById<Button>(Resource.Id.logoutButton);
            logoutButton.Click += delegate {
                LogoutUser();
            };
        }

        private void SetupLoginButton(int buttonId, string secret, string user)
        {
            var button = FindViewById<Button>(buttonId);
            button.Click += delegate {
                LoginUser(secret, user);
            };
        }

        private void LoginUser(string secret, string user)
        {
            Toast.MakeText(this, "Not implemented", ToastLength.Long).Show(); // FIXME: implement login
        }

        private void LogoutUser()
        {
            Toast.MakeText(this, "Not implemented", ToastLength.Long).Show(); // FIXME: implement logout
        }
    }
}
