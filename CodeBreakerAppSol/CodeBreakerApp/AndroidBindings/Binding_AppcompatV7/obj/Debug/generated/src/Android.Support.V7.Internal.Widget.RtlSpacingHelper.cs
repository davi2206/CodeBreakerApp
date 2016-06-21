using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='RtlSpacingHelper']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/RtlSpacingHelper", DoNotGenerateAcw=true)]
	public partial class RtlSpacingHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='RtlSpacingHelper']/field[@name='UNDEFINED']"
		[Register ("UNDEFINED")]
		public const int Undefined = (int) -2147483648;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/RtlSpacingHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RtlSpacingHelper); }
		}

		protected RtlSpacingHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='RtlSpacingHelper']/constructor[@name='RtlSpacingHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RtlSpacingHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (RtlSpacingHelper)) {
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

		static Delegate cb_getEnd;
#pragma warning disable 0169
		static Delegate GetGetEndHandler ()
		{
			if (cb_getEnd == null)
				cb_getEnd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEnd);
			return cb_getEnd;
		}

		static int n_GetEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.RtlSpacingHelper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.RtlSpacingHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.End;
		}
#pragma warning restore 0169

		static IntPtr id_getEnd;
		public virtual unsafe int End {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='RtlSpacingHelper']/method[@name='getEnd' and count(parameter)=0]"
			[Register ("getEnd", "()I", "GetGetEndHandler")]
			get {
				if (id_getEnd == IntPtr.Zero)
					id_getEnd = JNIEnv.GetMethodID (class_ref, "getEnd", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getEnd);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnd", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLeft;
#pragma warning disable 0169
		static Delegate GetGetLeftHandler ()
		{
			if (cb_getLeft == null)
				cb_getLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLeft);
			return cb_getLeft;
		}

		static int n_GetLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.RtlSpacingHelper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.RtlSpacingHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Left;
		}
#pragma warning restore 0169

		static IntPtr id_getLeft;
		public virtual unsafe int Left {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='RtlSpacingHelper']/method[@name='getLeft' and count(parameter)=0]"
			[Register ("getLeft", "()I", "GetGetLeftHandler")]
			get {
				if (id_getLeft == IntPtr.Zero)
					id_getLeft = JNIEnv.GetMethodID (class_ref, "getLeft", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getLeft);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeft", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRight;
#pragma warning disable 0169
		static Delegate GetGetRightHandler ()
		{
			if (cb_getRight == null)
				cb_getRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRight);
			return cb_getRight;
		}

		static int n_GetRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.RtlSpacingHelper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.RtlSpacingHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Right;
		}
#pragma warning restore 0169

		static IntPtr id_getRight;
		public virtual unsafe int Right {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='RtlSpacingHelper']/method[@name='getRight' and count(parameter)=0]"
			[Register ("getRight", "()I", "GetGetRightHandler")]
			get {
				if (id_getRight == IntPtr.Zero)
					id_getRight = JNIEnv.GetMethodID (class_ref, "getRight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getRight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStart;
#pragma warning disable 0169
		static Delegate GetGetStartHandler ()
		{
			if (cb_getStart == null)
				cb_getStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStart);
			return cb_getStart;
		}

		static int n_GetStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.RtlSpacingHelper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.RtlSpacingHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Start;
		}
#pragma warning restore 0169

		static IntPtr id_getStart;
		public virtual unsafe int Start {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='RtlSpacingHelper']/method[@name='getStart' and count(parameter)=0]"
			[Register ("getStart", "()I", "GetGetStartHandler")]
			get {
				if (id_getStart == IntPtr.Zero)
					id_getStart = JNIEnv.GetMethodID (class_ref, "getStart", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getStart);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStart", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_setAbsolute_II;
#pragma warning disable 0169
		static Delegate GetSetAbsolute_IIHandler ()
		{
			if (cb_setAbsolute_II == null)
				cb_setAbsolute_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetAbsolute_II);
			return cb_setAbsolute_II;
		}

		static void n_SetAbsolute_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Internal.Widget.RtlSpacingHelper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.RtlSpacingHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAbsolute (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAbsolute_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='RtlSpacingHelper']/method[@name='setAbsolute' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setAbsolute", "(II)V", "GetSetAbsolute_IIHandler")]
		public virtual unsafe void SetAbsolute (int p0, int p1)
		{
			if (id_setAbsolute_II == IntPtr.Zero)
				id_setAbsolute_II = JNIEnv.GetMethodID (class_ref, "setAbsolute", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAbsolute_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAbsolute", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDirection_Z;
#pragma warning disable 0169
		static Delegate GetSetDirection_ZHandler ()
		{
			if (cb_setDirection_Z == null)
				cb_setDirection_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDirection_Z);
			return cb_setDirection_Z;
		}

		static void n_SetDirection_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.Widget.RtlSpacingHelper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.RtlSpacingHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDirection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDirection_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='RtlSpacingHelper']/method[@name='setDirection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDirection", "(Z)V", "GetSetDirection_ZHandler")]
		public virtual unsafe void SetDirection (bool p0)
		{
			if (id_setDirection_Z == IntPtr.Zero)
				id_setDirection_Z = JNIEnv.GetMethodID (class_ref, "setDirection", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDirection_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDirection", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRelative_II;
#pragma warning disable 0169
		static Delegate GetSetRelative_IIHandler ()
		{
			if (cb_setRelative_II == null)
				cb_setRelative_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetRelative_II);
			return cb_setRelative_II;
		}

		static void n_SetRelative_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Internal.Widget.RtlSpacingHelper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.RtlSpacingHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRelative (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRelative_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='RtlSpacingHelper']/method[@name='setRelative' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setRelative", "(II)V", "GetSetRelative_IIHandler")]
		public virtual unsafe void SetRelative (int p0, int p1)
		{
			if (id_setRelative_II == IntPtr.Zero)
				id_setRelative_II = JNIEnv.GetMethodID (class_ref, "setRelative", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRelative_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRelative", "(II)V"), __args);
			} finally {
			}
		}

	}
}
