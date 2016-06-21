using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/ViewStubCompat", DoNotGenerateAcw=true)]
	public sealed partial class ViewStubCompat : global::Android.Views.View {

		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ViewStubCompat.OnInflateListener']"
		[Register ("android/support/v7/internal/widget/ViewStubCompat$OnInflateListener", "", "Android.Support.V7.Internal.Widget.ViewStubCompat/IOnInflateListenerInvoker")]
		public partial interface IOnInflateListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ViewStubCompat.OnInflateListener']/method[@name='onInflate' and count(parameter)=2 and parameter[1][@type='android.support.v7.internal.widget.ViewStubCompat'] and parameter[2][@type='android.view.View']]"
			[Register ("onInflate", "(Landroid/support/v7/internal/widget/ViewStubCompat;Landroid/view/View;)V", "GetOnInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_Handler:Android.Support.V7.Internal.Widget.ViewStubCompat/IOnInflateListenerInvoker, Binding_AppcompatV7")]
			void OnInflate (global::Android.Support.V7.Internal.Widget.ViewStubCompat p0, global::Android.Views.View p1);

		}

		[global::Android.Runtime.Register ("android/support/v7/internal/widget/ViewStubCompat$OnInflateListener", DoNotGenerateAcw=true)]
		internal class IOnInflateListenerInvoker : global::Java.Lang.Object, IOnInflateListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/internal/widget/ViewStubCompat$OnInflateListener");
			IntPtr class_ref;

			public static IOnInflateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnInflateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.internal.widget.ViewStubCompat.OnInflateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnInflateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnInflateListenerInvoker); }
			}

			static Delegate cb_onInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_Handler ()
			{
				if (cb_onInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_ == null)
					cb_onInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_);
				return cb_onInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_;
			}

			static void n_OnInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.Internal.Widget.ViewStubCompat p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ViewStubCompat> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnInflate (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_;
			public unsafe void OnInflate (global::Android.Support.V7.Internal.Widget.ViewStubCompat p0, global::Android.Views.View p1)
			{
				if (id_onInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_ == IntPtr.Zero)
					id_onInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onInflate", "(Landroid/support/v7/internal/widget/ViewStubCompat;Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onInflate_Landroid_support_v7_internal_widget_ViewStubCompat_Landroid_view_View_, __args);
			}

		}

		public partial class InflateEventArgs : global::System.EventArgs {

			public InflateEventArgs (global::Android.Support.V7.Internal.Widget.ViewStubCompat p0, global::Android.Views.View p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Android.Support.V7.Internal.Widget.ViewStubCompat p0;
			public global::Android.Support.V7.Internal.Widget.ViewStubCompat P0 {
				get { return p0; }
			}

			global::Android.Views.View p1;
			public global::Android.Views.View P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/android/support/v7/internal/widget/ViewStubCompat_OnInflateListenerImplementor")]
		internal sealed partial class IOnInflateListenerImplementor : global::Java.Lang.Object, IOnInflateListener {

			object sender;

			public IOnInflateListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/android/support/v7/internal/widget/ViewStubCompat_OnInflateListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InflateEventArgs> Handler;
#pragma warning restore 0649

			public void OnInflate (global::Android.Support.V7.Internal.Widget.ViewStubCompat p0, global::Android.Views.View p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new InflateEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnInflateListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/ViewStubCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewStubCompat); }
		}

		internal ViewStubCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']/constructor[@name='ViewStubCompat' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ViewStubCompat (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ViewStubCompat)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']/constructor[@name='ViewStubCompat' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ViewStubCompat (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ViewStubCompat)) {
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

		static IntPtr id_getInflatedId;
		static IntPtr id_setInflatedId_I;
		public unsafe int InflatedId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']/method[@name='getInflatedId' and count(parameter)=0]"
			[Register ("getInflatedId", "()I", "GetGetInflatedIdHandler")]
			get {
				if (id_getInflatedId == IntPtr.Zero)
					id_getInflatedId = JNIEnv.GetMethodID (class_ref, "getInflatedId", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getInflatedId);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']/method[@name='setInflatedId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setInflatedId", "(I)V", "GetSetInflatedId_IHandler")]
			set {
				if (id_setInflatedId_I == IntPtr.Zero)
					id_setInflatedId_I = JNIEnv.GetMethodID (class_ref, "setInflatedId", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setInflatedId_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLayoutInflater;
		static IntPtr id_setLayoutInflater_Landroid_view_LayoutInflater_;
		public unsafe global::Android.Views.LayoutInflater LayoutInflater {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']/method[@name='getLayoutInflater' and count(parameter)=0]"
			[Register ("getLayoutInflater", "()Landroid/view/LayoutInflater;", "GetGetLayoutInflaterHandler")]
			get {
				if (id_getLayoutInflater == IntPtr.Zero)
					id_getLayoutInflater = JNIEnv.GetMethodID (class_ref, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Views.LayoutInflater> (JNIEnv.CallObjectMethod  (Handle, id_getLayoutInflater), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']/method[@name='setLayoutInflater' and count(parameter)=1 and parameter[1][@type='android.view.LayoutInflater']]"
			[Register ("setLayoutInflater", "(Landroid/view/LayoutInflater;)V", "GetSetLayoutInflater_Landroid_view_LayoutInflater_Handler")]
			set {
				if (id_setLayoutInflater_Landroid_view_LayoutInflater_ == IntPtr.Zero)
					id_setLayoutInflater_Landroid_view_LayoutInflater_ = JNIEnv.GetMethodID (class_ref, "setLayoutInflater", "(Landroid/view/LayoutInflater;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setLayoutInflater_Landroid_view_LayoutInflater_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLayoutResource;
		static IntPtr id_setLayoutResource_I;
		public unsafe int LayoutResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']/method[@name='getLayoutResource' and count(parameter)=0]"
			[Register ("getLayoutResource", "()I", "GetGetLayoutResourceHandler")]
			get {
				if (id_getLayoutResource == IntPtr.Zero)
					id_getLayoutResource = JNIEnv.GetMethodID (class_ref, "getLayoutResource", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getLayoutResource);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']/method[@name='setLayoutResource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLayoutResource", "(I)V", "GetSetLayoutResource_IHandler")]
			set {
				if (id_setLayoutResource_I == IntPtr.Zero)
					id_setLayoutResource_I = JNIEnv.GetMethodID (class_ref, "setLayoutResource", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setLayoutResource_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_inflate;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']/method[@name='inflate' and count(parameter)=0]"
		[Register ("inflate", "()Landroid/view/View;", "")]
		public unsafe global::Android.Views.View Inflate ()
		{
			if (id_inflate == IntPtr.Zero)
				id_inflate = JNIEnv.GetMethodID (class_ref, "inflate", "()Landroid/view/View;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_inflate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setOnInflateListener_Landroid_support_v7_internal_widget_ViewStubCompat_OnInflateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ViewStubCompat']/method[@name='setOnInflateListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.internal.widget.ViewStubCompat.OnInflateListener']]"
		[Register ("setOnInflateListener", "(Landroid/support/v7/internal/widget/ViewStubCompat$OnInflateListener;)V", "")]
		public unsafe void SetOnInflateListener (global::Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListener p0)
		{
			if (id_setOnInflateListener_Landroid_support_v7_internal_widget_ViewStubCompat_OnInflateListener_ == IntPtr.Zero)
				id_setOnInflateListener_Landroid_support_v7_internal_widget_ViewStubCompat_OnInflateListener_ = JNIEnv.GetMethodID (class_ref, "setOnInflateListener", "(Landroid/support/v7/internal/widget/ViewStubCompat$OnInflateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setOnInflateListener_Landroid_support_v7_internal_widget_ViewStubCompat_OnInflateListener_, __args);
			} finally {
			}
		}

#region "Event implementation for Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListener"
		public event EventHandler<global::Android.Support.V7.Internal.Widget.ViewStubCompat.InflateEventArgs> InflateEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListener, global::Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListenerImplementor>(
						ref weak_implementor_SetOnInflateListener,
						__CreateIOnInflateListenerImplementor,
						SetOnInflateListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListener, global::Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListenerImplementor>(
						ref weak_implementor_SetOnInflateListener,
						global::Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListenerImplementor.__IsEmpty,
						__v => SetOnInflateListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnInflateListener;

		global::Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListenerImplementor __CreateIOnInflateListenerImplementor ()
		{
			return new global::Android.Support.V7.Internal.Widget.ViewStubCompat.IOnInflateListenerImplementor (this);
		}
#endregion
	}
}
