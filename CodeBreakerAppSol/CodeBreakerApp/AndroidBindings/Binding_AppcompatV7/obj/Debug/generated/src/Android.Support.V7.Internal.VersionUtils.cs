using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal']/class[@name='VersionUtils']"
	[global::Android.Runtime.Register ("android/support/v7/internal/VersionUtils", DoNotGenerateAcw=true)]
	public partial class VersionUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/VersionUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VersionUtils); }
		}

		protected VersionUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isAtLeastL;
		public static unsafe bool IsAtLeastL {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal']/class[@name='VersionUtils']/method[@name='isAtLeastL' and count(parameter)=0]"
			[Register ("isAtLeastL", "()Z", "GetIsAtLeastLHandler")]
			get {
				if (id_isAtLeastL == IntPtr.Zero)
					id_isAtLeastL = JNIEnv.GetStaticMethodID (class_ref, "isAtLeastL", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAtLeastL);
				} finally {
				}
			}
		}

	}
}
