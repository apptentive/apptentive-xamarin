using System;
using Android.App;
using Android.Runtime;
using Com.Apptentive.Android.Sdk;

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

            Apptentive.Register(this, "ANDROID-ANDROID-DEV-c9c0b324114f", "98f5539e9310dc290394c68b76664e98");
        }
    }

}
