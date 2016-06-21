using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']"
	[global::Android.Runtime.Register ("android/support/v7/widget/LinearLayoutCompat", DoNotGenerateAcw=true)]
	public partial class LinearLayoutCompat : global::Android.Views.ViewGroup {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/field[@name='HORIZONTAL']"
		[Register ("HORIZONTAL")]
		public const int Horizontal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/field[@name='SHOW_DIVIDER_BEGINNING']"
		[Register ("SHOW_DIVIDER_BEGINNING")]
		public const int ShowDividerBeginning = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/field[@name='SHOW_DIVIDER_END']"
		[Register ("SHOW_DIVIDER_END")]
		public const int ShowDividerEnd = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/field[@name='SHOW_DIVIDER_MIDDLE']"
		[Register ("SHOW_DIVIDER_MIDDLE")]
		public const int ShowDividerMiddle = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/field[@name='SHOW_DIVIDER_NONE']"
		[Register ("SHOW_DIVIDER_NONE")]
		public const int ShowDividerNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/field[@name='VERTICAL']"
		[Register ("VERTICAL")]
		public const int Vertical = (int) 1;
		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.widget']/interface[@name='LinearLayoutCompat.DividerMode']"
		[Register ("android/support/v7/widget/LinearLayoutCompat$DividerMode", "", "Android.Support.V7.Widget.LinearLayoutCompat/IDividerModeInvoker")]
		public partial interface IDividerMode : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("android/support/v7/widget/LinearLayoutCompat$DividerMode", DoNotGenerateAcw=true)]
		internal class IDividerModeInvoker : global::Java.Lang.Object, IDividerMode {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/widget/LinearLayoutCompat$DividerMode");
			IntPtr class_ref;

			public static IDividerMode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDividerMode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.widget.LinearLayoutCompat.DividerMode"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDividerModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDividerModeInvoker); }
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.LinearLayoutCompat.IDividerMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat.IDividerMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Android.Support.V7.Widget.LinearLayoutCompat.IDividerMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat.IDividerMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.LinearLayoutCompat.IDividerMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat.IDividerMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.LinearLayoutCompat.IDividerMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat.IDividerMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat.LayoutParams']"
		[global::Android.Runtime.Register ("android/support/v7/widget/LinearLayoutCompat$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams {


			static IntPtr gravity_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat.LayoutParams']/field[@name='gravity']"
			[Register ("gravity")]
			public int Gravity {
				get {
					if (gravity_jfieldId == IntPtr.Zero)
						gravity_jfieldId = JNIEnv.GetFieldID (class_ref, "gravity", "I");
					return JNIEnv.GetIntField (Handle, gravity_jfieldId);
				}
				set {
					if (gravity_jfieldId == IntPtr.Zero)
						gravity_jfieldId = JNIEnv.GetFieldID (class_ref, "gravity", "I");
					try {
						JNIEnv.SetField (Handle, gravity_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr weight_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat.LayoutParams']/field[@name='weight']"
			[Register ("weight")]
			public float Weight {
				get {
					if (weight_jfieldId == IntPtr.Zero)
						weight_jfieldId = JNIEnv.GetFieldID (class_ref, "weight", "F");
					return JNIEnv.GetFloatField (Handle, weight_jfieldId);
				}
				set {
					if (weight_jfieldId == IntPtr.Zero)
						weight_jfieldId = JNIEnv.GetFieldID (class_ref, "weight", "F");
					try {
						JNIEnv.SetField (Handle, weight_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/widget/LinearLayoutCompat$LayoutParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LayoutParams); }
			}

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_support_v7_widget_LinearLayoutCompat_LayoutParams_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat.LayoutParams']/constructor[@name='LinearLayoutCompat.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.LinearLayoutCompat.LayoutParams']]"
			[Register (".ctor", "(Landroid/support/v7/widget/LinearLayoutCompat$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Support.V7.Widget.LinearLayoutCompat.LayoutParams p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/support/v7/widget/LinearLayoutCompat$LayoutParams;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/support/v7/widget/LinearLayoutCompat$LayoutParams;)V", __args);
						return;
					}

					if (id_ctor_Landroid_support_v7_widget_LinearLayoutCompat_LayoutParams_ == IntPtr.Zero)
						id_ctor_Landroid_support_v7_widget_LinearLayoutCompat_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v7/widget/LinearLayoutCompat$LayoutParams;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v7_widget_LinearLayoutCompat_LayoutParams_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_support_v7_widget_LinearLayoutCompat_LayoutParams_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Landroid_view_ViewGroup_MarginLayoutParams_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat.LayoutParams']/constructor[@name='LinearLayoutCompat.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.MarginLayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.MarginLayoutParams p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/ViewGroup$MarginLayoutParams;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/ViewGroup$MarginLayoutParams;)V", __args);
						return;
					}

					if (id_ctor_Landroid_view_ViewGroup_MarginLayoutParams_ == IntPtr.Zero)
						id_ctor_Landroid_view_ViewGroup_MarginLayoutParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_ViewGroup_MarginLayoutParams_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_ViewGroup_MarginLayoutParams_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Landroid_view_ViewGroup_LayoutParams_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat.LayoutParams']/constructor[@name='LinearLayoutCompat.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.LayoutParams p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/ViewGroup$LayoutParams;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/ViewGroup$LayoutParams;)V", __args);
						return;
					}

					if (id_ctor_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
						id_ctor_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_ViewGroup_LayoutParams_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_ViewGroup_LayoutParams_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_IIF;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat.LayoutParams']/constructor[@name='LinearLayoutCompat.LayoutParams' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
			[Register (".ctor", "(IIF)V", "")]
			public unsafe LayoutParams (int p0, int p1, float p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIF)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIF)V", __args);
						return;
					}

					if (id_ctor_IIF == IntPtr.Zero)
						id_ctor_IIF = JNIEnv.GetMethodID (class_ref, "<init>", "(IIF)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIF, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIF, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat.LayoutParams']/constructor[@name='LinearLayoutCompat.LayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe LayoutParams (int p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", __args);
						return;
					}

					if (id_ctor_II == IntPtr.Zero)
						id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat.LayoutParams']/constructor[@name='LinearLayoutCompat.LayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe LayoutParams (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (LayoutParams)) {
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

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.widget']/interface[@name='LinearLayoutCompat.OrientationMode']"
		[Register ("android/support/v7/widget/LinearLayoutCompat$OrientationMode", "", "Android.Support.V7.Widget.LinearLayoutCompat/IOrientationModeInvoker")]
		public partial interface IOrientationMode : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("android/support/v7/widget/LinearLayoutCompat$OrientationMode", DoNotGenerateAcw=true)]
		internal class IOrientationModeInvoker : global::Java.Lang.Object, IOrientationMode {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/widget/LinearLayoutCompat$OrientationMode");
			IntPtr class_ref;

			public static IOrientationMode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOrientationMode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.widget.LinearLayoutCompat.OrientationMode"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOrientationModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOrientationModeInvoker); }
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.LinearLayoutCompat.IOrientationMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat.IOrientationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Android.Support.V7.Widget.LinearLayoutCompat.IOrientationMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat.IOrientationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.LinearLayoutCompat.IOrientationMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat.IOrientationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.LinearLayoutCompat.IOrientationMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat.IOrientationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/widget/LinearLayoutCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinearLayoutCompat); }
		}

		protected LinearLayoutCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/constructor[@name='LinearLayoutCompat' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe LinearLayoutCompat (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (LinearLayoutCompat)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/constructor[@name='LinearLayoutCompat' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LinearLayoutCompat (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LinearLayoutCompat)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/constructor[@name='LinearLayoutCompat' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe LinearLayoutCompat (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (LinearLayoutCompat)) {
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

		static Delegate cb_isBaselineAligned;
#pragma warning disable 0169
		static Delegate GetIsBaselineAlignedHandler ()
		{
			if (cb_isBaselineAligned == null)
				cb_isBaselineAligned = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBaselineAligned);
			return cb_isBaselineAligned;
		}

		static bool n_IsBaselineAligned (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BaselineAligned;
		}
#pragma warning restore 0169

		static Delegate cb_setBaselineAligned_Z;
#pragma warning disable 0169
		static Delegate GetSetBaselineAligned_ZHandler ()
		{
			if (cb_setBaselineAligned_Z == null)
				cb_setBaselineAligned_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBaselineAligned_Z);
			return cb_setBaselineAligned_Z;
		}

		static void n_SetBaselineAligned_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BaselineAligned = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isBaselineAligned;
		static IntPtr id_setBaselineAligned_Z;
		public virtual unsafe bool BaselineAligned {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='isBaselineAligned' and count(parameter)=0]"
			[Register ("isBaselineAligned", "()Z", "GetIsBaselineAlignedHandler")]
			get {
				if (id_isBaselineAligned == IntPtr.Zero)
					id_isBaselineAligned = JNIEnv.GetMethodID (class_ref, "isBaselineAligned", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isBaselineAligned);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBaselineAligned", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setBaselineAligned' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBaselineAligned", "(Z)V", "GetSetBaselineAligned_ZHandler")]
			set {
				if (id_setBaselineAligned_Z == IntPtr.Zero)
					id_setBaselineAligned_Z = JNIEnv.GetMethodID (class_ref, "setBaselineAligned", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBaselineAligned_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBaselineAligned", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBaselineAlignedChildIndex;
#pragma warning disable 0169
		static Delegate GetGetBaselineAlignedChildIndexHandler ()
		{
			if (cb_getBaselineAlignedChildIndex == null)
				cb_getBaselineAlignedChildIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBaselineAlignedChildIndex);
			return cb_getBaselineAlignedChildIndex;
		}

		static int n_GetBaselineAlignedChildIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BaselineAlignedChildIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setBaselineAlignedChildIndex_I;
#pragma warning disable 0169
		static Delegate GetSetBaselineAlignedChildIndex_IHandler ()
		{
			if (cb_setBaselineAlignedChildIndex_I == null)
				cb_setBaselineAlignedChildIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBaselineAlignedChildIndex_I);
			return cb_setBaselineAlignedChildIndex_I;
		}

		static void n_SetBaselineAlignedChildIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BaselineAlignedChildIndex = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBaselineAlignedChildIndex;
		static IntPtr id_setBaselineAlignedChildIndex_I;
		public virtual unsafe int BaselineAlignedChildIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='getBaselineAlignedChildIndex' and count(parameter)=0]"
			[Register ("getBaselineAlignedChildIndex", "()I", "GetGetBaselineAlignedChildIndexHandler")]
			get {
				if (id_getBaselineAlignedChildIndex == IntPtr.Zero)
					id_getBaselineAlignedChildIndex = JNIEnv.GetMethodID (class_ref, "getBaselineAlignedChildIndex", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getBaselineAlignedChildIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaselineAlignedChildIndex", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setBaselineAlignedChildIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBaselineAlignedChildIndex", "(I)V", "GetSetBaselineAlignedChildIndex_IHandler")]
			set {
				if (id_setBaselineAlignedChildIndex_I == IntPtr.Zero)
					id_setBaselineAlignedChildIndex_I = JNIEnv.GetMethodID (class_ref, "setBaselineAlignedChildIndex", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBaselineAlignedChildIndex_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBaselineAlignedChildIndex", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDividerDrawable;
#pragma warning disable 0169
		static Delegate GetGetDividerDrawableHandler ()
		{
			if (cb_getDividerDrawable == null)
				cb_getDividerDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDividerDrawable);
			return cb_getDividerDrawable;
		}

		static IntPtr n_GetDividerDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DividerDrawable);
		}
#pragma warning restore 0169

		static Delegate cb_setDividerDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetDividerDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setDividerDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setDividerDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDividerDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setDividerDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetDividerDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DividerDrawable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDividerDrawable;
		static IntPtr id_setDividerDrawable_Landroid_graphics_drawable_Drawable_;
		public virtual unsafe global::Android.Graphics.Drawables.Drawable DividerDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='getDividerDrawable' and count(parameter)=0]"
			[Register ("getDividerDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetDividerDrawableHandler")]
			get {
				if (id_getDividerDrawable == IntPtr.Zero)
					id_getDividerDrawable = JNIEnv.GetMethodID (class_ref, "getDividerDrawable", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDividerDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDividerDrawable", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setDividerDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDividerDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				if (id_setDividerDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setDividerDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDividerDrawable_Landroid_graphics_drawable_Drawable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDividerPadding;
#pragma warning disable 0169
		static Delegate GetGetDividerPaddingHandler ()
		{
			if (cb_getDividerPadding == null)
				cb_getDividerPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDividerPadding);
			return cb_getDividerPadding;
		}

		static int n_GetDividerPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DividerPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setDividerPadding_I;
#pragma warning disable 0169
		static Delegate GetSetDividerPadding_IHandler ()
		{
			if (cb_setDividerPadding_I == null)
				cb_setDividerPadding_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDividerPadding_I);
			return cb_setDividerPadding_I;
		}

		static void n_SetDividerPadding_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DividerPadding = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDividerPadding;
		static IntPtr id_setDividerPadding_I;
		public virtual unsafe int DividerPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='getDividerPadding' and count(parameter)=0]"
			[Register ("getDividerPadding", "()I", "GetGetDividerPaddingHandler")]
			get {
				if (id_getDividerPadding == IntPtr.Zero)
					id_getDividerPadding = JNIEnv.GetMethodID (class_ref, "getDividerPadding", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDividerPadding);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDividerPadding", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setDividerPadding' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDividerPadding", "(I)V", "GetSetDividerPadding_IHandler")]
			set {
				if (id_setDividerPadding_I == IntPtr.Zero)
					id_setDividerPadding_I = JNIEnv.GetMethodID (class_ref, "setDividerPadding", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDividerPadding_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDividerPadding", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDividerWidth;
#pragma warning disable 0169
		static Delegate GetGetDividerWidthHandler ()
		{
			if (cb_getDividerWidth == null)
				cb_getDividerWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDividerWidth);
			return cb_getDividerWidth;
		}

		static int n_GetDividerWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DividerWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getDividerWidth;
		public virtual unsafe int DividerWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='getDividerWidth' and count(parameter)=0]"
			[Register ("getDividerWidth", "()I", "GetGetDividerWidthHandler")]
			get {
				if (id_getDividerWidth == IntPtr.Zero)
					id_getDividerWidth = JNIEnv.GetMethodID (class_ref, "getDividerWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDividerWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDividerWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isMeasureWithLargestChildEnabled;
#pragma warning disable 0169
		static Delegate GetIsMeasureWithLargestChildEnabledHandler ()
		{
			if (cb_isMeasureWithLargestChildEnabled == null)
				cb_isMeasureWithLargestChildEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMeasureWithLargestChildEnabled);
			return cb_isMeasureWithLargestChildEnabled;
		}

		static bool n_IsMeasureWithLargestChildEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MeasureWithLargestChildEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setMeasureWithLargestChildEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetMeasureWithLargestChildEnabled_ZHandler ()
		{
			if (cb_setMeasureWithLargestChildEnabled_Z == null)
				cb_setMeasureWithLargestChildEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMeasureWithLargestChildEnabled_Z);
			return cb_setMeasureWithLargestChildEnabled_Z;
		}

		static void n_SetMeasureWithLargestChildEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MeasureWithLargestChildEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isMeasureWithLargestChildEnabled;
		static IntPtr id_setMeasureWithLargestChildEnabled_Z;
		public virtual unsafe bool MeasureWithLargestChildEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='isMeasureWithLargestChildEnabled' and count(parameter)=0]"
			[Register ("isMeasureWithLargestChildEnabled", "()Z", "GetIsMeasureWithLargestChildEnabledHandler")]
			get {
				if (id_isMeasureWithLargestChildEnabled == IntPtr.Zero)
					id_isMeasureWithLargestChildEnabled = JNIEnv.GetMethodID (class_ref, "isMeasureWithLargestChildEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isMeasureWithLargestChildEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMeasureWithLargestChildEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setMeasureWithLargestChildEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMeasureWithLargestChildEnabled", "(Z)V", "GetSetMeasureWithLargestChildEnabled_ZHandler")]
			set {
				if (id_setMeasureWithLargestChildEnabled_Z == IntPtr.Zero)
					id_setMeasureWithLargestChildEnabled_Z = JNIEnv.GetMethodID (class_ref, "setMeasureWithLargestChildEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setMeasureWithLargestChildEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMeasureWithLargestChildEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		static Delegate cb_setOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetOrientation_IHandler ()
		{
			if (cb_setOrientation_I == null)
				cb_setOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOrientation_I);
			return cb_setOrientation_I;
		}

		static void n_SetOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Orientation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		static IntPtr id_setOrientation_I;
		public virtual unsafe int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOrientation);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOrientation", "(I)V", "GetSetOrientation_IHandler")]
			set {
				if (id_setOrientation_I == IntPtr.Zero)
					id_setOrientation_I = JNIEnv.GetMethodID (class_ref, "setOrientation", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setOrientation_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientation", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowDividers;
#pragma warning disable 0169
		static Delegate GetGetShowDividersHandler ()
		{
			if (cb_getShowDividers == null)
				cb_getShowDividers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShowDividers);
			return cb_getShowDividers;
		}

		static int n_GetShowDividers (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowDividers;
		}
#pragma warning restore 0169

		static Delegate cb_setShowDividers_I;
#pragma warning disable 0169
		static Delegate GetSetShowDividers_IHandler ()
		{
			if (cb_setShowDividers_I == null)
				cb_setShowDividers_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShowDividers_I);
			return cb_setShowDividers_I;
		}

		static void n_SetShowDividers_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowDividers = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShowDividers;
		static IntPtr id_setShowDividers_I;
		public virtual unsafe int ShowDividers {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='getShowDividers' and count(parameter)=0]"
			[Register ("getShowDividers", "()I", "GetGetShowDividersHandler")]
			get {
				if (id_getShowDividers == IntPtr.Zero)
					id_getShowDividers = JNIEnv.GetMethodID (class_ref, "getShowDividers", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getShowDividers);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShowDividers", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setShowDividers' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShowDividers", "(I)V", "GetSetShowDividers_IHandler")]
			set {
				if (id_setShowDividers_I == IntPtr.Zero)
					id_setShowDividers_I = JNIEnv.GetMethodID (class_ref, "setShowDividers", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setShowDividers_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowDividers", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWeightSum;
#pragma warning disable 0169
		static Delegate GetGetWeightSumHandler ()
		{
			if (cb_getWeightSum == null)
				cb_getWeightSum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWeightSum);
			return cb_getWeightSum;
		}

		static float n_GetWeightSum (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WeightSum;
		}
#pragma warning restore 0169

		static Delegate cb_setWeightSum_F;
#pragma warning disable 0169
		static Delegate GetSetWeightSum_FHandler ()
		{
			if (cb_setWeightSum_F == null)
				cb_setWeightSum_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetWeightSum_F);
			return cb_setWeightSum_F;
		}

		static void n_SetWeightSum_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WeightSum = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWeightSum;
		static IntPtr id_setWeightSum_F;
		public virtual unsafe float WeightSum {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='getWeightSum' and count(parameter)=0]"
			[Register ("getWeightSum", "()F", "GetGetWeightSumHandler")]
			get {
				if (id_getWeightSum == IntPtr.Zero)
					id_getWeightSum = JNIEnv.GetMethodID (class_ref, "getWeightSum", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getWeightSum);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeightSum", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setWeightSum' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWeightSum", "(F)V", "GetSetWeightSum_FHandler")]
			set {
				if (id_setWeightSum_F == IntPtr.Zero)
					id_setWeightSum_F = JNIEnv.GetMethodID (class_ref, "setWeightSum", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWeightSum_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWeightSum", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_hasDividerBeforeChildAt_I;
#pragma warning disable 0169
		static Delegate GetHasDividerBeforeChildAt_IHandler ()
		{
			if (cb_hasDividerBeforeChildAt_I == null)
				cb_hasDividerBeforeChildAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_HasDividerBeforeChildAt_I);
			return cb_hasDividerBeforeChildAt_I;
		}

		static bool n_HasDividerBeforeChildAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDividerBeforeChildAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_hasDividerBeforeChildAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='hasDividerBeforeChildAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasDividerBeforeChildAt", "(I)Z", "GetHasDividerBeforeChildAt_IHandler")]
		protected virtual unsafe bool HasDividerBeforeChildAt (int p0)
		{
			if (id_hasDividerBeforeChildAt_I == IntPtr.Zero)
				id_hasDividerBeforeChildAt_I = JNIEnv.GetMethodID (class_ref, "hasDividerBeforeChildAt", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasDividerBeforeChildAt_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasDividerBeforeChildAt", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLayout_ZIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setGravity_I;
#pragma warning disable 0169
		static Delegate GetSetGravity_IHandler ()
		{
			if (cb_setGravity_I == null)
				cb_setGravity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGravity_I);
			return cb_setGravity_I;
		}

		static void n_SetGravity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGravity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGravity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setGravity", "(I)V", "GetSetGravity_IHandler")]
		public virtual unsafe void SetGravity (int p0)
		{
			if (id_setGravity_I == IntPtr.Zero)
				id_setGravity_I = JNIEnv.GetMethodID (class_ref, "setGravity", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGravity_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGravity", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHorizontalGravity_I;
#pragma warning disable 0169
		static Delegate GetSetHorizontalGravity_IHandler ()
		{
			if (cb_setHorizontalGravity_I == null)
				cb_setHorizontalGravity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHorizontalGravity_I);
			return cb_setHorizontalGravity_I;
		}

		static void n_SetHorizontalGravity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHorizontalGravity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHorizontalGravity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setHorizontalGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHorizontalGravity", "(I)V", "GetSetHorizontalGravity_IHandler")]
		public virtual unsafe void SetHorizontalGravity (int p0)
		{
			if (id_setHorizontalGravity_I == IntPtr.Zero)
				id_setHorizontalGravity_I = JNIEnv.GetMethodID (class_ref, "setHorizontalGravity", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHorizontalGravity_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHorizontalGravity", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVerticalGravity_I;
#pragma warning disable 0169
		static Delegate GetSetVerticalGravity_IHandler ()
		{
			if (cb_setVerticalGravity_I == null)
				cb_setVerticalGravity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetVerticalGravity_I);
			return cb_setVerticalGravity_I;
		}

		static void n_SetVerticalGravity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.LinearLayoutCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.LinearLayoutCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVerticalGravity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVerticalGravity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='LinearLayoutCompat']/method[@name='setVerticalGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setVerticalGravity", "(I)V", "GetSetVerticalGravity_IHandler")]
		public virtual unsafe void SetVerticalGravity (int p0)
		{
			if (id_setVerticalGravity_I == IntPtr.Zero)
				id_setVerticalGravity_I = JNIEnv.GetMethodID (class_ref, "setVerticalGravity", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setVerticalGravity_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVerticalGravity", "(I)V"), __args);
			} finally {
			}
		}

	}
}
