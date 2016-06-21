using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.App {

	// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.app']/interface[@name='AppCompatCallback']"
	[Register ("android/support/v7/app/AppCompatCallback", "", "Android.Support.V7.App.IAppCompatCallbackInvoker")]
	public partial interface IAppCompatCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/interface[@name='AppCompatCallback']/method[@name='onSupportActionModeFinished' and count(parameter)=1 and parameter[1][@type='android.support.v7.view.ActionMode']]"
		[Register ("onSupportActionModeFinished", "(Landroid/support/v7/view/ActionMode;)V", "GetOnSupportActionModeFinished_Landroid_support_v7_view_ActionMode_Handler:Android.Support.V7.App.IAppCompatCallbackInvoker, Binding_AppcompatV7")]
		void OnSupportActionModeFinished (global::Android.Support.V7.View.ActionMode p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/interface[@name='AppCompatCallback']/method[@name='onSupportActionModeStarted' and count(parameter)=1 and parameter[1][@type='android.support.v7.view.ActionMode']]"
		[Register ("onSupportActionModeStarted", "(Landroid/support/v7/view/ActionMode;)V", "GetOnSupportActionModeStarted_Landroid_support_v7_view_ActionMode_Handler:Android.Support.V7.App.IAppCompatCallbackInvoker, Binding_AppcompatV7")]
		void OnSupportActionModeStarted (global::Android.Support.V7.View.ActionMode p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/interface[@name='AppCompatCallback']/method[@name='onWindowStartingSupportActionMode' and count(parameter)=1 and parameter[1][@type='android.support.v7.view.ActionMode.Callback']]"
		[Register ("onWindowStartingSupportActionMode", "(Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;", "GetOnWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_Handler:Android.Support.V7.App.IAppCompatCallbackInvoker, Binding_AppcompatV7")]
		global::Android.Support.V7.View.ActionMode OnWindowStartingSupportActionMode (global::Android.Support.V7.View.ActionMode.ICallback p0);

	}

	[global::Android.Runtime.Register ("android/support/v7/app/AppCompatCallback", DoNotGenerateAcw=true)]
	internal class IAppCompatCallbackInvoker : global::Java.Lang.Object, IAppCompatCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/app/AppCompatCallback");
		IntPtr class_ref;

		public static IAppCompatCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppCompatCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.app.AppCompatCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppCompatCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAppCompatCallbackInvoker); }
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
			global::Android.Support.V7.App.IAppCompatCallback __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.IAppCompatCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSupportActionModeFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_;
		public unsafe void OnSupportActionModeFinished (global::Android.Support.V7.View.ActionMode p0)
		{
			if (id_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_ == IntPtr.Zero)
				id_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onSupportActionModeFinished", "(Landroid/support/v7/view/ActionMode;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onSupportActionModeFinished_Landroid_support_v7_view_ActionMode_, __args);
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
			global::Android.Support.V7.App.IAppCompatCallback __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.IAppCompatCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSupportActionModeStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_;
		public unsafe void OnSupportActionModeStarted (global::Android.Support.V7.View.ActionMode p0)
		{
			if (id_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_ == IntPtr.Zero)
				id_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onSupportActionModeStarted", "(Landroid/support/v7/view/ActionMode;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onSupportActionModeStarted_Landroid_support_v7_view_ActionMode_, __args);
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
			global::Android.Support.V7.App.IAppCompatCallback __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.IAppCompatCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.View.ActionMode.ICallback p0 = (global::Android.Support.V7.View.ActionMode.ICallback)global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnWindowStartingSupportActionMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_;
		public unsafe global::Android.Support.V7.View.ActionMode OnWindowStartingSupportActionMode (global::Android.Support.V7.View.ActionMode.ICallback p0)
		{
			if (id_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_ == IntPtr.Zero)
				id_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_ = JNIEnv.GetMethodID (class_ref, "onWindowStartingSupportActionMode", "(Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Android.Support.V7.View.ActionMode __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (JNIEnv.CallObjectMethod (Handle, id_onWindowStartingSupportActionMode_Landroid_support_v7_view_ActionMode_Callback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
