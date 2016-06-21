using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ThemeUtils']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/ThemeUtils", DoNotGenerateAcw=true)]
	public partial class ThemeUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/ThemeUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThemeUtils); }
		}

		protected ThemeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ThemeUtils']/constructor[@name='ThemeUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThemeUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ThemeUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_createDisabledStateList_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ThemeUtils']/method[@name='createDisabledStateList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createDisabledStateList", "(II)Landroid/content/res/ColorStateList;", "")]
		public static unsafe global::Android.Content.Res.ColorStateList CreateDisabledStateList (int p0, int p1)
		{
			if (id_createDisabledStateList_II == IntPtr.Zero)
				id_createDisabledStateList_II = JNIEnv.GetStaticMethodID (class_ref, "createDisabledStateList", "(II)Landroid/content/res/ColorStateList;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDisabledStateList_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getDisabledThemeAttrColor_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ThemeUtils']/method[@name='getDisabledThemeAttrColor' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getDisabledThemeAttrColor", "(Landroid/content/Context;I)I", "")]
		public static unsafe int GetDisabledThemeAttrColor (global::Android.Content.Context p0, int p1)
		{
			if (id_getDisabledThemeAttrColor_Landroid_content_Context_I == IntPtr.Zero)
				id_getDisabledThemeAttrColor_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "getDisabledThemeAttrColor", "(Landroid/content/Context;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getDisabledThemeAttrColor_Landroid_content_Context_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getThemeAttrColor_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ThemeUtils']/method[@name='getThemeAttrColor' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getThemeAttrColor", "(Landroid/content/Context;I)I", "")]
		public static unsafe int GetThemeAttrColor (global::Android.Content.Context p0, int p1)
		{
			if (id_getThemeAttrColor_Landroid_content_Context_I == IntPtr.Zero)
				id_getThemeAttrColor_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "getThemeAttrColor", "(Landroid/content/Context;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getThemeAttrColor_Landroid_content_Context_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getThemeAttrColorStateList_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ThemeUtils']/method[@name='getThemeAttrColorStateList' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getThemeAttrColorStateList", "(Landroid/content/Context;I)Landroid/content/res/ColorStateList;", "")]
		public static unsafe global::Android.Content.Res.ColorStateList GetThemeAttrColorStateList (global::Android.Content.Context p0, int p1)
		{
			if (id_getThemeAttrColorStateList_Landroid_content_Context_I == IntPtr.Zero)
				id_getThemeAttrColorStateList_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "getThemeAttrColorStateList", "(Landroid/content/Context;I)Landroid/content/res/ColorStateList;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Content.Res.ColorStateList __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getThemeAttrColorStateList_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
