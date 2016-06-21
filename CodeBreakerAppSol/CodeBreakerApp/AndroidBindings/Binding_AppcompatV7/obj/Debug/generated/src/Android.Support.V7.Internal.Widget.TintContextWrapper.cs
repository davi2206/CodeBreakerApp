using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintContextWrapper']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/TintContextWrapper", DoNotGenerateAcw=true)]
	public partial class TintContextWrapper : global::Android.Content.ContextWrapper {

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintContextWrapper.TintResources']"
		[global::Android.Runtime.Register ("android/support/v7/internal/widget/TintContextWrapper$TintResources", DoNotGenerateAcw=true)]
		public partial class TintResources : global::Android.Support.V7.Internal.Widget.ResourcesWrapper {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/internal/widget/TintContextWrapper$TintResources", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TintResources); }
			}

			protected TintResources (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_res_Resources_Landroid_support_v7_internal_widget_TintManager_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintContextWrapper.TintResources']/constructor[@name='TintContextWrapper.TintResources' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='android.support.v7.internal.widget.TintManager']]"
			[Register (".ctor", "(Landroid/content/res/Resources;Landroid/support/v7/internal/widget/TintManager;)V", "")]
			public unsafe TintResources (global::Android.Content.Res.Resources p0, global::Android.Support.V7.Internal.Widget.TintManager p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (TintResources)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/res/Resources;Landroid/support/v7/internal/widget/TintManager;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/res/Resources;Landroid/support/v7/internal/widget/TintManager;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_res_Resources_Landroid_support_v7_internal_widget_TintManager_ == IntPtr.Zero)
						id_ctor_Landroid_content_res_Resources_Landroid_support_v7_internal_widget_TintManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/res/Resources;Landroid/support/v7/internal/widget/TintManager;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_res_Resources_Landroid_support_v7_internal_widget_TintManager_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_res_Resources_Landroid_support_v7_internal_widget_TintManager_, __args);
				} finally {
				}
			}

			static Delegate cb_getDrawable_I;
#pragma warning disable 0169
			static Delegate GetGetDrawable_IHandler ()
			{
				if (cb_getDrawable_I == null)
					cb_getDrawable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDrawable_I);
				return cb_getDrawable_I;
			}

			static IntPtr n_GetDrawable_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Android.Support.V7.Internal.Widget.TintContextWrapper.TintResources __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintContextWrapper.TintResources> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetDrawable (p0));
			}
#pragma warning restore 0169

			static IntPtr id_getDrawable_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintContextWrapper.TintResources']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_IHandler")]
			public override unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (int p0)
			{
				if (id_getDrawable_I == IntPtr.Zero)
					id_getDrawable_I = JNIEnv.GetMethodID (class_ref, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDrawable_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/TintContextWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TintContextWrapper); }
		}

		protected TintContextWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_wrap_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintContextWrapper']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("wrap", "(Landroid/content/Context;)Landroid/content/Context;", "")]
		public static unsafe global::Android.Content.Context Wrap (global::Android.Content.Context p0)
		{
			if (id_wrap_Landroid_content_Context_ == IntPtr.Zero)
				id_wrap_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Landroid/content/Context;)Landroid/content/Context;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Context __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
