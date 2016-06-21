using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']"
	[global::Android.Runtime.Register ("android/support/v7/internal/app/ToolbarActionBar", DoNotGenerateAcw=true)]
	public partial class ToolbarActionBar : global::Android.Support.V7.App.ActionBar {

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar.ToolbarCallbackWrapper']"
		[global::Android.Runtime.Register ("android/support/v7/internal/app/ToolbarActionBar$ToolbarCallbackWrapper", DoNotGenerateAcw=true)]
		public partial class ToolbarCallbackWrapper : global::Android.Support.V7.Internal.View.WindowCallbackWrapper {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/internal/app/ToolbarActionBar$ToolbarCallbackWrapper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ToolbarCallbackWrapper); }
			}

			protected ToolbarCallbackWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_support_v7_internal_app_ToolbarActionBar_Landroid_view_Window_Callback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar.ToolbarCallbackWrapper']/constructor[@name='ToolbarActionBar.ToolbarCallbackWrapper' and count(parameter)=2 and parameter[1][@type='android.support.v7.internal.app.ToolbarActionBar'] and parameter[2][@type='android.view.Window.Callback']]"
			[Register (".ctor", "(Landroid/support/v7/internal/app/ToolbarActionBar;Landroid/view/Window$Callback;)V", "")]
			public unsafe ToolbarCallbackWrapper (global::Android.Support.V7.Internal.App.ToolbarActionBar __self, global::Android.Views.Window.ICallback p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (ToolbarCallbackWrapper)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/Window$Callback;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/Window$Callback;)V", __args);
						return;
					}

					if (id_ctor_Landroid_support_v7_internal_app_ToolbarActionBar_Landroid_view_Window_Callback_ == IntPtr.Zero)
						id_ctor_Landroid_support_v7_internal_app_ToolbarActionBar_Landroid_view_Window_Callback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v7/internal/app/ToolbarActionBar;Landroid/view/Window$Callback;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v7_internal_app_ToolbarActionBar_Landroid_view_Window_Callback_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_support_v7_internal_app_ToolbarActionBar_Landroid_view_Window_Callback_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/app/ToolbarActionBar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ToolbarActionBar); }
		}

		protected ToolbarActionBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCustomView;
#pragma warning disable 0169
		static Delegate GetGetCustomViewHandler ()
		{
			if (cb_getCustomView == null)
				cb_getCustomView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomView);
			return cb_getCustomView;
		}

		static IntPtr n_GetCustomView (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CustomView);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetCustomView_Landroid_view_View_Handler ()
		{
			if (cb_setCustomView_Landroid_view_View_ == null)
				cb_setCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomView_Landroid_view_View_);
			return cb_setCustomView_Landroid_view_View_;
		}

		static void n_SetCustomView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomView = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCustomView;
		static IntPtr id_setCustomView_Landroid_view_View_;
		public override unsafe global::Android.Views.View CustomView {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getCustomView' and count(parameter)=0]"
			[Register ("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")]
			get {
				if (id_getCustomView == IntPtr.Zero)
					id_getCustomView = JNIEnv.GetMethodID (class_ref, "getCustomView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getCustomView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler")]
			set {
				if (id_setCustomView_Landroid_view_View_ == IntPtr.Zero)
					id_setCustomView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setCustomView", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCustomView_Landroid_view_View_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomView", "(Landroid/view/View;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayOptions;
#pragma warning disable 0169
		static Delegate GetGetDisplayOptionsHandler ()
		{
			if (cb_getDisplayOptions == null)
				cb_getDisplayOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayOptions);
			return cb_getDisplayOptions;
		}

		static int n_GetDisplayOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayOptions;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayOptions_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayOptions_IHandler ()
		{
			if (cb_setDisplayOptions_I == null)
				cb_setDisplayOptions_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisplayOptions_I);
			return cb_setDisplayOptions_I;
		}

		static void n_SetDisplayOptions_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayOptions = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayOptions;
		static IntPtr id_setDisplayOptions_I;
		public override unsafe int DisplayOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getDisplayOptions' and count(parameter)=0]"
			[Register ("getDisplayOptions", "()I", "GetGetDisplayOptionsHandler")]
			get {
				if (id_getDisplayOptions == IntPtr.Zero)
					id_getDisplayOptions = JNIEnv.GetMethodID (class_ref, "getDisplayOptions", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDisplayOptions);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayOptions", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setDisplayOptions' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisplayOptions", "(I)V", "GetSetDisplayOptions_IHandler")]
			set {
				if (id_setDisplayOptions_I == IntPtr.Zero)
					id_setDisplayOptions_I = JNIEnv.GetMethodID (class_ref, "setDisplayOptions", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDisplayOptions_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayOptions", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public override unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isShowing;
#pragma warning disable 0169
		static Delegate GetIsShowingHandler ()
		{
			if (cb_isShowing == null)
				cb_isShowing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowing);
			return cb_isShowing;
		}

		static bool n_IsShowing (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowing;
		}
#pragma warning restore 0169

		static IntPtr id_isShowing;
		public override unsafe bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "GetIsShowingHandler")]
			get {
				if (id_isShowing == IntPtr.Zero)
					id_isShowing = JNIEnv.GetMethodID (class_ref, "isShowing", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isShowing);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowing", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNavigationItemCount;
#pragma warning disable 0169
		static Delegate GetGetNavigationItemCountHandler ()
		{
			if (cb_getNavigationItemCount == null)
				cb_getNavigationItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNavigationItemCount);
			return cb_getNavigationItemCount;
		}

		static int n_GetNavigationItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NavigationItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getNavigationItemCount;
		public override unsafe int NavigationItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getNavigationItemCount' and count(parameter)=0]"
			[Register ("getNavigationItemCount", "()I", "GetGetNavigationItemCountHandler")]
			get {
				if (id_getNavigationItemCount == IntPtr.Zero)
					id_getNavigationItemCount = JNIEnv.GetMethodID (class_ref, "getNavigationItemCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNavigationItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNavigationItemCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNavigationMode;
#pragma warning disable 0169
		static Delegate GetGetNavigationModeHandler ()
		{
			if (cb_getNavigationMode == null)
				cb_getNavigationMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNavigationMode);
			return cb_getNavigationMode;
		}

		static int n_GetNavigationMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NavigationMode;
		}
#pragma warning restore 0169

		static Delegate cb_setNavigationMode_I;
#pragma warning disable 0169
		static Delegate GetSetNavigationMode_IHandler ()
		{
			if (cb_setNavigationMode_I == null)
				cb_setNavigationMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNavigationMode_I);
			return cb_setNavigationMode_I;
		}

		static void n_SetNavigationMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NavigationMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNavigationMode;
		static IntPtr id_setNavigationMode_I;
		public override unsafe int NavigationMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getNavigationMode' and count(parameter)=0]"
			[Register ("getNavigationMode", "()I", "GetGetNavigationModeHandler")]
			get {
				if (id_getNavigationMode == IntPtr.Zero)
					id_getNavigationMode = JNIEnv.GetMethodID (class_ref, "getNavigationMode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNavigationMode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNavigationMode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setNavigationMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNavigationMode", "(I)V", "GetSetNavigationMode_IHandler")]
			set {
				if (id_setNavigationMode_I == IntPtr.Zero)
					id_setNavigationMode_I = JNIEnv.GetMethodID (class_ref, "setNavigationMode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNavigationMode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNavigationMode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedNavigationIndex;
#pragma warning disable 0169
		static Delegate GetGetSelectedNavigationIndexHandler ()
		{
			if (cb_getSelectedNavigationIndex == null)
				cb_getSelectedNavigationIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedNavigationIndex);
			return cb_getSelectedNavigationIndex;
		}

		static int n_GetSelectedNavigationIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedNavigationIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedNavigationIndex;
		public override unsafe int SelectedNavigationIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getSelectedNavigationIndex' and count(parameter)=0]"
			[Register ("getSelectedNavigationIndex", "()I", "GetGetSelectedNavigationIndexHandler")]
			get {
				if (id_getSelectedNavigationIndex == IntPtr.Zero)
					id_getSelectedNavigationIndex = JNIEnv.GetMethodID (class_ref, "getSelectedNavigationIndex", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSelectedNavigationIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedNavigationIndex", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedTab;
#pragma warning disable 0169
		static Delegate GetGetSelectedTabHandler ()
		{
			if (cb_getSelectedTab == null)
				cb_getSelectedTab = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedTab);
			return cb_getSelectedTab;
		}

		static IntPtr n_GetSelectedTab (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedTab);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedTab;
		public override unsafe global::Android.Support.V7.App.ActionBar.Tab SelectedTab {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getSelectedTab' and count(parameter)=0]"
			[Register ("getSelectedTab", "()Landroid/support/v7/app/ActionBar$Tab;", "GetGetSelectedTabHandler")]
			get {
				if (id_getSelectedTab == IntPtr.Zero)
					id_getSelectedTab = JNIEnv.GetMethodID (class_ref, "getSelectedTab", "()Landroid/support/v7/app/ActionBar$Tab;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_getSelectedTab), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedTab", "()Landroid/support/v7/app/ActionBar$Tab;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubtitle;
#pragma warning disable 0169
		static Delegate GetGetSubtitleHandler ()
		{
			if (cb_getSubtitle == null)
				cb_getSubtitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubtitle);
			return cb_getSubtitle;
		}

		static IntPtr n_GetSubtitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.SubtitleFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setSubtitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetSubtitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setSubtitle_Ljava_lang_CharSequence_ == null)
				cb_setSubtitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubtitle_Ljava_lang_CharSequence_);
			return cb_setSubtitle_Ljava_lang_CharSequence_;
		}

		static void n_SetSubtitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubtitleFormatted = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSubtitle;
		static IntPtr id_setSubtitle_Ljava_lang_CharSequence_;
		public override unsafe global::Java.Lang.ICharSequence SubtitleFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getSubtitle' and count(parameter)=0]"
			[Register ("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler")]
			get {
				if (id_getSubtitle == IntPtr.Zero)
					id_getSubtitle = JNIEnv.GetMethodID (class_ref, "getSubtitle", "()Ljava/lang/CharSequence;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getSubtitle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubtitle", "()Ljava/lang/CharSequence;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setSubtitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")]
			set {
				if (id_setSubtitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setSubtitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setSubtitle", "(Ljava/lang/CharSequence;)V");
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSubtitle_Ljava_lang_CharSequence_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubtitle", "(Ljava/lang/CharSequence;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTabCount;
#pragma warning disable 0169
		static Delegate GetGetTabCountHandler ()
		{
			if (cb_getTabCount == null)
				cb_getTabCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTabCount);
			return cb_getTabCount;
		}

		static int n_GetTabCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabCount;
		}
#pragma warning restore 0169

		static IntPtr id_getTabCount;
		public override unsafe int TabCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getTabCount' and count(parameter)=0]"
			[Register ("getTabCount", "()I", "GetGetTabCountHandler")]
			get {
				if (id_getTabCount == IntPtr.Zero)
					id_getTabCount = JNIEnv.GetMethodID (class_ref, "getTabCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTabCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTabCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TitleFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTitle_Ljava_lang_CharSequence_ == null)
				cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_CharSequence_);
			return cb_setTitle_Ljava_lang_CharSequence_;
		}

		static void n_SetTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TitleFormatted = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_CharSequence_;
		public override unsafe global::Java.Lang.ICharSequence TitleFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/CharSequence;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/CharSequence;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			set {
				if (id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/CharSequence;)V");
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_CharSequence_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/CharSequence;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWrappedWindowCallback;
#pragma warning disable 0169
		static Delegate GetGetWrappedWindowCallbackHandler ()
		{
			if (cb_getWrappedWindowCallback == null)
				cb_getWrappedWindowCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWrappedWindowCallback);
			return cb_getWrappedWindowCallback;
		}

		static IntPtr n_GetWrappedWindowCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WrappedWindowCallback);
		}
#pragma warning restore 0169

		static IntPtr id_getWrappedWindowCallback;
		public virtual unsafe global::Android.Views.Window.ICallback WrappedWindowCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getWrappedWindowCallback' and count(parameter)=0]"
			[Register ("getWrappedWindowCallback", "()Landroid/view/Window$Callback;", "GetGetWrappedWindowCallbackHandler")]
			get {
				if (id_getWrappedWindowCallback == IntPtr.Zero)
					id_getWrappedWindowCallback = JNIEnv.GetMethodID (class_ref, "getWrappedWindowCallback", "()Landroid/view/Window$Callback;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.Window.ICallback> (JNIEnv.CallObjectMethod  (Handle, id_getWrappedWindowCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.Window.ICallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWrappedWindowCallback", "()Landroid/view/Window$Callback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
#pragma warning disable 0169
		static Delegate GetAddOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_Handler ()
		{
			if (cb_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ == null)
				cb_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_);
			return cb_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
		}

		static void n_AddOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener p0 = (global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener)global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOnMenuVisibilityListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='addOnMenuVisibilityListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.OnMenuVisibilityListener']]"
		[Register ("addOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V", "GetAddOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public override unsafe void AddOnMenuVisibilityListener (global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener p0)
		{
			if (id_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ == IntPtr.Zero)
				id_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ = JNIEnv.GetMethodID (class_ref, "addOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addTab_Landroid_support_v7_app_ActionBar_Tab_;
#pragma warning disable 0169
		static Delegate GetAddTab_Landroid_support_v7_app_ActionBar_Tab_Handler ()
		{
			if (cb_addTab_Landroid_support_v7_app_ActionBar_Tab_ == null)
				cb_addTab_Landroid_support_v7_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTab_Landroid_support_v7_app_ActionBar_Tab_);
			return cb_addTab_Landroid_support_v7_app_ActionBar_Tab_;
		}

		static void n_AddTab_Landroid_support_v7_app_ActionBar_Tab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addTab_Landroid_support_v7_app_ActionBar_Tab_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='addTab' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.Tab']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_Handler")]
		public override unsafe void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0)
		{
			if (id_addTab_Landroid_support_v7_app_ActionBar_Tab_ == IntPtr.Zero)
				id_addTab_Landroid_support_v7_app_ActionBar_Tab_ = JNIEnv.GetMethodID (class_ref, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addTab_Landroid_support_v7_app_ActionBar_Tab_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addTab_Landroid_support_v7_app_ActionBar_Tab_Z;
#pragma warning disable 0169
		static Delegate GetAddTab_Landroid_support_v7_app_ActionBar_Tab_ZHandler ()
		{
			if (cb_addTab_Landroid_support_v7_app_ActionBar_Tab_Z == null)
				cb_addTab_Landroid_support_v7_app_ActionBar_Tab_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddTab_Landroid_support_v7_app_ActionBar_Tab_Z);
			return cb_addTab_Landroid_support_v7_app_ActionBar_Tab_Z;
		}

		static void n_AddTab_Landroid_support_v7_app_ActionBar_Tab_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addTab_Landroid_support_v7_app_ActionBar_Tab_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='addTab' and count(parameter)=2 and parameter[1][@type='android.support.v7.app.ActionBar.Tab'] and parameter[2][@type='boolean']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;Z)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_ZHandler")]
		public override unsafe void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0, bool p1)
		{
			if (id_addTab_Landroid_support_v7_app_ActionBar_Tab_Z == IntPtr.Zero)
				id_addTab_Landroid_support_v7_app_ActionBar_Tab_Z = JNIEnv.GetMethodID (class_ref, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addTab_Landroid_support_v7_app_ActionBar_Tab_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addTab_Landroid_support_v7_app_ActionBar_Tab_I;
#pragma warning disable 0169
		static Delegate GetAddTab_Landroid_support_v7_app_ActionBar_Tab_IHandler ()
		{
			if (cb_addTab_Landroid_support_v7_app_ActionBar_Tab_I == null)
				cb_addTab_Landroid_support_v7_app_ActionBar_Tab_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AddTab_Landroid_support_v7_app_ActionBar_Tab_I);
			return cb_addTab_Landroid_support_v7_app_ActionBar_Tab_I;
		}

		static void n_AddTab_Landroid_support_v7_app_ActionBar_Tab_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addTab_Landroid_support_v7_app_ActionBar_Tab_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='addTab' and count(parameter)=2 and parameter[1][@type='android.support.v7.app.ActionBar.Tab'] and parameter[2][@type='int']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;I)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_IHandler")]
		public override unsafe void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0, int p1)
		{
			if (id_addTab_Landroid_support_v7_app_ActionBar_Tab_I == IntPtr.Zero)
				id_addTab_Landroid_support_v7_app_ActionBar_Tab_I = JNIEnv.GetMethodID (class_ref, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addTab_Landroid_support_v7_app_ActionBar_Tab_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ;
#pragma warning disable 0169
		static Delegate GetAddTab_Landroid_support_v7_app_ActionBar_Tab_IZHandler ()
		{
			if (cb_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ == null)
				cb_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_AddTab_Landroid_support_v7_app_ActionBar_Tab_IZ);
			return cb_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ;
		}

		static void n_AddTab_Landroid_support_v7_app_ActionBar_Tab_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='addTab' and count(parameter)=3 and parameter[1][@type='android.support.v7.app.ActionBar.Tab'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;IZ)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_IZHandler")]
		public override unsafe void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0, int p1, bool p2)
		{
			if (id_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ == IntPtr.Zero)
				id_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ = JNIEnv.GetMethodID (class_ref, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;IZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getTabAt_I;
#pragma warning disable 0169
		static Delegate GetGetTabAt_IHandler ()
		{
			if (cb_getTabAt_I == null)
				cb_getTabAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTabAt_I);
			return cb_getTabAt_I;
		}

		static IntPtr n_GetTabAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTabAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getTabAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='getTabAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTabAt", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetGetTabAt_IHandler")]
		public override unsafe global::Android.Support.V7.App.ActionBar.Tab GetTabAt (int p0)
		{
			if (id_getTabAt_I == IntPtr.Zero)
				id_getTabAt_I = JNIEnv.GetMethodID (class_ref, "getTabAt", "(I)Landroid/support/v7/app/ActionBar$Tab;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_getTabAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTabAt", "(I)Landroid/support/v7/app/ActionBar$Tab;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hide;
#pragma warning disable 0169
		static Delegate GetHideHandler ()
		{
			if (cb_hide == null)
				cb_hide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Hide);
			return cb_hide;
		}

		static void n_Hide (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		static IntPtr id_hide;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "GetHideHandler")]
		public override unsafe void Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_hide);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hide", "()V"));
			} finally {
			}
		}

		static Delegate cb_newTab;
#pragma warning disable 0169
		static Delegate GetNewTabHandler ()
		{
			if (cb_newTab == null)
				cb_newTab = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewTab);
			return cb_newTab;
		}

		static IntPtr n_NewTab (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewTab ());
		}
#pragma warning restore 0169

		static IntPtr id_newTab;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='newTab' and count(parameter)=0]"
		[Register ("newTab", "()Landroid/support/v7/app/ActionBar$Tab;", "GetNewTabHandler")]
		public override unsafe global::Android.Support.V7.App.ActionBar.Tab NewTab ()
		{
			if (id_newTab == IntPtr.Zero)
				id_newTab = JNIEnv.GetMethodID (class_ref, "newTab", "()Landroid/support/v7/app/ActionBar$Tab;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_newTab), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newTab", "()Landroid/support/v7/app/ActionBar$Tab;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeAllTabs;
#pragma warning disable 0169
		static Delegate GetRemoveAllTabsHandler ()
		{
			if (cb_removeAllTabs == null)
				cb_removeAllTabs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllTabs);
			return cb_removeAllTabs;
		}

		static void n_RemoveAllTabs (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllTabs ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllTabs;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='removeAllTabs' and count(parameter)=0]"
		[Register ("removeAllTabs", "()V", "GetRemoveAllTabsHandler")]
		public override unsafe void RemoveAllTabs ()
		{
			if (id_removeAllTabs == IntPtr.Zero)
				id_removeAllTabs = JNIEnv.GetMethodID (class_ref, "removeAllTabs", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeAllTabs);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllTabs", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_Handler ()
		{
			if (cb_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ == null)
				cb_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_);
			return cb_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
		}

		static void n_RemoveOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener p0 = (global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener)global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnMenuVisibilityListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='removeOnMenuVisibilityListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.OnMenuVisibilityListener']]"
		[Register ("removeOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V", "GetRemoveOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public override unsafe void RemoveOnMenuVisibilityListener (global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener p0)
		{
			if (id_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ == IntPtr.Zero)
				id_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ = JNIEnv.GetMethodID (class_ref, "removeOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeTab_Landroid_support_v7_app_ActionBar_Tab_;
#pragma warning disable 0169
		static Delegate GetRemoveTab_Landroid_support_v7_app_ActionBar_Tab_Handler ()
		{
			if (cb_removeTab_Landroid_support_v7_app_ActionBar_Tab_ == null)
				cb_removeTab_Landroid_support_v7_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveTab_Landroid_support_v7_app_ActionBar_Tab_);
			return cb_removeTab_Landroid_support_v7_app_ActionBar_Tab_;
		}

		static void n_RemoveTab_Landroid_support_v7_app_ActionBar_Tab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTab (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeTab_Landroid_support_v7_app_ActionBar_Tab_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='removeTab' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.Tab']]"
		[Register ("removeTab", "(Landroid/support/v7/app/ActionBar$Tab;)V", "GetRemoveTab_Landroid_support_v7_app_ActionBar_Tab_Handler")]
		public override unsafe void RemoveTab (global::Android.Support.V7.App.ActionBar.Tab p0)
		{
			if (id_removeTab_Landroid_support_v7_app_ActionBar_Tab_ == IntPtr.Zero)
				id_removeTab_Landroid_support_v7_app_ActionBar_Tab_ = JNIEnv.GetMethodID (class_ref, "removeTab", "(Landroid/support/v7/app/ActionBar$Tab;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeTab_Landroid_support_v7_app_ActionBar_Tab_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeTab", "(Landroid/support/v7/app/ActionBar$Tab;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeTabAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveTabAt_IHandler ()
		{
			if (cb_removeTabAt_I == null)
				cb_removeTabAt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveTabAt_I);
			return cb_removeTabAt_I;
		}

		static void n_RemoveTabAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTabAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeTabAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='removeTabAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeTabAt", "(I)V", "GetRemoveTabAt_IHandler")]
		public override unsafe void RemoveTabAt (int p0)
		{
			if (id_removeTabAt_I == IntPtr.Zero)
				id_removeTabAt_I = JNIEnv.GetMethodID (class_ref, "removeTabAt", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeTabAt_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeTabAt", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_selectTab_Landroid_support_v7_app_ActionBar_Tab_;
#pragma warning disable 0169
		static Delegate GetSelectTab_Landroid_support_v7_app_ActionBar_Tab_Handler ()
		{
			if (cb_selectTab_Landroid_support_v7_app_ActionBar_Tab_ == null)
				cb_selectTab_Landroid_support_v7_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SelectTab_Landroid_support_v7_app_ActionBar_Tab_);
			return cb_selectTab_Landroid_support_v7_app_ActionBar_Tab_;
		}

		static void n_SelectTab_Landroid_support_v7_app_ActionBar_Tab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectTab (p0);
		}
#pragma warning restore 0169

		static IntPtr id_selectTab_Landroid_support_v7_app_ActionBar_Tab_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='selectTab' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.Tab']]"
		[Register ("selectTab", "(Landroid/support/v7/app/ActionBar$Tab;)V", "GetSelectTab_Landroid_support_v7_app_ActionBar_Tab_Handler")]
		public override unsafe void SelectTab (global::Android.Support.V7.App.ActionBar.Tab p0)
		{
			if (id_selectTab_Landroid_support_v7_app_ActionBar_Tab_ == IntPtr.Zero)
				id_selectTab_Landroid_support_v7_app_ActionBar_Tab_ = JNIEnv.GetMethodID (class_ref, "selectTab", "(Landroid/support/v7/app/ActionBar$Tab;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_selectTab_Landroid_support_v7_app_ActionBar_Tab_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectTab", "(Landroid/support/v7/app/ActionBar$Tab;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackgroundDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetBackgroundDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setBackgroundDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public override unsafe void SetBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetSetCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_Handler ()
		{
			if (cb_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_ == null)
				cb_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_);
			return cb_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_;
		}

		static void n_SetCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.LayoutParams p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.LayoutParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setCustomView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.support.v7.app.ActionBar.LayoutParams']]"
		[Register ("setCustomView", "(Landroid/view/View;Landroid/support/v7/app/ActionBar$LayoutParams;)V", "GetSetCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_Handler")]
		public override unsafe void SetCustomView (global::Android.Views.View p0, global::Android.Support.V7.App.ActionBar.LayoutParams p1)
		{
			if (id_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_ == IntPtr.Zero)
				id_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "setCustomView", "(Landroid/view/View;Landroid/support/v7/app/ActionBar$LayoutParams;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomView", "(Landroid/view/View;Landroid/support/v7/app/ActionBar$LayoutParams;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCustomView_I;
#pragma warning disable 0169
		static Delegate GetSetCustomView_IHandler ()
		{
			if (cb_setCustomView_I == null)
				cb_setCustomView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCustomView_I);
			return cb_setCustomView_I;
		}

		static void n_SetCustomView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCustomView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCustomView", "(I)V", "GetSetCustomView_IHandler")]
		public override unsafe void SetCustomView (int p0)
		{
			if (id_setCustomView_I == IntPtr.Zero)
				id_setCustomView_I = JNIEnv.GetMethodID (class_ref, "setCustomView", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCustomView_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomView", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayHomeAsUpEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayHomeAsUpEnabled_ZHandler ()
		{
			if (cb_setDisplayHomeAsUpEnabled_Z == null)
				cb_setDisplayHomeAsUpEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayHomeAsUpEnabled_Z);
			return cb_setDisplayHomeAsUpEnabled_Z;
		}

		static void n_SetDisplayHomeAsUpEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayHomeAsUpEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayHomeAsUpEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setDisplayHomeAsUpEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayHomeAsUpEnabled", "(Z)V", "GetSetDisplayHomeAsUpEnabled_ZHandler")]
		public override unsafe void SetDisplayHomeAsUpEnabled (bool p0)
		{
			if (id_setDisplayHomeAsUpEnabled_Z == IntPtr.Zero)
				id_setDisplayHomeAsUpEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayHomeAsUpEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDisplayHomeAsUpEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayHomeAsUpEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayOptions_II;
#pragma warning disable 0169
		static Delegate GetSetDisplayOptions_IIHandler ()
		{
			if (cb_setDisplayOptions_II == null)
				cb_setDisplayOptions_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetDisplayOptions_II);
			return cb_setDisplayOptions_II;
		}

		static void n_SetDisplayOptions_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayOptions (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayOptions_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setDisplayOptions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDisplayOptions", "(II)V", "GetSetDisplayOptions_IIHandler")]
		public override unsafe void SetDisplayOptions ([global::Android.Runtime.IntDef (Flag = true, Type = "Android.Support.V7.App.ActionBar", Fields = new string [] {"DisplayUseLogo", "DisplayShowHome", "DisplayHomeAsUp", "DisplayShowTitle", "DisplayShowCustom"})]int p0, [global::Android.Runtime.IntDef (Flag = true, Type = "Android.Support.V7.App.ActionBar", Fields = new string [] {"DisplayUseLogo", "DisplayShowHome", "DisplayHomeAsUp", "DisplayShowTitle", "DisplayShowCustom"})]int p1)
		{
			if (id_setDisplayOptions_II == IntPtr.Zero)
				id_setDisplayOptions_II = JNIEnv.GetMethodID (class_ref, "setDisplayOptions", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDisplayOptions_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayOptions", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayShowCustomEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayShowCustomEnabled_ZHandler ()
		{
			if (cb_setDisplayShowCustomEnabled_Z == null)
				cb_setDisplayShowCustomEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayShowCustomEnabled_Z);
			return cb_setDisplayShowCustomEnabled_Z;
		}

		static void n_SetDisplayShowCustomEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayShowCustomEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayShowCustomEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setDisplayShowCustomEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayShowCustomEnabled", "(Z)V", "GetSetDisplayShowCustomEnabled_ZHandler")]
		public override unsafe void SetDisplayShowCustomEnabled (bool p0)
		{
			if (id_setDisplayShowCustomEnabled_Z == IntPtr.Zero)
				id_setDisplayShowCustomEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayShowCustomEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDisplayShowCustomEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayShowCustomEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayShowHomeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayShowHomeEnabled_ZHandler ()
		{
			if (cb_setDisplayShowHomeEnabled_Z == null)
				cb_setDisplayShowHomeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayShowHomeEnabled_Z);
			return cb_setDisplayShowHomeEnabled_Z;
		}

		static void n_SetDisplayShowHomeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayShowHomeEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayShowHomeEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setDisplayShowHomeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayShowHomeEnabled", "(Z)V", "GetSetDisplayShowHomeEnabled_ZHandler")]
		public override unsafe void SetDisplayShowHomeEnabled (bool p0)
		{
			if (id_setDisplayShowHomeEnabled_Z == IntPtr.Zero)
				id_setDisplayShowHomeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayShowHomeEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDisplayShowHomeEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayShowHomeEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayShowTitleEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayShowTitleEnabled_ZHandler ()
		{
			if (cb_setDisplayShowTitleEnabled_Z == null)
				cb_setDisplayShowTitleEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayShowTitleEnabled_Z);
			return cb_setDisplayShowTitleEnabled_Z;
		}

		static void n_SetDisplayShowTitleEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayShowTitleEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayShowTitleEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setDisplayShowTitleEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayShowTitleEnabled", "(Z)V", "GetSetDisplayShowTitleEnabled_ZHandler")]
		public override unsafe void SetDisplayShowTitleEnabled (bool p0)
		{
			if (id_setDisplayShowTitleEnabled_Z == IntPtr.Zero)
				id_setDisplayShowTitleEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayShowTitleEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDisplayShowTitleEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayShowTitleEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayUseLogoEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayUseLogoEnabled_ZHandler ()
		{
			if (cb_setDisplayUseLogoEnabled_Z == null)
				cb_setDisplayUseLogoEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayUseLogoEnabled_Z);
			return cb_setDisplayUseLogoEnabled_Z;
		}

		static void n_SetDisplayUseLogoEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayUseLogoEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayUseLogoEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setDisplayUseLogoEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayUseLogoEnabled", "(Z)V", "GetSetDisplayUseLogoEnabled_ZHandler")]
		public override unsafe void SetDisplayUseLogoEnabled (bool p0)
		{
			if (id_setDisplayUseLogoEnabled_Z == IntPtr.Zero)
				id_setDisplayUseLogoEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayUseLogoEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDisplayUseLogoEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayUseLogoEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public override unsafe void SetIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIcon_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_IHandler ()
		{
			if (cb_setIcon_I == null)
				cb_setIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIcon_I);
			return cb_setIcon_I;
		}

		static void n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIcon", "(I)V", "GetSetIcon_IHandler")]
		public override unsafe void SetIcon (int p0)
		{
			if (id_setIcon_I == IntPtr.Zero)
				id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIcon_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_;
#pragma warning disable 0169
		static Delegate GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_Handler ()
		{
			if (cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_ == null)
				cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_);
			return cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_;
		}

		static void n_SetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ISpinnerAdapter p0 = (global::Android.Widget.ISpinnerAdapter)global::Java.Lang.Object.GetObject<global::Android.Widget.ISpinnerAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.IOnNavigationListener p1 = (global::Android.Support.V7.App.ActionBar.IOnNavigationListener)global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IOnNavigationListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetListNavigationCallbacks (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setListNavigationCallbacks' and count(parameter)=2 and parameter[1][@type='android.widget.SpinnerAdapter'] and parameter[2][@type='android.support.v7.app.ActionBar.OnNavigationListener']]"
		[Register ("setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Landroid/support/v7/app/ActionBar$OnNavigationListener;)V", "GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_Handler")]
		public override unsafe void SetListNavigationCallbacks (global::Android.Widget.ISpinnerAdapter p0, global::Android.Support.V7.App.ActionBar.IOnNavigationListener p1)
		{
			if (id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_ == IntPtr.Zero)
				id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_ = JNIEnv.GetMethodID (class_ref, "setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Landroid/support/v7/app/ActionBar$OnNavigationListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Landroid/support/v7/app/ActionBar$OnNavigationListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLogo_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetLogo_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setLogo_Landroid_graphics_drawable_Drawable_ == null)
				cb_setLogo_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLogo_Landroid_graphics_drawable_Drawable_);
			return cb_setLogo_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetLogo_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLogo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLogo_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setLogo' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setLogo", "(Landroid/graphics/drawable/Drawable;)V", "GetSetLogo_Landroid_graphics_drawable_Drawable_Handler")]
		public override unsafe void SetLogo (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setLogo_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setLogo_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setLogo", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLogo_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogo", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLogo_I;
#pragma warning disable 0169
		static Delegate GetSetLogo_IHandler ()
		{
			if (cb_setLogo_I == null)
				cb_setLogo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLogo_I);
			return cb_setLogo_I;
		}

		static void n_SetLogo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLogo_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setLogo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogo", "(I)V", "GetSetLogo_IHandler")]
		public override unsafe void SetLogo (int p0)
		{
			if (id_setLogo_I == IntPtr.Zero)
				id_setLogo_I = JNIEnv.GetMethodID (class_ref, "setLogo", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLogo_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogo", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectedNavigationItem_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedNavigationItem_IHandler ()
		{
			if (cb_setSelectedNavigationItem_I == null)
				cb_setSelectedNavigationItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedNavigationItem_I);
			return cb_setSelectedNavigationItem_I;
		}

		static void n_SetSelectedNavigationItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectedNavigationItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectedNavigationItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setSelectedNavigationItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectedNavigationItem", "(I)V", "GetSetSelectedNavigationItem_IHandler")]
		public override unsafe void SetSelectedNavigationItem (int p0)
		{
			if (id_setSelectedNavigationItem_I == IntPtr.Zero)
				id_setSelectedNavigationItem_I = JNIEnv.GetMethodID (class_ref, "setSelectedNavigationItem", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelectedNavigationItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedNavigationItem", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSubtitle_I;
#pragma warning disable 0169
		static Delegate GetSetSubtitle_IHandler ()
		{
			if (cb_setSubtitle_I == null)
				cb_setSubtitle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSubtitle_I);
			return cb_setSubtitle_I;
		}

		static void n_SetSubtitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSubtitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSubtitle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setSubtitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSubtitle", "(I)V", "GetSetSubtitle_IHandler")]
		public override unsafe void SetSubtitle (int p0)
		{
			if (id_setSubtitle_I == IntPtr.Zero)
				id_setSubtitle_I = JNIEnv.GetMethodID (class_ref, "setSubtitle", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSubtitle_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubtitle", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTitle_I;
#pragma warning disable 0169
		static Delegate GetSetTitle_IHandler ()
		{
			if (cb_setTitle_I == null)
				cb_setTitle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTitle_I);
			return cb_setTitle_I;
		}

		static void n_SetTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTitle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public override unsafe void SetTitle (int p0)
		{
			if (id_setTitle_I == IntPtr.Zero)
				id_setTitle_I = JNIEnv.GetMethodID (class_ref, "setTitle", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTitle_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.App.ToolbarActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.App.ToolbarActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.app']/class[@name='ToolbarActionBar']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public override unsafe void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_show);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "()V"));
			} finally {
			}
		}

#region "Event implementation for Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener"
		public event EventHandler<global::Android.Support.V7.App.ActionBar.MenuVisibilityEventArgs> MenuVisibility {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener, global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListenerImplementor>(
						ref weak_implementor_AddOnMenuVisibilityListener,
						__CreateIOnMenuVisibilityListenerImplementor,
						AddOnMenuVisibilityListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener, global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListenerImplementor>(
						ref weak_implementor_AddOnMenuVisibilityListener,
						global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListenerImplementor.__IsEmpty,
						RemoveOnMenuVisibilityListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnMenuVisibilityListener;

		global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListenerImplementor __CreateIOnMenuVisibilityListenerImplementor ()
		{
			return new global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListenerImplementor (this);
		}
#endregion
	}
}
