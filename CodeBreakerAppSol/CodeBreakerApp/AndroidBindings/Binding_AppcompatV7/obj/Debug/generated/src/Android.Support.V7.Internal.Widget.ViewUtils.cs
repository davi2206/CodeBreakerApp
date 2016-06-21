using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewUtils']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/ViewUtils", DoNotGenerateAcw=true)]
	public partial class ViewUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/ViewUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewUtils); }
		}

		protected ViewUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_combineMeasuredStates_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewUtils']/method[@name='combineMeasuredStates' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("combineMeasuredStates", "(II)I", "")]
		public static unsafe int CombineMeasuredStates (int p0, int p1)
		{
			if (id_combineMeasuredStates_II == IntPtr.Zero)
				id_combineMeasuredStates_II = JNIEnv.GetStaticMethodID (class_ref, "combineMeasuredStates", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_combineMeasuredStates_II, __args);
			} finally {
			}
		}

		static IntPtr id_computeFitSystemWindows_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewUtils']/method[@name='computeFitSystemWindows' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.Rect'] and parameter[3][@type='android.graphics.Rect']]"
		[Register ("computeFitSystemWindows", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Rect;)V", "")]
		public static unsafe void ComputeFitSystemWindows (global::Android.Views.View p0, global::Android.Graphics.Rect p1, global::Android.Graphics.Rect p2)
		{
			if (id_computeFitSystemWindows_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_computeFitSystemWindows_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Rect_ = JNIEnv.GetStaticMethodID (class_ref, "computeFitSystemWindows", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Rect;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_computeFitSystemWindows_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Rect_, __args);
			} finally {
			}
		}

		static IntPtr id_isLayoutRtl_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewUtils']/method[@name='isLayoutRtl' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("isLayoutRtl", "(Landroid/view/View;)Z", "")]
		public static unsafe bool IsLayoutRtl (global::Android.Views.View p0)
		{
			if (id_isLayoutRtl_Landroid_view_View_ == IntPtr.Zero)
				id_isLayoutRtl_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "isLayoutRtl", "(Landroid/view/View;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLayoutRtl_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeOptionalFitsSystemWindows_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewUtils']/method[@name='makeOptionalFitsSystemWindows' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("makeOptionalFitsSystemWindows", "(Landroid/view/View;)V", "")]
		public static unsafe void MakeOptionalFitsSystemWindows (global::Android.Views.View p0)
		{
			if (id_makeOptionalFitsSystemWindows_Landroid_view_View_ == IntPtr.Zero)
				id_makeOptionalFitsSystemWindows_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "makeOptionalFitsSystemWindows", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_makeOptionalFitsSystemWindows_Landroid_view_View_, __args);
			} finally {
			}
		}

	}
}
