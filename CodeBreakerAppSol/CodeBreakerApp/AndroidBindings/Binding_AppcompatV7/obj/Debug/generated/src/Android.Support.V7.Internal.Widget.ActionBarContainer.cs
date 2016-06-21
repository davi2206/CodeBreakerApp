using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/ActionBarContainer", DoNotGenerateAcw=true)]
	public partial class ActionBarContainer : global::Android.Widget.FrameLayout {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/ActionBarContainer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBarContainer); }
		}

		protected ActionBarContainer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/constructor[@name='ActionBarContainer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ActionBarContainer (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ActionBarContainer)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/constructor[@name='ActionBarContainer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ActionBarContainer (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ActionBarContainer)) {
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

		static Delegate cb_getTabContainer;
#pragma warning disable 0169
		static Delegate GetGetTabContainerHandler ()
		{
			if (cb_getTabContainer == null)
				cb_getTabContainer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTabContainer);
			return cb_getTabContainer;
		}

		static IntPtr n_GetTabContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ActionBarContainer __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActionBarContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TabContainer);
		}
#pragma warning restore 0169

		static IntPtr id_getTabContainer;
		public virtual unsafe global::Android.Views.View TabContainer {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/method[@name='getTabContainer' and count(parameter)=0]"
			[Register ("getTabContainer", "()Landroid/view/View;", "GetGetTabContainerHandler")]
			get {
				if (id_getTabContainer == IntPtr.Zero)
					id_getTabContainer = JNIEnv.GetMethodID (class_ref, "getTabContainer", "()Landroid/view/View;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getTabContainer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTabContainer", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onFinishInflate;
#pragma warning disable 0169
		static Delegate GetOnFinishInflateHandler ()
		{
			if (cb_onFinishInflate == null)
				cb_onFinishInflate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFinishInflate);
			return cb_onFinishInflate;
		}

		static void n_OnFinishInflate (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ActionBarContainer __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActionBarContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFinishInflate ();
		}
#pragma warning restore 0169

		static IntPtr id_onFinishInflate;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/method[@name='onFinishInflate' and count(parameter)=0]"
		[Register ("onFinishInflate", "()V", "GetOnFinishInflateHandler")]
		public virtual unsafe void OnFinishInflate ()
		{
			if (id_onFinishInflate == IntPtr.Zero)
				id_onFinishInflate = JNIEnv.GetMethodID (class_ref, "onFinishInflate", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onFinishInflate);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFinishInflate", "()V"));
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
			global::Android.Support.V7.Internal.Widget.ActionBarContainer __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActionBarContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		public override unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
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
			global::Android.Support.V7.Internal.Widget.ActionBarContainer __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActionBarContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMeasure (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onMeasure_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/method[@name='onMeasure' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		static Delegate cb_setPrimaryBackground_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetPrimaryBackground_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setPrimaryBackground_Landroid_graphics_drawable_Drawable_ == null)
				cb_setPrimaryBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrimaryBackground_Landroid_graphics_drawable_Drawable_);
			return cb_setPrimaryBackground_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetPrimaryBackground_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.ActionBarContainer __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActionBarContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPrimaryBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPrimaryBackground_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/method[@name='setPrimaryBackground' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setPrimaryBackground", "(Landroid/graphics/drawable/Drawable;)V", "GetSetPrimaryBackground_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetPrimaryBackground (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setPrimaryBackground_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setPrimaryBackground_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setPrimaryBackground", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPrimaryBackground_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrimaryBackground", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSplitBackground_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetSplitBackground_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setSplitBackground_Landroid_graphics_drawable_Drawable_ == null)
				cb_setSplitBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSplitBackground_Landroid_graphics_drawable_Drawable_);
			return cb_setSplitBackground_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetSplitBackground_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.ActionBarContainer __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActionBarContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSplitBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSplitBackground_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/method[@name='setSplitBackground' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setSplitBackground", "(Landroid/graphics/drawable/Drawable;)V", "GetSetSplitBackground_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetSplitBackground (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setSplitBackground_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setSplitBackground_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setSplitBackground", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSplitBackground_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSplitBackground", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStackedBackground_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetStackedBackground_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setStackedBackground_Landroid_graphics_drawable_Drawable_ == null)
				cb_setStackedBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStackedBackground_Landroid_graphics_drawable_Drawable_);
			return cb_setStackedBackground_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetStackedBackground_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.ActionBarContainer __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActionBarContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStackedBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStackedBackground_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/method[@name='setStackedBackground' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setStackedBackground", "(Landroid/graphics/drawable/Drawable;)V", "GetSetStackedBackground_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetStackedBackground (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setStackedBackground_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setStackedBackground_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setStackedBackground", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStackedBackground_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStackedBackground", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTransitioning_Z;
#pragma warning disable 0169
		static Delegate GetSetTransitioning_ZHandler ()
		{
			if (cb_setTransitioning_Z == null)
				cb_setTransitioning_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTransitioning_Z);
			return cb_setTransitioning_Z;
		}

		static void n_SetTransitioning_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.Widget.ActionBarContainer __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActionBarContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTransitioning (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTransitioning_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/method[@name='setTransitioning' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTransitioning", "(Z)V", "GetSetTransitioning_ZHandler")]
		public virtual unsafe void SetTransitioning (bool p0)
		{
			if (id_setTransitioning_Z == IntPtr.Zero)
				id_setTransitioning_Z = JNIEnv.GetMethodID (class_ref, "setTransitioning", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTransitioning_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransitioning", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_;
#pragma warning disable 0169
		static Delegate GetStartActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_Handler ()
		{
			if (cb_startActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_ == null)
				cb_startActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_);
			return cb_startActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_;
		}

		static IntPtr n_StartActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.Widget.ActionBarContainer __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActionBarContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.View.ActionMode.ICallback p1 = (global::Android.Support.V7.View.ActionMode.ICallback)global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartActionModeForChild (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActionBarContainer']/method[@name='startActionModeForChild' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.support.v7.view.ActionMode.Callback']]"
		[Register ("startActionModeForChild", "(Landroid/view/View;Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;", "GetStartActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_Handler")]
		public virtual unsafe global::Android.Support.V7.View.ActionMode StartActionModeForChild (global::Android.Views.View p0, global::Android.Support.V7.View.ActionMode.ICallback p1)
		{
			if (id_startActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_ == IntPtr.Zero)
				id_startActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_ = JNIEnv.GetMethodID (class_ref, "startActionModeForChild", "(Landroid/view/View;Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Support.V7.View.ActionMode __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (JNIEnv.CallObjectMethod  (Handle, id_startActionModeForChild_Landroid_view_View_Landroid_support_v7_view_ActionMode_Callback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startActionModeForChild", "(Landroid/view/View;Landroid/support/v7/view/ActionMode$Callback;)Landroid/support/v7/view/ActionMode;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
