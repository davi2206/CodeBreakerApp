using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']"
	[global::Android.Runtime.Register ("android/support/v7/app/ActionBar", DoNotGenerateAcw=true)]
	public abstract partial class ActionBar : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/field[@name='DISPLAY_HOME_AS_UP']"
		[Register ("DISPLAY_HOME_AS_UP")]
		public const int DisplayHomeAsUp = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/field[@name='DISPLAY_SHOW_CUSTOM']"
		[Register ("DISPLAY_SHOW_CUSTOM")]
		public const int DisplayShowCustom = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/field[@name='DISPLAY_SHOW_HOME']"
		[Register ("DISPLAY_SHOW_HOME")]
		public const int DisplayShowHome = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/field[@name='DISPLAY_SHOW_TITLE']"
		[Register ("DISPLAY_SHOW_TITLE")]
		public const int DisplayShowTitle = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/field[@name='DISPLAY_USE_LOGO']"
		[Register ("DISPLAY_USE_LOGO")]
		public const int DisplayUseLogo = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/field[@name='NAVIGATION_MODE_LIST']"
		[Register ("NAVIGATION_MODE_LIST")]
		public const int NavigationModeList = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/field[@name='NAVIGATION_MODE_STANDARD']"
		[Register ("NAVIGATION_MODE_STANDARD")]
		public const int NavigationModeStandard = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/field[@name='NAVIGATION_MODE_TABS']"
		[Register ("NAVIGATION_MODE_TABS")]
		public const int NavigationModeTabs = (int) 2;
		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.app']/interface[@name='ActionBar.DisplayOptions']"
		[Register ("android/support/v7/app/ActionBar$DisplayOptions", "", "Android.Support.V7.App.ActionBar/IDisplayOptionsInvoker")]
		public partial interface IDisplayOptions : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("android/support/v7/app/ActionBar$DisplayOptions", DoNotGenerateAcw=true)]
		internal class IDisplayOptionsInvoker : global::Java.Lang.Object, IDisplayOptions {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/app/ActionBar$DisplayOptions");
			IntPtr class_ref;

			public static IDisplayOptions GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDisplayOptions> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.app.ActionBar.DisplayOptions"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDisplayOptionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDisplayOptionsInvoker); }
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
				global::Android.Support.V7.App.ActionBar.IDisplayOptions __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IDisplayOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.Support.V7.App.ActionBar.IDisplayOptions __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IDisplayOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.Support.V7.App.ActionBar.IDisplayOptions __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IDisplayOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.Support.V7.App.ActionBar.IDisplayOptions __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IDisplayOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.LayoutParams']"
		[global::Android.Runtime.Register ("android/support/v7/app/ActionBar$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams {


			static IntPtr gravity_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.LayoutParams']/field[@name='gravity']"
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
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/app/ActionBar$LayoutParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LayoutParams); }
			}

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_ViewGroup_LayoutParams_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.LayoutParams']/constructor[@name='ActionBar.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
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

			static IntPtr id_ctor_Landroid_support_v7_app_ActionBar_LayoutParams_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.LayoutParams']/constructor[@name='ActionBar.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.LayoutParams']]"
			[Register (".ctor", "(Landroid/support/v7/app/ActionBar$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Support.V7.App.ActionBar.LayoutParams p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/support/v7/app/ActionBar$LayoutParams;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/support/v7/app/ActionBar$LayoutParams;)V", __args);
						return;
					}

					if (id_ctor_Landroid_support_v7_app_ActionBar_LayoutParams_ == IntPtr.Zero)
						id_ctor_Landroid_support_v7_app_ActionBar_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v7/app/ActionBar$LayoutParams;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v7_app_ActionBar_LayoutParams_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_support_v7_app_ActionBar_LayoutParams_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.LayoutParams']/constructor[@name='ActionBar.LayoutParams' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe LayoutParams (int p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
						return;
					}

					if (id_ctor_I == IntPtr.Zero)
						id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_III;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.LayoutParams']/constructor[@name='ActionBar.LayoutParams' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(III)V", "")]
			public unsafe LayoutParams (int p0, int p1, int p2)
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
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(III)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(III)V", __args);
						return;
					}

					if (id_ctor_III == IntPtr.Zero)
						id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_III, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_III, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.LayoutParams']/constructor[@name='ActionBar.LayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.LayoutParams']/constructor[@name='ActionBar.LayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.app']/interface[@name='ActionBar.NavigationMode']"
		[Register ("android/support/v7/app/ActionBar$NavigationMode", "", "Android.Support.V7.App.ActionBar/INavigationModeInvoker")]
		public partial interface INavigationMode : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("android/support/v7/app/ActionBar$NavigationMode", DoNotGenerateAcw=true)]
		internal class INavigationModeInvoker : global::Java.Lang.Object, INavigationMode {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/app/ActionBar$NavigationMode");
			IntPtr class_ref;

			public static INavigationMode GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INavigationMode> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.app.ActionBar.NavigationMode"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INavigationModeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INavigationModeInvoker); }
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
				global::Android.Support.V7.App.ActionBar.INavigationMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.INavigationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.Support.V7.App.ActionBar.INavigationMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.INavigationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.Support.V7.App.ActionBar.INavigationMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.INavigationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.Support.V7.App.ActionBar.INavigationMode __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.INavigationMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.app']/interface[@name='ActionBar.OnMenuVisibilityListener']"
		[Register ("android/support/v7/app/ActionBar$OnMenuVisibilityListener", "", "Android.Support.V7.App.ActionBar/IOnMenuVisibilityListenerInvoker")]
		public partial interface IOnMenuVisibilityListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/interface[@name='ActionBar.OnMenuVisibilityListener']/method[@name='onMenuVisibilityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onMenuVisibilityChanged", "(Z)V", "GetOnMenuVisibilityChanged_ZHandler:Android.Support.V7.App.ActionBar/IOnMenuVisibilityListenerInvoker, Binding_AppcompatV7")]
			void OnMenuVisibilityChanged (bool p0);

		}

		[global::Android.Runtime.Register ("android/support/v7/app/ActionBar$OnMenuVisibilityListener", DoNotGenerateAcw=true)]
		internal class IOnMenuVisibilityListenerInvoker : global::Java.Lang.Object, IOnMenuVisibilityListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/app/ActionBar$OnMenuVisibilityListener");
			IntPtr class_ref;

			public static IOnMenuVisibilityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMenuVisibilityListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.app.ActionBar.OnMenuVisibilityListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMenuVisibilityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMenuVisibilityListenerInvoker); }
			}

			static Delegate cb_onMenuVisibilityChanged_Z;
#pragma warning disable 0169
			static Delegate GetOnMenuVisibilityChanged_ZHandler ()
			{
				if (cb_onMenuVisibilityChanged_Z == null)
					cb_onMenuVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnMenuVisibilityChanged_Z);
				return cb_onMenuVisibilityChanged_Z;
			}

			static void n_OnMenuVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMenuVisibilityChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMenuVisibilityChanged_Z;
			public unsafe void OnMenuVisibilityChanged (bool p0)
			{
				if (id_onMenuVisibilityChanged_Z == IntPtr.Zero)
					id_onMenuVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "onMenuVisibilityChanged", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onMenuVisibilityChanged_Z, __args);
			}

		}

		public partial class MenuVisibilityEventArgs : global::System.EventArgs {

			public MenuVisibilityEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/android/support/v7/app/ActionBar_OnMenuVisibilityListenerImplementor")]
		internal sealed partial class IOnMenuVisibilityListenerImplementor : global::Java.Lang.Object, IOnMenuVisibilityListener {

			object sender;

			public IOnMenuVisibilityListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/android/support/v7/app/ActionBar_OnMenuVisibilityListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MenuVisibilityEventArgs> Handler;
#pragma warning restore 0649

			public void OnMenuVisibilityChanged (bool p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MenuVisibilityEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMenuVisibilityListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.app']/interface[@name='ActionBar.OnNavigationListener']"
		[Register ("android/support/v7/app/ActionBar$OnNavigationListener", "", "Android.Support.V7.App.ActionBar/IOnNavigationListenerInvoker")]
		public partial interface IOnNavigationListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/interface[@name='ActionBar.OnNavigationListener']/method[@name='onNavigationItemSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
			[Register ("onNavigationItemSelected", "(IJ)Z", "GetOnNavigationItemSelected_IJHandler:Android.Support.V7.App.ActionBar/IOnNavigationListenerInvoker, Binding_AppcompatV7")]
			bool OnNavigationItemSelected (int p0, long p1);

		}

		[global::Android.Runtime.Register ("android/support/v7/app/ActionBar$OnNavigationListener", DoNotGenerateAcw=true)]
		internal class IOnNavigationListenerInvoker : global::Java.Lang.Object, IOnNavigationListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/app/ActionBar$OnNavigationListener");
			IntPtr class_ref;

			public static IOnNavigationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnNavigationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.app.ActionBar.OnNavigationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnNavigationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnNavigationListenerInvoker); }
			}

			static Delegate cb_onNavigationItemSelected_IJ;
#pragma warning disable 0169
			static Delegate GetOnNavigationItemSelected_IJHandler ()
			{
				if (cb_onNavigationItemSelected_IJ == null)
					cb_onNavigationItemSelected_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, bool>) n_OnNavigationItemSelected_IJ);
				return cb_onNavigationItemSelected_IJ;
			}

			static bool n_OnNavigationItemSelected_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				global::Android.Support.V7.App.ActionBar.IOnNavigationListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IOnNavigationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnNavigationItemSelected (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onNavigationItemSelected_IJ;
			public unsafe bool OnNavigationItemSelected (int p0, long p1)
			{
				if (id_onNavigationItemSelected_IJ == IntPtr.Zero)
					id_onNavigationItemSelected_IJ = JNIEnv.GetMethodID (class_ref, "onNavigationItemSelected", "(IJ)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallBooleanMethod (Handle, id_onNavigationItemSelected_IJ, __args);
			}

		}

		public partial class NavigationEventArgs : global::System.EventArgs {

			public NavigationEventArgs (bool handled, int p0, long p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			long p1;
			public long P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/android/support/v7/app/ActionBar_OnNavigationListenerImplementor")]
		internal sealed partial class IOnNavigationListenerImplementor : global::Java.Lang.Object, IOnNavigationListener {

			object sender;

			public IOnNavigationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/android/support/v7/app/ActionBar_OnNavigationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NavigationEventArgs> Handler;
#pragma warning restore 0649

			public bool OnNavigationItemSelected (int p0, long p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new NavigationEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnNavigationListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']"
		[global::Android.Runtime.Register ("android/support/v7/app/ActionBar$Tab", DoNotGenerateAcw=true)]
		public abstract partial class Tab : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/field[@name='INVALID_POSITION']"
			[Register ("INVALID_POSITION")]
			public const int InvalidPosition = (int) -1;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/app/ActionBar$Tab", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Tab); }
			}

			protected Tab (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/constructor[@name='ActionBar.Tab' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Tab ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Tab)) {
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

			static Delegate cb_getContentDescription;
#pragma warning disable 0169
			static Delegate GetGetContentDescriptionHandler ()
			{
				if (cb_getContentDescription == null)
					cb_getContentDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentDescription);
				return cb_getContentDescription;
			}

			static IntPtr n_GetContentDescription (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return CharSequence.ToLocalJniHandle (__this.ContentDescriptionFormatted);
			}
#pragma warning restore 0169

			public abstract global::Java.Lang.ICharSequence ContentDescriptionFormatted {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getContentDescription' and count(parameter)=0]"
				[Register ("getContentDescription", "()Ljava/lang/CharSequence;", "GetGetContentDescriptionHandler")] get;
			}

			public string ContentDescription {
				get { return ContentDescriptionFormatted == null ? null : ContentDescriptionFormatted.ToString (); }
			}

			static Delegate cb_getCustomView;
#pragma warning disable 0169
			static Delegate GetGetCustomViewHandler ()
			{
				if (cb_getCustomView == null)
					cb_getCustomView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomView);
				return cb_getCustomView;
			}

			static IntPtr n_GetCustomView (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CustomView);
			}
#pragma warning restore 0169

			public abstract global::Android.Views.View CustomView {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getCustomView' and count(parameter)=0]"
				[Register ("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")] get;
			}

			static Delegate cb_getIcon;
#pragma warning disable 0169
			static Delegate GetGetIconHandler ()
			{
				if (cb_getIcon == null)
					cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
				return cb_getIcon;
			}

			static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Icon);
			}
#pragma warning restore 0169

			public abstract global::Android.Graphics.Drawables.Drawable Icon {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getIcon' and count(parameter)=0]"
				[Register ("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler")] get;
			}

			static Delegate cb_getPosition;
#pragma warning disable 0169
			static Delegate GetGetPositionHandler ()
			{
				if (cb_getPosition == null)
					cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPosition);
				return cb_getPosition;
			}

			static int n_GetPosition (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Position;
			}
#pragma warning restore 0169

			public abstract int Position {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getPosition' and count(parameter)=0]"
				[Register ("getPosition", "()I", "GetGetPositionHandler")] get;
			}

			static Delegate cb_getTag;
#pragma warning disable 0169
			static Delegate GetGetTagHandler ()
			{
				if (cb_getTag == null)
					cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
				return cb_getTag;
			}

			static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Tag);
			}
#pragma warning restore 0169

			public abstract global::Java.Lang.Object Tag {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getTag' and count(parameter)=0]"
				[Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")] get;
			}

			static Delegate cb_getText;
#pragma warning disable 0169
			static Delegate GetGetTextHandler ()
			{
				if (cb_getText == null)
					cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
				return cb_getText;
			}

			static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return CharSequence.ToLocalJniHandle (__this.TextFormatted);
			}
#pragma warning restore 0169

			public abstract global::Java.Lang.ICharSequence TextFormatted {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getText' and count(parameter)=0]"
				[Register ("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")] get;
			}

			public string Text {
				get { return TextFormatted == null ? null : TextFormatted.ToString (); }
			}

			static Delegate cb_select;
#pragma warning disable 0169
			static Delegate GetSelectHandler ()
			{
				if (cb_select == null)
					cb_select = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Select);
				return cb_select;
			}

			static void n_Select (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Select ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='select' and count(parameter)=0]"
			[Register ("select", "()V", "GetSelectHandler")]
			public abstract void Select ();

			static Delegate cb_setContentDescription_I;
#pragma warning disable 0169
			static Delegate GetSetContentDescription_IHandler ()
			{
				if (cb_setContentDescription_I == null)
					cb_setContentDescription_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetContentDescription_I);
				return cb_setContentDescription_I;
			}

			static IntPtr n_SetContentDescription_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetContentDescription (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setContentDescription' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setContentDescription", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetSetContentDescription_IHandler")]
			public abstract global::Android.Support.V7.App.ActionBar.Tab SetContentDescription (int p0);

			static Delegate cb_setContentDescription_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetContentDescription_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setContentDescription_Ljava_lang_CharSequence_ == null)
					cb_setContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentDescription_Ljava_lang_CharSequence_);
				return cb_setContentDescription_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetContentDescription_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentDescription (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setContentDescription' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setContentDescription", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/ActionBar$Tab;", "GetSetContentDescription_Ljava_lang_CharSequence_Handler")]
			public abstract global::Android.Support.V7.App.ActionBar.Tab SetContentDescription (global::Java.Lang.ICharSequence p0);

			public global::Android.Support.V7.App.ActionBar.Tab SetContentDescription (string p0)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				global::Android.Support.V7.App.ActionBar.Tab __result = SetContentDescription (jls_p0);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

			static Delegate cb_setCustomView_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetSetCustomView_Landroid_view_View_Handler ()
			{
				if (cb_setCustomView_Landroid_view_View_ == null)
					cb_setCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomView_Landroid_view_View_);
				return cb_setCustomView_Landroid_view_View_;
			}

			static IntPtr n_SetCustomView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomView (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setCustomView", "(Landroid/view/View;)Landroid/support/v7/app/ActionBar$Tab;", "GetSetCustomView_Landroid_view_View_Handler")]
			public abstract global::Android.Support.V7.App.ActionBar.Tab SetCustomView (global::Android.Views.View p0);

			static Delegate cb_setCustomView_I;
#pragma warning disable 0169
			static Delegate GetSetCustomView_IHandler ()
			{
				if (cb_setCustomView_I == null)
					cb_setCustomView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetCustomView_I);
				return cb_setCustomView_I;
			}

			static IntPtr n_SetCustomView_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCustomView (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCustomView", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetSetCustomView_IHandler")]
			public abstract global::Android.Support.V7.App.ActionBar.Tab SetCustomView (int p0);

			static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
					cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetIcon_Landroid_graphics_drawable_Drawable_);
				return cb_setIcon_Landroid_graphics_drawable_Drawable_;
			}

			static IntPtr n_SetIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/support/v7/app/ActionBar$Tab;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public abstract global::Android.Support.V7.App.ActionBar.Tab SetIcon (global::Android.Graphics.Drawables.Drawable p0);

			static Delegate cb_setIcon_I;
#pragma warning disable 0169
			static Delegate GetSetIcon_IHandler ()
			{
				if (cb_setIcon_I == null)
					cb_setIcon_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetIcon_I);
				return cb_setIcon_I;
			}

			static IntPtr n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIcon", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetSetIcon_IHandler")]
			public abstract global::Android.Support.V7.App.ActionBar.Tab SetIcon (int p0);

			static Delegate cb_setTag_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSetTag_Ljava_lang_Object_Handler ()
			{
				if (cb_setTag_Ljava_lang_Object_ == null)
					cb_setTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTag_Ljava_lang_Object_);
				return cb_setTag_Ljava_lang_Object_;
			}

			static IntPtr n_SetTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTag (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setTag", "(Ljava/lang/Object;)Landroid/support/v7/app/ActionBar$Tab;", "GetSetTag_Ljava_lang_Object_Handler")]
			public abstract global::Android.Support.V7.App.ActionBar.Tab SetTag (global::Java.Lang.Object p0);

			static Delegate cb_setText_I;
#pragma warning disable 0169
			static Delegate GetSetText_IHandler ()
			{
				if (cb_setText_I == null)
					cb_setText_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetText_I);
				return cb_setText_I;
			}

			static IntPtr n_SetText_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetText (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setText", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetSetText_IHandler")]
			public abstract global::Android.Support.V7.App.ActionBar.Tab SetText (int p0);

			static Delegate cb_setText_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetText_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setText_Ljava_lang_CharSequence_ == null)
					cb_setText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_CharSequence_);
				return cb_setText_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetText_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.ActionBar.Tab __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetText (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setText", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/ActionBar$Tab;", "GetSetText_Ljava_lang_CharSequence_Handler")]
			public abstract global::Android.Support.V7.App.ActionBar.Tab SetText (global::Java.Lang.ICharSequence p0);

			public global::Android.Support.V7.App.ActionBar.Tab SetText (string p0)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				global::Android.Support.V7.App.ActionBar.Tab __result = SetText (jls_p0);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

		}

		[global::Android.Runtime.Register ("android/support/v7/app/ActionBar$Tab", DoNotGenerateAcw=true)]
		internal partial class TabInvoker : Tab {

			public TabInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (TabInvoker); }
			}

			static IntPtr id_getContentDescription;
			public override unsafe global::Java.Lang.ICharSequence ContentDescriptionFormatted {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getContentDescription' and count(parameter)=0]"
				[Register ("getContentDescription", "()Ljava/lang/CharSequence;", "GetGetContentDescriptionHandler")]
				get {
					if (id_getContentDescription == IntPtr.Zero)
						id_getContentDescription = JNIEnv.GetMethodID (class_ref, "getContentDescription", "()Ljava/lang/CharSequence;");
					try {
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getContentDescription), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getCustomView;
			public override unsafe global::Android.Views.View CustomView {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getCustomView' and count(parameter)=0]"
				[Register ("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")]
				get {
					if (id_getCustomView == IntPtr.Zero)
						id_getCustomView = JNIEnv.GetMethodID (class_ref, "getCustomView", "()Landroid/view/View;");
					try {
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getCustomView), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getIcon;
			public override unsafe global::Android.Graphics.Drawables.Drawable Icon {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getIcon' and count(parameter)=0]"
				[Register ("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler")]
				get {
					if (id_getIcon == IntPtr.Zero)
						id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Landroid/graphics/drawable/Drawable;");
					try {
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getPosition;
			public override unsafe int Position {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getPosition' and count(parameter)=0]"
				[Register ("getPosition", "()I", "GetGetPositionHandler")]
				get {
					if (id_getPosition == IntPtr.Zero)
						id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()I");
					try {
						return JNIEnv.CallIntMethod  (Handle, id_getPosition);
					} finally {
					}
				}
			}

			static IntPtr id_getTag;
			public override unsafe global::Java.Lang.Object Tag {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getTag' and count(parameter)=0]"
				[Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
				get {
					if (id_getTag == IntPtr.Zero)
						id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/Object;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getText;
			public override unsafe global::Java.Lang.ICharSequence TextFormatted {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='getText' and count(parameter)=0]"
				[Register ("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
				get {
					if (id_getText == IntPtr.Zero)
						id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/CharSequence;");
					try {
						return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getText), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_select;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='select' and count(parameter)=0]"
			[Register ("select", "()V", "GetSelectHandler")]
			public override unsafe void Select ()
			{
				if (id_select == IntPtr.Zero)
					id_select = JNIEnv.GetMethodID (class_ref, "select", "()V");
				try {
					JNIEnv.CallVoidMethod  (Handle, id_select);
				} finally {
				}
			}

			static IntPtr id_setContentDescription_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setContentDescription' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setContentDescription", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetSetContentDescription_IHandler")]
			public override unsafe global::Android.Support.V7.App.ActionBar.Tab SetContentDescription (int p0)
			{
				if (id_setContentDescription_I == IntPtr.Zero)
					id_setContentDescription_I = JNIEnv.GetMethodID (class_ref, "setContentDescription", "(I)Landroid/support/v7/app/ActionBar$Tab;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setContentDescription_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setContentDescription_Ljava_lang_CharSequence_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setContentDescription' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setContentDescription", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/ActionBar$Tab;", "GetSetContentDescription_Ljava_lang_CharSequence_Handler")]
			public override unsafe global::Android.Support.V7.App.ActionBar.Tab SetContentDescription (global::Java.Lang.ICharSequence p0)
			{
				if (id_setContentDescription_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setContentDescription_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setContentDescription", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/ActionBar$Tab;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Android.Support.V7.App.ActionBar.Tab __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setContentDescription_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_setCustomView_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setCustomView", "(Landroid/view/View;)Landroid/support/v7/app/ActionBar$Tab;", "GetSetCustomView_Landroid_view_View_Handler")]
			public override unsafe global::Android.Support.V7.App.ActionBar.Tab SetCustomView (global::Android.Views.View p0)
			{
				if (id_setCustomView_Landroid_view_View_ == IntPtr.Zero)
					id_setCustomView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setCustomView", "(Landroid/view/View;)Landroid/support/v7/app/ActionBar$Tab;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Android.Support.V7.App.ActionBar.Tab __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setCustomView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_setCustomView_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCustomView", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetSetCustomView_IHandler")]
			public override unsafe global::Android.Support.V7.App.ActionBar.Tab SetCustomView (int p0)
			{
				if (id_setCustomView_I == IntPtr.Zero)
					id_setCustomView_I = JNIEnv.GetMethodID (class_ref, "setCustomView", "(I)Landroid/support/v7/app/ActionBar$Tab;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setCustomView_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/support/v7/app/ActionBar$Tab;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public override unsafe global::Android.Support.V7.App.ActionBar.Tab SetIcon (global::Android.Graphics.Drawables.Drawable p0)
			{
				if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/support/v7/app/ActionBar$Tab;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Android.Support.V7.App.ActionBar.Tab __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_setIcon_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIcon", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetSetIcon_IHandler")]
			public override unsafe global::Android.Support.V7.App.ActionBar.Tab SetIcon (int p0)
			{
				if (id_setIcon_I == IntPtr.Zero)
					id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)Landroid/support/v7/app/ActionBar$Tab;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setIcon_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setTag_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setTag", "(Ljava/lang/Object;)Landroid/support/v7/app/ActionBar$Tab;", "GetSetTag_Ljava_lang_Object_Handler")]
			public override unsafe global::Android.Support.V7.App.ActionBar.Tab SetTag (global::Java.Lang.Object p0)
			{
				if (id_setTag_Ljava_lang_Object_ == IntPtr.Zero)
					id_setTag_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/Object;)Landroid/support/v7/app/ActionBar$Tab;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Android.Support.V7.App.ActionBar.Tab __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setTag_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_setText_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setText", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetSetText_IHandler")]
			public override unsafe global::Android.Support.V7.App.ActionBar.Tab SetText (int p0)
			{
				if (id_setText_I == IntPtr.Zero)
					id_setText_I = JNIEnv.GetMethodID (class_ref, "setText", "(I)Landroid/support/v7/app/ActionBar$Tab;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setText_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_setText_Ljava_lang_CharSequence_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar.Tab']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setText", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/ActionBar$Tab;", "GetSetText_Ljava_lang_CharSequence_Handler")]
			public override unsafe global::Android.Support.V7.App.ActionBar.Tab SetText (global::Java.Lang.ICharSequence p0)
			{
				if (id_setText_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setText_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/ActionBar$Tab;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Android.Support.V7.App.ActionBar.Tab __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_setText_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/app/ActionBar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBar); }
		}

		protected ActionBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/constructor[@name='ActionBar' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActionBar ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ActionBar)) {
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

		static Delegate cb_getCustomView;
#pragma warning disable 0169
		static Delegate GetGetCustomViewHandler ()
		{
			if (cb_getCustomView == null)
				cb_getCustomView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomView);
			return cb_getCustomView;
		}

		static IntPtr n_GetCustomView (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CustomView);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetCustomView_Landroid_view_View_Handler ()
		{
			if (cb_setCustomView_Landroid_view_View_ == null)
				cb_setCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomView_Landroid_view_View_);
			return cb_setCustomView_Landroid_view_View_;
		}

		static void n_SetCustomView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomView = p0;
		}
#pragma warning restore 0169

		public abstract global::Android.Views.View CustomView {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getCustomView' and count(parameter)=0]"
			[Register ("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler")] set;
		}

		static Delegate cb_getDisplayOptions;
#pragma warning disable 0169
		static Delegate GetGetDisplayOptionsHandler ()
		{
			if (cb_getDisplayOptions == null)
				cb_getDisplayOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayOptions);
			return cb_getDisplayOptions;
		}

		static int n_GetDisplayOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayOptions;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayOptions_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayOptions_IHandler ()
		{
			if (cb_setDisplayOptions_I == null)
				cb_setDisplayOptions_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisplayOptions_I);
			return cb_setDisplayOptions_I;
		}

		static void n_SetDisplayOptions_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayOptions = p0;
		}
#pragma warning restore 0169

		public abstract int DisplayOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getDisplayOptions' and count(parameter)=0]"
			[Register ("getDisplayOptions", "()I", "GetGetDisplayOptionsHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayOptions' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisplayOptions", "(I)V", "GetSetDisplayOptions_IHandler")] set;
		}

		static Delegate cb_getElevation;
#pragma warning disable 0169
		static Delegate GetGetElevationHandler ()
		{
			if (cb_getElevation == null)
				cb_getElevation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetElevation);
			return cb_getElevation;
		}

		static float n_GetElevation (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Elevation;
		}
#pragma warning restore 0169

		static Delegate cb_setElevation_F;
#pragma warning disable 0169
		static Delegate GetSetElevation_FHandler ()
		{
			if (cb_setElevation_F == null)
				cb_setElevation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetElevation_F);
			return cb_setElevation_F;
		}

		static void n_SetElevation_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Elevation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getElevation;
		static IntPtr id_setElevation_F;
		public virtual unsafe float Elevation {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getElevation' and count(parameter)=0]"
			[Register ("getElevation", "()F", "GetGetElevationHandler")]
			get {
				if (id_getElevation == IntPtr.Zero)
					id_getElevation = JNIEnv.GetMethodID (class_ref, "getElevation", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getElevation);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElevation", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setElevation' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setElevation", "(F)V", "GetSetElevation_FHandler")]
			set {
				if (id_setElevation_F == IntPtr.Zero)
					id_setElevation_F = JNIEnv.GetMethodID (class_ref, "setElevation", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setElevation_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setElevation", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		public abstract int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")] get;
		}

		static Delegate cb_getHideOffset;
#pragma warning disable 0169
		static Delegate GetGetHideOffsetHandler ()
		{
			if (cb_getHideOffset == null)
				cb_getHideOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHideOffset);
			return cb_getHideOffset;
		}

		static int n_GetHideOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setHideOffset_I;
#pragma warning disable 0169
		static Delegate GetSetHideOffset_IHandler ()
		{
			if (cb_setHideOffset_I == null)
				cb_setHideOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHideOffset_I);
			return cb_setHideOffset_I;
		}

		static void n_SetHideOffset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideOffset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHideOffset;
		static IntPtr id_setHideOffset_I;
		public virtual unsafe int HideOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getHideOffset' and count(parameter)=0]"
			[Register ("getHideOffset", "()I", "GetGetHideOffsetHandler")]
			get {
				if (id_getHideOffset == IntPtr.Zero)
					id_getHideOffset = JNIEnv.GetMethodID (class_ref, "getHideOffset", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHideOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHideOffset", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setHideOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHideOffset", "(I)V", "GetSetHideOffset_IHandler")]
			set {
				if (id_setHideOffset_I == IntPtr.Zero)
					id_setHideOffset_I = JNIEnv.GetMethodID (class_ref, "setHideOffset", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHideOffset_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHideOffset", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isHideOnContentScrollEnabled;
#pragma warning disable 0169
		static Delegate GetIsHideOnContentScrollEnabledHandler ()
		{
			if (cb_isHideOnContentScrollEnabled == null)
				cb_isHideOnContentScrollEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideOnContentScrollEnabled);
			return cb_isHideOnContentScrollEnabled;
		}

		static bool n_IsHideOnContentScrollEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideOnContentScrollEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHideOnContentScrollEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHideOnContentScrollEnabled_ZHandler ()
		{
			if (cb_setHideOnContentScrollEnabled_Z == null)
				cb_setHideOnContentScrollEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHideOnContentScrollEnabled_Z);
			return cb_setHideOnContentScrollEnabled_Z;
		}

		static void n_SetHideOnContentScrollEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideOnContentScrollEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isHideOnContentScrollEnabled;
		static IntPtr id_setHideOnContentScrollEnabled_Z;
		public virtual unsafe bool HideOnContentScrollEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='isHideOnContentScrollEnabled' and count(parameter)=0]"
			[Register ("isHideOnContentScrollEnabled", "()Z", "GetIsHideOnContentScrollEnabledHandler")]
			get {
				if (id_isHideOnContentScrollEnabled == IntPtr.Zero)
					id_isHideOnContentScrollEnabled = JNIEnv.GetMethodID (class_ref, "isHideOnContentScrollEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isHideOnContentScrollEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHideOnContentScrollEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setHideOnContentScrollEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHideOnContentScrollEnabled", "(Z)V", "GetSetHideOnContentScrollEnabled_ZHandler")]
			set {
				if (id_setHideOnContentScrollEnabled_Z == IntPtr.Zero)
					id_setHideOnContentScrollEnabled_Z = JNIEnv.GetMethodID (class_ref, "setHideOnContentScrollEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHideOnContentScrollEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHideOnContentScrollEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isShowing;
#pragma warning disable 0169
		static Delegate GetIsShowingHandler ()
		{
			if (cb_isShowing == null)
				cb_isShowing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowing);
			return cb_isShowing;
		}

		static bool n_IsShowing (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowing;
		}
#pragma warning restore 0169

		public abstract bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "GetIsShowingHandler")] get;
		}

		static Delegate cb_isTitleTruncated;
#pragma warning disable 0169
		static Delegate GetIsTitleTruncatedHandler ()
		{
			if (cb_isTitleTruncated == null)
				cb_isTitleTruncated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTitleTruncated);
			return cb_isTitleTruncated;
		}

		static bool n_IsTitleTruncated (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTitleTruncated;
		}
#pragma warning restore 0169

		static IntPtr id_isTitleTruncated;
		public virtual unsafe bool IsTitleTruncated {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='isTitleTruncated' and count(parameter)=0]"
			[Register ("isTitleTruncated", "()Z", "GetIsTitleTruncatedHandler")]
			get {
				if (id_isTitleTruncated == IntPtr.Zero)
					id_isTitleTruncated = JNIEnv.GetMethodID (class_ref, "isTitleTruncated", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isTitleTruncated);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTitleTruncated", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNavigationItemCount;
#pragma warning disable 0169
		static Delegate GetGetNavigationItemCountHandler ()
		{
			if (cb_getNavigationItemCount == null)
				cb_getNavigationItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNavigationItemCount);
			return cb_getNavigationItemCount;
		}

		static int n_GetNavigationItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NavigationItemCount;
		}
#pragma warning restore 0169

		public abstract int NavigationItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getNavigationItemCount' and count(parameter)=0]"
			[Register ("getNavigationItemCount", "()I", "GetGetNavigationItemCountHandler")] get;
		}

		static Delegate cb_getNavigationMode;
#pragma warning disable 0169
		static Delegate GetGetNavigationModeHandler ()
		{
			if (cb_getNavigationMode == null)
				cb_getNavigationMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNavigationMode);
			return cb_getNavigationMode;
		}

		static int n_GetNavigationMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NavigationMode;
		}
#pragma warning restore 0169

		static Delegate cb_setNavigationMode_I;
#pragma warning disable 0169
		static Delegate GetSetNavigationMode_IHandler ()
		{
			if (cb_setNavigationMode_I == null)
				cb_setNavigationMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNavigationMode_I);
			return cb_setNavigationMode_I;
		}

		static void n_SetNavigationMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NavigationMode = p0;
		}
#pragma warning restore 0169

		public abstract int NavigationMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getNavigationMode' and count(parameter)=0]"
			[Register ("getNavigationMode", "()I", "GetGetNavigationModeHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setNavigationMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNavigationMode", "(I)V", "GetSetNavigationMode_IHandler")] set;
		}

		static Delegate cb_getSelectedNavigationIndex;
#pragma warning disable 0169
		static Delegate GetGetSelectedNavigationIndexHandler ()
		{
			if (cb_getSelectedNavigationIndex == null)
				cb_getSelectedNavigationIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedNavigationIndex);
			return cb_getSelectedNavigationIndex;
		}

		static int n_GetSelectedNavigationIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedNavigationIndex;
		}
#pragma warning restore 0169

		public abstract int SelectedNavigationIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getSelectedNavigationIndex' and count(parameter)=0]"
			[Register ("getSelectedNavigationIndex", "()I", "GetGetSelectedNavigationIndexHandler")] get;
		}

		static Delegate cb_getSelectedTab;
#pragma warning disable 0169
		static Delegate GetGetSelectedTabHandler ()
		{
			if (cb_getSelectedTab == null)
				cb_getSelectedTab = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedTab);
			return cb_getSelectedTab;
		}

		static IntPtr n_GetSelectedTab (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedTab);
		}
#pragma warning restore 0169

		public abstract global::Android.Support.V7.App.ActionBar.Tab SelectedTab {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getSelectedTab' and count(parameter)=0]"
			[Register ("getSelectedTab", "()Landroid/support/v7/app/ActionBar$Tab;", "GetGetSelectedTabHandler")] get;
		}

		static Delegate cb_getSubtitle;
#pragma warning disable 0169
		static Delegate GetGetSubtitleHandler ()
		{
			if (cb_getSubtitle == null)
				cb_getSubtitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubtitle);
			return cb_getSubtitle;
		}

		static IntPtr n_GetSubtitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.SubtitleFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setSubtitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetSubtitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setSubtitle_Ljava_lang_CharSequence_ == null)
				cb_setSubtitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubtitle_Ljava_lang_CharSequence_);
			return cb_setSubtitle_Ljava_lang_CharSequence_;
		}

		static void n_SetSubtitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubtitleFormatted = p0;
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.ICharSequence SubtitleFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getSubtitle' and count(parameter)=0]"
			[Register ("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setSubtitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")] set;
		}

		public string Subtitle {
			get { return SubtitleFormatted == null ? null : SubtitleFormatted.ToString (); }
			set {
				global::Java.Lang.String jls = value == null ? null : new global::Java.Lang.String (value);
				SubtitleFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_getTabCount;
#pragma warning disable 0169
		static Delegate GetGetTabCountHandler ()
		{
			if (cb_getTabCount == null)
				cb_getTabCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTabCount);
			return cb_getTabCount;
		}

		static int n_GetTabCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabCount;
		}
#pragma warning restore 0169

		public abstract int TabCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getTabCount' and count(parameter)=0]"
			[Register ("getTabCount", "()I", "GetGetTabCountHandler")] get;
		}

		static Delegate cb_getThemedContext;
#pragma warning disable 0169
		static Delegate GetGetThemedContextHandler ()
		{
			if (cb_getThemedContext == null)
				cb_getThemedContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThemedContext);
			return cb_getThemedContext;
		}

		static IntPtr n_GetThemedContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThemedContext);
		}
#pragma warning restore 0169

		static IntPtr id_getThemedContext;
		public virtual unsafe global::Android.Content.Context ThemedContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getThemedContext' and count(parameter)=0]"
			[Register ("getThemedContext", "()Landroid/content/Context;", "GetGetThemedContextHandler")]
			get {
				if (id_getThemedContext == IntPtr.Zero)
					id_getThemedContext = JNIEnv.GetMethodID (class_ref, "getThemedContext", "()Landroid/content/Context;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getThemedContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThemedContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TitleFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setTitle_Ljava_lang_CharSequence_ == null)
				cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_CharSequence_);
			return cb_setTitle_Ljava_lang_CharSequence_;
		}

		static void n_SetTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TitleFormatted = p0;
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.ICharSequence TitleFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")] set;
		}

		public string Title {
			get { return TitleFormatted == null ? null : TitleFormatted.ToString (); }
			set {
				global::Java.Lang.String jls = value == null ? null : new global::Java.Lang.String (value);
				TitleFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
#pragma warning disable 0169
		static Delegate GetAddOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_Handler ()
		{
			if (cb_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ == null)
				cb_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_);
			return cb_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
		}

		static void n_AddOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener p0 = (global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener)global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOnMenuVisibilityListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='addOnMenuVisibilityListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.OnMenuVisibilityListener']]"
		[Register ("addOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V", "GetAddOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public abstract void AddOnMenuVisibilityListener (global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener p0);

		static Delegate cb_addTab_Landroid_support_v7_app_ActionBar_Tab_;
#pragma warning disable 0169
		static Delegate GetAddTab_Landroid_support_v7_app_ActionBar_Tab_Handler ()
		{
			if (cb_addTab_Landroid_support_v7_app_ActionBar_Tab_ == null)
				cb_addTab_Landroid_support_v7_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTab_Landroid_support_v7_app_ActionBar_Tab_);
			return cb_addTab_Landroid_support_v7_app_ActionBar_Tab_;
		}

		static void n_AddTab_Landroid_support_v7_app_ActionBar_Tab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='addTab' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.Tab']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_Handler")]
		public abstract void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0);

		static Delegate cb_addTab_Landroid_support_v7_app_ActionBar_Tab_Z;
#pragma warning disable 0169
		static Delegate GetAddTab_Landroid_support_v7_app_ActionBar_Tab_ZHandler ()
		{
			if (cb_addTab_Landroid_support_v7_app_ActionBar_Tab_Z == null)
				cb_addTab_Landroid_support_v7_app_ActionBar_Tab_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_AddTab_Landroid_support_v7_app_ActionBar_Tab_Z);
			return cb_addTab_Landroid_support_v7_app_ActionBar_Tab_Z;
		}

		static void n_AddTab_Landroid_support_v7_app_ActionBar_Tab_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='addTab' and count(parameter)=2 and parameter[1][@type='android.support.v7.app.ActionBar.Tab'] and parameter[2][@type='boolean']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;Z)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_ZHandler")]
		public abstract void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0, bool p1);

		static Delegate cb_addTab_Landroid_support_v7_app_ActionBar_Tab_I;
#pragma warning disable 0169
		static Delegate GetAddTab_Landroid_support_v7_app_ActionBar_Tab_IHandler ()
		{
			if (cb_addTab_Landroid_support_v7_app_ActionBar_Tab_I == null)
				cb_addTab_Landroid_support_v7_app_ActionBar_Tab_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AddTab_Landroid_support_v7_app_ActionBar_Tab_I);
			return cb_addTab_Landroid_support_v7_app_ActionBar_Tab_I;
		}

		static void n_AddTab_Landroid_support_v7_app_ActionBar_Tab_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='addTab' and count(parameter)=2 and parameter[1][@type='android.support.v7.app.ActionBar.Tab'] and parameter[2][@type='int']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;I)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_IHandler")]
		public abstract void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0, int p1);

		static Delegate cb_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ;
#pragma warning disable 0169
		static Delegate GetAddTab_Landroid_support_v7_app_ActionBar_Tab_IZHandler ()
		{
			if (cb_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ == null)
				cb_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_AddTab_Landroid_support_v7_app_ActionBar_Tab_IZ);
			return cb_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ;
		}

		static void n_AddTab_Landroid_support_v7_app_ActionBar_Tab_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTab (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='addTab' and count(parameter)=3 and parameter[1][@type='android.support.v7.app.ActionBar.Tab'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;IZ)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_IZHandler")]
		public abstract void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0, int p1, bool p2);

		static Delegate cb_collapseActionView;
#pragma warning disable 0169
		static Delegate GetCollapseActionViewHandler ()
		{
			if (cb_collapseActionView == null)
				cb_collapseActionView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CollapseActionView);
			return cb_collapseActionView;
		}

		static bool n_CollapseActionView (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CollapseActionView ();
		}
#pragma warning restore 0169

		static IntPtr id_collapseActionView;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='collapseActionView' and count(parameter)=0]"
		[Register ("collapseActionView", "()Z", "GetCollapseActionViewHandler")]
		public virtual unsafe bool CollapseActionView ()
		{
			if (id_collapseActionView == IntPtr.Zero)
				id_collapseActionView = JNIEnv.GetMethodID (class_ref, "collapseActionView", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_collapseActionView);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "collapseActionView", "()Z"));
			} finally {
			}
		}

		static Delegate cb_dispatchMenuVisibilityChanged_Z;
#pragma warning disable 0169
		static Delegate GetDispatchMenuVisibilityChanged_ZHandler ()
		{
			if (cb_dispatchMenuVisibilityChanged_Z == null)
				cb_dispatchMenuVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_DispatchMenuVisibilityChanged_Z);
			return cb_dispatchMenuVisibilityChanged_Z;
		}

		static void n_DispatchMenuVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchMenuVisibilityChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchMenuVisibilityChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='dispatchMenuVisibilityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("dispatchMenuVisibilityChanged", "(Z)V", "GetDispatchMenuVisibilityChanged_ZHandler")]
		public virtual unsafe void DispatchMenuVisibilityChanged (bool p0)
		{
			if (id_dispatchMenuVisibilityChanged_Z == IntPtr.Zero)
				id_dispatchMenuVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "dispatchMenuVisibilityChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dispatchMenuVisibilityChanged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchMenuVisibilityChanged", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getTabAt_I;
#pragma warning disable 0169
		static Delegate GetGetTabAt_IHandler ()
		{
			if (cb_getTabAt_I == null)
				cb_getTabAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTabAt_I);
			return cb_getTabAt_I;
		}

		static IntPtr n_GetTabAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTabAt (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getTabAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTabAt", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetGetTabAt_IHandler")]
		public abstract global::Android.Support.V7.App.ActionBar.Tab GetTabAt (int p0);

		static Delegate cb_hide;
#pragma warning disable 0169
		static Delegate GetHideHandler ()
		{
			if (cb_hide == null)
				cb_hide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Hide);
			return cb_hide;
		}

		static void n_Hide (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "GetHideHandler")]
		public abstract void Hide ();

		static Delegate cb_invalidateOptionsMenu;
#pragma warning disable 0169
		static Delegate GetInvalidateOptionsMenuHandler ()
		{
			if (cb_invalidateOptionsMenu == null)
				cb_invalidateOptionsMenu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_InvalidateOptionsMenu);
			return cb_invalidateOptionsMenu;
		}

		static bool n_InvalidateOptionsMenu (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvalidateOptionsMenu ();
		}
#pragma warning restore 0169

		static IntPtr id_invalidateOptionsMenu;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='invalidateOptionsMenu' and count(parameter)=0]"
		[Register ("invalidateOptionsMenu", "()Z", "GetInvalidateOptionsMenuHandler")]
		public virtual unsafe bool InvalidateOptionsMenu ()
		{
			if (id_invalidateOptionsMenu == IntPtr.Zero)
				id_invalidateOptionsMenu = JNIEnv.GetMethodID (class_ref, "invalidateOptionsMenu", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_invalidateOptionsMenu);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidateOptionsMenu", "()Z"));
			} finally {
			}
		}

		static Delegate cb_newTab;
#pragma warning disable 0169
		static Delegate GetNewTabHandler ()
		{
			if (cb_newTab == null)
				cb_newTab = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewTab);
			return cb_newTab;
		}

		static IntPtr n_NewTab (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewTab ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='newTab' and count(parameter)=0]"
		[Register ("newTab", "()Landroid/support/v7/app/ActionBar$Tab;", "GetNewTabHandler")]
		public abstract global::Android.Support.V7.App.ActionBar.Tab NewTab ();

		static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
				cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfigurationChanged_Landroid_content_res_Configuration_);
			return cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		static void n_OnConfigurationChanged_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfigurationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='onConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public virtual unsafe void OnConfigurationChanged (global::Android.Content.Res.Configuration p0)
		{
			if (id_onConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_onConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onConfigurationChanged_Landroid_content_res_Configuration_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onKeyShortcut_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKeyShortcut_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKeyShortcut_ILandroid_view_KeyEvent_ == null)
				cb_onKeyShortcut_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnKeyShortcut_ILandroid_view_KeyEvent_);
			return cb_onKeyShortcut_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKeyShortcut_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyShortcut (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyShortcut_ILandroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='onKeyShortcut' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyShortcut_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnKeyShortcut (int p0, global::Android.Views.KeyEvent p1)
		{
			if (id_onKeyShortcut_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_onKeyShortcut_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onKeyShortcut_ILandroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyShortcut", "(ILandroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onMenuKeyEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnMenuKeyEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_onMenuKeyEvent_Landroid_view_KeyEvent_ == null)
				cb_onMenuKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMenuKeyEvent_Landroid_view_KeyEvent_);
			return cb_onMenuKeyEvent_Landroid_view_KeyEvent_;
		}

		static bool n_OnMenuKeyEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuKeyEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onMenuKeyEvent_Landroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='onMenuKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("onMenuKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetOnMenuKeyEvent_Landroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnMenuKeyEvent (global::Android.Views.KeyEvent p0)
		{
			if (id_onMenuKeyEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_onMenuKeyEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onMenuKeyEvent", "(Landroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onMenuKeyEvent_Landroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMenuKeyEvent", "(Landroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_openOptionsMenu;
#pragma warning disable 0169
		static Delegate GetOpenOptionsMenuHandler ()
		{
			if (cb_openOptionsMenu == null)
				cb_openOptionsMenu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OpenOptionsMenu);
			return cb_openOptionsMenu;
		}

		static bool n_OpenOptionsMenu (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpenOptionsMenu ();
		}
#pragma warning restore 0169

		static IntPtr id_openOptionsMenu;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='openOptionsMenu' and count(parameter)=0]"
		[Register ("openOptionsMenu", "()Z", "GetOpenOptionsMenuHandler")]
		public virtual unsafe bool OpenOptionsMenu ()
		{
			if (id_openOptionsMenu == IntPtr.Zero)
				id_openOptionsMenu = JNIEnv.GetMethodID (class_ref, "openOptionsMenu", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_openOptionsMenu);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openOptionsMenu", "()Z"));
			} finally {
			}
		}

		static Delegate cb_removeAllTabs;
#pragma warning disable 0169
		static Delegate GetRemoveAllTabsHandler ()
		{
			if (cb_removeAllTabs == null)
				cb_removeAllTabs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllTabs);
			return cb_removeAllTabs;
		}

		static void n_RemoveAllTabs (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllTabs ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='removeAllTabs' and count(parameter)=0]"
		[Register ("removeAllTabs", "()V", "GetRemoveAllTabsHandler")]
		public abstract void RemoveAllTabs ();

		static Delegate cb_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_Handler ()
		{
			if (cb_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ == null)
				cb_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_);
			return cb_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
		}

		static void n_RemoveOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener p0 = (global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener)global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnMenuVisibilityListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='removeOnMenuVisibilityListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.OnMenuVisibilityListener']]"
		[Register ("removeOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V", "GetRemoveOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public abstract void RemoveOnMenuVisibilityListener (global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener p0);

		static Delegate cb_removeTab_Landroid_support_v7_app_ActionBar_Tab_;
#pragma warning disable 0169
		static Delegate GetRemoveTab_Landroid_support_v7_app_ActionBar_Tab_Handler ()
		{
			if (cb_removeTab_Landroid_support_v7_app_ActionBar_Tab_ == null)
				cb_removeTab_Landroid_support_v7_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveTab_Landroid_support_v7_app_ActionBar_Tab_);
			return cb_removeTab_Landroid_support_v7_app_ActionBar_Tab_;
		}

		static void n_RemoveTab_Landroid_support_v7_app_ActionBar_Tab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTab (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='removeTab' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.Tab']]"
		[Register ("removeTab", "(Landroid/support/v7/app/ActionBar$Tab;)V", "GetRemoveTab_Landroid_support_v7_app_ActionBar_Tab_Handler")]
		public abstract void RemoveTab (global::Android.Support.V7.App.ActionBar.Tab p0);

		static Delegate cb_removeTabAt_I;
#pragma warning disable 0169
		static Delegate GetRemoveTabAt_IHandler ()
		{
			if (cb_removeTabAt_I == null)
				cb_removeTabAt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveTabAt_I);
			return cb_removeTabAt_I;
		}

		static void n_RemoveTabAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTabAt (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='removeTabAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeTabAt", "(I)V", "GetRemoveTabAt_IHandler")]
		public abstract void RemoveTabAt (int p0);

		static Delegate cb_selectTab_Landroid_support_v7_app_ActionBar_Tab_;
#pragma warning disable 0169
		static Delegate GetSelectTab_Landroid_support_v7_app_ActionBar_Tab_Handler ()
		{
			if (cb_selectTab_Landroid_support_v7_app_ActionBar_Tab_ == null)
				cb_selectTab_Landroid_support_v7_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SelectTab_Landroid_support_v7_app_ActionBar_Tab_);
			return cb_selectTab_Landroid_support_v7_app_ActionBar_Tab_;
		}

		static void n_SelectTab_Landroid_support_v7_app_ActionBar_Tab_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.Tab p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectTab (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='selectTab' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.Tab']]"
		[Register ("selectTab", "(Landroid/support/v7/app/ActionBar$Tab;)V", "GetSelectTab_Landroid_support_v7_app_ActionBar_Tab_Handler")]
		public abstract void SelectTab (global::Android.Support.V7.App.ActionBar.Tab p0);

		static Delegate cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackgroundDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetBackgroundDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundDrawable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setBackgroundDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void SetBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0);

		static Delegate cb_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetSetCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_Handler ()
		{
			if (cb_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_ == null)
				cb_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_);
			return cb_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_;
		}

		static void n_SetCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.LayoutParams p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.LayoutParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomView (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setCustomView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.support.v7.app.ActionBar.LayoutParams']]"
		[Register ("setCustomView", "(Landroid/view/View;Landroid/support/v7/app/ActionBar$LayoutParams;)V", "GetSetCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_Handler")]
		public abstract void SetCustomView (global::Android.Views.View p0, global::Android.Support.V7.App.ActionBar.LayoutParams p1);

		static Delegate cb_setCustomView_I;
#pragma warning disable 0169
		static Delegate GetSetCustomView_IHandler ()
		{
			if (cb_setCustomView_I == null)
				cb_setCustomView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCustomView_I);
			return cb_setCustomView_I;
		}

		static void n_SetCustomView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomView (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCustomView", "(I)V", "GetSetCustomView_IHandler")]
		public abstract void SetCustomView (int p0);

		static Delegate cb_setDefaultDisplayHomeAsUpEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDefaultDisplayHomeAsUpEnabled_ZHandler ()
		{
			if (cb_setDefaultDisplayHomeAsUpEnabled_Z == null)
				cb_setDefaultDisplayHomeAsUpEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDefaultDisplayHomeAsUpEnabled_Z);
			return cb_setDefaultDisplayHomeAsUpEnabled_Z;
		}

		static void n_SetDefaultDisplayHomeAsUpEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultDisplayHomeAsUpEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultDisplayHomeAsUpEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDefaultDisplayHomeAsUpEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDefaultDisplayHomeAsUpEnabled", "(Z)V", "GetSetDefaultDisplayHomeAsUpEnabled_ZHandler")]
		public virtual unsafe void SetDefaultDisplayHomeAsUpEnabled (bool p0)
		{
			if (id_setDefaultDisplayHomeAsUpEnabled_Z == IntPtr.Zero)
				id_setDefaultDisplayHomeAsUpEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDefaultDisplayHomeAsUpEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDefaultDisplayHomeAsUpEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultDisplayHomeAsUpEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayHomeAsUpEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayHomeAsUpEnabled_ZHandler ()
		{
			if (cb_setDisplayHomeAsUpEnabled_Z == null)
				cb_setDisplayHomeAsUpEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayHomeAsUpEnabled_Z);
			return cb_setDisplayHomeAsUpEnabled_Z;
		}

		static void n_SetDisplayHomeAsUpEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayHomeAsUpEnabled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayHomeAsUpEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayHomeAsUpEnabled", "(Z)V", "GetSetDisplayHomeAsUpEnabled_ZHandler")]
		public abstract void SetDisplayHomeAsUpEnabled (bool p0);

		static Delegate cb_setDisplayOptions_II;
#pragma warning disable 0169
		static Delegate GetSetDisplayOptions_IIHandler ()
		{
			if (cb_setDisplayOptions_II == null)
				cb_setDisplayOptions_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetDisplayOptions_II);
			return cb_setDisplayOptions_II;
		}

		static void n_SetDisplayOptions_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayOptions (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayOptions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDisplayOptions", "(II)V", "GetSetDisplayOptions_IIHandler")]
		public abstract void SetDisplayOptions ([global::Android.Runtime.IntDef (Flag = true, Type = "Android.Support.V7.App.ActionBar", Fields = new string [] {"DisplayUseLogo", "DisplayShowHome", "DisplayHomeAsUp", "DisplayShowTitle", "DisplayShowCustom"})]int p0, [global::Android.Runtime.IntDef (Flag = true, Type = "Android.Support.V7.App.ActionBar", Fields = new string [] {"DisplayUseLogo", "DisplayShowHome", "DisplayHomeAsUp", "DisplayShowTitle", "DisplayShowCustom"})]int p1);

		static Delegate cb_setDisplayShowCustomEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayShowCustomEnabled_ZHandler ()
		{
			if (cb_setDisplayShowCustomEnabled_Z == null)
				cb_setDisplayShowCustomEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayShowCustomEnabled_Z);
			return cb_setDisplayShowCustomEnabled_Z;
		}

		static void n_SetDisplayShowCustomEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayShowCustomEnabled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayShowCustomEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayShowCustomEnabled", "(Z)V", "GetSetDisplayShowCustomEnabled_ZHandler")]
		public abstract void SetDisplayShowCustomEnabled (bool p0);

		static Delegate cb_setDisplayShowHomeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayShowHomeEnabled_ZHandler ()
		{
			if (cb_setDisplayShowHomeEnabled_Z == null)
				cb_setDisplayShowHomeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayShowHomeEnabled_Z);
			return cb_setDisplayShowHomeEnabled_Z;
		}

		static void n_SetDisplayShowHomeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayShowHomeEnabled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayShowHomeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayShowHomeEnabled", "(Z)V", "GetSetDisplayShowHomeEnabled_ZHandler")]
		public abstract void SetDisplayShowHomeEnabled (bool p0);

		static Delegate cb_setDisplayShowTitleEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayShowTitleEnabled_ZHandler ()
		{
			if (cb_setDisplayShowTitleEnabled_Z == null)
				cb_setDisplayShowTitleEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayShowTitleEnabled_Z);
			return cb_setDisplayShowTitleEnabled_Z;
		}

		static void n_SetDisplayShowTitleEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayShowTitleEnabled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayShowTitleEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayShowTitleEnabled", "(Z)V", "GetSetDisplayShowTitleEnabled_ZHandler")]
		public abstract void SetDisplayShowTitleEnabled (bool p0);

		static Delegate cb_setDisplayUseLogoEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayUseLogoEnabled_ZHandler ()
		{
			if (cb_setDisplayUseLogoEnabled_Z == null)
				cb_setDisplayUseLogoEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayUseLogoEnabled_Z);
			return cb_setDisplayUseLogoEnabled_Z;
		}

		static void n_SetDisplayUseLogoEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayUseLogoEnabled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayUseLogoEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayUseLogoEnabled", "(Z)V", "GetSetDisplayUseLogoEnabled_ZHandler")]
		public abstract void SetDisplayUseLogoEnabled (bool p0);

		static Delegate cb_setHomeActionContentDescription_I;
#pragma warning disable 0169
		static Delegate GetSetHomeActionContentDescription_IHandler ()
		{
			if (cb_setHomeActionContentDescription_I == null)
				cb_setHomeActionContentDescription_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHomeActionContentDescription_I);
			return cb_setHomeActionContentDescription_I;
		}

		static void n_SetHomeActionContentDescription_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHomeActionContentDescription (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHomeActionContentDescription_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setHomeActionContentDescription' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHomeActionContentDescription", "(I)V", "GetSetHomeActionContentDescription_IHandler")]
		public virtual unsafe void SetHomeActionContentDescription (int p0)
		{
			if (id_setHomeActionContentDescription_I == IntPtr.Zero)
				id_setHomeActionContentDescription_I = JNIEnv.GetMethodID (class_ref, "setHomeActionContentDescription", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHomeActionContentDescription_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHomeActionContentDescription", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHomeActionContentDescription_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetHomeActionContentDescription_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setHomeActionContentDescription_Ljava_lang_CharSequence_ == null)
				cb_setHomeActionContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHomeActionContentDescription_Ljava_lang_CharSequence_);
			return cb_setHomeActionContentDescription_Ljava_lang_CharSequence_;
		}

		static void n_SetHomeActionContentDescription_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHomeActionContentDescription (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHomeActionContentDescription_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setHomeActionContentDescription' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setHomeActionContentDescription", "(Ljava/lang/CharSequence;)V", "GetSetHomeActionContentDescription_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe void SetHomeActionContentDescription (global::Java.Lang.ICharSequence p0)
		{
			if (id_setHomeActionContentDescription_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setHomeActionContentDescription_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setHomeActionContentDescription", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHomeActionContentDescription_Ljava_lang_CharSequence_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHomeActionContentDescription", "(Ljava/lang/CharSequence;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void SetHomeActionContentDescription (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			SetHomeActionContentDescription (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_ == null)
				cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_);
			return cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHomeAsUpIndicator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setHomeAsUpIndicator' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setHomeAsUpIndicator", "(Landroid/graphics/drawable/Drawable;)V", "GetSetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetHomeAsUpIndicator (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setHomeAsUpIndicator", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHomeAsUpIndicator", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHomeAsUpIndicator_I;
#pragma warning disable 0169
		static Delegate GetSetHomeAsUpIndicator_IHandler ()
		{
			if (cb_setHomeAsUpIndicator_I == null)
				cb_setHomeAsUpIndicator_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHomeAsUpIndicator_I);
			return cb_setHomeAsUpIndicator_I;
		}

		static void n_SetHomeAsUpIndicator_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHomeAsUpIndicator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHomeAsUpIndicator_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setHomeAsUpIndicator' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHomeAsUpIndicator", "(I)V", "GetSetHomeAsUpIndicator_IHandler")]
		public virtual unsafe void SetHomeAsUpIndicator (int p0)
		{
			if (id_setHomeAsUpIndicator_I == IntPtr.Zero)
				id_setHomeAsUpIndicator_I = JNIEnv.GetMethodID (class_ref, "setHomeAsUpIndicator", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHomeAsUpIndicator_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHomeAsUpIndicator", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHomeButtonEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHomeButtonEnabled_ZHandler ()
		{
			if (cb_setHomeButtonEnabled_Z == null)
				cb_setHomeButtonEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHomeButtonEnabled_Z);
			return cb_setHomeButtonEnabled_Z;
		}

		static void n_SetHomeButtonEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHomeButtonEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHomeButtonEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setHomeButtonEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHomeButtonEnabled", "(Z)V", "GetSetHomeButtonEnabled_ZHandler")]
		public virtual unsafe void SetHomeButtonEnabled (bool p0)
		{
			if (id_setHomeButtonEnabled_Z == IntPtr.Zero)
				id_setHomeButtonEnabled_Z = JNIEnv.GetMethodID (class_ref, "setHomeButtonEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHomeButtonEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHomeButtonEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void SetIcon (global::Android.Graphics.Drawables.Drawable p0);

		static Delegate cb_setIcon_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_IHandler ()
		{
			if (cb_setIcon_I == null)
				cb_setIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIcon_I);
			return cb_setIcon_I;
		}

		static void n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIcon", "(I)V", "GetSetIcon_IHandler")]
		public abstract void SetIcon (int p0);

		static Delegate cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_;
#pragma warning disable 0169
		static Delegate GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_Handler ()
		{
			if (cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_ == null)
				cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_);
			return cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_;
		}

		static void n_SetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ISpinnerAdapter p0 = (global::Android.Widget.ISpinnerAdapter)global::Java.Lang.Object.GetObject<global::Android.Widget.ISpinnerAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.App.ActionBar.IOnNavigationListener p1 = (global::Android.Support.V7.App.ActionBar.IOnNavigationListener)global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.IOnNavigationListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetListNavigationCallbacks (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setListNavigationCallbacks' and count(parameter)=2 and parameter[1][@type='android.widget.SpinnerAdapter'] and parameter[2][@type='android.support.v7.app.ActionBar.OnNavigationListener']]"
		[Register ("setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Landroid/support/v7/app/ActionBar$OnNavigationListener;)V", "GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_Handler")]
		public abstract void SetListNavigationCallbacks (global::Android.Widget.ISpinnerAdapter p0, global::Android.Support.V7.App.ActionBar.IOnNavigationListener p1);

		static Delegate cb_setLogo_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetLogo_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setLogo_Landroid_graphics_drawable_Drawable_ == null)
				cb_setLogo_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLogo_Landroid_graphics_drawable_Drawable_);
			return cb_setLogo_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetLogo_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLogo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setLogo' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setLogo", "(Landroid/graphics/drawable/Drawable;)V", "GetSetLogo_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void SetLogo (global::Android.Graphics.Drawables.Drawable p0);

		static Delegate cb_setLogo_I;
#pragma warning disable 0169
		static Delegate GetSetLogo_IHandler ()
		{
			if (cb_setLogo_I == null)
				cb_setLogo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLogo_I);
			return cb_setLogo_I;
		}

		static void n_SetLogo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setLogo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogo", "(I)V", "GetSetLogo_IHandler")]
		public abstract void SetLogo (int p0);

		static Delegate cb_setSelectedNavigationItem_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedNavigationItem_IHandler ()
		{
			if (cb_setSelectedNavigationItem_I == null)
				cb_setSelectedNavigationItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedNavigationItem_I);
			return cb_setSelectedNavigationItem_I;
		}

		static void n_SetSelectedNavigationItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectedNavigationItem (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setSelectedNavigationItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectedNavigationItem", "(I)V", "GetSetSelectedNavigationItem_IHandler")]
		public abstract void SetSelectedNavigationItem (int p0);

		static Delegate cb_setShowHideAnimationEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetShowHideAnimationEnabled_ZHandler ()
		{
			if (cb_setShowHideAnimationEnabled_Z == null)
				cb_setShowHideAnimationEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowHideAnimationEnabled_Z);
			return cb_setShowHideAnimationEnabled_Z;
		}

		static void n_SetShowHideAnimationEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowHideAnimationEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowHideAnimationEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setShowHideAnimationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowHideAnimationEnabled", "(Z)V", "GetSetShowHideAnimationEnabled_ZHandler")]
		public virtual unsafe void SetShowHideAnimationEnabled (bool p0)
		{
			if (id_setShowHideAnimationEnabled_Z == IntPtr.Zero)
				id_setShowHideAnimationEnabled_Z = JNIEnv.GetMethodID (class_ref, "setShowHideAnimationEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setShowHideAnimationEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowHideAnimationEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSplitBackgroundDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setSplitBackgroundDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setSplitBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetSplitBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setSplitBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSplitBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStackedBackgroundDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setStackedBackgroundDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setStackedBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetStackedBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setStackedBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStackedBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSubtitle_I;
#pragma warning disable 0169
		static Delegate GetSetSubtitle_IHandler ()
		{
			if (cb_setSubtitle_I == null)
				cb_setSubtitle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSubtitle_I);
			return cb_setSubtitle_I;
		}

		static void n_SetSubtitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSubtitle (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setSubtitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSubtitle", "(I)V", "GetSetSubtitle_IHandler")]
		public abstract void SetSubtitle (int p0);

		static Delegate cb_setTitle_I;
#pragma warning disable 0169
		static Delegate GetSetTitle_IHandler ()
		{
			if (cb_setTitle_I == null)
				cb_setTitle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTitle_I);
			return cb_setTitle_I;
		}

		static void n_SetTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public abstract void SetTitle (int p0);

		static Delegate cb_setWindowTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetWindowTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setWindowTitle_Ljava_lang_CharSequence_ == null)
				cb_setWindowTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWindowTitle_Ljava_lang_CharSequence_);
			return cb_setWindowTitle_Ljava_lang_CharSequence_;
		}

		static void n_SetWindowTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWindowTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWindowTitle_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setWindowTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setWindowTitle", "(Ljava/lang/CharSequence;)V", "GetSetWindowTitle_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe void SetWindowTitle (global::Java.Lang.ICharSequence p0)
		{
			if (id_setWindowTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setWindowTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setWindowTitle", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWindowTitle_Ljava_lang_CharSequence_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWindowTitle", "(Ljava/lang/CharSequence;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void SetWindowTitle (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			SetWindowTitle (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public abstract void Show ();

		static Delegate cb_startActionMode_Landroid_support_v7_view_ActionMode_Callback_;
#pragma warning disable 0169
		static Delegate GetStartActionMode_Landroid_support_v7_view_ActionMode_Callback_Handler ()
		{
			if (cb_startActionMode_Landroid_support_v7_view_ActionMode_Callback_ == null)
				cb_startActionMode_Landroid_support_v7_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActionMode_Landroid_support_v7_view_ActionMode_Callback_);
			return cb_startActionMode_Landroid_support_v7_view_ActionMode_Callback_;
		}

		static IntPtr n_StartActionMode_Landroid_support_v7_view_ActionMode_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.ActionBar __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.View.ActionMode.ICallback p0 = (global::Android.Support.V7.View.ActionMode.ICallback)global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartActionMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startActionMode_Landroid_support_v7_view_ActionMode_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='startActionMode' and count(parameter)=1 and parameter[1][@type='android.support.v7.view.ActionMode.Callback']]"
		[Register ("startActionMode", "(Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;", "GetStartActionMode_Landroid_support_v7_view_ActionMode_Callback_Handler")]
		public virtual unsafe global::Android.Support.V7.View.ActionMode StartActionMode (global::Android.Support.V7.View.ActionMode.ICallback p0)
		{
			if (id_startActionMode_Landroid_support_v7_view_ActionMode_Callback_ == IntPtr.Zero)
				id_startActionMode_Landroid_support_v7_view_ActionMode_Callback_ = JNIEnv.GetMethodID (class_ref, "startActionMode", "(Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Support.V7.View.ActionMode __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (JNIEnv.CallObjectMethod  (Handle, id_startActionMode_Landroid_support_v7_view_ActionMode_Callback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startActionMode", "(Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

#region "Event implementation for Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener"
		public event EventHandler<global::Android.Support.V7.App.ActionBar.MenuVisibilityEventArgs> MenuVisibility {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener, global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListenerImplementor>(
						ref weak_implementor_AddOnMenuVisibilityListener,
						__CreateIOnMenuVisibilityListenerImplementor,
						AddOnMenuVisibilityListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener, global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListenerImplementor>(
						ref weak_implementor_AddOnMenuVisibilityListener,
						global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListenerImplementor.__IsEmpty,
						RemoveOnMenuVisibilityListener,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnMenuVisibilityListener;

		global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListenerImplementor __CreateIOnMenuVisibilityListenerImplementor ()
		{
			return new global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("android/support/v7/app/ActionBar", DoNotGenerateAcw=true)]
	internal partial class ActionBarInvoker : ActionBar {

		public ActionBarInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBarInvoker); }
		}

		static IntPtr id_getCustomView;
		static IntPtr id_setCustomView_Landroid_view_View_;
		public override unsafe global::Android.Views.View CustomView {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getCustomView' and count(parameter)=0]"
			[Register ("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")]
			get {
				if (id_getCustomView == IntPtr.Zero)
					id_getCustomView = JNIEnv.GetMethodID (class_ref, "getCustomView", "()Landroid/view/View;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getCustomView), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler")]
			set {
				if (id_setCustomView_Landroid_view_View_ == IntPtr.Zero)
					id_setCustomView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setCustomView", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setCustomView_Landroid_view_View_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getDisplayOptions;
		static IntPtr id_setDisplayOptions_I;
		public override unsafe int DisplayOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getDisplayOptions' and count(parameter)=0]"
			[Register ("getDisplayOptions", "()I", "GetGetDisplayOptionsHandler")]
			get {
				if (id_getDisplayOptions == IntPtr.Zero)
					id_getDisplayOptions = JNIEnv.GetMethodID (class_ref, "getDisplayOptions", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getDisplayOptions);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayOptions' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisplayOptions", "(I)V", "GetSetDisplayOptions_IHandler")]
			set {
				if (id_setDisplayOptions_I == IntPtr.Zero)
					id_setDisplayOptions_I = JNIEnv.GetMethodID (class_ref, "setDisplayOptions", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setDisplayOptions_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getHeight;
		public override unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getHeight);
				} finally {
				}
			}
		}

		static IntPtr id_isShowing;
		public override unsafe bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "GetIsShowingHandler")]
			get {
				if (id_isShowing == IntPtr.Zero)
					id_isShowing = JNIEnv.GetMethodID (class_ref, "isShowing", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isShowing);
				} finally {
				}
			}
		}

		static IntPtr id_getNavigationItemCount;
		public override unsafe int NavigationItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getNavigationItemCount' and count(parameter)=0]"
			[Register ("getNavigationItemCount", "()I", "GetGetNavigationItemCountHandler")]
			get {
				if (id_getNavigationItemCount == IntPtr.Zero)
					id_getNavigationItemCount = JNIEnv.GetMethodID (class_ref, "getNavigationItemCount", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getNavigationItemCount);
				} finally {
				}
			}
		}

		static IntPtr id_getNavigationMode;
		static IntPtr id_setNavigationMode_I;
		public override unsafe int NavigationMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getNavigationMode' and count(parameter)=0]"
			[Register ("getNavigationMode", "()I", "GetGetNavigationModeHandler")]
			get {
				if (id_getNavigationMode == IntPtr.Zero)
					id_getNavigationMode = JNIEnv.GetMethodID (class_ref, "getNavigationMode", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getNavigationMode);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setNavigationMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNavigationMode", "(I)V", "GetSetNavigationMode_IHandler")]
			set {
				if (id_setNavigationMode_I == IntPtr.Zero)
					id_setNavigationMode_I = JNIEnv.GetMethodID (class_ref, "setNavigationMode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setNavigationMode_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSelectedNavigationIndex;
		public override unsafe int SelectedNavigationIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getSelectedNavigationIndex' and count(parameter)=0]"
			[Register ("getSelectedNavigationIndex", "()I", "GetGetSelectedNavigationIndexHandler")]
			get {
				if (id_getSelectedNavigationIndex == IntPtr.Zero)
					id_getSelectedNavigationIndex = JNIEnv.GetMethodID (class_ref, "getSelectedNavigationIndex", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSelectedNavigationIndex);
				} finally {
				}
			}
		}

		static IntPtr id_getSelectedTab;
		public override unsafe global::Android.Support.V7.App.ActionBar.Tab SelectedTab {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getSelectedTab' and count(parameter)=0]"
			[Register ("getSelectedTab", "()Landroid/support/v7/app/ActionBar$Tab;", "GetGetSelectedTabHandler")]
			get {
				if (id_getSelectedTab == IntPtr.Zero)
					id_getSelectedTab = JNIEnv.GetMethodID (class_ref, "getSelectedTab", "()Landroid/support/v7/app/ActionBar$Tab;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_getSelectedTab), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSubtitle;
		static IntPtr id_setSubtitle_Ljava_lang_CharSequence_;
		public override unsafe global::Java.Lang.ICharSequence SubtitleFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getSubtitle' and count(parameter)=0]"
			[Register ("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler")]
			get {
				if (id_getSubtitle == IntPtr.Zero)
					id_getSubtitle = JNIEnv.GetMethodID (class_ref, "getSubtitle", "()Ljava/lang/CharSequence;");
				try {
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getSubtitle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setSubtitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")]
			set {
				if (id_setSubtitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setSubtitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setSubtitle", "(Ljava/lang/CharSequence;)V");
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setSubtitle_Ljava_lang_CharSequence_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getTabCount;
		public override unsafe int TabCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getTabCount' and count(parameter)=0]"
			[Register ("getTabCount", "()I", "GetGetTabCountHandler")]
			get {
				if (id_getTabCount == IntPtr.Zero)
					id_getTabCount = JNIEnv.GetMethodID (class_ref, "getTabCount", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getTabCount);
				} finally {
				}
			}
		}

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_CharSequence_;
		public override unsafe global::Java.Lang.ICharSequence TitleFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/CharSequence;");
				try {
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			set {
				if (id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/CharSequence;)V");
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_CharSequence_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='addOnMenuVisibilityListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.OnMenuVisibilityListener']]"
		[Register ("addOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V", "GetAddOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public override unsafe void AddOnMenuVisibilityListener (global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener p0)
		{
			if (id_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ == IntPtr.Zero)
				id_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ = JNIEnv.GetMethodID (class_ref, "addOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_addOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_, __args);
			} finally {
			}
		}

		static IntPtr id_addTab_Landroid_support_v7_app_ActionBar_Tab_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='addTab' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.Tab']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_Handler")]
		public override unsafe void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0)
		{
			if (id_addTab_Landroid_support_v7_app_ActionBar_Tab_ == IntPtr.Zero)
				id_addTab_Landroid_support_v7_app_ActionBar_Tab_ = JNIEnv.GetMethodID (class_ref, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_addTab_Landroid_support_v7_app_ActionBar_Tab_, __args);
			} finally {
			}
		}

		static IntPtr id_addTab_Landroid_support_v7_app_ActionBar_Tab_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='addTab' and count(parameter)=2 and parameter[1][@type='android.support.v7.app.ActionBar.Tab'] and parameter[2][@type='boolean']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;Z)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_ZHandler")]
		public override unsafe void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0, bool p1)
		{
			if (id_addTab_Landroid_support_v7_app_ActionBar_Tab_Z == IntPtr.Zero)
				id_addTab_Landroid_support_v7_app_ActionBar_Tab_Z = JNIEnv.GetMethodID (class_ref, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_addTab_Landroid_support_v7_app_ActionBar_Tab_Z, __args);
			} finally {
			}
		}

		static IntPtr id_addTab_Landroid_support_v7_app_ActionBar_Tab_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='addTab' and count(parameter)=2 and parameter[1][@type='android.support.v7.app.ActionBar.Tab'] and parameter[2][@type='int']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;I)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_IHandler")]
		public override unsafe void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0, int p1)
		{
			if (id_addTab_Landroid_support_v7_app_ActionBar_Tab_I == IntPtr.Zero)
				id_addTab_Landroid_support_v7_app_ActionBar_Tab_I = JNIEnv.GetMethodID (class_ref, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_addTab_Landroid_support_v7_app_ActionBar_Tab_I, __args);
			} finally {
			}
		}

		static IntPtr id_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='addTab' and count(parameter)=3 and parameter[1][@type='android.support.v7.app.ActionBar.Tab'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("addTab", "(Landroid/support/v7/app/ActionBar$Tab;IZ)V", "GetAddTab_Landroid_support_v7_app_ActionBar_Tab_IZHandler")]
		public override unsafe void AddTab (global::Android.Support.V7.App.ActionBar.Tab p0, int p1, bool p2)
		{
			if (id_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ == IntPtr.Zero)
				id_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ = JNIEnv.GetMethodID (class_ref, "addTab", "(Landroid/support/v7/app/ActionBar$Tab;IZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod  (Handle, id_addTab_Landroid_support_v7_app_ActionBar_Tab_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_getTabAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='getTabAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTabAt", "(I)Landroid/support/v7/app/ActionBar$Tab;", "GetGetTabAt_IHandler")]
		public override unsafe global::Android.Support.V7.App.ActionBar.Tab GetTabAt (int p0)
		{
			if (id_getTabAt_I == IntPtr.Zero)
				id_getTabAt_I = JNIEnv.GetMethodID (class_ref, "getTabAt", "(I)Landroid/support/v7/app/ActionBar$Tab;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_getTabAt_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_hide;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "GetHideHandler")]
		public override unsafe void Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_hide);
			} finally {
			}
		}

		static IntPtr id_newTab;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='newTab' and count(parameter)=0]"
		[Register ("newTab", "()Landroid/support/v7/app/ActionBar$Tab;", "GetNewTabHandler")]
		public override unsafe global::Android.Support.V7.App.ActionBar.Tab NewTab ()
		{
			if (id_newTab == IntPtr.Zero)
				id_newTab = JNIEnv.GetMethodID (class_ref, "newTab", "()Landroid/support/v7/app/ActionBar$Tab;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar.Tab> (JNIEnv.CallObjectMethod  (Handle, id_newTab), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_removeAllTabs;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='removeAllTabs' and count(parameter)=0]"
		[Register ("removeAllTabs", "()V", "GetRemoveAllTabsHandler")]
		public override unsafe void RemoveAllTabs ()
		{
			if (id_removeAllTabs == IntPtr.Zero)
				id_removeAllTabs = JNIEnv.GetMethodID (class_ref, "removeAllTabs", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_removeAllTabs);
			} finally {
			}
		}

		static IntPtr id_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='removeOnMenuVisibilityListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.OnMenuVisibilityListener']]"
		[Register ("removeOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V", "GetRemoveOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public override unsafe void RemoveOnMenuVisibilityListener (global::Android.Support.V7.App.ActionBar.IOnMenuVisibilityListener p0)
		{
			if (id_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ == IntPtr.Zero)
				id_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_ = JNIEnv.GetMethodID (class_ref, "removeOnMenuVisibilityListener", "(Landroid/support/v7/app/ActionBar$OnMenuVisibilityListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_removeOnMenuVisibilityListener_Landroid_support_v7_app_ActionBar_OnMenuVisibilityListener_, __args);
			} finally {
			}
		}

		static IntPtr id_removeTab_Landroid_support_v7_app_ActionBar_Tab_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='removeTab' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.Tab']]"
		[Register ("removeTab", "(Landroid/support/v7/app/ActionBar$Tab;)V", "GetRemoveTab_Landroid_support_v7_app_ActionBar_Tab_Handler")]
		public override unsafe void RemoveTab (global::Android.Support.V7.App.ActionBar.Tab p0)
		{
			if (id_removeTab_Landroid_support_v7_app_ActionBar_Tab_ == IntPtr.Zero)
				id_removeTab_Landroid_support_v7_app_ActionBar_Tab_ = JNIEnv.GetMethodID (class_ref, "removeTab", "(Landroid/support/v7/app/ActionBar$Tab;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_removeTab_Landroid_support_v7_app_ActionBar_Tab_, __args);
			} finally {
			}
		}

		static IntPtr id_removeTabAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='removeTabAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeTabAt", "(I)V", "GetRemoveTabAt_IHandler")]
		public override unsafe void RemoveTabAt (int p0)
		{
			if (id_removeTabAt_I == IntPtr.Zero)
				id_removeTabAt_I = JNIEnv.GetMethodID (class_ref, "removeTabAt", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_removeTabAt_I, __args);
			} finally {
			}
		}

		static IntPtr id_selectTab_Landroid_support_v7_app_ActionBar_Tab_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='selectTab' and count(parameter)=1 and parameter[1][@type='android.support.v7.app.ActionBar.Tab']]"
		[Register ("selectTab", "(Landroid/support/v7/app/ActionBar$Tab;)V", "GetSelectTab_Landroid_support_v7_app_ActionBar_Tab_Handler")]
		public override unsafe void SelectTab (global::Android.Support.V7.App.ActionBar.Tab p0)
		{
			if (id_selectTab_Landroid_support_v7_app_ActionBar_Tab_ == IntPtr.Zero)
				id_selectTab_Landroid_support_v7_app_ActionBar_Tab_ = JNIEnv.GetMethodID (class_ref, "selectTab", "(Landroid/support/v7/app/ActionBar$Tab;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_selectTab_Landroid_support_v7_app_ActionBar_Tab_, __args);
			} finally {
			}
		}

		static IntPtr id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setBackgroundDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public override unsafe void SetBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_, __args);
			} finally {
			}
		}

		static IntPtr id_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setCustomView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.support.v7.app.ActionBar.LayoutParams']]"
		[Register ("setCustomView", "(Landroid/view/View;Landroid/support/v7/app/ActionBar$LayoutParams;)V", "GetSetCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_Handler")]
		public override unsafe void SetCustomView (global::Android.Views.View p0, global::Android.Support.V7.App.ActionBar.LayoutParams p1)
		{
			if (id_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_ == IntPtr.Zero)
				id_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "setCustomView", "(Landroid/view/View;Landroid/support/v7/app/ActionBar$LayoutParams;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setCustomView_Landroid_view_View_Landroid_support_v7_app_ActionBar_LayoutParams_, __args);
			} finally {
			}
		}

		static IntPtr id_setCustomView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setCustomView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCustomView", "(I)V", "GetSetCustomView_IHandler")]
		public override unsafe void SetCustomView (int p0)
		{
			if (id_setCustomView_I == IntPtr.Zero)
				id_setCustomView_I = JNIEnv.GetMethodID (class_ref, "setCustomView", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setCustomView_I, __args);
			} finally {
			}
		}

		static IntPtr id_setDisplayHomeAsUpEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayHomeAsUpEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayHomeAsUpEnabled", "(Z)V", "GetSetDisplayHomeAsUpEnabled_ZHandler")]
		public override unsafe void SetDisplayHomeAsUpEnabled (bool p0)
		{
			if (id_setDisplayHomeAsUpEnabled_Z == IntPtr.Zero)
				id_setDisplayHomeAsUpEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayHomeAsUpEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setDisplayHomeAsUpEnabled_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setDisplayOptions_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayOptions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDisplayOptions", "(II)V", "GetSetDisplayOptions_IIHandler")]
		public override unsafe void SetDisplayOptions ([global::Android.Runtime.IntDef (Flag = true, Type = "Android.Support.V7.App.ActionBar", Fields = new string [] {"DisplayUseLogo", "DisplayShowHome", "DisplayHomeAsUp", "DisplayShowTitle", "DisplayShowCustom"})]int p0, [global::Android.Runtime.IntDef (Flag = true, Type = "Android.Support.V7.App.ActionBar", Fields = new string [] {"DisplayUseLogo", "DisplayShowHome", "DisplayHomeAsUp", "DisplayShowTitle", "DisplayShowCustom"})]int p1)
		{
			if (id_setDisplayOptions_II == IntPtr.Zero)
				id_setDisplayOptions_II = JNIEnv.GetMethodID (class_ref, "setDisplayOptions", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setDisplayOptions_II, __args);
			} finally {
			}
		}

		static IntPtr id_setDisplayShowCustomEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayShowCustomEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayShowCustomEnabled", "(Z)V", "GetSetDisplayShowCustomEnabled_ZHandler")]
		public override unsafe void SetDisplayShowCustomEnabled (bool p0)
		{
			if (id_setDisplayShowCustomEnabled_Z == IntPtr.Zero)
				id_setDisplayShowCustomEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayShowCustomEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setDisplayShowCustomEnabled_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setDisplayShowHomeEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayShowHomeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayShowHomeEnabled", "(Z)V", "GetSetDisplayShowHomeEnabled_ZHandler")]
		public override unsafe void SetDisplayShowHomeEnabled (bool p0)
		{
			if (id_setDisplayShowHomeEnabled_Z == IntPtr.Zero)
				id_setDisplayShowHomeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayShowHomeEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setDisplayShowHomeEnabled_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setDisplayShowTitleEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayShowTitleEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayShowTitleEnabled", "(Z)V", "GetSetDisplayShowTitleEnabled_ZHandler")]
		public override unsafe void SetDisplayShowTitleEnabled (bool p0)
		{
			if (id_setDisplayShowTitleEnabled_Z == IntPtr.Zero)
				id_setDisplayShowTitleEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayShowTitleEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setDisplayShowTitleEnabled_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setDisplayUseLogoEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setDisplayUseLogoEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisplayUseLogoEnabled", "(Z)V", "GetSetDisplayUseLogoEnabled_ZHandler")]
		public override unsafe void SetDisplayUseLogoEnabled (bool p0)
		{
			if (id_setDisplayUseLogoEnabled_Z == IntPtr.Zero)
				id_setDisplayUseLogoEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDisplayUseLogoEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setDisplayUseLogoEnabled_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public override unsafe void SetIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, __args);
			} finally {
			}
		}

		static IntPtr id_setIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIcon", "(I)V", "GetSetIcon_IHandler")]
		public override unsafe void SetIcon (int p0)
		{
			if (id_setIcon_I == IntPtr.Zero)
				id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setIcon_I, __args);
			} finally {
			}
		}

		static IntPtr id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setListNavigationCallbacks' and count(parameter)=2 and parameter[1][@type='android.widget.SpinnerAdapter'] and parameter[2][@type='android.support.v7.app.ActionBar.OnNavigationListener']]"
		[Register ("setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Landroid/support/v7/app/ActionBar$OnNavigationListener;)V", "GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_Handler")]
		public override unsafe void SetListNavigationCallbacks (global::Android.Widget.ISpinnerAdapter p0, global::Android.Support.V7.App.ActionBar.IOnNavigationListener p1)
		{
			if (id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_ == IntPtr.Zero)
				id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_ = JNIEnv.GetMethodID (class_ref, "setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Landroid/support/v7/app/ActionBar$OnNavigationListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroid_support_v7_app_ActionBar_OnNavigationListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setLogo_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setLogo' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setLogo", "(Landroid/graphics/drawable/Drawable;)V", "GetSetLogo_Landroid_graphics_drawable_Drawable_Handler")]
		public override unsafe void SetLogo (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setLogo_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setLogo_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setLogo", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setLogo_Landroid_graphics_drawable_Drawable_, __args);
			} finally {
			}
		}

		static IntPtr id_setLogo_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setLogo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogo", "(I)V", "GetSetLogo_IHandler")]
		public override unsafe void SetLogo (int p0)
		{
			if (id_setLogo_I == IntPtr.Zero)
				id_setLogo_I = JNIEnv.GetMethodID (class_ref, "setLogo", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setLogo_I, __args);
			} finally {
			}
		}

		static IntPtr id_setSelectedNavigationItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setSelectedNavigationItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectedNavigationItem", "(I)V", "GetSetSelectedNavigationItem_IHandler")]
		public override unsafe void SetSelectedNavigationItem (int p0)
		{
			if (id_setSelectedNavigationItem_I == IntPtr.Zero)
				id_setSelectedNavigationItem_I = JNIEnv.GetMethodID (class_ref, "setSelectedNavigationItem", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setSelectedNavigationItem_I, __args);
			} finally {
			}
		}

		static IntPtr id_setSubtitle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setSubtitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSubtitle", "(I)V", "GetSetSubtitle_IHandler")]
		public override unsafe void SetSubtitle (int p0)
		{
			if (id_setSubtitle_I == IntPtr.Zero)
				id_setSubtitle_I = JNIEnv.GetMethodID (class_ref, "setSubtitle", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setSubtitle_I, __args);
			} finally {
			}
		}

		static IntPtr id_setTitle_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public override unsafe void SetTitle (int p0)
		{
			if (id_setTitle_I == IntPtr.Zero)
				id_setTitle_I = JNIEnv.GetMethodID (class_ref, "setTitle", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setTitle_I, __args);
			} finally {
			}
		}

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='ActionBar']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public override unsafe void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_show);
			} finally {
			}
		}

	}

}
