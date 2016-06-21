using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintInfo']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/TintInfo", DoNotGenerateAcw=true)]
	public partial class TintInfo : global::Java.Lang.Object {


		static IntPtr mHasTintList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintInfo']/field[@name='mHasTintList']"
		[Register ("mHasTintList")]
		public bool MHasTintList {
			get {
				if (mHasTintList_jfieldId == IntPtr.Zero)
					mHasTintList_jfieldId = JNIEnv.GetFieldID (class_ref, "mHasTintList", "Z");
				return JNIEnv.GetBooleanField (Handle, mHasTintList_jfieldId);
			}
			set {
				if (mHasTintList_jfieldId == IntPtr.Zero)
					mHasTintList_jfieldId = JNIEnv.GetFieldID (class_ref, "mHasTintList", "Z");
				try {
					JNIEnv.SetField (Handle, mHasTintList_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mHasTintMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintInfo']/field[@name='mHasTintMode']"
		[Register ("mHasTintMode")]
		public bool MHasTintMode {
			get {
				if (mHasTintMode_jfieldId == IntPtr.Zero)
					mHasTintMode_jfieldId = JNIEnv.GetFieldID (class_ref, "mHasTintMode", "Z");
				return JNIEnv.GetBooleanField (Handle, mHasTintMode_jfieldId);
			}
			set {
				if (mHasTintMode_jfieldId == IntPtr.Zero)
					mHasTintMode_jfieldId = JNIEnv.GetFieldID (class_ref, "mHasTintMode", "Z");
				try {
					JNIEnv.SetField (Handle, mHasTintMode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mTintList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintInfo']/field[@name='mTintList']"
		[Register ("mTintList")]
		public global::Android.Content.Res.ColorStateList MTintList {
			get {
				if (mTintList_jfieldId == IntPtr.Zero)
					mTintList_jfieldId = JNIEnv.GetFieldID (class_ref, "mTintList", "Landroid/content/res/ColorStateList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTintList_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTintList_jfieldId == IntPtr.Zero)
					mTintList_jfieldId = JNIEnv.GetFieldID (class_ref, "mTintList", "Landroid/content/res/ColorStateList;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mTintList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTintMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintInfo']/field[@name='mTintMode']"
		[Register ("mTintMode")]
		public global::Android.Graphics.PorterDuff.Mode MTintMode {
			get {
				if (mTintMode_jfieldId == IntPtr.Zero)
					mTintMode_jfieldId = JNIEnv.GetFieldID (class_ref, "mTintMode", "Landroid/graphics/PorterDuff$Mode;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTintMode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.PorterDuff.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTintMode_jfieldId == IntPtr.Zero)
					mTintMode_jfieldId = JNIEnv.GetFieldID (class_ref, "mTintMode", "Landroid/graphics/PorterDuff$Mode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mTintMode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/TintInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TintInfo); }
		}

		protected TintInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintInfo']/constructor[@name='TintInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TintInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TintInfo)) {
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

	}
}
