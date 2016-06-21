using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.View {

	// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.view']/interface[@name='CollapsibleActionView']"
	[Register ("android/support/v7/view/CollapsibleActionView", "", "Android.Support.V7.View.ICollapsibleActionViewInvoker")]
	public partial interface ICollapsibleActionView : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.view']/interface[@name='CollapsibleActionView']/method[@name='onActionViewCollapsed' and count(parameter)=0]"
		[Register ("onActionViewCollapsed", "()V", "GetOnActionViewCollapsedHandler:Android.Support.V7.View.ICollapsibleActionViewInvoker, Binding_AppcompatV7")]
		void OnActionViewCollapsed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.view']/interface[@name='CollapsibleActionView']/method[@name='onActionViewExpanded' and count(parameter)=0]"
		[Register ("onActionViewExpanded", "()V", "GetOnActionViewExpandedHandler:Android.Support.V7.View.ICollapsibleActionViewInvoker, Binding_AppcompatV7")]
		void OnActionViewExpanded ();

	}

	[global::Android.Runtime.Register ("android/support/v7/view/CollapsibleActionView", DoNotGenerateAcw=true)]
	internal class ICollapsibleActionViewInvoker : global::Java.Lang.Object, ICollapsibleActionView {

		static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/view/CollapsibleActionView");
		IntPtr class_ref;

		public static ICollapsibleActionView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICollapsibleActionView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.view.CollapsibleActionView"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICollapsibleActionViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICollapsibleActionViewInvoker); }
		}

		static Delegate cb_onActionViewCollapsed;
#pragma warning disable 0169
		static Delegate GetOnActionViewCollapsedHandler ()
		{
			if (cb_onActionViewCollapsed == null)
				cb_onActionViewCollapsed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnActionViewCollapsed);
			return cb_onActionViewCollapsed;
		}

		static void n_OnActionViewCollapsed (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.View.ICollapsibleActionView __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ICollapsibleActionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnActionViewCollapsed ();
		}
#pragma warning restore 0169

		IntPtr id_onActionViewCollapsed;
		public unsafe void OnActionViewCollapsed ()
		{
			if (id_onActionViewCollapsed == IntPtr.Zero)
				id_onActionViewCollapsed = JNIEnv.GetMethodID (class_ref, "onActionViewCollapsed", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onActionViewCollapsed);
		}

		static Delegate cb_onActionViewExpanded;
#pragma warning disable 0169
		static Delegate GetOnActionViewExpandedHandler ()
		{
			if (cb_onActionViewExpanded == null)
				cb_onActionViewExpanded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnActionViewExpanded);
			return cb_onActionViewExpanded;
		}

		static void n_OnActionViewExpanded (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.View.ICollapsibleActionView __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ICollapsibleActionView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnActionViewExpanded ();
		}
#pragma warning restore 0169

		IntPtr id_onActionViewExpanded;
		public unsafe void OnActionViewExpanded ()
		{
			if (id_onActionViewExpanded == IntPtr.Zero)
				id_onActionViewExpanded = JNIEnv.GetMethodID (class_ref, "onActionViewExpanded", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onActionViewExpanded);
		}

	}

}
