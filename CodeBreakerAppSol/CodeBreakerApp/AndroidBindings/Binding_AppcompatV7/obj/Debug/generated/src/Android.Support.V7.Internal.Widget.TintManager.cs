using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintManager']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/TintManager", DoNotGenerateAcw=true)]
	public sealed partial class TintManager : global::Java.Lang.Object {


		static IntPtr SHOULD_BE_USED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintManager']/field[@name='SHOULD_BE_USED']"
		[Register ("SHOULD_BE_USED")]
		public static bool ShouldBeUsed {
			get {
				if (SHOULD_BE_USED_jfieldId == IntPtr.Zero)
					SHOULD_BE_USED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHOULD_BE_USED", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, SHOULD_BE_USED_jfieldId);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/TintManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TintManager); }
		}

		internal TintManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_get_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintManager']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("get", "(Landroid/content/Context;)Landroid/support/v7/internal/widget/TintManager;", "")]
		public static unsafe global::Android.Support.V7.Internal.Widget.TintManager Get (global::Android.Content.Context p0)
		{
			if (id_get_Landroid_content_Context_ == IntPtr.Zero)
				id_get_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Landroid/content/Context;)Landroid/support/v7/internal/widget/TintManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Support.V7.Internal.Widget.TintManager __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDrawable_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintManager']/method[@name='getDrawable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getDrawable", "(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (global::Android.Content.Context p0, int p1)
		{
			if (id_getDrawable_Landroid_content_Context_I == IntPtr.Zero)
				id_getDrawable_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "getDrawable", "(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDrawable_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDrawable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintManager']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", "")]
		public unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (int p0)
		{
			if (id_getDrawable_I == IntPtr.Zero)
				id_getDrawable_I = JNIEnv.GetMethodID (class_ref, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDrawable_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getDrawable_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintManager']/method[@name='getDrawable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("getDrawable", "(IZ)Landroid/graphics/drawable/Drawable;", "")]
		public unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (int p0, bool p1)
		{
			if (id_getDrawable_IZ == IntPtr.Zero)
				id_getDrawable_IZ = JNIEnv.GetMethodID (class_ref, "getDrawable", "(IZ)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDrawable_IZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getTintList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintManager']/method[@name='getTintList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTintList", "(I)Landroid/content/res/ColorStateList;", "")]
		public unsafe global::Android.Content.Res.ColorStateList GetTintList (int p0)
		{
			if (id_getTintList_I == IntPtr.Zero)
				id_getTintList_I = JNIEnv.GetMethodID (class_ref, "getTintList", "(I)Landroid/content/res/ColorStateList;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (JNIEnv.CallObjectMethod  (Handle, id_getTintList_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_tintDrawable_Landroid_graphics_drawable_Drawable_Landroid_support_v7_internal_widget_TintInfo_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintManager']/method[@name='tintDrawable' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.support.v7.internal.widget.TintInfo'] and parameter[3][@type='int[]']]"
		[Register ("tintDrawable", "(Landroid/graphics/drawable/Drawable;Landroid/support/v7/internal/widget/TintInfo;[I)V", "")]
		public static unsafe void TintDrawable (global::Android.Graphics.Drawables.Drawable p0, global::Android.Support.V7.Internal.Widget.TintInfo p1, int[] p2)
		{
			if (id_tintDrawable_Landroid_graphics_drawable_Drawable_Landroid_support_v7_internal_widget_TintInfo_arrayI == IntPtr.Zero)
				id_tintDrawable_Landroid_graphics_drawable_Drawable_Landroid_support_v7_internal_widget_TintInfo_arrayI = JNIEnv.GetStaticMethodID (class_ref, "tintDrawable", "(Landroid/graphics/drawable/Drawable;Landroid/support/v7/internal/widget/TintInfo;[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_tintDrawable_Landroid_graphics_drawable_Drawable_Landroid_support_v7_internal_widget_TintInfo_arrayI, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_tintDrawableUsingColorFilter_ILandroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintManager']/method[@name='tintDrawableUsingColorFilter' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("tintDrawableUsingColorFilter", "(ILandroid/graphics/drawable/Drawable;)Z", "")]
		public unsafe bool TintDrawableUsingColorFilter (int p0, global::Android.Graphics.Drawables.Drawable p1)
		{
			if (id_tintDrawableUsingColorFilter_ILandroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_tintDrawableUsingColorFilter_ILandroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "tintDrawableUsingColorFilter", "(ILandroid/graphics/drawable/Drawable;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_tintDrawableUsingColorFilter_ILandroid_graphics_drawable_Drawable_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
