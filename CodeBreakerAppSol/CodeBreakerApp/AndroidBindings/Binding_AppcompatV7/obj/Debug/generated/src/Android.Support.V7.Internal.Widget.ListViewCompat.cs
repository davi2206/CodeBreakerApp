using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/ListViewCompat", DoNotGenerateAcw=true)]
	public partial class ListViewCompat : global::Android.Widget.ListView {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/field[@name='INVALID_POSITION']"
		[Register ("INVALID_POSITION")]
		public const int InvalidPosition = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/field[@name='NO_POSITION']"
		[Register ("NO_POSITION")]
		public const int NoPosition = (int) -1;

		static IntPtr mMotionPosition_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/field[@name='mMotionPosition']"
		[Register ("mMotionPosition")]
		protected int MMotionPosition {
			get {
				if (mMotionPosition_jfieldId == IntPtr.Zero)
					mMotionPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mMotionPosition", "I");
				return JNIEnv.GetIntField (Handle, mMotionPosition_jfieldId);
			}
			set {
				if (mMotionPosition_jfieldId == IntPtr.Zero)
					mMotionPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mMotionPosition", "I");
				try {
					JNIEnv.SetField (Handle, mMotionPosition_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat.GateKeeperDrawable']"
		[global::Android.Runtime.Register ("android/support/v7/internal/widget/ListViewCompat$GateKeeperDrawable", DoNotGenerateAcw=true)]
		public partial class GateKeeperDrawable : global::Android.Support.V7.Graphics.Drawable.DrawableWrapper {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/internal/widget/ListViewCompat$GateKeeperDrawable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GateKeeperDrawable); }
			}

			protected GateKeeperDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_graphics_drawable_Drawable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat.GateKeeperDrawable']/constructor[@name='ListViewCompat.GateKeeperDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register (".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
			public unsafe GateKeeperDrawable (global::Android.Graphics.Drawables.Drawable p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (GateKeeperDrawable)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/ListViewCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ListViewCompat); }
		}

		protected ListViewCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/constructor[@name='ListViewCompat' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ListViewCompat (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ListViewCompat)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/constructor[@name='ListViewCompat' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ListViewCompat (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ListViewCompat)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/constructor[@name='ListViewCompat' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ListViewCompat (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ListViewCompat)) {
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

		static Delegate cb_drawSelectorCompat_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawSelectorCompat_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawSelectorCompat_Landroid_graphics_Canvas_ == null)
				cb_drawSelectorCompat_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawSelectorCompat_Landroid_graphics_Canvas_);
			return cb_drawSelectorCompat_Landroid_graphics_Canvas_;
		}

		static void n_DrawSelectorCompat_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.ListViewCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ListViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawSelectorCompat (p0);
		}
#pragma warning restore 0169

		static IntPtr id_drawSelectorCompat_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/method[@name='drawSelectorCompat' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawSelectorCompat", "(Landroid/graphics/Canvas;)V", "GetDrawSelectorCompat_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void DrawSelectorCompat (global::Android.Graphics.Canvas p0)
		{
			if (id_drawSelectorCompat_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_drawSelectorCompat_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "drawSelectorCompat", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawSelectorCompat_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawSelectorCompat", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_lookForSelectablePosition_IZ;
#pragma warning disable 0169
		static Delegate GetLookForSelectablePosition_IZHandler ()
		{
			if (cb_lookForSelectablePosition_IZ == null)
				cb_lookForSelectablePosition_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, int>) n_LookForSelectablePosition_IZ);
			return cb_lookForSelectablePosition_IZ;
		}

		static int n_LookForSelectablePosition_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Android.Support.V7.Internal.Widget.ListViewCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ListViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LookForSelectablePosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_lookForSelectablePosition_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/method[@name='lookForSelectablePosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("lookForSelectablePosition", "(IZ)I", "GetLookForSelectablePosition_IZHandler")]
		public virtual unsafe int LookForSelectablePosition (int p0, bool p1)
		{
			if (id_lookForSelectablePosition_IZ == IntPtr.Zero)
				id_lookForSelectablePosition_IZ = JNIEnv.GetMethodID (class_ref, "lookForSelectablePosition", "(IZ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_lookForSelectablePosition_IZ, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lookForSelectablePosition", "(IZ)I"), __args);
			} finally {
			}
		}

		static Delegate cb_measureHeightOfChildrenCompat_IIIII;
#pragma warning disable 0169
		static Delegate GetMeasureHeightOfChildrenCompat_IIIIIHandler ()
		{
			if (cb_measureHeightOfChildrenCompat_IIIII == null)
				cb_measureHeightOfChildrenCompat_IIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, int>) n_MeasureHeightOfChildrenCompat_IIIII);
			return cb_measureHeightOfChildrenCompat_IIIII;
		}

		static int n_MeasureHeightOfChildrenCompat_IIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4)
		{
			global::Android.Support.V7.Internal.Widget.ListViewCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ListViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MeasureHeightOfChildrenCompat (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_measureHeightOfChildrenCompat_IIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/method[@name='measureHeightOfChildrenCompat' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("measureHeightOfChildrenCompat", "(IIIII)I", "GetMeasureHeightOfChildrenCompat_IIIIIHandler")]
		public virtual unsafe int MeasureHeightOfChildrenCompat (int p0, int p1, int p2, int p3, int p4)
		{
			if (id_measureHeightOfChildrenCompat_IIIII == IntPtr.Zero)
				id_measureHeightOfChildrenCompat_IIIII = JNIEnv.GetMethodID (class_ref, "measureHeightOfChildrenCompat", "(IIIII)I");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_measureHeightOfChildrenCompat_IIIII, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "measureHeightOfChildrenCompat", "(IIIII)I"), __args);
			} finally {
			}
		}

		static Delegate cb_positionSelectorCompat_ILandroid_view_View_;
#pragma warning disable 0169
		static Delegate GetPositionSelectorCompat_ILandroid_view_View_Handler ()
		{
			if (cb_positionSelectorCompat_ILandroid_view_View_ == null)
				cb_positionSelectorCompat_ILandroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_PositionSelectorCompat_ILandroid_view_View_);
			return cb_positionSelectorCompat_ILandroid_view_View_;
		}

		static void n_PositionSelectorCompat_ILandroid_view_View_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.Widget.ListViewCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ListViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PositionSelectorCompat (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_positionSelectorCompat_ILandroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/method[@name='positionSelectorCompat' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.View']]"
		[Register ("positionSelectorCompat", "(ILandroid/view/View;)V", "GetPositionSelectorCompat_ILandroid_view_View_Handler")]
		protected virtual unsafe void PositionSelectorCompat (int p0, global::Android.Views.View p1)
		{
			if (id_positionSelectorCompat_ILandroid_view_View_ == IntPtr.Zero)
				id_positionSelectorCompat_ILandroid_view_View_ = JNIEnv.GetMethodID (class_ref, "positionSelectorCompat", "(ILandroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_positionSelectorCompat_ILandroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "positionSelectorCompat", "(ILandroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_positionSelectorLikeFocusCompat_ILandroid_view_View_;
#pragma warning disable 0169
		static Delegate GetPositionSelectorLikeFocusCompat_ILandroid_view_View_Handler ()
		{
			if (cb_positionSelectorLikeFocusCompat_ILandroid_view_View_ == null)
				cb_positionSelectorLikeFocusCompat_ILandroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_PositionSelectorLikeFocusCompat_ILandroid_view_View_);
			return cb_positionSelectorLikeFocusCompat_ILandroid_view_View_;
		}

		static void n_PositionSelectorLikeFocusCompat_ILandroid_view_View_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.Widget.ListViewCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ListViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PositionSelectorLikeFocusCompat (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_positionSelectorLikeFocusCompat_ILandroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/method[@name='positionSelectorLikeFocusCompat' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.View']]"
		[Register ("positionSelectorLikeFocusCompat", "(ILandroid/view/View;)V", "GetPositionSelectorLikeFocusCompat_ILandroid_view_View_Handler")]
		protected virtual unsafe void PositionSelectorLikeFocusCompat (int p0, global::Android.Views.View p1)
		{
			if (id_positionSelectorLikeFocusCompat_ILandroid_view_View_ == IntPtr.Zero)
				id_positionSelectorLikeFocusCompat_ILandroid_view_View_ = JNIEnv.GetMethodID (class_ref, "positionSelectorLikeFocusCompat", "(ILandroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_positionSelectorLikeFocusCompat_ILandroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "positionSelectorLikeFocusCompat", "(ILandroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_positionSelectorLikeTouchCompat_ILandroid_view_View_FF;
#pragma warning disable 0169
		static Delegate GetPositionSelectorLikeTouchCompat_ILandroid_view_View_FFHandler ()
		{
			if (cb_positionSelectorLikeTouchCompat_ILandroid_view_View_FF == null)
				cb_positionSelectorLikeTouchCompat_ILandroid_view_View_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, float, float>) n_PositionSelectorLikeTouchCompat_ILandroid_view_View_FF);
			return cb_positionSelectorLikeTouchCompat_ILandroid_view_View_FF;
		}

		static void n_PositionSelectorLikeTouchCompat_ILandroid_view_View_FF (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, float p2, float p3)
		{
			global::Android.Support.V7.Internal.Widget.ListViewCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ListViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PositionSelectorLikeTouchCompat (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_positionSelectorLikeTouchCompat_ILandroid_view_View_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/method[@name='positionSelectorLikeTouchCompat' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("positionSelectorLikeTouchCompat", "(ILandroid/view/View;FF)V", "GetPositionSelectorLikeTouchCompat_ILandroid_view_View_FFHandler")]
		protected virtual unsafe void PositionSelectorLikeTouchCompat (int p0, global::Android.Views.View p1, float p2, float p3)
		{
			if (id_positionSelectorLikeTouchCompat_ILandroid_view_View_FF == IntPtr.Zero)
				id_positionSelectorLikeTouchCompat_ILandroid_view_View_FF = JNIEnv.GetMethodID (class_ref, "positionSelectorLikeTouchCompat", "(ILandroid/view/View;FF)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_positionSelectorLikeTouchCompat_ILandroid_view_View_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "positionSelectorLikeTouchCompat", "(ILandroid/view/View;FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectorEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetSelectorEnabled_ZHandler ()
		{
			if (cb_setSelectorEnabled_Z == null)
				cb_setSelectorEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSelectorEnabled_Z);
			return cb_setSelectorEnabled_Z;
		}

		static void n_SetSelectorEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Android.Support.V7.Internal.Widget.ListViewCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ListViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectorEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectorEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/method[@name='setSelectorEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSelectorEnabled", "(Z)V", "GetSetSelectorEnabled_ZHandler")]
		protected virtual unsafe void SetSelectorEnabled (bool p0)
		{
			if (id_setSelectorEnabled_Z == IntPtr.Zero)
				id_setSelectorEnabled_Z = JNIEnv.GetMethodID (class_ref, "setSelectorEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelectorEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectorEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shouldShowSelectorCompat;
#pragma warning disable 0169
		static Delegate GetShouldShowSelectorCompatHandler ()
		{
			if (cb_shouldShowSelectorCompat == null)
				cb_shouldShowSelectorCompat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldShowSelectorCompat);
			return cb_shouldShowSelectorCompat;
		}

		static bool n_ShouldShowSelectorCompat (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ListViewCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ListViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldShowSelectorCompat ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldShowSelectorCompat;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/method[@name='shouldShowSelectorCompat' and count(parameter)=0]"
		[Register ("shouldShowSelectorCompat", "()Z", "GetShouldShowSelectorCompatHandler")]
		protected virtual unsafe bool ShouldShowSelectorCompat ()
		{
			if (id_shouldShowSelectorCompat == IntPtr.Zero)
				id_shouldShowSelectorCompat = JNIEnv.GetMethodID (class_ref, "shouldShowSelectorCompat", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_shouldShowSelectorCompat);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldShowSelectorCompat", "()Z"));
			} finally {
			}
		}

		static Delegate cb_touchModeDrawsInPressedStateCompat;
#pragma warning disable 0169
		static Delegate GetTouchModeDrawsInPressedStateCompatHandler ()
		{
			if (cb_touchModeDrawsInPressedStateCompat == null)
				cb_touchModeDrawsInPressedStateCompat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_TouchModeDrawsInPressedStateCompat);
			return cb_touchModeDrawsInPressedStateCompat;
		}

		static bool n_TouchModeDrawsInPressedStateCompat (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ListViewCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ListViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TouchModeDrawsInPressedStateCompat ();
		}
#pragma warning restore 0169

		static IntPtr id_touchModeDrawsInPressedStateCompat;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/method[@name='touchModeDrawsInPressedStateCompat' and count(parameter)=0]"
		[Register ("touchModeDrawsInPressedStateCompat", "()Z", "GetTouchModeDrawsInPressedStateCompatHandler")]
		protected virtual unsafe bool TouchModeDrawsInPressedStateCompat ()
		{
			if (id_touchModeDrawsInPressedStateCompat == IntPtr.Zero)
				id_touchModeDrawsInPressedStateCompat = JNIEnv.GetMethodID (class_ref, "touchModeDrawsInPressedStateCompat", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_touchModeDrawsInPressedStateCompat);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "touchModeDrawsInPressedStateCompat", "()Z"));
			} finally {
			}
		}

		static Delegate cb_updateSelectorStateCompat;
#pragma warning disable 0169
		static Delegate GetUpdateSelectorStateCompatHandler ()
		{
			if (cb_updateSelectorStateCompat == null)
				cb_updateSelectorStateCompat = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateSelectorStateCompat);
			return cb_updateSelectorStateCompat;
		}

		static void n_UpdateSelectorStateCompat (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ListViewCompat __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ListViewCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSelectorStateCompat ();
		}
#pragma warning restore 0169

		static IntPtr id_updateSelectorStateCompat;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ListViewCompat']/method[@name='updateSelectorStateCompat' and count(parameter)=0]"
		[Register ("updateSelectorStateCompat", "()V", "GetUpdateSelectorStateCompatHandler")]
		protected virtual unsafe void UpdateSelectorStateCompat ()
		{
			if (id_updateSelectorStateCompat == IntPtr.Zero)
				id_updateSelectorStateCompat = JNIEnv.GetMethodID (class_ref, "updateSelectorStateCompat", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_updateSelectorStateCompat);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSelectorStateCompat", "()V"));
			} finally {
			}
		}

	}
}
