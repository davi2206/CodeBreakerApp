using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/ContentFrameLayout", DoNotGenerateAcw=true)]
	public partial class ContentFrameLayout : global::Android.Widget.FrameLayout {

		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ContentFrameLayout.OnAttachListener']"
		[Register ("android/support/v7/internal/widget/ContentFrameLayout$OnAttachListener", "", "Android.Support.V7.Internal.Widget.ContentFrameLayout/IOnAttachListenerInvoker")]
		public partial interface IOnAttachListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ContentFrameLayout.OnAttachListener']/method[@name='onAttachedFromWindow' and count(parameter)=0]"
			[Register ("onAttachedFromWindow", "()V", "GetOnAttachedFromWindowHandler:Android.Support.V7.Internal.Widget.ContentFrameLayout/IOnAttachListenerInvoker, Binding_AppcompatV7")]
			void OnAttachedFromWindow ();

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ContentFrameLayout.OnAttachListener']/method[@name='onDetachedFromWindow' and count(parameter)=0]"
			[Register ("onDetachedFromWindow", "()V", "GetOnDetachedFromWindowHandler:Android.Support.V7.Internal.Widget.ContentFrameLayout/IOnAttachListenerInvoker, Binding_AppcompatV7")]
			void OnDetachedFromWindow ();

		}

		[global::Android.Runtime.Register ("android/support/v7/internal/widget/ContentFrameLayout$OnAttachListener", DoNotGenerateAcw=true)]
		internal class IOnAttachListenerInvoker : global::Java.Lang.Object, IOnAttachListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/internal/widget/ContentFrameLayout$OnAttachListener");
			IntPtr class_ref;

			public static IOnAttachListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnAttachListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.internal.widget.ContentFrameLayout.OnAttachListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnAttachListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnAttachListenerInvoker); }
			}

			static Delegate cb_onAttachedFromWindow;
#pragma warning disable 0169
			static Delegate GetOnAttachedFromWindowHandler ()
			{
				if (cb_onAttachedFromWindow == null)
					cb_onAttachedFromWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAttachedFromWindow);
				return cb_onAttachedFromWindow;
			}

			static void n_OnAttachedFromWindow (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAttachedFromWindow ();
			}
#pragma warning restore 0169

			IntPtr id_onAttachedFromWindow;
			public unsafe void OnAttachedFromWindow ()
			{
				if (id_onAttachedFromWindow == IntPtr.Zero)
					id_onAttachedFromWindow = JNIEnv.GetMethodID (class_ref, "onAttachedFromWindow", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onAttachedFromWindow);
			}

			static Delegate cb_onDetachedFromWindow;
#pragma warning disable 0169
			static Delegate GetOnDetachedFromWindowHandler ()
			{
				if (cb_onDetachedFromWindow == null)
					cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDetachedFromWindow);
				return cb_onDetachedFromWindow;
			}

			static void n_OnDetachedFromWindow (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDetachedFromWindow ();
			}
#pragma warning restore 0169

			IntPtr id_onDetachedFromWindow;
			public unsafe void OnDetachedFromWindow ()
			{
				if (id_onDetachedFromWindow == IntPtr.Zero)
					id_onDetachedFromWindow = JNIEnv.GetMethodID (class_ref, "onDetachedFromWindow", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onDetachedFromWindow);
			}

		}

		[global::Android.Runtime.Register ("mono/android/support/v7/internal/widget/ContentFrameLayout_OnAttachListenerImplementor")]
		internal sealed partial class IOnAttachListenerImplementor : global::Java.Lang.Object, IOnAttachListener {

			object sender;

			public IOnAttachListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/android/support/v7/internal/widget/ContentFrameLayout_OnAttachListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnAttachedFromWindowHandler;
#pragma warning restore 0649

			public void OnAttachedFromWindow ()
			{
				var __h = OnAttachedFromWindowHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnDetachedFromWindowHandler;
#pragma warning restore 0649

			public void OnDetachedFromWindow ()
			{
				var __h = OnDetachedFromWindowHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnAttachListenerImplementor value)
			{
				return value.OnAttachedFromWindowHandler == null && value.OnDetachedFromWindowHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/ContentFrameLayout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentFrameLayout); }
		}

		protected ContentFrameLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/constructor[@name='ContentFrameLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ContentFrameLayout (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ContentFrameLayout)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/constructor[@name='ContentFrameLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ContentFrameLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ContentFrameLayout)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/constructor[@name='ContentFrameLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ContentFrameLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ContentFrameLayout)) {
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

		static Delegate cb_getFixedHeightMajor;
#pragma warning disable 0169
		static Delegate GetGetFixedHeightMajorHandler ()
		{
			if (cb_getFixedHeightMajor == null)
				cb_getFixedHeightMajor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFixedHeightMajor);
			return cb_getFixedHeightMajor;
		}

		static IntPtr n_GetFixedHeightMajor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ContentFrameLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FixedHeightMajor);
		}
#pragma warning restore 0169

		static IntPtr id_getFixedHeightMajor;
		public virtual unsafe global::Android.Util.TypedValue FixedHeightMajor {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/method[@name='getFixedHeightMajor' and count(parameter)=0]"
			[Register ("getFixedHeightMajor", "()Landroid/util/TypedValue;", "GetGetFixedHeightMajorHandler")]
			get {
				if (id_getFixedHeightMajor == IntPtr.Zero)
					id_getFixedHeightMajor = JNIEnv.GetMethodID (class_ref, "getFixedHeightMajor", "()Landroid/util/TypedValue;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallObjectMethod  (Handle, id_getFixedHeightMajor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFixedHeightMajor", "()Landroid/util/TypedValue;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFixedHeightMinor;
#pragma warning disable 0169
		static Delegate GetGetFixedHeightMinorHandler ()
		{
			if (cb_getFixedHeightMinor == null)
				cb_getFixedHeightMinor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFixedHeightMinor);
			return cb_getFixedHeightMinor;
		}

		static IntPtr n_GetFixedHeightMinor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ContentFrameLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FixedHeightMinor);
		}
#pragma warning restore 0169

		static IntPtr id_getFixedHeightMinor;
		public virtual unsafe global::Android.Util.TypedValue FixedHeightMinor {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/method[@name='getFixedHeightMinor' and count(parameter)=0]"
			[Register ("getFixedHeightMinor", "()Landroid/util/TypedValue;", "GetGetFixedHeightMinorHandler")]
			get {
				if (id_getFixedHeightMinor == IntPtr.Zero)
					id_getFixedHeightMinor = JNIEnv.GetMethodID (class_ref, "getFixedHeightMinor", "()Landroid/util/TypedValue;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallObjectMethod  (Handle, id_getFixedHeightMinor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFixedHeightMinor", "()Landroid/util/TypedValue;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFixedWidthMajor;
#pragma warning disable 0169
		static Delegate GetGetFixedWidthMajorHandler ()
		{
			if (cb_getFixedWidthMajor == null)
				cb_getFixedWidthMajor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFixedWidthMajor);
			return cb_getFixedWidthMajor;
		}

		static IntPtr n_GetFixedWidthMajor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ContentFrameLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FixedWidthMajor);
		}
#pragma warning restore 0169

		static IntPtr id_getFixedWidthMajor;
		public virtual unsafe global::Android.Util.TypedValue FixedWidthMajor {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/method[@name='getFixedWidthMajor' and count(parameter)=0]"
			[Register ("getFixedWidthMajor", "()Landroid/util/TypedValue;", "GetGetFixedWidthMajorHandler")]
			get {
				if (id_getFixedWidthMajor == IntPtr.Zero)
					id_getFixedWidthMajor = JNIEnv.GetMethodID (class_ref, "getFixedWidthMajor", "()Landroid/util/TypedValue;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallObjectMethod  (Handle, id_getFixedWidthMajor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFixedWidthMajor", "()Landroid/util/TypedValue;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFixedWidthMinor;
#pragma warning disable 0169
		static Delegate GetGetFixedWidthMinorHandler ()
		{
			if (cb_getFixedWidthMinor == null)
				cb_getFixedWidthMinor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFixedWidthMinor);
			return cb_getFixedWidthMinor;
		}

		static IntPtr n_GetFixedWidthMinor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ContentFrameLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FixedWidthMinor);
		}
#pragma warning restore 0169

		static IntPtr id_getFixedWidthMinor;
		public virtual unsafe global::Android.Util.TypedValue FixedWidthMinor {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/method[@name='getFixedWidthMinor' and count(parameter)=0]"
			[Register ("getFixedWidthMinor", "()Landroid/util/TypedValue;", "GetGetFixedWidthMinorHandler")]
			get {
				if (id_getFixedWidthMinor == IntPtr.Zero)
					id_getFixedWidthMinor = JNIEnv.GetMethodID (class_ref, "getFixedWidthMinor", "()Landroid/util/TypedValue;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallObjectMethod  (Handle, id_getFixedWidthMinor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFixedWidthMinor", "()Landroid/util/TypedValue;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMinWidthMajor;
#pragma warning disable 0169
		static Delegate GetGetMinWidthMajorHandler ()
		{
			if (cb_getMinWidthMajor == null)
				cb_getMinWidthMajor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMinWidthMajor);
			return cb_getMinWidthMajor;
		}

		static IntPtr n_GetMinWidthMajor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ContentFrameLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MinWidthMajor);
		}
#pragma warning restore 0169

		static IntPtr id_getMinWidthMajor;
		public virtual unsafe global::Android.Util.TypedValue MinWidthMajor {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/method[@name='getMinWidthMajor' and count(parameter)=0]"
			[Register ("getMinWidthMajor", "()Landroid/util/TypedValue;", "GetGetMinWidthMajorHandler")]
			get {
				if (id_getMinWidthMajor == IntPtr.Zero)
					id_getMinWidthMajor = JNIEnv.GetMethodID (class_ref, "getMinWidthMajor", "()Landroid/util/TypedValue;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallObjectMethod  (Handle, id_getMinWidthMajor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinWidthMajor", "()Landroid/util/TypedValue;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMinWidthMinor;
#pragma warning disable 0169
		static Delegate GetGetMinWidthMinorHandler ()
		{
			if (cb_getMinWidthMinor == null)
				cb_getMinWidthMinor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMinWidthMinor);
			return cb_getMinWidthMinor;
		}

		static IntPtr n_GetMinWidthMinor (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ContentFrameLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MinWidthMinor);
		}
#pragma warning restore 0169

		static IntPtr id_getMinWidthMinor;
		public virtual unsafe global::Android.Util.TypedValue MinWidthMinor {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/method[@name='getMinWidthMinor' and count(parameter)=0]"
			[Register ("getMinWidthMinor", "()Landroid/util/TypedValue;", "GetGetMinWidthMinorHandler")]
			get {
				if (id_getMinWidthMinor == IntPtr.Zero)
					id_getMinWidthMinor = JNIEnv.GetMethodID (class_ref, "getMinWidthMinor", "()Landroid/util/TypedValue;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallObjectMethod  (Handle, id_getMinWidthMinor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinWidthMinor", "()Landroid/util/TypedValue;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_dispatchFitSystemWindows_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetDispatchFitSystemWindows_Landroid_graphics_Rect_Handler ()
		{
			if (cb_dispatchFitSystemWindows_Landroid_graphics_Rect_ == null)
				cb_dispatchFitSystemWindows_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchFitSystemWindows_Landroid_graphics_Rect_);
			return cb_dispatchFitSystemWindows_Landroid_graphics_Rect_;
		}

		static void n_DispatchFitSystemWindows_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.ContentFrameLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchFitSystemWindows (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchFitSystemWindows_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/method[@name='dispatchFitSystemWindows' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("dispatchFitSystemWindows", "(Landroid/graphics/Rect;)V", "GetDispatchFitSystemWindows_Landroid_graphics_Rect_Handler")]
		public virtual unsafe void DispatchFitSystemWindows (global::Android.Graphics.Rect p0)
		{
			if (id_dispatchFitSystemWindows_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_dispatchFitSystemWindows_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "dispatchFitSystemWindows", "(Landroid/graphics/Rect;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dispatchFitSystemWindows_Landroid_graphics_Rect_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchFitSystemWindows", "(Landroid/graphics/Rect;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_;
#pragma warning disable 0169
		static Delegate GetSetAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_Handler ()
		{
			if (cb_setAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_ == null)
				cb_setAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_);
			return cb_setAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_;
		}

		static void n_SetAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.ContentFrameLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener p0 = (global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener)global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAttachListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/method[@name='setAttachListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.internal.widget.ContentFrameLayout.OnAttachListener']]"
		[Register ("setAttachListener", "(Landroid/support/v7/internal/widget/ContentFrameLayout$OnAttachListener;)V", "GetSetAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_Handler")]
		public virtual unsafe void SetAttachListener (global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener p0)
		{
			if (id_setAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_ == IntPtr.Zero)
				id_setAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_ = JNIEnv.GetMethodID (class_ref, "setAttachListener", "(Landroid/support/v7/internal/widget/ContentFrameLayout$OnAttachListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAttachListener_Landroid_support_v7_internal_widget_ContentFrameLayout_OnAttachListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttachListener", "(Landroid/support/v7/internal/widget/ContentFrameLayout$OnAttachListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDecorPadding_IIII;
#pragma warning disable 0169
		static Delegate GetSetDecorPadding_IIIIHandler ()
		{
			if (cb_setDecorPadding_IIII == null)
				cb_setDecorPadding_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_SetDecorPadding_IIII);
			return cb_setDecorPadding_IIII;
		}

		static void n_SetDecorPadding_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Android.Support.V7.Internal.Widget.ContentFrameLayout __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ContentFrameLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDecorPadding (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setDecorPadding_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ContentFrameLayout']/method[@name='setDecorPadding' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setDecorPadding", "(IIII)V", "GetSetDecorPadding_IIIIHandler")]
		public virtual unsafe void SetDecorPadding (int p0, int p1, int p2, int p3)
		{
			if (id_setDecorPadding_IIII == IntPtr.Zero)
				id_setDecorPadding_IIII = JNIEnv.GetMethodID (class_ref, "setDecorPadding", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDecorPadding_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDecorPadding", "(IIII)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener"
		public event EventHandler AttachedFromWindow {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener, global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListenerImplementor>(
						ref weak_implementor_SetAttachListener,
						__CreateIOnAttachListenerImplementor,
						SetAttachListener,
						__h => __h.OnAttachedFromWindowHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener, global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListenerImplementor>(
						ref weak_implementor_SetAttachListener,
						global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListenerImplementor.__IsEmpty,
						__v => SetAttachListener (null),
						__h => __h.OnAttachedFromWindowHandler -= value);
			}
		}

		public event EventHandler DetachedFromWindow {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener, global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListenerImplementor>(
						ref weak_implementor_SetAttachListener,
						__CreateIOnAttachListenerImplementor,
						SetAttachListener,
						__h => __h.OnDetachedFromWindowHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListener, global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListenerImplementor>(
						ref weak_implementor_SetAttachListener,
						global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListenerImplementor.__IsEmpty,
						__v => SetAttachListener (null),
						__h => __h.OnDetachedFromWindowHandler -= value);
			}
		}

		WeakReference weak_implementor_SetAttachListener;

		global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListenerImplementor __CreateIOnAttachListenerImplementor ()
		{
			return new global::Android.Support.V7.Internal.Widget.ContentFrameLayout.IOnAttachListenerImplementor (this);
		}
#endregion
	}
}
