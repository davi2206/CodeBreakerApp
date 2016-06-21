using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Graphics.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableUtils']"
	[global::Android.Runtime.Register ("android/support/v7/graphics/drawable/DrawableUtils", DoNotGenerateAcw=true)]
	public partial class DrawableUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/graphics/drawable/DrawableUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableUtils); }
		}

		protected DrawableUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableUtils']/constructor[@name='DrawableUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrawableUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DrawableUtils)) {
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

		static IntPtr id_parseTintMode_ILandroid_graphics_PorterDuff_Mode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableUtils']/method[@name='parseTintMode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.PorterDuff.Mode']]"
		[Register ("parseTintMode", "(ILandroid/graphics/PorterDuff$Mode;)Landroid/graphics/PorterDuff$Mode;", "")]
		public static unsafe global::Android.Graphics.PorterDuff.Mode ParseTintMode (int p0, global::Android.Graphics.PorterDuff.Mode p1)
		{
			if (id_parseTintMode_ILandroid_graphics_PorterDuff_Mode_ == IntPtr.Zero)
				id_parseTintMode_ILandroid_graphics_PorterDuff_Mode_ = JNIEnv.GetStaticMethodID (class_ref, "parseTintMode", "(ILandroid/graphics/PorterDuff$Mode;)Landroid/graphics/PorterDuff$Mode;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.PorterDuff.Mode __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.PorterDuff.Mode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseTintMode_ILandroid_graphics_PorterDuff_Mode_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
