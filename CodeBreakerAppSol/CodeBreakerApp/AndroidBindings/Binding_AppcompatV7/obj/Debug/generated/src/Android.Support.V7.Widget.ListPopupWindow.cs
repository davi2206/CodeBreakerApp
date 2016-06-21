using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']"
	[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow", DoNotGenerateAcw=true)]
	public partial class ListPopupWindow : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/field[@name='INPUT_METHOD_FROM_FOCUSABLE']"
		[Register ("INPUT_METHOD_FROM_FOCUSABLE")]
		public const int InputMethodFromFocusable = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/field[@name='INPUT_METHOD_NEEDED']"
		[Register ("INPUT_METHOD_NEEDED")]
		public const int InputMethodNeeded = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/field[@name='INPUT_METHOD_NOT_NEEDED']"
		[Register ("INPUT_METHOD_NOT_NEEDED")]
		public const int InputMethodNotNeeded = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/field[@name='MATCH_PARENT']"
		[Register ("MATCH_PARENT")]
		public const int MatchParent = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/field[@name='POSITION_PROMPT_ABOVE']"
		[Register ("POSITION_PROMPT_ABOVE")]
		public const int PositionPromptAbove = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/field[@name='POSITION_PROMPT_BELOW']"
		[Register ("POSITION_PROMPT_BELOW")]
		public const int PositionPromptBelow = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/field[@name='WRAP_CONTENT']"
		[Register ("WRAP_CONTENT")]
		public const int WrapContent = (int) -2;
		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.DropDownListView']"
		[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow$DropDownListView", DoNotGenerateAcw=true)]
		public partial class DropDownListView : global::Android.Support.V7.Internal.Widget.ListViewCompat {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/widget/ListPopupWindow$DropDownListView", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DropDownListView); }
			}

			protected DropDownListView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_Z;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.DropDownListView']/constructor[@name='ListPopupWindow.DropDownListView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Landroid/content/Context;Z)V", "")]
			public unsafe DropDownListView (global::Android.Content.Context p0, bool p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (DropDownListView)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Z)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Z)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_Z == IntPtr.Zero)
						id_ctor_Landroid_content_Context_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Z)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Z, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Z, __args);
				} finally {
				}
			}

			static Delegate cb_onForwardedEvent_Landroid_view_MotionEvent_I;
#pragma warning disable 0169
			static Delegate GetOnForwardedEvent_Landroid_view_MotionEvent_IHandler ()
			{
				if (cb_onForwardedEvent_Landroid_view_MotionEvent_I == null)
					cb_onForwardedEvent_Landroid_view_MotionEvent_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_OnForwardedEvent_Landroid_view_MotionEvent_I);
				return cb_onForwardedEvent_Landroid_view_MotionEvent_I;
			}

			static bool n_OnForwardedEvent_Landroid_view_MotionEvent_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Android.Support.V7.Widget.ListPopupWindow.DropDownListView __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.DropDownListView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnForwardedEvent (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onForwardedEvent_Landroid_view_MotionEvent_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.DropDownListView']/method[@name='onForwardedEvent' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='int']]"
			[Register ("onForwardedEvent", "(Landroid/view/MotionEvent;I)Z", "GetOnForwardedEvent_Landroid_view_MotionEvent_IHandler")]
			public virtual unsafe bool OnForwardedEvent (global::Android.Views.MotionEvent p0, int p1)
			{
				if (id_onForwardedEvent_Landroid_view_MotionEvent_I == IntPtr.Zero)
					id_onForwardedEvent_Landroid_view_MotionEvent_I = JNIEnv.GetMethodID (class_ref, "onForwardedEvent", "(Landroid/view/MotionEvent;I)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_onForwardedEvent_Landroid_view_MotionEvent_I, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onForwardedEvent", "(Landroid/view/MotionEvent;I)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener']"
		[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow$ForwardingListener", DoNotGenerateAcw=true)]
		public abstract partial class ForwardingListener : global::Java.Lang.Object, global::Android.Views.View.IOnTouchListener {

			// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener.DisallowIntercept']"
			[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow$ForwardingListener$DisallowIntercept", DoNotGenerateAcw=true)]
			public partial class DisallowIntercept : global::Java.Lang.Object, global::Java.Lang.IRunnable {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("android/support/v7/widget/ListPopupWindow$ForwardingListener$DisallowIntercept", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (DisallowIntercept); }
				}

				protected DisallowIntercept (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_run;
#pragma warning disable 0169
				static Delegate GetRunHandler ()
				{
					if (cb_run == null)
						cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
					return cb_run;
				}

				static void n_Run (IntPtr jnienv, IntPtr native__this)
				{
					global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener.DisallowIntercept __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener.DisallowIntercept> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					__this.Run ();
				}
#pragma warning restore 0169

				static IntPtr id_run;
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener.DisallowIntercept']/method[@name='run' and count(parameter)=0]"
				[Register ("run", "()V", "GetRunHandler")]
				public virtual unsafe void Run ()
				{
					if (id_run == IntPtr.Zero)
						id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
					try {

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_run);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
					} finally {
					}
				}

			}

			// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener.TriggerLongPress']"
			[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow$ForwardingListener$TriggerLongPress", DoNotGenerateAcw=true)]
			public partial class TriggerLongPress : global::Java.Lang.Object, global::Java.Lang.IRunnable {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("android/support/v7/widget/ListPopupWindow$ForwardingListener$TriggerLongPress", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (TriggerLongPress); }
				}

				protected TriggerLongPress (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_run;
#pragma warning disable 0169
				static Delegate GetRunHandler ()
				{
					if (cb_run == null)
						cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
					return cb_run;
				}

				static void n_Run (IntPtr jnienv, IntPtr native__this)
				{
					global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener.TriggerLongPress __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener.TriggerLongPress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					__this.Run ();
				}
#pragma warning restore 0169

				static IntPtr id_run;
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener.TriggerLongPress']/method[@name='run' and count(parameter)=0]"
				[Register ("run", "()V", "GetRunHandler")]
				public virtual unsafe void Run ()
				{
					if (id_run == IntPtr.Zero)
						id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
					try {

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod  (Handle, id_run);
						else
							JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/widget/ListPopupWindow$ForwardingListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ForwardingListener); }
			}

			protected ForwardingListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener']/constructor[@name='ListPopupWindow.ForwardingListener' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register (".ctor", "(Landroid/view/View;)V", "")]
			public unsafe ForwardingListener (global::Android.Views.View p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (ForwardingListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_, __args);
				} finally {
				}
			}

			static Delegate cb_getPopup;
#pragma warning disable 0169
			static Delegate GetGetPopupHandler ()
			{
				if (cb_getPopup == null)
					cb_getPopup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPopup);
				return cb_getPopup;
			}

			static IntPtr n_GetPopup (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Popup);
			}
#pragma warning restore 0169

			public abstract global::Android.Support.V7.Widget.ListPopupWindow Popup {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener']/method[@name='getPopup' and count(parameter)=0]"
				[Register ("getPopup", "()Landroid/support/v7/widget/ListPopupWindow;", "GetGetPopupHandler")] get;
			}

			static Delegate cb_onForwardingStarted;
#pragma warning disable 0169
			static Delegate GetOnForwardingStartedHandler ()
			{
				if (cb_onForwardingStarted == null)
					cb_onForwardingStarted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnForwardingStarted);
				return cb_onForwardingStarted;
			}

			static bool n_OnForwardingStarted (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnForwardingStarted ();
			}
#pragma warning restore 0169

			static IntPtr id_onForwardingStarted;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener']/method[@name='onForwardingStarted' and count(parameter)=0]"
			[Register ("onForwardingStarted", "()Z", "GetOnForwardingStartedHandler")]
			protected virtual unsafe bool OnForwardingStarted ()
			{
				if (id_onForwardingStarted == IntPtr.Zero)
					id_onForwardingStarted = JNIEnv.GetMethodID (class_ref, "onForwardingStarted", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_onForwardingStarted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onForwardingStarted", "()Z"));
				} finally {
				}
			}

			static Delegate cb_onForwardingStopped;
#pragma warning disable 0169
			static Delegate GetOnForwardingStoppedHandler ()
			{
				if (cb_onForwardingStopped == null)
					cb_onForwardingStopped = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnForwardingStopped);
				return cb_onForwardingStopped;
			}

			static bool n_OnForwardingStopped (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnForwardingStopped ();
			}
#pragma warning restore 0169

			static IntPtr id_onForwardingStopped;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener']/method[@name='onForwardingStopped' and count(parameter)=0]"
			[Register ("onForwardingStopped", "()Z", "GetOnForwardingStoppedHandler")]
			protected virtual unsafe bool OnForwardingStopped ()
			{
				if (id_onForwardingStopped == IntPtr.Zero)
					id_onForwardingStopped = JNIEnv.GetMethodID (class_ref, "onForwardingStopped", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_onForwardingStopped);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onForwardingStopped", "()Z"));
				} finally {
				}
			}

			static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
					cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
				return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			}

			static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.ForwardingListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTouch (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
			[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
			{
				if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow$ForwardingListener", DoNotGenerateAcw=true)]
		internal partial class ForwardingListenerInvoker : ForwardingListener {

			public ForwardingListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ForwardingListenerInvoker); }
			}

			static IntPtr id_getPopup;
			public override unsafe global::Android.Support.V7.Widget.ListPopupWindow Popup {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ForwardingListener']/method[@name='getPopup' and count(parameter)=0]"
				[Register ("getPopup", "()Landroid/support/v7/widget/ListPopupWindow;", "GetGetPopupHandler")]
				get {
					if (id_getPopup == IntPtr.Zero)
						id_getPopup = JNIEnv.GetMethodID (class_ref, "getPopup", "()Landroid/support/v7/widget/ListPopupWindow;");
					try {
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (JNIEnv.CallObjectMethod  (Handle, id_getPopup), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ListSelectorHider']"
		[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow$ListSelectorHider", DoNotGenerateAcw=true)]
		public partial class ListSelectorHider : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/widget/ListPopupWindow$ListSelectorHider", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ListSelectorHider); }
			}

			protected ListSelectorHider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.ListPopupWindow.ListSelectorHider __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.ListSelectorHider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ListSelectorHider']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.PopupDataSetObserver']"
		[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow$PopupDataSetObserver", DoNotGenerateAcw=true)]
		public partial class PopupDataSetObserver : global::Android.Database.DataSetObserver {

			protected PopupDataSetObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.PopupScrollListener']"
		[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow$PopupScrollListener", DoNotGenerateAcw=true)]
		public partial class PopupScrollListener : global::Java.Lang.Object, global::Android.Widget.AbsListView.IOnScrollListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/widget/ListPopupWindow$PopupScrollListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PopupScrollListener); }
			}

			protected PopupScrollListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onScroll_Landroid_widget_AbsListView_III;
#pragma warning disable 0169
			static Delegate GetOnScroll_Landroid_widget_AbsListView_IIIHandler ()
			{
				if (cb_onScroll_Landroid_widget_AbsListView_III == null)
					cb_onScroll_Landroid_widget_AbsListView_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnScroll_Landroid_widget_AbsListView_III);
				return cb_onScroll_Landroid_widget_AbsListView_III;
			}

			static void n_OnScroll_Landroid_widget_AbsListView_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
			{
				global::Android.Support.V7.Widget.ListPopupWindow.PopupScrollListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.PopupScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnScroll (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onScroll_Landroid_widget_AbsListView_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.PopupScrollListener']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onScroll", "(Landroid/widget/AbsListView;III)V", "GetOnScroll_Landroid_widget_AbsListView_IIIHandler")]
			public virtual unsafe void OnScroll (global::Android.Widget.AbsListView p0, int p1, int p2, int p3)
			{
				if (id_onScroll_Landroid_widget_AbsListView_III == IntPtr.Zero)
					id_onScroll_Landroid_widget_AbsListView_III = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/widget/AbsListView;III)V");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onScroll_Landroid_widget_AbsListView_III, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Landroid/widget/AbsListView;III)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
#pragma warning disable 0169
			static Delegate GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler ()
			{
				if (cb_onScrollStateChanged_Landroid_widget_AbsListView_I == null)
					cb_onScrollStateChanged_Landroid_widget_AbsListView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnScrollStateChanged_Landroid_widget_AbsListView_I);
				return cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
			}

			static void n_OnScrollStateChanged_Landroid_widget_AbsListView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Android.Support.V7.Widget.ListPopupWindow.PopupScrollListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.PopupScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.ScrollState p1 = (global::Android.Widget.ScrollState) native_p1;
				__this.OnScrollStateChanged (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onScrollStateChanged_Landroid_widget_AbsListView_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.PopupScrollListener']/method[@name='onScrollStateChanged' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int']]"
			[Register ("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", "GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler")]
			public virtual unsafe void OnScrollStateChanged (global::Android.Widget.AbsListView p0, [global::Android.Runtime.GeneratedEnum] global::Android.Widget.ScrollState p1)
			{
				if (id_onScrollStateChanged_Landroid_widget_AbsListView_I == IntPtr.Zero)
					id_onScrollStateChanged_Landroid_widget_AbsListView_I = JNIEnv.GetMethodID (class_ref, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onScrollStateChanged_Landroid_widget_AbsListView_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.PopupTouchInterceptor']"
		[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow$PopupTouchInterceptor", DoNotGenerateAcw=true)]
		public partial class PopupTouchInterceptor : global::Java.Lang.Object, global::Android.Views.View.IOnTouchListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/widget/ListPopupWindow$PopupTouchInterceptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PopupTouchInterceptor); }
			}

			protected PopupTouchInterceptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
					cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
				return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			}

			static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.Widget.ListPopupWindow.PopupTouchInterceptor __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.PopupTouchInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTouch (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.PopupTouchInterceptor']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
			[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
			{
				if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ResizePopupRunnable']"
		[global::Android.Runtime.Register ("android/support/v7/widget/ListPopupWindow$ResizePopupRunnable", DoNotGenerateAcw=true)]
		public partial class ResizePopupRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/widget/ListPopupWindow$ResizePopupRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResizePopupRunnable); }
			}

			protected ResizePopupRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.Widget.ListPopupWindow.ResizePopupRunnable __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow.ResizePopupRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow.ResizePopupRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/widget/ListPopupWindow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListPopupWindow); }
		}

		protected ListPopupWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/constructor[@name='ListPopupWindow' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ListPopupWindow (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ListPopupWindow)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/constructor[@name='ListPopupWindow' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ListPopupWindow (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ListPopupWindow)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/constructor[@name='ListPopupWindow' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe ListPopupWindow (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (ListPopupWindow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/constructor[@name='ListPopupWindow' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ListPopupWindow (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ListPopupWindow)) {
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

		static Delegate cb_getAnchorView;
#pragma warning disable 0169
		static Delegate GetGetAnchorViewHandler ()
		{
			if (cb_getAnchorView == null)
				cb_getAnchorView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnchorView);
			return cb_getAnchorView;
		}

		static IntPtr n_GetAnchorView (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnchorView);
		}
#pragma warning restore 0169

		static Delegate cb_setAnchorView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetAnchorView_Landroid_view_View_Handler ()
		{
			if (cb_setAnchorView_Landroid_view_View_ == null)
				cb_setAnchorView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnchorView_Landroid_view_View_);
			return cb_setAnchorView_Landroid_view_View_;
		}

		static void n_SetAnchorView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AnchorView = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAnchorView;
		static IntPtr id_setAnchorView_Landroid_view_View_;
		public virtual unsafe global::Android.Views.View AnchorView {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getAnchorView' and count(parameter)=0]"
			[Register ("getAnchorView", "()Landroid/view/View;", "GetGetAnchorViewHandler")]
			get {
				if (id_getAnchorView == IntPtr.Zero)
					id_getAnchorView = JNIEnv.GetMethodID (class_ref, "getAnchorView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getAnchorView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnchorView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setAnchorView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setAnchorView", "(Landroid/view/View;)V", "GetSetAnchorView_Landroid_view_View_Handler")]
			set {
				if (id_setAnchorView_Landroid_view_View_ == IntPtr.Zero)
					id_setAnchorView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setAnchorView", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAnchorView_Landroid_view_View_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnchorView", "(Landroid/view/View;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAnimationStyle;
#pragma warning disable 0169
		static Delegate GetGetAnimationStyleHandler ()
		{
			if (cb_getAnimationStyle == null)
				cb_getAnimationStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAnimationStyle);
			return cb_getAnimationStyle;
		}

		static int n_GetAnimationStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnimationStyle;
		}
#pragma warning restore 0169

		static Delegate cb_setAnimationStyle_I;
#pragma warning disable 0169
		static Delegate GetSetAnimationStyle_IHandler ()
		{
			if (cb_setAnimationStyle_I == null)
				cb_setAnimationStyle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAnimationStyle_I);
			return cb_setAnimationStyle_I;
		}

		static void n_SetAnimationStyle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimationStyle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAnimationStyle;
		static IntPtr id_setAnimationStyle_I;
		public virtual unsafe int AnimationStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getAnimationStyle' and count(parameter)=0]"
			[Register ("getAnimationStyle", "()I", "GetGetAnimationStyleHandler")]
			get {
				if (id_getAnimationStyle == IntPtr.Zero)
					id_getAnimationStyle = JNIEnv.GetMethodID (class_ref, "getAnimationStyle", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getAnimationStyle);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnimationStyle", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setAnimationStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAnimationStyle", "(I)V", "GetSetAnimationStyle_IHandler")]
			set {
				if (id_setAnimationStyle_I == IntPtr.Zero)
					id_setAnimationStyle_I = JNIEnv.GetMethodID (class_ref, "setAnimationStyle", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setAnimationStyle_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationStyle", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBackground;
#pragma warning disable 0169
		static Delegate GetGetBackgroundHandler ()
		{
			if (cb_getBackground == null)
				cb_getBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackground);
			return cb_getBackground;
		}

		static IntPtr n_GetBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Background);
		}
#pragma warning restore 0169

		static IntPtr id_getBackground;
		public virtual unsafe global::Android.Graphics.Drawables.Drawable Background {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getBackground' and count(parameter)=0]"
			[Register ("getBackground", "()Landroid/graphics/drawable/Drawable;", "GetGetBackgroundHandler")]
			get {
				if (id_getBackground == IntPtr.Zero)
					id_getBackground = JNIEnv.GetMethodID (class_ref, "getBackground", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getBackground), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackground", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDropDownAlwaysVisible;
#pragma warning disable 0169
		static Delegate GetIsDropDownAlwaysVisibleHandler ()
		{
			if (cb_isDropDownAlwaysVisible == null)
				cb_isDropDownAlwaysVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDropDownAlwaysVisible);
			return cb_isDropDownAlwaysVisible;
		}

		static bool n_IsDropDownAlwaysVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DropDownAlwaysVisible;
		}
#pragma warning restore 0169

		static Delegate cb_setDropDownAlwaysVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetDropDownAlwaysVisible_ZHandler ()
		{
			if (cb_setDropDownAlwaysVisible_Z == null)
				cb_setDropDownAlwaysVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDropDownAlwaysVisible_Z);
			return cb_setDropDownAlwaysVisible_Z;
		}

		static void n_SetDropDownAlwaysVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DropDownAlwaysVisible = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDropDownAlwaysVisible;
		static IntPtr id_setDropDownAlwaysVisible_Z;
		public virtual unsafe bool DropDownAlwaysVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='isDropDownAlwaysVisible' and count(parameter)=0]"
			[Register ("isDropDownAlwaysVisible", "()Z", "GetIsDropDownAlwaysVisibleHandler")]
			get {
				if (id_isDropDownAlwaysVisible == IntPtr.Zero)
					id_isDropDownAlwaysVisible = JNIEnv.GetMethodID (class_ref, "isDropDownAlwaysVisible", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDropDownAlwaysVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDropDownAlwaysVisible", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setDropDownAlwaysVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDropDownAlwaysVisible", "(Z)V", "GetSetDropDownAlwaysVisible_ZHandler")]
			set {
				if (id_setDropDownAlwaysVisible_Z == IntPtr.Zero)
					id_setDropDownAlwaysVisible_Z = JNIEnv.GetMethodID (class_ref, "setDropDownAlwaysVisible", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDropDownAlwaysVisible_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDropDownAlwaysVisible", "(Z)V"), __args);
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
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static Delegate cb_setHeight_I;
#pragma warning disable 0169
		static Delegate GetSetHeight_IHandler ()
		{
			if (cb_setHeight_I == null)
				cb_setHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeight_I);
			return cb_setHeight_I;
		}

		static void n_SetHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Height = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		static IntPtr id_setHeight_I;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeight", "(I)V", "GetSetHeight_IHandler")]
			set {
				if (id_setHeight_I == IntPtr.Zero)
					id_setHeight_I = JNIEnv.GetMethodID (class_ref, "setHeight", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHeight_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHorizontalOffset;
#pragma warning disable 0169
		static Delegate GetGetHorizontalOffsetHandler ()
		{
			if (cb_getHorizontalOffset == null)
				cb_getHorizontalOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHorizontalOffset);
			return cb_getHorizontalOffset;
		}

		static int n_GetHorizontalOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HorizontalOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setHorizontalOffset_I;
#pragma warning disable 0169
		static Delegate GetSetHorizontalOffset_IHandler ()
		{
			if (cb_setHorizontalOffset_I == null)
				cb_setHorizontalOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHorizontalOffset_I);
			return cb_setHorizontalOffset_I;
		}

		static void n_SetHorizontalOffset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HorizontalOffset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHorizontalOffset;
		static IntPtr id_setHorizontalOffset_I;
		public virtual unsafe int HorizontalOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getHorizontalOffset' and count(parameter)=0]"
			[Register ("getHorizontalOffset", "()I", "GetGetHorizontalOffsetHandler")]
			get {
				if (id_getHorizontalOffset == IntPtr.Zero)
					id_getHorizontalOffset = JNIEnv.GetMethodID (class_ref, "getHorizontalOffset", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHorizontalOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHorizontalOffset", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setHorizontalOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHorizontalOffset", "(I)V", "GetSetHorizontalOffset_IHandler")]
			set {
				if (id_setHorizontalOffset_I == IntPtr.Zero)
					id_setHorizontalOffset_I = JNIEnv.GetMethodID (class_ref, "setHorizontalOffset", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHorizontalOffset_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHorizontalOffset", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInputMethodMode;
#pragma warning disable 0169
		static Delegate GetGetInputMethodModeHandler ()
		{
			if (cb_getInputMethodMode == null)
				cb_getInputMethodMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInputMethodMode);
			return cb_getInputMethodMode;
		}

		static int n_GetInputMethodMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InputMethodMode;
		}
#pragma warning restore 0169

		static Delegate cb_setInputMethodMode_I;
#pragma warning disable 0169
		static Delegate GetSetInputMethodMode_IHandler ()
		{
			if (cb_setInputMethodMode_I == null)
				cb_setInputMethodMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetInputMethodMode_I);
			return cb_setInputMethodMode_I;
		}

		static void n_SetInputMethodMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InputMethodMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInputMethodMode;
		static IntPtr id_setInputMethodMode_I;
		public virtual unsafe int InputMethodMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getInputMethodMode' and count(parameter)=0]"
			[Register ("getInputMethodMode", "()I", "GetGetInputMethodModeHandler")]
			get {
				if (id_getInputMethodMode == IntPtr.Zero)
					id_getInputMethodMode = JNIEnv.GetMethodID (class_ref, "getInputMethodMode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getInputMethodMode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputMethodMode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setInputMethodMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setInputMethodMode", "(I)V", "GetSetInputMethodMode_IHandler")]
			set {
				if (id_setInputMethodMode_I == IntPtr.Zero)
					id_setInputMethodMode_I = JNIEnv.GetMethodID (class_ref, "setInputMethodMode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setInputMethodMode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInputMethodMode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isInputMethodNotNeeded;
#pragma warning disable 0169
		static Delegate GetIsInputMethodNotNeededHandler ()
		{
			if (cb_isInputMethodNotNeeded == null)
				cb_isInputMethodNotNeeded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInputMethodNotNeeded);
			return cb_isInputMethodNotNeeded;
		}

		static bool n_IsInputMethodNotNeeded (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInputMethodNotNeeded;
		}
#pragma warning restore 0169

		static IntPtr id_isInputMethodNotNeeded;
		public virtual unsafe bool IsInputMethodNotNeeded {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='isInputMethodNotNeeded' and count(parameter)=0]"
			[Register ("isInputMethodNotNeeded", "()Z", "GetIsInputMethodNotNeededHandler")]
			get {
				if (id_isInputMethodNotNeeded == IntPtr.Zero)
					id_isInputMethodNotNeeded = JNIEnv.GetMethodID (class_ref, "isInputMethodNotNeeded", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInputMethodNotNeeded);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInputMethodNotNeeded", "()Z"));
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
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowing;
		}
#pragma warning restore 0169

		static IntPtr id_isShowing;
		public virtual unsafe bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "GetIsShowingHandler")]
			get {
				if (id_isShowing == IntPtr.Zero)
					id_isShowing = JNIEnv.GetMethodID (class_ref, "isShowing", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isShowing);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowing", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getListView;
#pragma warning disable 0169
		static Delegate GetGetListViewHandler ()
		{
			if (cb_getListView == null)
				cb_getListView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListView);
			return cb_getListView;
		}

		static IntPtr n_GetListView (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListView);
		}
#pragma warning restore 0169

		static IntPtr id_getListView;
		public virtual unsafe global::Android.Widget.ListView ListView {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getListView' and count(parameter)=0]"
			[Register ("getListView", "()Landroid/widget/ListView;", "GetGetListViewHandler")]
			get {
				if (id_getListView == IntPtr.Zero)
					id_getListView = JNIEnv.GetMethodID (class_ref, "getListView", "()Landroid/widget/ListView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (JNIEnv.CallObjectMethod  (Handle, id_getListView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListView", "()Landroid/widget/ListView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isModal;
#pragma warning disable 0169
		static Delegate GetIsModalHandler ()
		{
			if (cb_isModal == null)
				cb_isModal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsModal);
			return cb_isModal;
		}

		static bool n_IsModal (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Modal;
		}
#pragma warning restore 0169

		static Delegate cb_setModal_Z;
#pragma warning disable 0169
		static Delegate GetSetModal_ZHandler ()
		{
			if (cb_setModal_Z == null)
				cb_setModal_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetModal_Z);
			return cb_setModal_Z;
		}

		static void n_SetModal_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Modal = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isModal;
		static IntPtr id_setModal_Z;
		public virtual unsafe bool Modal {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='isModal' and count(parameter)=0]"
			[Register ("isModal", "()Z", "GetIsModalHandler")]
			get {
				if (id_isModal == IntPtr.Zero)
					id_isModal = JNIEnv.GetMethodID (class_ref, "isModal", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isModal);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isModal", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setModal' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setModal", "(Z)V", "GetSetModal_ZHandler")]
			set {
				if (id_setModal_Z == IntPtr.Zero)
					id_setModal_Z = JNIEnv.GetMethodID (class_ref, "setModal", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setModal_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModal", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPromptPosition;
#pragma warning disable 0169
		static Delegate GetGetPromptPositionHandler ()
		{
			if (cb_getPromptPosition == null)
				cb_getPromptPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPromptPosition);
			return cb_getPromptPosition;
		}

		static int n_GetPromptPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PromptPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setPromptPosition_I;
#pragma warning disable 0169
		static Delegate GetSetPromptPosition_IHandler ()
		{
			if (cb_setPromptPosition_I == null)
				cb_setPromptPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPromptPosition_I);
			return cb_setPromptPosition_I;
		}

		static void n_SetPromptPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PromptPosition = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPromptPosition;
		static IntPtr id_setPromptPosition_I;
		public virtual unsafe int PromptPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getPromptPosition' and count(parameter)=0]"
			[Register ("getPromptPosition", "()I", "GetGetPromptPositionHandler")]
			get {
				if (id_getPromptPosition == IntPtr.Zero)
					id_getPromptPosition = JNIEnv.GetMethodID (class_ref, "getPromptPosition", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPromptPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPromptPosition", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setPromptPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPromptPosition", "(I)V", "GetSetPromptPosition_IHandler")]
			set {
				if (id_setPromptPosition_I == IntPtr.Zero)
					id_setPromptPosition_I = JNIEnv.GetMethodID (class_ref, "setPromptPosition", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPromptPosition_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPromptPosition", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedItem;
#pragma warning disable 0169
		static Delegate GetGetSelectedItemHandler ()
		{
			if (cb_getSelectedItem == null)
				cb_getSelectedItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedItem);
			return cb_getSelectedItem;
		}

		static IntPtr n_GetSelectedItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedItem);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedItem;
		public virtual unsafe global::Java.Lang.Object SelectedItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getSelectedItem' and count(parameter)=0]"
			[Register ("getSelectedItem", "()Ljava/lang/Object;", "GetGetSelectedItemHandler")]
			get {
				if (id_getSelectedItem == IntPtr.Zero)
					id_getSelectedItem = JNIEnv.GetMethodID (class_ref, "getSelectedItem", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getSelectedItem), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedItem", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedItemId;
#pragma warning disable 0169
		static Delegate GetGetSelectedItemIdHandler ()
		{
			if (cb_getSelectedItemId == null)
				cb_getSelectedItemId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSelectedItemId);
			return cb_getSelectedItemId;
		}

		static long n_GetSelectedItemId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedItemId;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedItemId;
		public virtual unsafe long SelectedItemId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getSelectedItemId' and count(parameter)=0]"
			[Register ("getSelectedItemId", "()J", "GetGetSelectedItemIdHandler")]
			get {
				if (id_getSelectedItemId == IntPtr.Zero)
					id_getSelectedItemId = JNIEnv.GetMethodID (class_ref, "getSelectedItemId", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getSelectedItemId);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedItemId", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedItemPosition;
#pragma warning disable 0169
		static Delegate GetGetSelectedItemPositionHandler ()
		{
			if (cb_getSelectedItemPosition == null)
				cb_getSelectedItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedItemPosition);
			return cb_getSelectedItemPosition;
		}

		static int n_GetSelectedItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedItemPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedItemPosition;
		public virtual unsafe int SelectedItemPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getSelectedItemPosition' and count(parameter)=0]"
			[Register ("getSelectedItemPosition", "()I", "GetGetSelectedItemPositionHandler")]
			get {
				if (id_getSelectedItemPosition == IntPtr.Zero)
					id_getSelectedItemPosition = JNIEnv.GetMethodID (class_ref, "getSelectedItemPosition", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSelectedItemPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedItemPosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedView;
#pragma warning disable 0169
		static Delegate GetGetSelectedViewHandler ()
		{
			if (cb_getSelectedView == null)
				cb_getSelectedView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedView);
			return cb_getSelectedView;
		}

		static IntPtr n_GetSelectedView (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedView);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedView;
		public virtual unsafe global::Android.Views.View SelectedView {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getSelectedView' and count(parameter)=0]"
			[Register ("getSelectedView", "()Landroid/view/View;", "GetGetSelectedViewHandler")]
			get {
				if (id_getSelectedView == IntPtr.Zero)
					id_getSelectedView = JNIEnv.GetMethodID (class_ref, "getSelectedView", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getSelectedView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSoftInputMode;
#pragma warning disable 0169
		static Delegate GetGetSoftInputModeHandler ()
		{
			if (cb_getSoftInputMode == null)
				cb_getSoftInputMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSoftInputMode);
			return cb_getSoftInputMode;
		}

		static int n_GetSoftInputMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SoftInputMode;
		}
#pragma warning restore 0169

		static Delegate cb_setSoftInputMode_I;
#pragma warning disable 0169
		static Delegate GetSetSoftInputMode_IHandler ()
		{
			if (cb_setSoftInputMode_I == null)
				cb_setSoftInputMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSoftInputMode_I);
			return cb_setSoftInputMode_I;
		}

		static void n_SetSoftInputMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SoftInputMode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSoftInputMode;
		static IntPtr id_setSoftInputMode_I;
		public virtual unsafe int SoftInputMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getSoftInputMode' and count(parameter)=0]"
			[Register ("getSoftInputMode", "()I", "GetGetSoftInputModeHandler")]
			get {
				if (id_getSoftInputMode == IntPtr.Zero)
					id_getSoftInputMode = JNIEnv.GetMethodID (class_ref, "getSoftInputMode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSoftInputMode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSoftInputMode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setSoftInputMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSoftInputMode", "(I)V", "GetSetSoftInputMode_IHandler")]
			set {
				if (id_setSoftInputMode_I == IntPtr.Zero)
					id_setSoftInputMode_I = JNIEnv.GetMethodID (class_ref, "setSoftInputMode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setSoftInputMode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSoftInputMode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVerticalOffset;
#pragma warning disable 0169
		static Delegate GetGetVerticalOffsetHandler ()
		{
			if (cb_getVerticalOffset == null)
				cb_getVerticalOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVerticalOffset);
			return cb_getVerticalOffset;
		}

		static int n_GetVerticalOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VerticalOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setVerticalOffset_I;
#pragma warning disable 0169
		static Delegate GetSetVerticalOffset_IHandler ()
		{
			if (cb_setVerticalOffset_I == null)
				cb_setVerticalOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetVerticalOffset_I);
			return cb_setVerticalOffset_I;
		}

		static void n_SetVerticalOffset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VerticalOffset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVerticalOffset;
		static IntPtr id_setVerticalOffset_I;
		public virtual unsafe int VerticalOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getVerticalOffset' and count(parameter)=0]"
			[Register ("getVerticalOffset", "()I", "GetGetVerticalOffsetHandler")]
			get {
				if (id_getVerticalOffset == IntPtr.Zero)
					id_getVerticalOffset = JNIEnv.GetMethodID (class_ref, "getVerticalOffset", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getVerticalOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVerticalOffset", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setVerticalOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVerticalOffset", "(I)V", "GetSetVerticalOffset_IHandler")]
			set {
				if (id_setVerticalOffset_I == IntPtr.Zero)
					id_setVerticalOffset_I = JNIEnv.GetMethodID (class_ref, "setVerticalOffset", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setVerticalOffset_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVerticalOffset", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_I;
#pragma warning disable 0169
		static Delegate GetSetWidth_IHandler ()
		{
			if (cb_setWidth_I == null)
				cb_setWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWidth_I);
			return cb_setWidth_I;
		}

		static void n_SetWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_I;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
			set {
				if (id_setWidth_I == IntPtr.Zero)
					id_setWidth_I = JNIEnv.GetMethodID (class_ref, "setWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWidth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_clearListSelection;
#pragma warning disable 0169
		static Delegate GetClearListSelectionHandler ()
		{
			if (cb_clearListSelection == null)
				cb_clearListSelection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearListSelection);
			return cb_clearListSelection;
		}

		static void n_ClearListSelection (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearListSelection ();
		}
#pragma warning restore 0169

		static IntPtr id_clearListSelection;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='clearListSelection' and count(parameter)=0]"
		[Register ("clearListSelection", "()V", "GetClearListSelectionHandler")]
		public virtual unsafe void ClearListSelection ()
		{
			if (id_clearListSelection == IntPtr.Zero)
				id_clearListSelection = JNIEnv.GetMethodID (class_ref, "clearListSelection", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearListSelection);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearListSelection", "()V"));
			} finally {
			}
		}

		static Delegate cb_createDragToOpenListener_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetCreateDragToOpenListener_Landroid_view_View_Handler ()
		{
			if (cb_createDragToOpenListener_Landroid_view_View_ == null)
				cb_createDragToOpenListener_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDragToOpenListener_Landroid_view_View_);
			return cb_createDragToOpenListener_Landroid_view_View_;
		}

		static IntPtr n_CreateDragToOpenListener_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDragToOpenListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createDragToOpenListener_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='createDragToOpenListener' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("createDragToOpenListener", "(Landroid/view/View;)Landroid/view/View$OnTouchListener;", "GetCreateDragToOpenListener_Landroid_view_View_Handler")]
		public virtual unsafe global::Android.Views.View.IOnTouchListener CreateDragToOpenListener (global::Android.Views.View p0)
		{
			if (id_createDragToOpenListener_Landroid_view_View_ == IntPtr.Zero)
				id_createDragToOpenListener_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "createDragToOpenListener", "(Landroid/view/View;)Landroid/view/View$OnTouchListener;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Views.View.IOnTouchListener __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnTouchListener> (JNIEnv.CallObjectMethod  (Handle, id_createDragToOpenListener_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnTouchListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createDragToOpenListener", "(Landroid/view/View;)Landroid/view/View$OnTouchListener;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dismiss;
#pragma warning disable 0169
		static Delegate GetDismissHandler ()
		{
			if (cb_dismiss == null)
				cb_dismiss = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dismiss);
			return cb_dismiss;
		}

		static void n_Dismiss (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dismiss ();
		}
#pragma warning restore 0169

		static IntPtr id_dismiss;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='dismiss' and count(parameter)=0]"
		[Register ("dismiss", "()V", "GetDismissHandler")]
		public virtual unsafe void Dismiss ()
		{
			if (id_dismiss == IntPtr.Zero)
				id_dismiss = JNIEnv.GetMethodID (class_ref, "dismiss", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dismiss);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dismiss", "()V"));
			} finally {
			}
		}

		static Delegate cb_onKeyDown_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKeyDown_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKeyDown_ILandroid_view_KeyEvent_ == null)
				cb_onKeyDown_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnKeyDown_ILandroid_view_KeyEvent_);
			return cb_onKeyDown_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKeyDown_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyDown (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyDown_ILandroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='onKeyDown' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyDown", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyDown_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnKeyDown (int p0, global::Android.Views.KeyEvent p1)
		{
			if (id_onKeyDown_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_onKeyDown_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onKeyDown_ILandroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onKeyPreIme_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKeyPreIme_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKeyPreIme_ILandroid_view_KeyEvent_ == null)
				cb_onKeyPreIme_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnKeyPreIme_ILandroid_view_KeyEvent_);
			return cb_onKeyPreIme_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKeyPreIme_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyPreIme (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyPreIme_ILandroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='onKeyPreIme' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyPreIme_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnKeyPreIme (int p0, global::Android.Views.KeyEvent p1)
		{
			if (id_onKeyPreIme_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_onKeyPreIme_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onKeyPreIme_ILandroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyPreIme", "(ILandroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onKeyUp_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKeyUp_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKeyUp_ILandroid_view_KeyEvent_ == null)
				cb_onKeyUp_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnKeyUp_ILandroid_view_KeyEvent_);
			return cb_onKeyUp_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKeyUp_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyUp (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyUp_ILandroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='onKeyUp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent']]"
		[Register ("onKeyUp", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyUp_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnKeyUp (int p0, global::Android.Views.KeyEvent p1)
		{
			if (id_onKeyUp_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_onKeyUp_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onKeyUp_ILandroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_performItemClick_I;
#pragma warning disable 0169
		static Delegate GetPerformItemClick_IHandler ()
		{
			if (cb_performItemClick_I == null)
				cb_performItemClick_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_PerformItemClick_I);
			return cb_performItemClick_I;
		}

		static bool n_PerformItemClick_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PerformItemClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_performItemClick_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='performItemClick' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("performItemClick", "(I)Z", "GetPerformItemClick_IHandler")]
		public virtual unsafe bool PerformItemClick (int p0)
		{
			if (id_performItemClick_I == IntPtr.Zero)
				id_performItemClick_I = JNIEnv.GetMethodID (class_ref, "performItemClick", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_performItemClick_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "performItemClick", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_postShow;
#pragma warning disable 0169
		static Delegate GetPostShowHandler ()
		{
			if (cb_postShow == null)
				cb_postShow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PostShow);
			return cb_postShow;
		}

		static void n_PostShow (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostShow ();
		}
#pragma warning restore 0169

		static IntPtr id_postShow;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='postShow' and count(parameter)=0]"
		[Register ("postShow", "()V", "GetPostShowHandler")]
		public virtual unsafe void PostShow ()
		{
			if (id_postShow == IntPtr.Zero)
				id_postShow = JNIEnv.GetMethodID (class_ref, "postShow", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_postShow);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postShow", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAdapter_Landroid_widget_ListAdapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Landroid_widget_ListAdapter_Handler ()
		{
			if (cb_setAdapter_Landroid_widget_ListAdapter_ == null)
				cb_setAdapter_Landroid_widget_ListAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdapter_Landroid_widget_ListAdapter_);
			return cb_setAdapter_Landroid_widget_ListAdapter_;
		}

		static void n_SetAdapter_Landroid_widget_ListAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.IListAdapter p0 = (global::Android.Widget.IListAdapter)global::Java.Lang.Object.GetObject<global::Android.Widget.IListAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdapter_Landroid_widget_ListAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.ListAdapter']]"
		[Register ("setAdapter", "(Landroid/widget/ListAdapter;)V", "GetSetAdapter_Landroid_widget_ListAdapter_Handler")]
		public virtual unsafe void SetAdapter (global::Android.Widget.IListAdapter p0)
		{
			if (id_setAdapter_Landroid_widget_ListAdapter_ == IntPtr.Zero)
				id_setAdapter_Landroid_widget_ListAdapter_ = JNIEnv.GetMethodID (class_ref, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAdapter_Landroid_widget_ListAdapter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdapter", "(Landroid/widget/ListAdapter;)V"), __args);
			} finally {
			}
		}

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
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setBackgroundDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetBackgroundDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setContentWidth_I;
#pragma warning disable 0169
		static Delegate GetSetContentWidth_IHandler ()
		{
			if (cb_setContentWidth_I == null)
				cb_setContentWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetContentWidth_I);
			return cb_setContentWidth_I;
		}

		static void n_SetContentWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContentWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setContentWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setContentWidth", "(I)V", "GetSetContentWidth_IHandler")]
		public virtual unsafe void SetContentWidth (int p0)
		{
			if (id_setContentWidth_I == IntPtr.Zero)
				id_setContentWidth_I = JNIEnv.GetMethodID (class_ref, "setContentWidth", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setContentWidth_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentWidth", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDropDownGravity_I;
#pragma warning disable 0169
		static Delegate GetSetDropDownGravity_IHandler ()
		{
			if (cb_setDropDownGravity_I == null)
				cb_setDropDownGravity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDropDownGravity_I);
			return cb_setDropDownGravity_I;
		}

		static void n_SetDropDownGravity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDropDownGravity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDropDownGravity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setDropDownGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDropDownGravity", "(I)V", "GetSetDropDownGravity_IHandler")]
		public virtual unsafe void SetDropDownGravity (int p0)
		{
			if (id_setDropDownGravity_I == IntPtr.Zero)
				id_setDropDownGravity_I = JNIEnv.GetMethodID (class_ref, "setDropDownGravity", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDropDownGravity_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDropDownGravity", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setForceIgnoreOutsideTouch_Z;
#pragma warning disable 0169
		static Delegate GetSetForceIgnoreOutsideTouch_ZHandler ()
		{
			if (cb_setForceIgnoreOutsideTouch_Z == null)
				cb_setForceIgnoreOutsideTouch_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetForceIgnoreOutsideTouch_Z);
			return cb_setForceIgnoreOutsideTouch_Z;
		}

		static void n_SetForceIgnoreOutsideTouch_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetForceIgnoreOutsideTouch (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setForceIgnoreOutsideTouch_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setForceIgnoreOutsideTouch' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setForceIgnoreOutsideTouch", "(Z)V", "GetSetForceIgnoreOutsideTouch_ZHandler")]
		public virtual unsafe void SetForceIgnoreOutsideTouch (bool p0)
		{
			if (id_setForceIgnoreOutsideTouch_Z == IntPtr.Zero)
				id_setForceIgnoreOutsideTouch_Z = JNIEnv.GetMethodID (class_ref, "setForceIgnoreOutsideTouch", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setForceIgnoreOutsideTouch_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setForceIgnoreOutsideTouch", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setListSelector_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetListSelector_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setListSelector_Landroid_graphics_drawable_Drawable_ == null)
				cb_setListSelector_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListSelector_Landroid_graphics_drawable_Drawable_);
			return cb_setListSelector_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetListSelector_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListSelector (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListSelector_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setListSelector' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setListSelector", "(Landroid/graphics/drawable/Drawable;)V", "GetSetListSelector_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetListSelector (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setListSelector_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setListSelector_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setListSelector", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListSelector_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListSelector", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_Handler ()
		{
			if (cb_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_ == null)
				cb_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_);
			return cb_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_;
		}

		static void n_SetOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.PopupWindow.IOnDismissListener p0 = (global::Android.Widget.PopupWindow.IOnDismissListener)global::Java.Lang.Object.GetObject<global::Android.Widget.PopupWindow.IOnDismissListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDismissListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setOnDismissListener' and count(parameter)=1 and parameter[1][@type='android.widget.PopupWindow.OnDismissListener']]"
		[Register ("setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V", "GetSetOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_Handler")]
		public virtual unsafe void SetOnDismissListener (global::Android.Widget.PopupWindow.IOnDismissListener p0)
		{
			if (id_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_ == IntPtr.Zero)
				id_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_ = JNIEnv.GetMethodID (class_ref, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnDismissListener_Landroid_widget_PopupWindow_OnDismissListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_Handler ()
		{
			if (cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ == null)
				cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_);
			return cb_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
		}

		static void n_SetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView.IOnItemClickListener p0 = (global::Android.Widget.AdapterView.IOnItemClickListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView.IOnItemClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setOnItemClickListener' and count(parameter)=1 and parameter[1][@type='android.widget.AdapterView.OnItemClickListener']]"
		[Register ("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", "GetSetOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_Handler")]
		public virtual unsafe void SetOnItemClickListener (global::Android.Widget.AdapterView.IOnItemClickListener p0)
		{
			if (id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ == IntPtr.Zero)
				id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnItemClickListener_Landroid_widget_AdapterView_OnItemClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_Handler ()
		{
			if (cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ == null)
				cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_);
			return cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_;
		}

		static void n_SetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView.IOnItemSelectedListener p0 = (global::Android.Widget.AdapterView.IOnItemSelectedListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView.IOnItemSelectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemSelectedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setOnItemSelectedListener' and count(parameter)=1 and parameter[1][@type='android.widget.AdapterView.OnItemSelectedListener']]"
		[Register ("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", "GetSetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_Handler")]
		public virtual unsafe void SetOnItemSelectedListener (global::Android.Widget.AdapterView.IOnItemSelectedListener p0)
		{
			if (id_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ == IntPtr.Zero)
				id_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPromptView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetPromptView_Landroid_view_View_Handler ()
		{
			if (cb_setPromptView_Landroid_view_View_ == null)
				cb_setPromptView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPromptView_Landroid_view_View_);
			return cb_setPromptView_Landroid_view_View_;
		}

		static void n_SetPromptView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPromptView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPromptView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setPromptView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setPromptView", "(Landroid/view/View;)V", "GetSetPromptView_Landroid_view_View_Handler")]
		public virtual unsafe void SetPromptView (global::Android.Views.View p0)
		{
			if (id_setPromptView_Landroid_view_View_ == IntPtr.Zero)
				id_setPromptView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setPromptView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPromptView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPromptView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelection_I;
#pragma warning disable 0169
		static Delegate GetSetSelection_IHandler ()
		{
			if (cb_setSelection_I == null)
				cb_setSelection_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelection_I);
			return cb_setSelection_I;
		}

		static void n_SetSelection_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelection_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setSelection' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelection", "(I)V", "GetSetSelection_IHandler")]
		public virtual unsafe void SetSelection (int p0)
		{
			if (id_setSelection_I == IntPtr.Zero)
				id_setSelection_I = JNIEnv.GetMethodID (class_ref, "setSelection", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelection_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelection", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setWindowLayoutType_I;
#pragma warning disable 0169
		static Delegate GetSetWindowLayoutType_IHandler ()
		{
			if (cb_setWindowLayoutType_I == null)
				cb_setWindowLayoutType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWindowLayoutType_I);
			return cb_setWindowLayoutType_I;
		}

		static void n_SetWindowLayoutType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetWindowLayoutType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWindowLayoutType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='setWindowLayoutType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setWindowLayoutType", "(I)V", "GetSetWindowLayoutType_IHandler")]
		public virtual unsafe void SetWindowLayoutType (int p0)
		{
			if (id_setWindowLayoutType_I == IntPtr.Zero)
				id_setWindowLayoutType_I = JNIEnv.GetMethodID (class_ref, "setWindowLayoutType", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWindowLayoutType_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWindowLayoutType", "(I)V"), __args);
			} finally {
			}
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
			global::Android.Support.V7.Widget.ListPopupWindow __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.ListPopupWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ListPopupWindow']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public virtual unsafe void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_show);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "()V"));
			} finally {
			}
		}

	}
}
