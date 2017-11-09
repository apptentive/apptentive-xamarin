using System;
using Android.App;
using Android.Runtime;
using ApptentiveSDK.Android;

namespace ApptentiveSample
{
    [Application]
    public class MyApplication : Application
    {
        public MyApplication(IntPtr handle, JniHandleOwnership ownerShip)
            : base(handle, ownerShip)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            ApptentiveLog.OverrideLogLevel(ApptentiveLog.Level.VeryVerbose);
            Apptentive.Register(this, "Your Apptentive Key", "Your Apptentive Signature");
        }
    }

}
