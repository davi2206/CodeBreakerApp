using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.app']/class[@name='AppCompatDialog']"
	[global::Android.Runtime.Register ("android/support/v7/app/AppCompatDialog", DoNotGenerateAcw=true)]
	public partial class AppCompatDialog : global::Android.App.Dialog, global::Android.Support.V7.App.IAppCompatCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/app/AppCompatDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppCompatDialog); }
		}

		protected AppCompatDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='AppCompatDialog']/constructor[@name='AppCompatDialog' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe AppCompatDialog (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AppCompatDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_ZLandroid_content_DialogInterface_OnCancelListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='AppCompatDialog']/constructor[@name='AppCompatDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register (".ctor", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", "")]
		protected unsafe AppCompatDialog (global::Android.Content.Context p0, bool p1, global::Android.Content.IDialogInterfaceOnCancelListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (AppCompatDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ZLandroid_content_DialogInterface_OnCancelListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ZLandroid_content_DialogInterface_OnCancelListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ZLandroid_content_DialogInterface_OnCancelListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_ZLandroid_content_DialogInterface_OnCancelListener_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='AppCompatDialog']/constructor[@name='AppCompatDialog' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AppCompatDialog (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AppCompatDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getSupportActionBar;
#pragma warning disable 0169
		static Delegate GetGetSupportActionBarHandler ()
		{
			if (cb_getSupportActionBar == null)
				cb_getSupportActionBar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportActionBar);
			return cb_getSupportActionBar;
		}

		static IntPtr n_GetSupportActionBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.AppCompatDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AppCompatDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SupportActionBar);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportActionBar;
		public virtual unsafe global::Android.Support.V7.App.ActionBar SupportActionBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AppCompatDialog']/method[@name='getSupportActionBar' and count(parameter)=0]"
			[Register ("getSupportActionBar", "()Landroid/support/v7/app/ActionBar;", "GetGetSupportActionBarHandler")]
			get {
				if (id_getSupportActionBar == IntPtr.Zero)
					id_getSupportActionBar = JNIEnv.GetMethodID (class_ref, "getSupportActionBar", "()Landroid/support/v7/app/ActionBar;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (JNIEnv.CallObjectMethod  (Handle, id_getSupportActionBar), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportActionBar", "()Landroid/support/v7/app/ActionBar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_;
#pragma warning disable 0169
		static Delegate GetOnSupportActionModeFinished_Landroid_support_v7_view_ActionMode_Handler ()
		{
			if (cb_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_ == null)
				cb_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSupportActionModeFinished_Landroid_support_v7_view_ActionMode_);
			return cb_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_;
		}

		static void n_OnSupportActionModeFinished_Landroid_support_v7_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.AppCompatDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AppCompatDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSupportActionModeFinished (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AppCompatDialog']/method[@name='onSupportActionModeFinished' and count(parameter)=1 and parameter[1][@type='android.support.v7.view.ActionMode']]"
		[Register ("onSupportActionModeFinished", "(Landroid/support/v7/view/ActionMode;)V", "GetOnSupportActionModeFinished_Landroid_support_v7_view_ActionMode_Handler")]
		public virtual unsafe void OnSupportActionModeFinished (global::Android.Support.V7.View.ActionMode p0)
		{
			if (id_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_ == IntPtr.Zero)
				id_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onSupportActionModeFinished", "(Landroid/support/v7/view/ActionMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSupportActionModeFinished", "(Landroid/support/v7/view/ActionMode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_;
#pragma warning disable 0169
		static Delegate GetOnSupportActionModeStarted_Landroid_support_v7_view_ActionMode_Handler ()
		{
			if (cb_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_ == null)
				cb_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSupportActionModeStarted_Landroid_support_v7_view_ActionMode_);
			return cb_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_;
		}

		static void n_OnSupportActionModeStarted_Landroid_support_v7_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.AppCompatDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AppCompatDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSupportActionModeStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AppCompatDialog']/method[@name='onSupportActionModeStarted' and count(parameter)=1 and parameter[1][@type='android.support.v7.view.ActionMode']]"
		[Register ("onSupportActionModeStarted", "(Landroid/support/v7/view/ActionMode;)V", "GetOnSupportActionModeStarted_Landroid_support_v7_view_ActionMode_Handler")]
		public virtual unsafe void OnSupportActionModeStarted (global::Android.Support.V7.View.ActionMode p0)
		{
			if (id_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_ == IntPtr.Zero)
				id_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onSupportActionModeStarted", "(Landroid/support/v7/view/ActionMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSupportActionModeStarted", "(Landroid/support/v7/view/ActionMode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_;
#pragma warning disable 0169
		static Delegate GetOnWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_Handler ()
		{
			if (cb_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_ == null)
				cb_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_);
			return cb_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_;
		}

		static IntPtr n_OnWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.AppCompatDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AppCompatDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.View.ActionMode.ICallback p0 = (global::Android.Support.V7.View.ActionMode.ICallback)global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnWindowStartingSupportActionMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AppCompatDialog']/method[@name='onWindowStartingSupportActionMode' and count(parameter)=1 and parameter[1][@type='android.support.v7.view.ActionMode.Callback']]"
		[Register ("onWindowStartingSupportActionMode", "(Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;", "GetOnWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_Handler")]
		public virtual unsafe global::Android.Support.V7.View.ActionMode OnWindowStartingSupportActionMode (global::Android.Support.V7.View.ActionMode.ICallback p0)
		{
			if (id_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_ == IntPtr.Zero)
				id_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_ = JNIEnv.GetMethodID (class_ref, "onWindowStartingSupportActionMode", "(Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Support.V7.View.ActionMode __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (JNIEnv.CallObjectMethod  (Handle, id_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onWindowStartingSupportActionMode", "(Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_supportRequestWindowFeature_I;
#pragma warning disable 0169
		static Delegate GetSupportRequestWindowFeature_IHandler ()
		{
			if (cb_supportRequestWindowFeature_I == null)
				cb_supportRequestWindowFeature_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SupportRequestWindowFeature_I);
			return cb_supportRequestWindowFeature_I;
		}

		static bool n_SupportRequestWindowFeature_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.AppCompatDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AppCompatDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SupportRequestWindowFeature (p0);
		}
#pragma warning restore 0169

		static IntPtr id_supportRequestWindowFeature_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AppCompatDialog']/method[@name='supportRequestWindowFeature' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("supportRequestWindowFeature", "(I)Z", "GetSupportRequestWindowFeature_IHandler")]
		public virtual unsafe bool SupportRequestWindowFeature (int p0)
		{
			if (id_supportRequestWindowFeature_I == IntPtr.Zero)
				id_supportRequestWindowFeature_I = JNIEnv.GetMethodID (class_ref, "supportRequestWindowFeature", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_supportRequestWindowFeature_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "supportRequestWindowFeature", "(I)Z"), __args);
			} finally {
			}
		}

	}
}
