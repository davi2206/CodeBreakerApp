using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='FitWindowsLinearLayout']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/FitWindowsLinearLayout", DoNotGenerateAcw=true)]
	public partial class FitWindowsLinearLayout : global::Android.Widget.LinearLayout, global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroup {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/FitWindowsLinearLayout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FitWindowsLinearLayout); }
		}

		protected FitWindowsLinearLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='FitWindowsLinearLayout']/constructor[@name='FitWindowsLinearLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe FitWindowsLinearLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FitWindowsLinearLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='FitWindowsLinearLayout']/constructor[@name='FitWindowsLinearLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FitWindowsLinearLayout (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (FitWindowsLinearLayout)) {
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
			global::Android.Support.V7.Internal.Widget.FitWindowsLinearLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.FitWindowsLinearLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener p0 = (global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener)global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnFitSystemWindowsListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='FitWindowsLinearLayout']/method[@name='setOnFitSystemWindowsListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.internal.widget.FitWindowsViewGroup.OnFitSystemWindowsListener']]"
		[Register ("setOnFitSystemWindowsListener", "(Landroid/support/v7/internal/widget/FitWindowsViewGroup$OnFitSystemWindowsListener;)V", "GetSetOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_Handler")]
		public virtual unsafe void SetOnFitSystemWindowsListener (global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener p0)
		{
			if (id_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_ == IntPtr.Zero)
				id_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_ = JNIEnv.GetMethodID (class_ref, "setOnFitSystemWindowsListener", "(Landroid/support/v7/internal/widget/FitWindowsViewGroup$OnFitSystemWindowsListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnFitSystemWindowsListener_Landroid_support_v7_internal_widget_FitWindowsViewGroup_OnFitSystemWindowsListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnFitSystemWindowsListener", "(Landroid/support/v7/internal/widget/FitWindowsViewGroup$OnFitSystemWindowsListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener"
		public event EventHandler<global::Android.Support.V7.Internal.Widget.FitWindowsViewGroupOnFitSystemWindowsEventArgs> FitSystemWindows {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener, global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor>(
						ref weak_implementor_SetOnFitSystemWindowsListener,
						__CreateIFitWindowsViewGroupOnFitSystemWindowsListenerImplementor,
						SetOnFitSystemWindowsListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListener, global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor>(
						ref weak_implementor_SetOnFitSystemWindowsListener,
						global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor.__IsEmpty,
						__v => SetOnFitSystemWindowsListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnFitSystemWindowsListener;

		global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor __CreateIFitWindowsViewGroupOnFitSystemWindowsListenerImplementor ()
		{
			return new global::Android.Support.V7.Internal.Widget.IFitWindowsViewGroupOnFitSystemWindowsListenerImplementor (this);
		}
#endregion
	}
}
