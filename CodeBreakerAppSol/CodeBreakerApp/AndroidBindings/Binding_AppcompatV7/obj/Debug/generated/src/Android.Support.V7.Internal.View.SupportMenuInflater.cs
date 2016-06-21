using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportMenuInflater']"
	[global::Android.Runtime.Register ("android/support/v7/internal/view/SupportMenuInflater", DoNotGenerateAcw=true)]
	public partial class SupportMenuInflater : global::Android.Views.MenuInflater {

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportMenuInflater.InflatedOnMenuItemClickListener']"
		[global::Android.Runtime.Register ("android/support/v7/internal/view/SupportMenuInflater$InflatedOnMenuItemClickListener", DoNotGenerateAcw=true)]
		public partial class InflatedOnMenuItemClickListener : global::Java.Lang.Object, global::Android.Views.IMenuItemOnMenuItemClickListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/internal/view/SupportMenuInflater$InflatedOnMenuItemClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InflatedOnMenuItemClickListener); }
			}

			protected InflatedOnMenuItemClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportMenuInflater.InflatedOnMenuItemClickListener']/constructor[@name='SupportMenuInflater.InflatedOnMenuItemClickListener' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/String;)V", "")]
			public unsafe InflatedOnMenuItemClickListener (global::Java.Lang.Object p0, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (InflatedOnMenuItemClickListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Object;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_onMenuItemClick_Landroid_view_MenuItem_;
#pragma warning disable 0169
			static Delegate GetOnMenuItemClick_Landroid_view_MenuItem_Handler ()
			{
				if (cb_onMenuItemClick_Landroid_view_MenuItem_ == null)
					cb_onMenuItemClick_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMenuItemClick_Landroid_view_MenuItem_);
				return cb_onMenuItemClick_Landroid_view_MenuItem_;
			}

			static bool n_OnMenuItemClick_Landroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.Internal.View.SupportMenuInflater.InflatedOnMenuItemClickListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.SupportMenuInflater.InflatedOnMenuItemClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IMenuItem p0 = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMenuItemClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onMenuItemClick_Landroid_view_MenuItem_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportMenuInflater.InflatedOnMenuItemClickListener']/method[@name='onMenuItemClick' and count(parameter)=1 and parameter[1][@type='android.view.MenuItem']]"
			[Register ("onMenuItemClick", "(Landroid/view/MenuItem;)Z", "GetOnMenuItemClick_Landroid_view_MenuItem_Handler")]
			public virtual unsafe bool OnMenuItemClick (global::Android.Views.IMenuItem p0)
			{
				if (id_onMenuItemClick_Landroid_view_MenuItem_ == IntPtr.Zero)
					id_onMenuItemClick_Landroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemClick", "(Landroid/view/MenuItem;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_onMenuItemClick_Landroid_view_MenuItem_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMenuItemClick", "(Landroid/view/MenuItem;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/view/SupportMenuInflater", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SupportMenuInflater); }
		}

		protected SupportMenuInflater (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='SupportMenuInflater']/constructor[@name='SupportMenuInflater' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SupportMenuInflater (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SupportMenuInflater)) {
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

	}
}
