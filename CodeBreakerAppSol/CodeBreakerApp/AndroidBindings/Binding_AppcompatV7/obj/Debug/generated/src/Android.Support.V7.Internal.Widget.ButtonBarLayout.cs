using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ButtonBarLayout']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/ButtonBarLayout", DoNotGenerateAcw=true)]
	public partial class ButtonBarLayout : global::Android.Widget.LinearLayout {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/ButtonBarLayout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ButtonBarLayout); }
		}

		protected ButtonBarLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ButtonBarLayout']/constructor[@name='ButtonBarLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ButtonBarLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ButtonBarLayout)) {
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

		static Delegate cb_setAllowStacking_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowStacking_ZHandler ()
		{
			if (cb_setAllowStacking_Z == null)
				cb_setAllowStacking_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllowStacking_Z);
			return cb_setAllowStacking_Z;
		}

		static void n_SetAllowStacking_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.Widget.ButtonBarLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ButtonBarLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowStacking (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllowStacking_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ButtonBarLayout']/method[@name='setAllowStacking' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowStacking", "(Z)V", "GetSetAllowStacking_ZHandler")]
		public virtual unsafe void SetAllowStacking (bool p0)
		{
			if (id_setAllowStacking_Z == IntPtr.Zero)
				id_setAllowStacking_Z = JNIEnv.GetMethodID (class_ref, "setAllowStacking", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAllowStacking_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllowStacking", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
