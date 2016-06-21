using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='FitWindowsViewGroup.OnFitSystemWindowsListener']"
	[Register ("android/support/v7/internal/widget/FitWindowsViewGroup$OnFitSystemWindowsListener", "", "Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListenerInvoker")]
	public partial interface IFitWindowsViewGroupOnFitSystemWindowsListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='FitWindowsViewGroup.OnFitSystemWindowsListener']/method[@name='onFitSystemWindows' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("onFitSystemWindows", "(Landroid/graphics/Rect;)V", "GetOnFitSystemWindows_Landroid_graphics_Rect_Handler:Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListenerInvoker, Binding_AppcompatV7")]
		void OnFitSystemWindows (global::Android.Graphics.Rect p0);

	}

	[global::Android.Runtime.Register ("android/support/v7/internal/widget/FitWindowsViewGroup$OnFitSystemWindowsListener", DoNotGenerateAcw=true)]
	internal class IFitWindowsViewGroupOnFitSystemWindowsListenerInvoker : global::Java.Lang.Object, IFitWindowsViewGroupOnFitSystemWindowsListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/internal/widget/FitWindowsViewGroup$OnFitSystemWindowsListener");
		IntPtr class_ref;

		public static IFitWindowsViewGroupOnFitSystemWindowsListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFitWindowsViewGroupOnFitSystemWindowsListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.internal.widget.FitWindowsViewGroup.OnFitSystemWindowsListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFitWindowsViewGroupOnFitSystemWindowsListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFitWindowsViewGroupOnFitSystemWindowsListenerInvoker); }
		}

		static Delegate cb_onFitSystemWindows_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetOnFitSystemWindows_Landroid_graphics_Rect_Handler ()
		{
			if (cb_onFitSystemWindows_Landroid_graphics_Rect_ == null)
				cb_onFitSystemWindows_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFitSystemWindows_Landroid_graphics_Rect_);
			return cb_onFitSystemWindows_Landroid_graphics_Rect_;
		}

		static void n_OnFitSystemWindows_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFitSystemWindows (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFitSystemWindows_Landroid_graphics_Rect_;
		public unsafe void OnFitSystemWindows (global::Android.Graphics.Rect p0)
		{
			if (id_onFitSystemWindows_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_onFitSystemWindows_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onFitSystemWindows", "(Landroid/graphics/Rect;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onFitSystemWindows_Landroid_graphics_Rect_, __args);
		}

	}

	public partial class FitWindowsViewGroupOnFitSystemWindowsEventArgs : global::System.EventArgs {

		public FitWindowsViewGroupOnFitSystemWindowsEventArgs (global::Android.Graphics.Rect p0)
		{
			this.p0 = p0;
		}

		global::Android.Graphics.Rect p0;
		public global::Android.Graphics.Rect P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/android/support/v7/internal/widget/FitWindowsViewGroup_OnFitSystemWindowsListenerImplementor")]
	internal sealed partial class IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor : global::Java.Lang.Object, IFitWindowsViewGroupOnFitSystemWindowsListener {

		object sender;

		public IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/android/support/v7/internal/widget/FitWindowsViewGroup_OnFitSystemWindowsListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FitWindowsViewGroupOnFitSystemWindowsEventArgs> Handler;
#pragma warning restore 0649

		public void OnFitSystemWindows (global::Android.Graphics.Rect p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new FitWindowsViewGroupOnFitSystemWindowsEventArgs (p0));
		}

		internal static bool __IsEmpty (IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='FitWindowsViewGroup']"
	[Register ("android/support/v7/internal/widget/FitWindowsViewGroup", "", "Android.Support.V7.Internal.Widget.IFitWindowsViewGroupInvoker")]
	public partial interface IFitWindowsViewGroup : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='FitWindowsViewGroup']/method[@name='setOnFitSystemWindowsListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.internal.widget.FitWindowsViewGroup.OnFitSystemWindowsListener']]"
		[Register ("setOnFitSystemWindowsListener", "(Landroid/support/v7/internal/widget/FitWindowsViewGroup$OnFitSystemWindowsListener;)V", "GetSetOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_Handler:Android.Support.V7.Internal.Widget.IFitWindowsViewGroupInvoker, Binding_AppcompatV7")]
		void SetOnFitSystemWindowsListener (global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener p0);

	}

	[global::Android.Runtime.Register ("android/support/v7/internal/widget/FitWindowsViewGroup", DoNotGenerateAcw=true)]
	internal class IFitWindowsViewGroupInvoker : global::Java.Lang.Object, IFitWindowsViewGroup {

		static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/internal/widget/FitWindowsViewGroup");
		IntPtr class_ref;

		public static IFitWindowsViewGroup GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFitWindowsViewGroup> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.internal.widget.FitWindowsViewGroup"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFitWindowsViewGroupInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFitWindowsViewGroupInvoker); }
		}

		static Delegate cb_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_;
#pragma warning disable 0169
		static Delegate GetSetOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_Handler ()
		{
			if (cb_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_ == null)
				cb_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_);
			return cb_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_;
		}

		static void n_SetOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroup __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener p0 = (global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener)global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnFitSystemWindowsListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_;
		public unsafe void SetOnFitSystemWindowsListener (global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener p0)
		{
			if (id_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_ == IntPtr.Zero)
				id_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_ = JNIEnv.GetMethodID (class_ref, "setOnFitSystemWindowsListener", "(Landroid/support/v7/internal/widget/FitWindowsViewGroup$OnFitSystemWindowsListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_, __args);
		}

	}

}
