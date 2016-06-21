using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']"
	[global::Android.Runtime.Register ("android/support/v7/internal/view/SupportActionModeWrapper", DoNotGenerateAcw=true)]
	public partial class SupportActionModeWrapper : global::Android.Views.ActionMode {

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper.CallbackWrapper']"
		[global::Android.Runtime.Register ("android/support/v7/internal/view/SupportActionModeWrapper$CallbackWrapper", DoNotGenerateAcw=true)]
		public partial class CallbackWrapper : global::Java.Lang.Object, global::Android.Support.V7.View.ActionMode.ICallback {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/internal/view/SupportActionModeWrapper$CallbackWrapper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallbackWrapper); }
			}

			protected CallbackWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Landroid_view_ActionMode_Callback_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper.CallbackWrapper']/constructor[@name='SupportActionModeWrapper.CallbackWrapper' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.ActionMode.Callback']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/view/ActionMode$Callback;)V", "")]
			public unsafe CallbackWrapper (global::Android.Content.Context p0, global::Android.Views.ActionMode.ICallback p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (CallbackWrapper)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/view/ActionMode$Callback;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/view/ActionMode$Callback;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_Landroid_view_ActionMode_Callback_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_Landroid_view_ActionMode_Callback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/view/ActionMode$Callback;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_view_ActionMode_Callback_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_view_ActionMode_Callback_, __args);
				} finally {
				}
			}

			static Delegate cb_getActionModeWrapper_Landroid_support_v7_view_ActionMode_;
#pragma warning disable 0169
			static Delegate GetGetActionModeWrapper_Landroid_support_v7_view_ActionMode_Handler ()
			{
				if (cb_getActionModeWrapper_Landroid_support_v7_view_ActionMode_ == null)
					cb_getActionModeWrapper_Landroid_support_v7_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetActionModeWrapper_Landroid_support_v7_view_ActionMode_);
				return cb_getActionModeWrapper_Landroid_support_v7_view_ActionMode_;
			}

			static IntPtr n_GetActionModeWrapper_Landroid_support_v7_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.Internal.View.SupportActionModeWrapper.CallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper.CallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetActionModeWrapper (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getActionModeWrapper_Landroid_support_v7_view_ActionMode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper.CallbackWrapper']/method[@name='getActionModeWrapper' and count(parameter)=1 and parameter[1][@type='android.support.v7.view.ActionMode']]"
			[Register ("getActionModeWrapper", "(Landroid/support/v7/view/ActionMode;)Landroid/view/ActionMode;", "GetGetActionModeWrapper_Landroid_support_v7_view_ActionMode_Handler")]
			public virtual unsafe global::Android.Views.ActionMode GetActionModeWrapper (global::Android.Support.V7.View.ActionMode p0)
			{
				if (id_getActionModeWrapper_Landroid_support_v7_view_ActionMode_ == IntPtr.Zero)
					id_getActionModeWrapper_Landroid_support_v7_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "getActionModeWrapper", "(Landroid/support/v7/view/ActionMode;)Landroid/view/ActionMode;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Android.Views.ActionMode __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (JNIEnv.CallObjectMethod  (Handle, id_getActionModeWrapper_Landroid_support_v7_view_ActionMode_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionModeWrapper", "(Landroid/support/v7/view/ActionMode;)Landroid/view/ActionMode;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_;
#pragma warning disable 0169
			static Delegate GetOnActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_Handler ()
			{
				if (cb_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_ == null)
					cb_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_);
				return cb_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_;
			}

			static bool n_OnActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.Internal.View.SupportActionModeWrapper.CallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper.CallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IMenuItem p1 = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnActionItemClicked (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper.CallbackWrapper']/method[@name='onActionItemClicked' and count(parameter)=2 and parameter[1][@type='android.support.v7.view.ActionMode'] and parameter[2][@type='android.view.MenuItem']]"
			[Register ("onActionItemClicked", "(Landroid/support/v7/view/ActionMode;Landroid/view/MenuItem;)Z", "GetOnActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_Handler")]
			public virtual unsafe bool OnActionItemClicked (global::Android.Support.V7.View.ActionMode p0, global::Android.Views.IMenuItem p1)
			{
				if (id_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_ == IntPtr.Zero)
					id_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onActionItemClicked", "(Landroid/support/v7/view/ActionMode;Landroid/view/MenuItem;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActionItemClicked", "(Landroid/support/v7/view/ActionMode;Landroid/view/MenuItem;)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
#pragma warning disable 0169
			static Delegate GetOnCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_Handler ()
			{
				if (cb_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ == null)
					cb_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_);
				return cb_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
			}

			static bool n_OnCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.Internal.View.SupportActionModeWrapper.CallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper.CallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCreateActionMode (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper.CallbackWrapper']/method[@name='onCreateActionMode' and count(parameter)=2 and parameter[1][@type='android.support.v7.view.ActionMode'] and parameter[2][@type='android.view.Menu']]"
			[Register ("onCreateActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z", "GetOnCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_Handler")]
			public virtual unsafe bool OnCreateActionMode (global::Android.Support.V7.View.ActionMode p0, global::Android.Views.IMenu p1)
			{
				if (id_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ == IntPtr.Zero)
					id_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onDestroyActionMode_Landroid_support_v7_view_ActionMode_;
#pragma warning disable 0169
			static Delegate GetOnDestroyActionMode_Landroid_support_v7_view_ActionMode_Handler ()
			{
				if (cb_onDestroyActionMode_Landroid_support_v7_view_ActionMode_ == null)
					cb_onDestroyActionMode_Landroid_support_v7_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDestroyActionMode_Landroid_support_v7_view_ActionMode_);
				return cb_onDestroyActionMode_Landroid_support_v7_view_ActionMode_;
			}

			static void n_OnDestroyActionMode_Landroid_support_v7_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.Internal.View.SupportActionModeWrapper.CallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper.CallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDestroyActionMode (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onDestroyActionMode_Landroid_support_v7_view_ActionMode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper.CallbackWrapper']/method[@name='onDestroyActionMode' and count(parameter)=1 and parameter[1][@type='android.support.v7.view.ActionMode']]"
			[Register ("onDestroyActionMode", "(Landroid/support/v7/view/ActionMode;)V", "GetOnDestroyActionMode_Landroid_support_v7_view_ActionMode_Handler")]
			public virtual unsafe void OnDestroyActionMode (global::Android.Support.V7.View.ActionMode p0)
			{
				if (id_onDestroyActionMode_Landroid_support_v7_view_ActionMode_ == IntPtr.Zero)
					id_onDestroyActionMode_Landroid_support_v7_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onDestroyActionMode", "(Landroid/support/v7/view/ActionMode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onDestroyActionMode_Landroid_support_v7_view_ActionMode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroyActionMode", "(Landroid/support/v7/view/ActionMode;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
#pragma warning disable 0169
			static Delegate GetOnPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_Handler ()
			{
				if (cb_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ == null)
					cb_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_);
				return cb_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
			}

			static bool n_OnPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.Internal.View.SupportActionModeWrapper.CallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper.CallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPrepareActionMode (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper.CallbackWrapper']/method[@name='onPrepareActionMode' and count(parameter)=2 and parameter[1][@type='android.support.v7.view.ActionMode'] and parameter[2][@type='android.view.Menu']]"
			[Register ("onPrepareActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z", "GetOnPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_Handler")]
			public virtual unsafe bool OnPrepareActionMode (global::Android.Support.V7.View.ActionMode p0, global::Android.Views.IMenu p1)
			{
				if (id_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ == IntPtr.Zero)
					id_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepareActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/view/SupportActionModeWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SupportActionModeWrapper); }
		}

		protected SupportActionModeWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_support_v7_view_ActionMode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/constructor[@name='SupportActionModeWrapper' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.support.v7.view.ActionMode']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/support/v7/view/ActionMode;)V", "")]
		public unsafe SupportActionModeWrapper (global::Android.Content.Context p0, global::Android.Support.V7.View.ActionMode p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SupportActionModeWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/support/v7/view/ActionMode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/support/v7/view/ActionMode;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_support_v7_view_ActionMode_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_support_v7_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/support/v7/view/ActionMode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_support_v7_view_ActionMode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_support_v7_view_ActionMode_, __args);
			} finally {
			}
		}

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
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomView = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCustomView;
		static IntPtr id_setCustomView_Landroid_view_View_;
		public override unsafe global::Android.Views.View CustomView {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='getCustomView' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
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

		static Delegate cb_getMenu;
#pragma warning disable 0169
		static Delegate GetGetMenuHandler ()
		{
			if (cb_getMenu == null)
				cb_getMenu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMenu);
			return cb_getMenu;
		}

		static IntPtr n_GetMenu (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Menu);
		}
#pragma warning restore 0169

		static IntPtr id_getMenu;
		public override unsafe global::Android.Views.IMenu Menu {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='getMenu' and count(parameter)=0]"
			[Register ("getMenu", "()Landroid/view/Menu;", "GetGetMenuHandler")]
			get {
				if (id_getMenu == IntPtr.Zero)
					id_getMenu = JNIEnv.GetMethodID (class_ref, "getMenu", "()Landroid/view/Menu;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (JNIEnv.CallObjectMethod  (Handle, id_getMenu), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMenu", "()Landroid/view/Menu;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMenuInflater;
#pragma warning disable 0169
		static Delegate GetGetMenuInflaterHandler ()
		{
			if (cb_getMenuInflater == null)
				cb_getMenuInflater = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMenuInflater);
			return cb_getMenuInflater;
		}

		static IntPtr n_GetMenuInflater (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MenuInflater);
		}
#pragma warning restore 0169

		static IntPtr id_getMenuInflater;
		public override unsafe global::Android.Views.MenuInflater MenuInflater {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='getMenuInflater' and count(parameter)=0]"
			[Register ("getMenuInflater", "()Landroid/view/MenuInflater;", "GetGetMenuInflaterHandler")]
			get {
				if (id_getMenuInflater == IntPtr.Zero)
					id_getMenuInflater = JNIEnv.GetMethodID (class_ref, "getMenuInflater", "()Landroid/view/MenuInflater;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.MenuInflater> (JNIEnv.CallObjectMethod  (Handle, id_getMenuInflater), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.MenuInflater> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMenuInflater", "()Landroid/view/MenuInflater;")), JniHandleOwnership.TransferLocalRef);
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
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.SubtitleFormatted);
		}
#pragma warning restore 0169

		static IntPtr id_getSubtitle;
		public override unsafe global::Java.Lang.ICharSequence SubtitleFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='getSubtitle' and count(parameter)=0]"
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
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TitleFormatted);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public override unsafe global::Java.Lang.ICharSequence TitleFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='getTitle' and count(parameter)=0]"
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
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		static IntPtr id_finish;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public override unsafe void Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_finish);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finish", "()V"));
			} finally {
			}
		}

		static Delegate cb_invalidate;
#pragma warning disable 0169
		static Delegate GetInvalidateHandler ()
		{
			if (cb_invalidate == null)
				cb_invalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Invalidate);
			return cb_invalidate;
		}

		static void n_Invalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate ();
		}
#pragma warning restore 0169

		static IntPtr id_invalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "GetInvalidateHandler")]
		public override unsafe void Invalidate ()
		{
			if (id_invalidate == IntPtr.Zero)
				id_invalidate = JNIEnv.GetMethodID (class_ref, "invalidate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_invalidate);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidate", "()V"));
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
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSubtitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSubtitle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='setSubtitle' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSubtitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSubtitle_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='setSubtitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")]
		public override unsafe void SetSubtitle (global::Java.Lang.ICharSequence p0)
		{
			if (id_setSubtitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setSubtitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setSubtitle", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSubtitle_Ljava_lang_CharSequence_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubtitle", "(Ljava/lang/CharSequence;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTitle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Android.Support.V7.Internal.View.SupportActionModeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportActionModeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTitle_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportActionModeWrapper']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
		public override unsafe void SetTitle (global::Java.Lang.ICharSequence p0)
		{
			if (id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_CharSequence_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/CharSequence;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
