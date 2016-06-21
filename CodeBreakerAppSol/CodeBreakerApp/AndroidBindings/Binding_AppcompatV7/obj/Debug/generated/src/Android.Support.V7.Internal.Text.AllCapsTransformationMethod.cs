using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Text {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.text']/class[@name='AllCapsTransformationMethod']"
	[global::Android.Runtime.Register ("android/support/v7/internal/text/AllCapsTransformationMethod", DoNotGenerateAcw=true)]
	public partial class AllCapsTransformationMethod : global::Java.Lang.Object, global::Android.Text.Method.ITransformationMethod {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/text/AllCapsTransformationMethod", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AllCapsTransformationMethod); }
		}

		protected AllCapsTransformationMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.text']/class[@name='AllCapsTransformationMethod']/constructor[@name='AllCapsTransformationMethod' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AllCapsTransformationMethod (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AllCapsTransformationMethod)) {
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

		static Delegate cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetTransformation_Ljava_lang_CharSequence_Landroid_view_View_Handler ()
		{
			if (cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_ == null)
				cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTransformation_Ljava_lang_CharSequence_Landroid_view_View_);
			return cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_;
		}

		static IntPtr n_GetTransformation_Ljava_lang_CharSequence_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.Text.AllCapsTransformationMethod __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Text.AllCapsTransformationMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = CharSequence.ToLocalJniHandle (__this.GetTransformationFormatted (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.text']/class[@name='AllCapsTransformationMethod']/method[@name='getTransformation' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='android.view.View']]"
		[Register ("getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", "GetGetTransformation_Ljava_lang_CharSequence_Landroid_view_View_Handler")]
		public virtual unsafe global::Java.Lang.ICharSequence GetTransformationFormatted (global::Java.Lang.ICharSequence p0, global::Android.Views.View p1)
		{
			if (id_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_ == IntPtr.Zero)
				id_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.ICharSequence __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public string GetTransformation (string p0, global::Android.Views.View p1)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			global::Java.Lang.ICharSequence __result = GetTransformationFormatted (jls_p0, p1);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result == null ? null : __result.ToString ();
		}

		static Delegate cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetOnFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_Handler ()
		{
			if (cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ == null)
				cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool, int, IntPtr>) n_OnFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_);
			return cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_;
		}

		static void n_OnFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, int native_p3, IntPtr native_p4)
		{
			global::Android.Support.V7.Internal.Text.AllCapsTransformationMethod __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Text.AllCapsTransformationMethod> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.FocusSearchDirection p3 = (global::Android.Views.FocusSearchDirection) native_p3;
			global::Android.Graphics.Rect p4 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnFocusChanged (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.text']/class[@name='AllCapsTransformationMethod']/method[@name='onFocusChanged' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.Rect']]"
		[Register ("onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", "GetOnFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_Handler")]
		public virtual unsafe void OnFocusChanged (global::Android.Views.View p0, global::Java.Lang.ICharSequence p1, bool p2, [global::Android.Runtime.GeneratedEnum] global::Android.Views.FocusSearchDirection p3, global::Android.Graphics.Rect p4)
		{
			if (id_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ == IntPtr.Zero)
				id_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V");
			IntPtr native_p1 = CharSequence.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue ((int) p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		public void OnFocusChanged (global::Android.Views.View p0, string p1, bool p2, [global::Android.Runtime.GeneratedEnum] global::Android.Views.FocusSearchDirection p3, global::Android.Graphics.Rect p4)
		{
			global::Java.Lang.String jls_p1 = p1 == null ? null : new global::Java.Lang.String (p1);
			OnFocusChanged (p0, jls_p1, p2, p3, p4);
			if (jls_p1 != null) jls_p1.Dispose ();
		}

	}
}
