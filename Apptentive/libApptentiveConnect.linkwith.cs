using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libApptentiveConnect.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true)]
