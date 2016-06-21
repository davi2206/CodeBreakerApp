using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ContextThemeWrapper']"
	[global::Android.Runtime.Register ("android/support/v7/internal/view/ContextThemeWrapper", DoNotGenerateAcw=true)]
	public partial class ContextThemeWrapper : global::Android.Content.ContextWrapper {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/view/ContextThemeWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContextThemeWrapper); }
		}

		protected ContextThemeWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ContextThemeWrapper']/constructor[@name='ContextThemeWrapper' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe ContextThemeWrapper (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ContextThemeWrapper)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Theme_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ContextThemeWrapper']/constructor[@name='ContextThemeWrapper' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.res.Resources.Theme']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/content/res/Resources$Theme;)V", "")]
		public unsafe ContextThemeWrapper (global::Android.Content.Context p0, global::Android.Content.Res.Resources.Theme p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ContextThemeWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/content/res/Resources$Theme;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/content/res/Resources$Theme;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Theme_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Theme_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/content/res/Resources$Theme;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Theme_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Theme_, __args);
			} finally {
			}
		}

		static Delegate cb_getThemeResId;
#pragma warning disable 0169
		static Delegate GetGetThemeResIdHandler ()
		{
			if (cb_getThemeResId == null)
				cb_getThemeResId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetThemeResId);
			return cb_getThemeResId;
		}

		static int n_GetThemeResId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.ContextThemeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.ContextThemeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThemeResId;
		}
#pragma warning restore 0169

		static IntPtr id_getThemeResId;
		public virtual unsafe int ThemeResId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ContextThemeWrapper']/method[@name='getThemeResId' and count(parameter)=0]"
			[Register ("getThemeResId", "()I", "GetGetThemeResIdHandler")]
			get {
				if (id_getThemeResId == IntPtr.Zero)
					id_getThemeResId = JNIEnv.GetMethodID (class_ref, "getThemeResId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getThemeResId);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThemeResId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_onApplyThemeResource_Landroid_content_res_Resources_Theme_IZ;
#pragma warning disable 0169
		static Delegate GetOnApplyThemeResource_Landroid_content_res_Resources_Theme_IZHandler ()
		{
			if (cb_onApplyThemeResource_Landroid_content_res_Resources_Theme_IZ == null)
				cb_onApplyThemeResource_Landroid_content_res_Resources_Theme_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_OnApplyThemeResource_Landroid_content_res_Resources_Theme_IZ);
			return cb_onApplyThemeResource_Landroid_content_res_Resources_Theme_IZ;
		}

		static void n_OnApplyThemeResource_Landroid_content_res_Resources_Theme_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Android.Support.V7.Internal.View.ContextThemeWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.ContextThemeWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Resources.Theme p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnApplyThemeResource (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onApplyThemeResource_Landroid_content_res_Resources_Theme_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ContextThemeWrapper']/method[@name='onApplyThemeResource' and count(parameter)=3 and parameter[1][@type='android.content.res.Resources.Theme'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V", "GetOnApplyThemeResource_Landroid_content_res_Resources_Theme_IZHandler")]
		protected virtual unsafe void OnApplyThemeResource (global::Android.Content.Res.Resources.Theme p0, int p1, bool p2)
		{
			if (id_onApplyThemeResource_Landroid_content_res_Resources_Theme_IZ == IntPtr.Zero)
				id_onApplyThemeResource_Landroid_content_res_Resources_Theme_IZ = JNIEnv.GetMethodID (class_ref, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onApplyThemeResource_Landroid_content_res_Resources_Theme_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V"), __args);
			} finally {
			}
		}

	}
}
