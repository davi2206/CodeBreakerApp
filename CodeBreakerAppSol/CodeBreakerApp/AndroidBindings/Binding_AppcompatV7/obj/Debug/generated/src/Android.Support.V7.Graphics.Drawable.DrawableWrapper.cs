using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Graphics.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']"
	[global::Android.Runtime.Register ("android/support/v7/graphics/drawable/DrawableWrapper", DoNotGenerateAcw=true)]
	public partial class DrawableWrapper : global::Android.Graphics.Drawables.Drawable, global::Android.Graphics.Drawables.Drawable.ICallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/graphics/drawable/DrawableWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrawableWrapper); }
		}

		protected DrawableWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']/constructor[@name='DrawableWrapper' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe DrawableWrapper (global::Android.Graphics.Drawables.Drawable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DrawableWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/drawable/Drawable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/drawable/Drawable;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_drawable_Drawable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_drawable_Drawable_, __args);
			} finally {
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
			global::Android.Support.V7.Graphics.Drawable.DrawableWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		static IntPtr id_getOpacity;
		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']/method[@name='getOpacity' and count(parameter)=0]"
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

		static Delegate cb_getWrappedDrawable;
#pragma warning disable 0169
		static Delegate GetGetWrappedDrawableHandler ()
		{
			if (cb_getWrappedDrawable == null)
				cb_getWrappedDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWrappedDrawable);
			return cb_getWrappedDrawable;
		}

		static IntPtr n_GetWrappedDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawableWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WrappedDrawable);
		}
#pragma warning restore 0169

		static Delegate cb_setWrappedDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetWrappedDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setWrappedDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setWrappedDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWrappedDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setWrappedDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetWrappedDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawableWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WrappedDrawable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWrappedDrawable;
		static IntPtr id_setWrappedDrawable_Landroid_graphics_drawable_Drawable_;
		public virtual unsafe global::Android.Graphics.Drawables.Drawable WrappedDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']/method[@name='getWrappedDrawable' and count(parameter)=0]"
			[Register ("getWrappedDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetWrappedDrawableHandler")]
			get {
				if (id_getWrappedDrawable == IntPtr.Zero)
					id_getWrappedDrawable = JNIEnv.GetMethodID (class_ref, "getWrappedDrawable", "()Landroid/graphics/drawable/Drawable;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getWrappedDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWrappedDrawable", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']/method[@name='setWrappedDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setWrappedDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetWrappedDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				if (id_setWrappedDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setWrappedDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setWrappedDrawable", "(Landroid/graphics/drawable/Drawable;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setWrappedDrawable_Landroid_graphics_drawable_Drawable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWrappedDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
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
			global::Android.Support.V7.Graphics.Drawable.DrawableWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		static Delegate cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetInvalidateDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawableWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_invalidateDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']/method[@name='invalidateDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetInvalidateDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void InvalidateDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_invalidateDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_invalidateDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_invalidateDrawable_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J == null)
				cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J);
			return cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;
		}

		static void n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawableWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p1 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ScheduleDrawable (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']/method[@name='scheduleDrawable' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.Runnable'] and parameter[3][@type='long']]"
		[Register ("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", "GetScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_JHandler")]
		public virtual unsafe void ScheduleDrawable (global::Android.Graphics.Drawables.Drawable p0, global::Java.Lang.IRunnable p1, long p2)
		{
			if (id_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"), __args);
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
			global::Android.Support.V7.Graphics.Drawable.DrawableWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlpha_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Android.Support.V7.Graphics.Drawable.DrawableWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorFilter_Landroid_graphics_ColorFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
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

		static Delegate cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetUnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_Handler ()
		{
			if (cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ == null)
				cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_);
			return cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
		}

		static void n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Graphics.Drawable.DrawableWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Graphics.Drawable.DrawableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p1 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnscheduleDrawable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.graphics.drawable']/class[@name='DrawableWrapper']/method[@name='unscheduleDrawable' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", "GetUnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void UnscheduleDrawable (global::Android.Graphics.Drawables.Drawable p0, global::Java.Lang.IRunnable p1)
		{
			if (id_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

	}
}
