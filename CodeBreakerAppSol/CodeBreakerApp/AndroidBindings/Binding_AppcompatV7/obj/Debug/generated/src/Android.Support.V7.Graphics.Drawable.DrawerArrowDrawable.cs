using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Graphics.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']"
	[global::Android.Runtime.Register ("android/support/v7/graphics/drawable/DrawerArrowDrawable", DoNotGenerateAcw=true)]
	public partial class DrawerArrowDrawable : global::Android.Graphics.Drawables.Drawable {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/field[@name='ARROW_DIRECTION_END']"
		[Register ("ARROW_DIRECTION_END")]
		public const int ArrowDirectionEnd = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/field[@name='ARROW_DIRECTION_LEFT']"
		[Register ("ARROW_DIRECTION_LEFT")]
		public const int ArrowDirectionLeft = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/field[@name='ARROW_DIRECTION_RIGHT']"
		[Register ("ARROW_DIRECTION_RIGHT")]
		public const int ArrowDirectionRight = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/field[@name='ARROW_DIRECTION_START']"
		[Register ("ARROW_DIRECTION_START")]
		public const int ArrowDirectionStart = (int) 2;
		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.graphics.drawable']/interface[@name='DrawerArrowDrawable.ArrowDirection']"
		[Register ("android/support/v7/graphics/drawable/DrawerArrowDrawable$ArrowDirection", "", "Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable/IArrowDirectionInvoker")]
		public partial interface IArrowDirection : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("android/support/v7/graphics/drawable/DrawerArrowDrawable$ArrowDirection", DoNotGenerateAcw=true)]
		internal class IArrowDirectionInvoker : global::Java.Lang.Object, IArrowDirection {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/graphics/drawable/DrawerArrowDrawable$ArrowDirection");
			IntPtr class_ref;

			public static IArrowDirection GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IArrowDirection> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.graphics.drawable.DrawerArrowDrawable.ArrowDirection"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IArrowDirectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IArrowDirectionInvoker); }
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
				global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable.IArrowDirection __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable.IArrowDirection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable.IArrowDirection __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable.IArrowDirection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable.IArrowDirection __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable.IArrowDirection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable.IArrowDirection __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable.IArrowDirection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				return JNIEnv.FindClass ("android/support/v7/graphics/drawable/DrawerArrowDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawerArrowDrawable); }
		}

		protected DrawerArrowDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/constructor[@name='DrawerArrowDrawable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DrawerArrowDrawable (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DrawerArrowDrawable)) {
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

		static Delegate cb_getArrowHeadLength;
#pragma warning disable 0169
		static Delegate GetGetArrowHeadLengthHandler ()
		{
			if (cb_getArrowHeadLength == null)
				cb_getArrowHeadLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetArrowHeadLength);
			return cb_getArrowHeadLength;
		}

		static float n_GetArrowHeadLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ArrowHeadLength;
		}
#pragma warning restore 0169

		static Delegate cb_setArrowHeadLength_F;
#pragma warning disable 0169
		static Delegate GetSetArrowHeadLength_FHandler ()
		{
			if (cb_setArrowHeadLength_F == null)
				cb_setArrowHeadLength_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetArrowHeadLength_F);
			return cb_setArrowHeadLength_F;
		}

		static void n_SetArrowHeadLength_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ArrowHeadLength = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getArrowHeadLength;
		static IntPtr id_setArrowHeadLength_F;
		public virtual unsafe float ArrowHeadLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='getArrowHeadLength' and count(parameter)=0]"
			[Register ("getArrowHeadLength", "()F", "GetGetArrowHeadLengthHandler")]
			get {
				if (id_getArrowHeadLength == IntPtr.Zero)
					id_getArrowHeadLength = JNIEnv.GetMethodID (class_ref, "getArrowHeadLength", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getArrowHeadLength);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getArrowHeadLength", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setArrowHeadLength' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setArrowHeadLength", "(F)V", "GetSetArrowHeadLength_FHandler")]
			set {
				if (id_setArrowHeadLength_F == IntPtr.Zero)
					id_setArrowHeadLength_F = JNIEnv.GetMethodID (class_ref, "setArrowHeadLength", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setArrowHeadLength_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setArrowHeadLength", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getArrowShaftLength;
#pragma warning disable 0169
		static Delegate GetGetArrowShaftLengthHandler ()
		{
			if (cb_getArrowShaftLength == null)
				cb_getArrowShaftLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetArrowShaftLength);
			return cb_getArrowShaftLength;
		}

		static float n_GetArrowShaftLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ArrowShaftLength;
		}
#pragma warning restore 0169

		static Delegate cb_setArrowShaftLength_F;
#pragma warning disable 0169
		static Delegate GetSetArrowShaftLength_FHandler ()
		{
			if (cb_setArrowShaftLength_F == null)
				cb_setArrowShaftLength_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetArrowShaftLength_F);
			return cb_setArrowShaftLength_F;
		}

		static void n_SetArrowShaftLength_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ArrowShaftLength = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getArrowShaftLength;
		static IntPtr id_setArrowShaftLength_F;
		public virtual unsafe float ArrowShaftLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='getArrowShaftLength' and count(parameter)=0]"
			[Register ("getArrowShaftLength", "()F", "GetGetArrowShaftLengthHandler")]
			get {
				if (id_getArrowShaftLength == IntPtr.Zero)
					id_getArrowShaftLength = JNIEnv.GetMethodID (class_ref, "getArrowShaftLength", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getArrowShaftLength);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getArrowShaftLength", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setArrowShaftLength' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setArrowShaftLength", "(F)V", "GetSetArrowShaftLength_FHandler")]
			set {
				if (id_setArrowShaftLength_F == IntPtr.Zero)
					id_setArrowShaftLength_F = JNIEnv.GetMethodID (class_ref, "setArrowShaftLength", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setArrowShaftLength_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setArrowShaftLength", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBarLength;
#pragma warning disable 0169
		static Delegate GetGetBarLengthHandler ()
		{
			if (cb_getBarLength == null)
				cb_getBarLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBarLength);
			return cb_getBarLength;
		}

		static float n_GetBarLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarLength;
		}
#pragma warning restore 0169

		static Delegate cb_setBarLength_F;
#pragma warning disable 0169
		static Delegate GetSetBarLength_FHandler ()
		{
			if (cb_setBarLength_F == null)
				cb_setBarLength_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBarLength_F);
			return cb_setBarLength_F;
		}

		static void n_SetBarLength_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarLength = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBarLength;
		static IntPtr id_setBarLength_F;
		public virtual unsafe float BarLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='getBarLength' and count(parameter)=0]"
			[Register ("getBarLength", "()F", "GetGetBarLengthHandler")]
			get {
				if (id_getBarLength == IntPtr.Zero)
					id_getBarLength = JNIEnv.GetMethodID (class_ref, "getBarLength", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getBarLength);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBarLength", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setBarLength' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBarLength", "(F)V", "GetSetBarLength_FHandler")]
			set {
				if (id_setBarLength_F == IntPtr.Zero)
					id_setBarLength_F = JNIEnv.GetMethodID (class_ref, "setBarLength", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBarLength_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBarLength", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBarThickness;
#pragma warning disable 0169
		static Delegate GetGetBarThicknessHandler ()
		{
			if (cb_getBarThickness == null)
				cb_getBarThickness = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBarThickness);
			return cb_getBarThickness;
		}

		static float n_GetBarThickness (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarThickness;
		}
#pragma warning restore 0169

		static Delegate cb_setBarThickness_F;
#pragma warning disable 0169
		static Delegate GetSetBarThickness_FHandler ()
		{
			if (cb_setBarThickness_F == null)
				cb_setBarThickness_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBarThickness_F);
			return cb_setBarThickness_F;
		}

		static void n_SetBarThickness_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarThickness = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBarThickness;
		static IntPtr id_setBarThickness_F;
		public virtual unsafe float BarThickness {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='getBarThickness' and count(parameter)=0]"
			[Register ("getBarThickness", "()F", "GetGetBarThicknessHandler")]
			get {
				if (id_getBarThickness == IntPtr.Zero)
					id_getBarThickness = JNIEnv.GetMethodID (class_ref, "getBarThickness", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getBarThickness);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBarThickness", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setBarThickness' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBarThickness", "(F)V", "GetSetBarThickness_FHandler")]
			set {
				if (id_setBarThickness_F == IntPtr.Zero)
					id_setBarThickness_F = JNIEnv.GetMethodID (class_ref, "setBarThickness", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBarThickness_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBarThickness", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Color = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		static IntPtr id_setColor_I;
		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getColor);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				if (id_setColor_I == IntPtr.Zero)
					id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDirection;
#pragma warning disable 0169
		static Delegate GetGetDirectionHandler ()
		{
			if (cb_getDirection == null)
				cb_getDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDirection);
			return cb_getDirection;
		}

		static int n_GetDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Direction;
		}
#pragma warning restore 0169

		static Delegate cb_setDirection_I;
#pragma warning disable 0169
		static Delegate GetSetDirection_IHandler ()
		{
			if (cb_setDirection_I == null)
				cb_setDirection_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDirection_I);
			return cb_setDirection_I;
		}

		static void n_SetDirection_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Direction = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDirection;
		static IntPtr id_setDirection_I;
		public virtual unsafe int Direction {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='getDirection' and count(parameter)=0]"
			[Register ("getDirection", "()I", "GetGetDirectionHandler")]
			get {
				if (id_getDirection == IntPtr.Zero)
					id_getDirection = JNIEnv.GetMethodID (class_ref, "getDirection", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getDirection);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDirection", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setDirection' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDirection", "(I)V", "GetSetDirection_IHandler")]
			set {
				if (id_setDirection_I == IntPtr.Zero)
					id_setDirection_I = JNIEnv.GetMethodID (class_ref, "setDirection", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDirection_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDirection", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGapSize;
#pragma warning disable 0169
		static Delegate GetGetGapSizeHandler ()
		{
			if (cb_getGapSize == null)
				cb_getGapSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetGapSize);
			return cb_getGapSize;
		}

		static float n_GetGapSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GapSize;
		}
#pragma warning restore 0169

		static Delegate cb_setGapSize_F;
#pragma warning disable 0169
		static Delegate GetSetGapSize_FHandler ()
		{
			if (cb_setGapSize_F == null)
				cb_setGapSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetGapSize_F);
			return cb_setGapSize_F;
		}

		static void n_SetGapSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GapSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGapSize;
		static IntPtr id_setGapSize_F;
		public virtual unsafe float GapSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='getGapSize' and count(parameter)=0]"
			[Register ("getGapSize", "()F", "GetGetGapSizeHandler")]
			get {
				if (id_getGapSize == IntPtr.Zero)
					id_getGapSize = JNIEnv.GetMethodID (class_ref, "getGapSize", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getGapSize);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGapSize", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setGapSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setGapSize", "(F)V", "GetSetGapSize_FHandler")]
			set {
				if (id_setGapSize_F == IntPtr.Zero)
					id_setGapSize_F = JNIEnv.GetMethodID (class_ref, "setGapSize", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setGapSize_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGapSize", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
			return cb_getOpacity;
		}

		static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		static IntPtr id_getOpacity;
		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				if (id_getOpacity == IntPtr.Zero)
					id_getOpacity = JNIEnv.GetMethodID (class_ref, "getOpacity", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getOpacity);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpacity", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_getPaint;
		public unsafe global::Android.Graphics.Paint Paint {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='getPaint' and count(parameter)=0]"
			[Register ("getPaint", "()Landroid/graphics/Paint;", "GetGetPaintHandler")]
			get {
				if (id_getPaint == IntPtr.Zero)
					id_getPaint = JNIEnv.GetMethodID (class_ref, "getPaint", "()Landroid/graphics/Paint;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallObjectMethod  (Handle, id_getPaint), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProgress;
#pragma warning disable 0169
		static Delegate GetGetProgressHandler ()
		{
			if (cb_getProgress == null)
				cb_getProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetProgress);
			return cb_getProgress;
		}

		static float n_GetProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress;
		}
#pragma warning restore 0169

		static Delegate cb_setProgress_F;
#pragma warning disable 0169
		static Delegate GetSetProgress_FHandler ()
		{
			if (cb_setProgress_F == null)
				cb_setProgress_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetProgress_F);
			return cb_setProgress_F;
		}

		static void n_SetProgress_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Progress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProgress;
		static IntPtr id_setProgress_F;
		public virtual unsafe float Progress {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='getProgress' and count(parameter)=0]"
			[Register ("getProgress", "()F", "GetGetProgressHandler")]
			get {
				if (id_getProgress == IntPtr.Zero)
					id_getProgress = JNIEnv.GetMethodID (class_ref, "getProgress", "()F");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getProgress);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProgress", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setProgress' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setProgress", "(F)V", "GetSetProgress_FHandler")]
			set {
				if (id_setProgress_F == IntPtr.Zero)
					id_setProgress_F = JNIEnv.GetMethodID (class_ref, "setProgress", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setProgress_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProgress", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSpinEnabled;
#pragma warning disable 0169
		static Delegate GetIsSpinEnabledHandler ()
		{
			if (cb_isSpinEnabled == null)
				cb_isSpinEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSpinEnabled);
			return cb_isSpinEnabled;
		}

		static bool n_IsSpinEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpinEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setSpinEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetSpinEnabled_ZHandler ()
		{
			if (cb_setSpinEnabled_Z == null)
				cb_setSpinEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSpinEnabled_Z);
			return cb_setSpinEnabled_Z;
		}

		static void n_SetSpinEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpinEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSpinEnabled;
		static IntPtr id_setSpinEnabled_Z;
		public virtual unsafe bool SpinEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='isSpinEnabled' and count(parameter)=0]"
			[Register ("isSpinEnabled", "()Z", "GetIsSpinEnabledHandler")]
			get {
				if (id_isSpinEnabled == IntPtr.Zero)
					id_isSpinEnabled = JNIEnv.GetMethodID (class_ref, "isSpinEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSpinEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSpinEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setSpinEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSpinEnabled", "(Z)V", "GetSetSpinEnabled_ZHandler")]
			set {
				if (id_setSpinEnabled_Z == IntPtr.Zero)
					id_setSpinEnabled_Z = JNIEnv.GetMethodID (class_ref, "setSpinEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSpinEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSpinEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlpha_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int p0)
		{
			if (id_setAlpha_I == IntPtr.Zero)
				id_setAlpha_I = JNIEnv.GetMethodID (class_ref, "setAlpha", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAlpha_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorFilter_Landroid_graphics_ColorFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter p0)
		{
			if (id_setColorFilter_Landroid_graphics_ColorFilter_ == IntPtr.Zero)
				id_setColorFilter_Landroid_graphics_ColorFilter_ = JNIEnv.GetMethodID (class_ref, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setColorFilter_Landroid_graphics_ColorFilter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVerticalMirror_Z;
#pragma warning disable 0169
		static Delegate GetSetVerticalMirror_ZHandler ()
		{
			if (cb_setVerticalMirror_Z == null)
				cb_setVerticalMirror_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVerticalMirror_Z);
			return cb_setVerticalMirror_Z;
		}

		static void n_SetVerticalMirror_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawerArrowDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVerticalMirror (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVerticalMirror_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawerArrowDrawable']/method[@name='setVerticalMirror' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setVerticalMirror", "(Z)V", "GetSetVerticalMirror_ZHandler")]
		public virtual unsafe void SetVerticalMirror (bool p0)
		{
			if (id_setVerticalMirror_Z == IntPtr.Zero)
				id_setVerticalMirror_Z = JNIEnv.GetMethodID (class_ref, "setVerticalMirror", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setVerticalMirror_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVerticalMirror", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
