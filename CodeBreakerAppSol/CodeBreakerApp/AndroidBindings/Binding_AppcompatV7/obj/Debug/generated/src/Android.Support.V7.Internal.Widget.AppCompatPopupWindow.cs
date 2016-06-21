using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='AppCompatPopupWindow']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/AppCompatPopupWindow", DoNotGenerateAcw=true)]
	public partial class AppCompatPopupWindow : global::Android.Widget.PopupWindow {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/AppCompatPopupWindow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppCompatPopupWindow); }
		}

		protected AppCompatPopupWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='AppCompatPopupWindow']/constructor[@name='AppCompatPopupWindow' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AppCompatPopupWindow (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (AppCompatPopupWindow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static Delegate cb_getSupportOverlapAnchor;
#pragma warning disable 0169
		static Delegate GetGetSupportOverlapAnchorHandler ()
		{
			if (cb_getSupportOverlapAnchor == null)
				cb_getSupportOverlapAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSupportOverlapAnchor);
			return cb_getSupportOverlapAnchor;
		}

		static bool n_GetSupportOverlapAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.AppCompatPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.AppCompatPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SupportOverlapAnchor;
		}
#pragma warning restore 0169

		static Delegate cb_setSupportOverlapAnchor_Z;
#pragma warning disable 0169
		static Delegate GetSetSupportOverlapAnchor_ZHandler ()
		{
			if (cb_setSupportOverlapAnchor_Z == null)
				cb_setSupportOverlapAnchor_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSupportOverlapAnchor_Z);
			return cb_setSupportOverlapAnchor_Z;
		}

		static void n_SetSupportOverlapAnchor_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.Widget.AppCompatPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.AppCompatPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SupportOverlapAnchor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSupportOverlapAnchor;
		static IntPtr id_setSupportOverlapAnchor_Z;
		public virtual unsafe bool SupportOverlapAnchor {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='AppCompatPopupWindow']/method[@name='getSupportOverlapAnchor' and count(parameter)=0]"
			[Register ("getSupportOverlapAnchor", "()Z", "GetGetSupportOverlapAnchorHandler")]
			get {
				if (id_getSupportOverlapAnchor == IntPtr.Zero)
					id_getSupportOverlapAnchor = JNIEnv.GetMethodID (class_ref, "getSupportOverlapAnchor", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getSupportOverlapAnchor);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportOverlapAnchor", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='AppCompatPopupWindow']/method[@name='setSupportOverlapAnchor' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSupportOverlapAnchor", "(Z)V", "GetSetSupportOverlapAnchor_ZHandler")]
			set {
				if (id_setSupportOverlapAnchor_Z == IntPtr.Zero)
					id_setSupportOverlapAnchor_Z = JNIEnv.GetMethodID (class_ref, "setSupportOverlapAnchor", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSupportOverlapAnchor_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSupportOverlapAnchor", "(Z)V"), __args);
				} finally {
				}
			}
		}

	}
}
