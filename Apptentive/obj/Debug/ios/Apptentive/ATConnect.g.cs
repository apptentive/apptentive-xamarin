//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace Apptentive {
	[Register("ATConnect", true)]
	public unsafe partial class ATConnect : NSObject {
		[CompilerGenerated]
		const string selApiKey = "apiKey";
		static readonly IntPtr selApiKeyHandle = Selector.GetHandle ("apiKey");
		[CompilerGenerated]
		const string selSetApiKey_ = "setApiKey:";
		static readonly IntPtr selSetApiKey_Handle = Selector.GetHandle ("setApiKey:");
		[CompilerGenerated]
		const string selShowTagline = "showTagline";
		static readonly IntPtr selShowTaglineHandle = Selector.GetHandle ("showTagline");
		[CompilerGenerated]
		const string selSetShowTagline_ = "setShowTagline:";
		static readonly IntPtr selSetShowTagline_Handle = Selector.GetHandle ("setShowTagline:");
		[CompilerGenerated]
		const string selShowEmailField = "showEmailField";
		static readonly IntPtr selShowEmailFieldHandle = Selector.GetHandle ("showEmailField");
		[CompilerGenerated]
		const string selSetShowEmailField_ = "setShowEmailField:";
		static readonly IntPtr selSetShowEmailField_Handle = Selector.GetHandle ("setShowEmailField:");
		[CompilerGenerated]
		const string selInitialUserName = "initialUserName";
		static readonly IntPtr selInitialUserNameHandle = Selector.GetHandle ("initialUserName");
		[CompilerGenerated]
		const string selSetInitialUserName_ = "setInitialUserName:";
		static readonly IntPtr selSetInitialUserName_Handle = Selector.GetHandle ("setInitialUserName:");
		[CompilerGenerated]
		const string selInitialUserEmailAddress = "initialUserEmailAddress";
		static readonly IntPtr selInitialUserEmailAddressHandle = Selector.GetHandle ("initialUserEmailAddress");
		[CompilerGenerated]
		const string selSetInitialUserEmailAddress_ = "setInitialUserEmailAddress:";
		static readonly IntPtr selSetInitialUserEmailAddress_Handle = Selector.GetHandle ("setInitialUserEmailAddress:");
		[CompilerGenerated]
		const string selCustomPlaceholderText = "customPlaceholderText";
		static readonly IntPtr selCustomPlaceholderTextHandle = Selector.GetHandle ("customPlaceholderText");
		[CompilerGenerated]
		const string selSetCustomPlaceholderText_ = "setCustomPlaceholderText:";
		static readonly IntPtr selSetCustomPlaceholderText_Handle = Selector.GetHandle ("setCustomPlaceholderText:");
		[CompilerGenerated]
		const string selSharedConnection = "sharedConnection";
		static readonly IntPtr selSharedConnectionHandle = Selector.GetHandle ("sharedConnection");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ATConnect");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ATConnect () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public ATConnect (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ATConnect (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public ATConnect (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string ApiKey {
			[Export ("apiKey")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selApiKeyHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selApiKeyHandle));
				}
			}
			
			[Export ("setApiKey:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetApiKey_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetApiKey_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowTagline {
			[Export ("showTagline")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowTaglineHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowTaglineHandle);
				}
			}
			
			[Export ("setShowTagline:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowTagline_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowTagline_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowEmailField {
			[Export ("showEmailField")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowEmailFieldHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowEmailFieldHandle);
				}
			}
			
			[Export ("setShowEmailField:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowEmailField_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowEmailField_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string InitialUserName {
			[Export ("initialUserName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInitialUserNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selInitialUserNameHandle));
				}
			}
			
			[Export ("setInitialUserName:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetInitialUserName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetInitialUserName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string InitialUserEmailAddress {
			[Export ("initialUserEmailAddress")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInitialUserEmailAddressHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selInitialUserEmailAddressHandle));
				}
			}
			
			[Export ("setInitialUserEmailAddress:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetInitialUserEmailAddress_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetInitialUserEmailAddress_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string CustomPlaceholderText {
			[Export ("customPlaceholderText")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomPlaceholderTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCustomPlaceholderTextHandle));
				}
			}
			
			[Export ("setCustomPlaceholderText:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCustomPlaceholderText_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCustomPlaceholderText_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_SharedConnection_var;
		[CompilerGenerated]
		public virtual ATConnect SharedConnection {
			[Export ("sharedConnection")]
			get {
				ATConnect ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ATConnect> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSharedConnectionHandle));
				} else {
					ret =  Runtime.GetNSObject<ATConnect> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSharedConnectionHandle));
				}
				MarkDirty ();
				__mt_SharedConnection_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_SharedConnection_var = null;
			}
		}
	} /* class ATConnect */
}
