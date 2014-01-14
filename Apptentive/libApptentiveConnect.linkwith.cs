using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libApptentiveConnect.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks="Accelerate CoreData CoreText CoreGraphics CoreTelephony Foundation QuartzCore StoreKit SystemConfiguration UIKit")]
