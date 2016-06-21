using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']"
	[global::Android.Runtime.Register ("android/support/v7/internal/view/WindowCallbackWrapper", DoNotGenerateAcw=true)]
	public partial class WindowCallbackWrapper : global::Java.Lang.Object, global::Android.Views.Window.ICallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/view/WindowCallbackWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WindowCallbackWrapper); }
		}

		protected WindowCallbackWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_Window_Callback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/constructor[@name='WindowCallbackWrapper' and count(parameter)=1 and parameter[1][@type='android.view.Window.Callback']]"
		[Register (".ctor", "(Landroid/view/Window$Callback;)V", "")]
		public unsafe WindowCallbackWrapper (global::Android.Views.Window.ICallback p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (WindowCallbackWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/Window$Callback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/Window$Callback;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_Window_Callback_ == IntPtr.Zero)
					id_ctor_Landroid_view_Window_Callback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/Window$Callback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_Window_Callback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_Window_Callback_, __args);
			} finally {
			}
		}

		static Delegate cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchGenericMotionEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ == null)
				cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchGenericMotionEvent_Landroid_view_MotionEvent_);
			return cb_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;
		}

		static bool n_DispatchGenericMotionEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchGenericMotionEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchGenericMotionEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='dispatchGenericMotionEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", "GetDispatchGenericMotionEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool DispatchGenericMotionEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_dispatchGenericMotionEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchGenericMotionEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_dispatchKeyEvent_Landroid_view_KeyEvent_ == null)
				cb_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchKeyEvent_Landroid_view_KeyEvent_);
			return cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
		}

		static bool n_DispatchKeyEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchKeyEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchKeyEvent_Landroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='dispatchKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler")]
		public virtual unsafe bool DispatchKeyEvent (global::Android.Views.KeyEvent p0)
		{
			if (id_dispatchKeyEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchKeyEvent_Landroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchKeyShortcutEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ == null)
				cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchKeyShortcutEvent_Landroid_view_KeyEvent_);
			return cb_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;
		}

		static bool n_DispatchKeyShortcutEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchKeyShortcutEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='dispatchKeyShortcutEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", "GetDispatchKeyShortcutEvent_Landroid_view_KeyEvent_Handler")]
		public virtual unsafe bool DispatchKeyShortcutEvent (global::Android.Views.KeyEvent p0)
		{
			if (id_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchKeyShortcutEvent_Landroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_Handler ()
		{
			if (cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ == null)
				cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_);
			return cb_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;
		}

		static bool n_DispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Accessibility.AccessibilityEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Accessibility.AccessibilityEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchPopulateAccessibilityEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='dispatchPopulateAccessibilityEvent' and count(parameter)=1 and parameter[1][@type='android.view.accessibility.AccessibilityEvent']]"
		[Register ("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", "GetDispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_Handler")]
		public virtual unsafe bool DispatchPopulateAccessibilityEvent (global::Android.Views.Accessibility.AccessibilityEvent p0)
		{
			if (id_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ == IntPtr.Zero)
				id_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchPopulateAccessibilityEvent_Landroid_view_accessibility_AccessibilityEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dispatchTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_dispatchTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_dispatchTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchTouchEvent_Landroid_view_MotionEvent_);
			return cb_dispatchTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_DispatchTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='dispatchTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool DispatchTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_dispatchTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_dispatchTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchTouchEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dispatchTrackballEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchTrackballEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_dispatchTrackballEvent_Landroid_view_MotionEvent_ == null)
				cb_dispatchTrackballEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DispatchTrackballEvent_Landroid_view_MotionEvent_);
			return cb_dispatchTrackballEvent_Landroid_view_MotionEvent_;
		}

		static bool n_DispatchTrackballEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DispatchTrackballEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dispatchTrackballEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='dispatchTrackballEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", "GetDispatchTrackballEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool DispatchTrackballEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_dispatchTrackballEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_dispatchTrackballEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_dispatchTrackballEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onActionModeFinished_Landroid_view_ActionMode_;
#pragma warning disable 0169
		static Delegate GetOnActionModeFinished_Landroid_view_ActionMode_Handler ()
		{
			if (cb_onActionModeFinished_Landroid_view_ActionMode_ == null)
				cb_onActionModeFinished_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActionModeFinished_Landroid_view_ActionMode_);
			return cb_onActionModeFinished_Landroid_view_ActionMode_;
		}

		static void n_OnActionModeFinished_Landroid_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActionModeFinished (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActionModeFinished_Landroid_view_ActionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onActionModeFinished' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode']]"
		[Register ("onActionModeFinished", "(Landroid/view/ActionMode;)V", "GetOnActionModeFinished_Landroid_view_ActionMode_Handler")]
		public virtual unsafe void OnActionModeFinished (global::Android.Views.ActionMode p0)
		{
			if (id_onActionModeFinished_Landroid_view_ActionMode_ == IntPtr.Zero)
				id_onActionModeFinished_Landroid_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onActionModeFinished", "(Landroid/view/ActionMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onActionModeFinished_Landroid_view_ActionMode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActionModeFinished", "(Landroid/view/ActionMode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActionModeStarted_Landroid_view_ActionMode_;
#pragma warning disable 0169
		static Delegate GetOnActionModeStarted_Landroid_view_ActionMode_Handler ()
		{
			if (cb_onActionModeStarted_Landroid_view_ActionMode_ == null)
				cb_onActionModeStarted_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActionModeStarted_Landroid_view_ActionMode_);
			return cb_onActionModeStarted_Landroid_view_ActionMode_;
		}

		static void n_OnActionModeStarted_Landroid_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnActionModeStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onActionModeStarted_Landroid_view_ActionMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onActionModeStarted' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode']]"
		[Register ("onActionModeStarted", "(Landroid/view/ActionMode;)V", "GetOnActionModeStarted_Landroid_view_ActionMode_Handler")]
		public virtual unsafe void OnActionModeStarted (global::Android.Views.ActionMode p0)
		{
			if (id_onActionModeStarted_Landroid_view_ActionMode_ == IntPtr.Zero)
				id_onActionModeStarted_Landroid_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onActionModeStarted", "(Landroid/view/ActionMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onActionModeStarted_Landroid_view_ActionMode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActionModeStarted", "(Landroid/view/ActionMode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onAttachedToWindow;
#pragma warning disable 0169
		static Delegate GetOnAttachedToWindowHandler ()
		{
			if (cb_onAttachedToWindow == null)
				cb_onAttachedToWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAttachedToWindow);
			return cb_onAttachedToWindow;
		}

		static void n_OnAttachedToWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAttachedToWindow ();
		}
#pragma warning restore 0169

		static IntPtr id_onAttachedToWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onAttachedToWindow' and count(parameter)=0]"
		[Register ("onAttachedToWindow", "()V", "GetOnAttachedToWindowHandler")]
		public virtual unsafe void OnAttachedToWindow ()
		{
			if (id_onAttachedToWindow == IntPtr.Zero)
				id_onAttachedToWindow = JNIEnv.GetMethodID (class_ref, "onAttachedToWindow", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAttachedToWindow);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAttachedToWindow", "()V"));
			} finally {
			}
		}

		static Delegate cb_onContentChanged;
#pragma warning disable 0169
		static Delegate GetOnContentChangedHandler ()
		{
			if (cb_onContentChanged == null)
				cb_onContentChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnContentChanged);
			return cb_onContentChanged;
		}

		static void n_OnContentChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnContentChanged ();
		}
#pragma warning restore 0169

		static IntPtr id_onContentChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onContentChanged' and count(parameter)=0]"
		[Register ("onContentChanged", "()V", "GetOnContentChangedHandler")]
		public virtual unsafe void OnContentChanged ()
		{
			if (id_onContentChanged == IntPtr.Zero)
				id_onContentChanged = JNIEnv.GetMethodID (class_ref, "onContentChanged", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onContentChanged);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onContentChanged", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCreatePanelMenu_ILandroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnCreatePanelMenu_ILandroid_view_Menu_Handler ()
		{
			if (cb_onCreatePanelMenu_ILandroid_view_Menu_ == null)
				cb_onCreatePanelMenu_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnCreatePanelMenu_ILandroid_view_Menu_);
			return cb_onCreatePanelMenu_ILandroid_view_Menu_;
		}

		static bool n_OnCreatePanelMenu_ILandroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreatePanelMenu (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreatePanelMenu_ILandroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onCreatePanelMenu' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", "GetOnCreatePanelMenu_ILandroid_view_Menu_Handler")]
		public virtual unsafe bool OnCreatePanelMenu (int p0, global::Android.Views.IMenu p1)
		{
			if (id_onCreatePanelMenu_ILandroid_view_Menu_ == IntPtr.Zero)
				id_onCreatePanelMenu_ILandroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onCreatePanelMenu_ILandroid_view_Menu_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onCreatePanelView_I;
#pragma warning disable 0169
		static Delegate GetOnCreatePanelView_IHandler ()
		{
			if (cb_onCreatePanelView_I == null)
				cb_onCreatePanelView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_OnCreatePanelView_I);
			return cb_onCreatePanelView_I;
		}

		static IntPtr n_OnCreatePanelView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCreatePanelView (p0));
		}
#pragma warning restore 0169

		static IntPtr id_onCreatePanelView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onCreatePanelView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCreatePanelView", "(I)Landroid/view/View;", "GetOnCreatePanelView_IHandler")]
		public virtual unsafe global::Android.Views.View OnCreatePanelView (int p0)
		{
			if (id_onCreatePanelView_I == IntPtr.Zero)
				id_onCreatePanelView_I = JNIEnv.GetMethodID (class_ref, "onCreatePanelView", "(I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_onCreatePanelView_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreatePanelView", "(I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetachedFromWindow ();
		}
#pragma warning restore 0169

		static IntPtr id_onDetachedFromWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onDetachedFromWindow' and count(parameter)=0]"
		[Register ("onDetachedFromWindow", "()V", "GetOnDetachedFromWindowHandler")]
		public virtual unsafe void OnDetachedFromWindow ()
		{
			if (id_onDetachedFromWindow == IntPtr.Zero)
				id_onDetachedFromWindow = JNIEnv.GetMethodID (class_ref, "onDetachedFromWindow", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDetachedFromWindow);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDetachedFromWindow", "()V"));
			} finally {
			}
		}

		static Delegate cb_onMenuItemSelected_ILandroid_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnMenuItemSelected_ILandroid_view_MenuItem_Handler ()
		{
			if (cb_onMenuItemSelected_ILandroid_view_MenuItem_ == null)
				cb_onMenuItemSelected_ILandroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnMenuItemSelected_ILandroid_view_MenuItem_);
			return cb_onMenuItemSelected_ILandroid_view_MenuItem_;
		}

		static bool n_OnMenuItemSelected_ILandroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem p1 = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuItemSelected (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onMenuItemSelected_ILandroid_view_MenuItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onMenuItemSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.MenuItem']]"
		[Register ("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", "GetOnMenuItemSelected_ILandroid_view_MenuItem_Handler")]
		public virtual unsafe bool OnMenuItemSelected (int p0, global::Android.Views.IMenuItem p1)
		{
			if (id_onMenuItemSelected_ILandroid_view_MenuItem_ == IntPtr.Zero)
				id_onMenuItemSelected_ILandroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onMenuItemSelected_ILandroid_view_MenuItem_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onMenuOpened_ILandroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnMenuOpened_ILandroid_view_Menu_Handler ()
		{
			if (cb_onMenuOpened_ILandroid_view_Menu_ == null)
				cb_onMenuOpened_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnMenuOpened_ILandroid_view_Menu_);
			return cb_onMenuOpened_ILandroid_view_Menu_;
		}

		static bool n_OnMenuOpened_ILandroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMenuOpened (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onMenuOpened_ILandroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onMenuOpened' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onMenuOpened", "(ILandroid/view/Menu;)Z", "GetOnMenuOpened_ILandroid_view_Menu_Handler")]
		public virtual unsafe bool OnMenuOpened (int p0, global::Android.Views.IMenu p1)
		{
			if (id_onMenuOpened_ILandroid_view_Menu_ == IntPtr.Zero)
				id_onMenuOpened_ILandroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onMenuOpened", "(ILandroid/view/Menu;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onMenuOpened_ILandroid_view_Menu_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMenuOpened", "(ILandroid/view/Menu;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onPanelClosed_ILandroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnPanelClosed_ILandroid_view_Menu_Handler ()
		{
			if (cb_onPanelClosed_ILandroid_view_Menu_ == null)
				cb_onPanelClosed_ILandroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnPanelClosed_ILandroid_view_Menu_);
			return cb_onPanelClosed_ILandroid_view_Menu_;
		}

		static void n_OnPanelClosed_ILandroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPanelClosed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onPanelClosed_ILandroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onPanelClosed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.Menu']]"
		[Register ("onPanelClosed", "(ILandroid/view/Menu;)V", "GetOnPanelClosed_ILandroid_view_Menu_Handler")]
		public virtual unsafe void OnPanelClosed (int p0, global::Android.Views.IMenu p1)
		{
			if (id_onPanelClosed_ILandroid_view_Menu_ == IntPtr.Zero)
				id_onPanelClosed_ILandroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPanelClosed", "(ILandroid/view/Menu;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPanelClosed_ILandroid_view_Menu_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPanelClosed", "(ILandroid/view/Menu;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;
#pragma warning disable 0169
		static Delegate GetOnPreparePanel_ILandroid_view_View_Landroid_view_Menu_Handler ()
		{
			if (cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ == null)
				cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_OnPreparePanel_ILandroid_view_View_Landroid_view_Menu_);
			return cb_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;
		}

		static bool n_OnPreparePanel_ILandroid_view_View_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu p2 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPreparePanel (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onPreparePanel' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.Menu']]"
		[Register ("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", "GetOnPreparePanel_ILandroid_view_View_Landroid_view_Menu_Handler")]
		public virtual unsafe bool OnPreparePanel (int p0, global::Android.Views.View p1, global::Android.Views.IMenu p2)
		{
			if (id_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ == IntPtr.Zero)
				id_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onPreparePanel_ILandroid_view_View_Landroid_view_Menu_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onSearchRequested;
#pragma warning disable 0169
		static Delegate GetOnSearchRequestedHandler ()
		{
			if (cb_onSearchRequested == null)
				cb_onSearchRequested = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnSearchRequested);
			return cb_onSearchRequested;
		}

		static bool n_OnSearchRequested (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnSearchRequested ();
		}
#pragma warning restore 0169

		static IntPtr id_onSearchRequested;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onSearchRequested' and count(parameter)=0]"
		[Register ("onSearchRequested", "()Z", "GetOnSearchRequestedHandler")]
		public virtual unsafe bool OnSearchRequested ()
		{
			if (id_onSearchRequested == IntPtr.Zero)
				id_onSearchRequested = JNIEnv.GetMethodID (class_ref, "onSearchRequested", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_onSearchRequested);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSearchRequested", "()Z"));
			} finally {
			}
		}

		static Delegate cb_onSearchRequested_Landroid_view_SearchEvent_;
#pragma warning disable 0169
		static Delegate GetOnSearchRequested_Landroid_view_SearchEvent_Handler ()
		{
			if (cb_onSearchRequested_Landroid_view_SearchEvent_ == null)
				cb_onSearchRequested_Landroid_view_SearchEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSearchRequested_Landroid_view_SearchEvent_);
			return cb_onSearchRequested_Landroid_view_SearchEvent_;
		}

		static bool n_OnSearchRequested_Landroid_view_SearchEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.SearchEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.SearchEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSearchRequested (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSearchRequested_Landroid_view_SearchEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onSearchRequested' and count(parameter)=1 and parameter[1][@type='android.view.SearchEvent']]"
		[Register ("onSearchRequested", "(Landroid/view/SearchEvent;)Z", "GetOnSearchRequested_Landroid_view_SearchEvent_Handler")]
		public virtual unsafe bool OnSearchRequested (global::Android.Views.SearchEvent p0)
		{
			if (id_onSearchRequested_Landroid_view_SearchEvent_ == IntPtr.Zero)
				id_onSearchRequested_Landroid_view_SearchEvent_ = JNIEnv.GetMethodID (class_ref, "onSearchRequested", "(Landroid/view/SearchEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSearchRequested_Landroid_view_SearchEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSearchRequested", "(Landroid/view/SearchEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetOnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_Handler ()
		{
			if (cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ == null)
				cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_);
			return cb_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;
		}

		static void n_OnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.WindowManagerLayoutParams p0 = global::Java.Lang.Object.GetObject<global::Android.Views.WindowManagerLayoutParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnWindowAttributesChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onWindowAttributesChanged' and count(parameter)=1 and parameter[1][@type='android.view.WindowManager.LayoutParams']]"
		[Register ("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", "GetOnWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_Handler")]
		public virtual unsafe void OnWindowAttributesChanged (global::Android.Views.WindowManagerLayoutParams p0)
		{
			if (id_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ == IntPtr.Zero)
				id_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onWindowAttributesChanged_Landroid_view_WindowManager_LayoutParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onWindowFocusChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnWindowFocusChanged_ZHandler ()
		{
			if (cb_onWindowFocusChanged_Z == null)
				cb_onWindowFocusChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnWindowFocusChanged_Z);
			return cb_onWindowFocusChanged_Z;
		}

		static void n_OnWindowFocusChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnWindowFocusChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onWindowFocusChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onWindowFocusChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onWindowFocusChanged", "(Z)V", "GetOnWindowFocusChanged_ZHandler")]
		public virtual unsafe void OnWindowFocusChanged (bool p0)
		{
			if (id_onWindowFocusChanged_Z == IntPtr.Zero)
				id_onWindowFocusChanged_Z = JNIEnv.GetMethodID (class_ref, "onWindowFocusChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onWindowFocusChanged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onWindowFocusChanged", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;
#pragma warning disable 0169
		static Delegate GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_Handler ()
		{
			if (cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ == null)
				cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_);
			return cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;
		}

		static IntPtr n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ActionMode.ICallback p0 = (global::Android.Views.ActionMode.ICallback)global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnWindowStartingActionMode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onWindowStartingActionMode' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode.Callback']]"
		[Register ("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", "GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_Handler")]
		public virtual unsafe global::Android.Views.ActionMode OnWindowStartingActionMode (global::Android.Views.ActionMode.ICallback p0)
		{
			if (id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ == IntPtr.Zero)
				id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_ = JNIEnv.GetMethodID (class_ref, "onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Views.ActionMode __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (JNIEnv.CallObjectMethod  (Handle, id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;
#pragma warning disable 0169
		static Delegate GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_IHandler ()
		{
			if (cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I == null)
				cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_I);
			return cb_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;
		}

		static IntPtr n_OnWindowStartingActionMode_Landroid_view_ActionMode_Callback_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Android.Support.V7.Internal.View.WindowCallbackWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.WindowCallbackWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ActionMode.ICallback p0 = (global::Android.Views.ActionMode.ICallback)global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ActionModeType p1 = (global::Android.Views.ActionModeType) native_p1;
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnWindowStartingActionMode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='WindowCallbackWrapper']/method[@name='onWindowStartingActionMode' and count(parameter)=2 and parameter[1][@type='android.view.ActionMode.Callback'] and parameter[2][@type='int']]"
		[Register ("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;", "GetOnWindowStartingActionMode_Landroid_view_ActionMode_Callback_IHandler")]
		public virtual unsafe global::Android.Views.ActionMode OnWindowStartingActionMode (global::Android.Views.ActionMode.ICallback p0, [global::Android.Runtime.GeneratedEnum] global::Android.Views.ActionModeType p1)
		{
			if (id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I == IntPtr.Zero)
				id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I = JNIEnv.GetMethodID (class_ref, "onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				global::Android.Views.ActionMode __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (JNIEnv.CallObjectMethod  (Handle, id_onWindowStartingActionMode_Landroid_view_ActionMode_Callback_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
