using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='DrawableUtils']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/DrawableUtils", DoNotGenerateAcw=true)]
	public partial class DrawableUtils : global::Java.Lang.Object {


		static IntPtr INSETS_NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='DrawableUtils']/field[@name='INSETS_NONE']"
		[Register ("INSETS_NONE")]
		public static global::Android.Graphics.Rect InsetsNone {
			get {
				if (INSETS_NONE_jfieldId == IntPtr.Zero)
					INSETS_NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSETS_NONE", "Landroid/graphics/Rect;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSETS_NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/DrawableUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableUtils); }
		}

		protected DrawableUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getOpticalBounds_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='DrawableUtils']/method[@name='getOpticalBounds' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("getOpticalBounds", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/Rect;", "")]
		public static unsafe global::Android.Graphics.Rect GetOpticalBounds (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_getOpticalBounds_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_getOpticalBounds_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetStaticMethodID (class_ref, "getOpticalBounds", "(Landroid/graphics/drawable/Drawable;)Landroid/graphics/Rect;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Rect __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOpticalBounds_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
