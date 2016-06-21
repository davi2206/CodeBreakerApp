using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']"
	[global::Android.Runtime.Register ("android/support/v7/widget/SwitchCompat", DoNotGenerateAcw=true)]
	public partial class SwitchCompat : global::Android.Widget.CompoundButton {

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat.ThumbAnimation']"
		[global::Android.Runtime.Register ("android/support/v7/widget/SwitchCompat$ThumbAnimation", DoNotGenerateAcw=true)]
		public partial class ThumbAnimation : global::Android.Views.Animations.Animation {

			protected ThumbAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/widget/SwitchCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwitchCompat); }
		}

		protected SwitchCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/constructor[@name='SwitchCompat' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SwitchCompat (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SwitchCompat)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/constructor[@name='SwitchCompat' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SwitchCompat (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SwitchCompat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/constructor[@name='SwitchCompat' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SwitchCompat (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (SwitchCompat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static Delegate cb_getShowText;
#pragma warning disable 0169
		static Delegate GetGetShowTextHandler ()
		{
			if (cb_getShowText == null)
				cb_getShowText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetShowText);
			return cb_getShowText;
		}

		static bool n_GetShowText (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowText;
		}
#pragma warning restore 0169

		static Delegate cb_setShowText_Z;
#pragma warning disable 0169
		static Delegate GetSetShowText_ZHandler ()
		{
			if (cb_setShowText_Z == null)
				cb_setShowText_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowText_Z);
			return cb_setShowText_Z;
		}

		static void n_SetShowText_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShowText;
		static IntPtr id_setShowText_Z;
		public virtual unsafe bool ShowText {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='getShowText' and count(parameter)=0]"
			[Register ("getShowText", "()Z", "GetGetShowTextHandler")]
			get {
				if (id_getShowText == IntPtr.Zero)
					id_getShowText = JNIEnv.GetMethodID (class_ref, "getShowText", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getShowText);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShowText", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setShowText' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowText", "(Z)V", "GetSetShowText_ZHandler")]
			set {
				if (id_setShowText_Z == IntPtr.Zero)
					id_setShowText_Z = JNIEnv.GetMethodID (class_ref, "setShowText", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setShowText_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowText", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSplitTrack;
#pragma warning disable 0169
		static Delegate GetGetSplitTrackHandler ()
		{
			if (cb_getSplitTrack == null)
				cb_getSplitTrack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSplitTrack);
			return cb_getSplitTrack;
		}

		static bool n_GetSplitTrack (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SplitTrack;
		}
#pragma warning restore 0169

		static Delegate cb_setSplitTrack_Z;
#pragma warning disable 0169
		static Delegate GetSetSplitTrack_ZHandler ()
		{
			if (cb_setSplitTrack_Z == null)
				cb_setSplitTrack_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSplitTrack_Z);
			return cb_setSplitTrack_Z;
		}

		static void n_SetSplitTrack_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SplitTrack = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSplitTrack;
		static IntPtr id_setSplitTrack_Z;
		public virtual unsafe bool SplitTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='getSplitTrack' and count(parameter)=0]"
			[Register ("getSplitTrack", "()Z", "GetGetSplitTrackHandler")]
			get {
				if (id_getSplitTrack == IntPtr.Zero)
					id_getSplitTrack = JNIEnv.GetMethodID (class_ref, "getSplitTrack", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getSplitTrack);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSplitTrack", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setSplitTrack' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSplitTrack", "(Z)V", "GetSetSplitTrack_ZHandler")]
			set {
				if (id_setSplitTrack_Z == IntPtr.Zero)
					id_setSplitTrack_Z = JNIEnv.GetMethodID (class_ref, "setSplitTrack", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSplitTrack_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSplitTrack", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSwitchMinWidth;
#pragma warning disable 0169
		static Delegate GetGetSwitchMinWidthHandler ()
		{
			if (cb_getSwitchMinWidth == null)
				cb_getSwitchMinWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSwitchMinWidth);
			return cb_getSwitchMinWidth;
		}

		static int n_GetSwitchMinWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SwitchMinWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setSwitchMinWidth_I;
#pragma warning disable 0169
		static Delegate GetSetSwitchMinWidth_IHandler ()
		{
			if (cb_setSwitchMinWidth_I == null)
				cb_setSwitchMinWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSwitchMinWidth_I);
			return cb_setSwitchMinWidth_I;
		}

		static void n_SetSwitchMinWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwitchMinWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSwitchMinWidth;
		static IntPtr id_setSwitchMinWidth_I;
		public virtual unsafe int SwitchMinWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='getSwitchMinWidth' and count(parameter)=0]"
			[Register ("getSwitchMinWidth", "()I", "GetGetSwitchMinWidthHandler")]
			get {
				if (id_getSwitchMinWidth == IntPtr.Zero)
					id_getSwitchMinWidth = JNIEnv.GetMethodID (class_ref, "getSwitchMinWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSwitchMinWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSwitchMinWidth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setSwitchMinWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSwitchMinWidth", "(I)V", "GetSetSwitchMinWidth_IHandler")]
			set {
				if (id_setSwitchMinWidth_I == IntPtr.Zero)
					id_setSwitchMinWidth_I = JNIEnv.GetMethodID (class_ref, "setSwitchMinWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSwitchMinWidth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSwitchMinWidth", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSwitchPadding;
#pragma warning disable 0169
		static Delegate GetGetSwitchPaddingHandler ()
		{
			if (cb_getSwitchPadding == null)
				cb_getSwitchPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSwitchPadding);
			return cb_getSwitchPadding;
		}

		static int n_GetSwitchPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SwitchPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setSwitchPadding_I;
#pragma warning disable 0169
		static Delegate GetSetSwitchPadding_IHandler ()
		{
			if (cb_setSwitchPadding_I == null)
				cb_setSwitchPadding_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSwitchPadding_I);
			return cb_setSwitchPadding_I;
		}

		static void n_SetSwitchPadding_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwitchPadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSwitchPadding;
		static IntPtr id_setSwitchPadding_I;
		public virtual unsafe int SwitchPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='getSwitchPadding' and count(parameter)=0]"
			[Register ("getSwitchPadding", "()I", "GetGetSwitchPaddingHandler")]
			get {
				if (id_getSwitchPadding == IntPtr.Zero)
					id_getSwitchPadding = JNIEnv.GetMethodID (class_ref, "getSwitchPadding", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSwitchPadding);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSwitchPadding", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setSwitchPadding' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSwitchPadding", "(I)V", "GetSetSwitchPadding_IHandler")]
			set {
				if (id_setSwitchPadding_I == IntPtr.Zero)
					id_setSwitchPadding_I = JNIEnv.GetMethodID (class_ref, "setSwitchPadding", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSwitchPadding_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSwitchPadding", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextOff;
#pragma warning disable 0169
		static Delegate GetGetTextOffHandler ()
		{
			if (cb_getTextOff == null)
				cb_getTextOff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextOff);
			return cb_getTextOff;
		}

		static IntPtr n_GetTextOff (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TextOffFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setTextOff_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTextOff_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTextOff_Ljava_lang_CharSequence_ == null)
				cb_setTextOff_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextOff_Ljava_lang_CharSequence_);
			return cb_setTextOff_Ljava_lang_CharSequence_;
		}

		static void n_SetTextOff_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TextOffFormatted = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextOff;
		static IntPtr id_setTextOff_Ljava_lang_CharSequence_;
		public virtual unsafe global::Java.Lang.ICharSequence TextOffFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='getTextOff' and count(parameter)=0]"
			[Register ("getTextOff", "()Ljava/lang/CharSequence;", "GetGetTextOffHandler")]
			get {
				if (id_getTextOff == IntPtr.Zero)
					id_getTextOff = JNIEnv.GetMethodID (class_ref, "getTextOff", "()Ljava/lang/CharSequence;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getTextOff), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextOff", "()Ljava/lang/CharSequence;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setTextOff' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setTextOff", "(Ljava/lang/CharSequence;)V", "GetSetTextOff_Ljava_lang_CharSequence_Handler")]
			set {
				if (id_setTextOff_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setTextOff_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTextOff", "(Ljava/lang/CharSequence;)V");
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTextOff_Ljava_lang_CharSequence_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextOff", "(Ljava/lang/CharSequence;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public string TextOff {
			get { return TextOffFormatted == null ? null : TextOffFormatted.ToString (); }
			set {
				global::Java.Lang.String jls = value == null ? null : new global::Java.Lang.String (value);
				TextOffFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_getTextOn;
#pragma warning disable 0169
		static Delegate GetGetTextOnHandler ()
		{
			if (cb_getTextOn == null)
				cb_getTextOn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextOn);
			return cb_getTextOn;
		}

		static IntPtr n_GetTextOn (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TextOnFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setTextOn_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTextOn_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTextOn_Ljava_lang_CharSequence_ == null)
				cb_setTextOn_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextOn_Ljava_lang_CharSequence_);
			return cb_setTextOn_Ljava_lang_CharSequence_;
		}

		static void n_SetTextOn_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TextOnFormatted = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextOn;
		static IntPtr id_setTextOn_Ljava_lang_CharSequence_;
		public virtual unsafe global::Java.Lang.ICharSequence TextOnFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='getTextOn' and count(parameter)=0]"
			[Register ("getTextOn", "()Ljava/lang/CharSequence;", "GetGetTextOnHandler")]
			get {
				if (id_getTextOn == IntPtr.Zero)
					id_getTextOn = JNIEnv.GetMethodID (class_ref, "getTextOn", "()Ljava/lang/CharSequence;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getTextOn), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextOn", "()Ljava/lang/CharSequence;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setTextOn' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setTextOn", "(Ljava/lang/CharSequence;)V", "GetSetTextOn_Ljava_lang_CharSequence_Handler")]
			set {
				if (id_setTextOn_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setTextOn_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTextOn", "(Ljava/lang/CharSequence;)V");
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTextOn_Ljava_lang_CharSequence_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextOn", "(Ljava/lang/CharSequence;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public string TextOn {
			get { return TextOnFormatted == null ? null : TextOnFormatted.ToString (); }
			set {
				global::Java.Lang.String jls = value == null ? null : new global::Java.Lang.String (value);
				TextOnFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_getThumbDrawable;
#pragma warning disable 0169
		static Delegate GetGetThumbDrawableHandler ()
		{
			if (cb_getThumbDrawable == null)
				cb_getThumbDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThumbDrawable);
			return cb_getThumbDrawable;
		}

		static IntPtr n_GetThumbDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThumbDrawable);
		}
#pragma warning restore 0169

		static Delegate cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetThumbDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetThumbDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetThumbDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ThumbDrawable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getThumbDrawable;
		static IntPtr id_setThumbDrawable_Landroid_graphics_drawable_Drawable_;
		public virtual unsafe global::Android.Graphics.Drawables.Drawable ThumbDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='getThumbDrawable' and count(parameter)=0]"
			[Register ("getThumbDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetThumbDrawableHandler")]
			get {
				if (id_getThumbDrawable == IntPtr.Zero)
					id_getThumbDrawable = JNIEnv.GetMethodID (class_ref, "getThumbDrawable", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getThumbDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThumbDrawable", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setThumbDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setThumbDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetThumbDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				if (id_setThumbDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setThumbDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setThumbDrawable", "(Landroid/graphics/drawable/Drawable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setThumbDrawable_Landroid_graphics_drawable_Drawable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThumbDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getThumbTextPadding;
#pragma warning disable 0169
		static Delegate GetGetThumbTextPaddingHandler ()
		{
			if (cb_getThumbTextPadding == null)
				cb_getThumbTextPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetThumbTextPadding);
			return cb_getThumbTextPadding;
		}

		static int n_GetThumbTextPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThumbTextPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setThumbTextPadding_I;
#pragma warning disable 0169
		static Delegate GetSetThumbTextPadding_IHandler ()
		{
			if (cb_setThumbTextPadding_I == null)
				cb_setThumbTextPadding_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetThumbTextPadding_I);
			return cb_setThumbTextPadding_I;
		}

		static void n_SetThumbTextPadding_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ThumbTextPadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getThumbTextPadding;
		static IntPtr id_setThumbTextPadding_I;
		public virtual unsafe int ThumbTextPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='getThumbTextPadding' and count(parameter)=0]"
			[Register ("getThumbTextPadding", "()I", "GetGetThumbTextPaddingHandler")]
			get {
				if (id_getThumbTextPadding == IntPtr.Zero)
					id_getThumbTextPadding = JNIEnv.GetMethodID (class_ref, "getThumbTextPadding", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getThumbTextPadding);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThumbTextPadding", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setThumbTextPadding' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setThumbTextPadding", "(I)V", "GetSetThumbTextPadding_IHandler")]
			set {
				if (id_setThumbTextPadding_I == IntPtr.Zero)
					id_setThumbTextPadding_I = JNIEnv.GetMethodID (class_ref, "setThumbTextPadding", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setThumbTextPadding_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThumbTextPadding", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackDrawable;
#pragma warning disable 0169
		static Delegate GetGetTrackDrawableHandler ()
		{
			if (cb_getTrackDrawable == null)
				cb_getTrackDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackDrawable);
			return cb_getTrackDrawable;
		}

		static IntPtr n_GetTrackDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackDrawable);
		}
#pragma warning restore 0169

		static Delegate cb_setTrackDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetTrackDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setTrackDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setTrackDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrackDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setTrackDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetTrackDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TrackDrawable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackDrawable;
		static IntPtr id_setTrackDrawable_Landroid_graphics_drawable_Drawable_;
		public virtual unsafe global::Android.Graphics.Drawables.Drawable TrackDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='getTrackDrawable' and count(parameter)=0]"
			[Register ("getTrackDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetTrackDrawableHandler")]
			get {
				if (id_getTrackDrawable == IntPtr.Zero)
					id_getTrackDrawable = JNIEnv.GetMethodID (class_ref, "getTrackDrawable", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getTrackDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackDrawable", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setTrackDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setTrackDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetTrackDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				if (id_setTrackDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setTrackDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setTrackDrawable", "(Landroid/graphics/drawable/Drawable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTrackDrawable_Landroid_graphics_drawable_Drawable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_onMeasure_II;
#pragma warning disable 0169
		static Delegate GetOnMeasure_IIHandler ()
		{
			if (cb_onMeasure_II == null)
				cb_onMeasure_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnMeasure_II);
			return cb_onMeasure_II;
		}

		static void n_OnMeasure_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMeasure (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onMeasure_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='onMeasure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onMeasure", "(II)V", "GetOnMeasure_IIHandler")]
		public virtual unsafe void OnMeasure (int p0, int p1)
		{
			if (id_onMeasure_II == IntPtr.Zero)
				id_onMeasure_II = JNIEnv.GetMethodID (class_ref, "onMeasure", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onMeasure_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMeasure", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSwitchTextAppearance_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetSetSwitchTextAppearance_Landroid_content_Context_IHandler ()
		{
			if (cb_setSwitchTextAppearance_Landroid_content_Context_I == null)
				cb_setSwitchTextAppearance_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetSwitchTextAppearance_Landroid_content_Context_I);
			return cb_setSwitchTextAppearance_Landroid_content_Context_I;
		}

		static void n_SetSwitchTextAppearance_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSwitchTextAppearance (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSwitchTextAppearance_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setSwitchTextAppearance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setSwitchTextAppearance", "(Landroid/content/Context;I)V", "GetSetSwitchTextAppearance_Landroid_content_Context_IHandler")]
		public virtual unsafe void SetSwitchTextAppearance (global::Android.Content.Context p0, int p1)
		{
			if (id_setSwitchTextAppearance_Landroid_content_Context_I == IntPtr.Zero)
				id_setSwitchTextAppearance_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "setSwitchTextAppearance", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSwitchTextAppearance_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSwitchTextAppearance", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSwitchTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetSwitchTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setSwitchTypeface_Landroid_graphics_Typeface_ == null)
				cb_setSwitchTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSwitchTypeface_Landroid_graphics_Typeface_);
			return cb_setSwitchTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetSwitchTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSwitchTypeface (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSwitchTypeface_Landroid_graphics_Typeface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setSwitchTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("setSwitchTypeface", "(Landroid/graphics/Typeface;)V", "GetSetSwitchTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe void SetSwitchTypeface (global::Android.Graphics.Typeface p0)
		{
			if (id_setSwitchTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
				id_setSwitchTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "setSwitchTypeface", "(Landroid/graphics/Typeface;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSwitchTypeface_Landroid_graphics_Typeface_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSwitchTypeface", "(Landroid/graphics/Typeface;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSwitchTypeface_Landroid_graphics_Typeface_I;
#pragma warning disable 0169
		static Delegate GetSetSwitchTypeface_Landroid_graphics_Typeface_IHandler ()
		{
			if (cb_setSwitchTypeface_Landroid_graphics_Typeface_I == null)
				cb_setSwitchTypeface_Landroid_graphics_Typeface_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetSwitchTypeface_Landroid_graphics_Typeface_I);
			return cb_setSwitchTypeface_Landroid_graphics_Typeface_I;
		}

		static void n_SetSwitchTypeface_Landroid_graphics_Typeface_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSwitchTypeface (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSwitchTypeface_Landroid_graphics_Typeface_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setSwitchTypeface' and count(parameter)=2 and parameter[1][@type='android.graphics.Typeface'] and parameter[2][@type='int']]"
		[Register ("setSwitchTypeface", "(Landroid/graphics/Typeface;I)V", "GetSetSwitchTypeface_Landroid_graphics_Typeface_IHandler")]
		public virtual unsafe void SetSwitchTypeface (global::Android.Graphics.Typeface p0, int p1)
		{
			if (id_setSwitchTypeface_Landroid_graphics_Typeface_I == IntPtr.Zero)
				id_setSwitchTypeface_Landroid_graphics_Typeface_I = JNIEnv.GetMethodID (class_ref, "setSwitchTypeface", "(Landroid/graphics/Typeface;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSwitchTypeface_Landroid_graphics_Typeface_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSwitchTypeface", "(Landroid/graphics/Typeface;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setThumbResource_I;
#pragma warning disable 0169
		static Delegate GetSetThumbResource_IHandler ()
		{
			if (cb_setThumbResource_I == null)
				cb_setThumbResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetThumbResource_I);
			return cb_setThumbResource_I;
		}

		static void n_SetThumbResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetThumbResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setThumbResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setThumbResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setThumbResource", "(I)V", "GetSetThumbResource_IHandler")]
		public virtual unsafe void SetThumbResource (int p0)
		{
			if (id_setThumbResource_I == IntPtr.Zero)
				id_setThumbResource_I = JNIEnv.GetMethodID (class_ref, "setThumbResource", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setThumbResource_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThumbResource", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTrackResource_I;
#pragma warning disable 0169
		static Delegate GetSetTrackResource_IHandler ()
		{
			if (cb_setTrackResource_I == null)
				cb_setTrackResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTrackResource_I);
			return cb_setTrackResource_I;
		}

		static void n_SetTrackResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.SwitchCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SwitchCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTrackResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTrackResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='SwitchCompat']/method[@name='setTrackResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTrackResource", "(I)V", "GetSetTrackResource_IHandler")]
		public virtual unsafe void SetTrackResource (int p0)
		{
			if (id_setTrackResource_I == IntPtr.Zero)
				id_setTrackResource_I = JNIEnv.GetMethodID (class_ref, "setTrackResource", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTrackResource_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackResource", "(I)V"), __args);
			} finally {
			}
		}

	}
}
