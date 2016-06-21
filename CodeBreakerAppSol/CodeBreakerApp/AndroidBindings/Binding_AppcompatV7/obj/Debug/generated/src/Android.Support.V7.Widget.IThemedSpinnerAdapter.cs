using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ThemedSpinnerAdapter.Helper']"
	[global::Android.Runtime.Register ("android/support/v7/widget/ThemedSpinnerAdapter$Helper", DoNotGenerateAcw=true)]
	public sealed partial class ThemedSpinnerAdapterHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/widget/ThemedSpinnerAdapter$Helper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThemedSpinnerAdapterHelper); }
		}

		internal ThemedSpinnerAdapterHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ThemedSpinnerAdapter.Helper']/constructor[@name='ThemedSpinnerAdapter.Helper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ThemedSpinnerAdapterHelper (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ThemedSpinnerAdapterHelper)) {
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

		static IntPtr id_getDropDownViewInflater;
		public unsafe global::Android.Views.LayoutInflater DropDownViewInflater {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ThemedSpinnerAdapter.Helper']/method[@name='getDropDownViewInflater' and count(parameter)=0]"
			[Register ("getDropDownViewInflater", "()Landroid/view/LayoutInflater;", "GetGetDropDownViewInflaterHandler")]
			get {
				if (id_getDropDownViewInflater == IntPtr.Zero)
					id_getDropDownViewInflater = JNIEnv.GetMethodID (class_ref, "getDropDownViewInflater", "()Landroid/view/LayoutInflater;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Views.LayoutInflater> (JNIEnv.CallObjectMethod  (Handle, id_getDropDownViewInflater), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDropDownViewTheme;
		static IntPtr id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_;
		public unsafe global::Android.Content.Res.Resources.Theme DropDownViewTheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ThemedSpinnerAdapter.Helper']/method[@name='getDropDownViewTheme' and count(parameter)=0]"
			[Register ("getDropDownViewTheme", "()Landroid/content/res/Resources$Theme;", "GetGetDropDownViewThemeHandler")]
			get {
				if (id_getDropDownViewTheme == IntPtr.Zero)
					id_getDropDownViewTheme = JNIEnv.GetMethodID (class_ref, "getDropDownViewTheme", "()Landroid/content/res/Resources$Theme;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (JNIEnv.CallObjectMethod  (Handle, id_getDropDownViewTheme), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/class[@name='ThemedSpinnerAdapter.Helper']/method[@name='setDropDownViewTheme' and count(parameter)=1 and parameter[1][@type='android.content.res.Resources.Theme']]"
			[Register ("setDropDownViewTheme", "(Landroid/content/res/Resources$Theme;)V", "GetSetDropDownViewTheme_Landroid_content_res_Resources_Theme_Handler")]
			set {
				if (id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ == IntPtr.Zero)
					id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ = JNIEnv.GetMethodID (class_ref, "setDropDownViewTheme", "(Landroid/content/res/Resources$Theme;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_, __args);
				} finally {
				}
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.widget']/interface[@name='ThemedSpinnerAdapter']"
	[Register ("android/support/v7/widget/ThemedSpinnerAdapter", "", "Android.Support.V7.Widget.IThemedSpinnerAdapterInvoker")]
	public partial interface IThemedSpinnerAdapter : global::Android.Widget.ISpinnerAdapter {

		global::Android.Content.Res.Resources.Theme DropDownViewTheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/interface[@name='ThemedSpinnerAdapter']/method[@name='getDropDownViewTheme' and count(parameter)=0]"
			[Register ("getDropDownViewTheme", "()Landroid/content/res/Resources$Theme;", "GetGetDropDownViewThemeHandler:Android.Support.V7.Widget.IThemedSpinnerAdapterInvoker, Binding_AppcompatV7")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.widget']/interface[@name='ThemedSpinnerAdapter']/method[@name='setDropDownViewTheme' and count(parameter)=1 and parameter[1][@type='android.content.res.Resources.Theme']]"
			[Register ("setDropDownViewTheme", "(Landroid/content/res/Resources$Theme;)V", "GetSetDropDownViewTheme_Landroid_content_res_Resources_Theme_Handler:Android.Support.V7.Widget.IThemedSpinnerAdapterInvoker, Binding_AppcompatV7")] set;
		}

	}

	[global::Android.Runtime.Register ("android/support/v7/widget/ThemedSpinnerAdapter", DoNotGenerateAcw=true)]
	internal class IThemedSpinnerAdapterInvoker : global::Java.Lang.Object, IThemedSpinnerAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/widget/ThemedSpinnerAdapter");
		IntPtr class_ref;

		public static IThemedSpinnerAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThemedSpinnerAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.widget.ThemedSpinnerAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThemedSpinnerAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IThemedSpinnerAdapterInvoker); }
		}

		static Delegate cb_getDropDownViewTheme;
#pragma warning disable 0169
		static Delegate GetGetDropDownViewThemeHandler ()
		{
			if (cb_getDropDownViewTheme == null)
				cb_getDropDownViewTheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDropDownViewTheme);
			return cb_getDropDownViewTheme;
		}

		static IntPtr n_GetDropDownViewTheme (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DropDownViewTheme);
		}
#pragma warning restore 0169

		static Delegate cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_;
#pragma warning disable 0169
		static Delegate GetSetDropDownViewTheme_Landroid_content_res_Resources_Theme_Handler ()
		{
			if (cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ == null)
				cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDropDownViewTheme_Landroid_content_res_Resources_Theme_);
			return cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_;
		}

		static void n_SetDropDownViewTheme_Landroid_content_res_Resources_Theme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Resources.Theme p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DropDownViewTheme = p0;
		}
#pragma warning restore 0169

		IntPtr id_getDropDownViewTheme;
		IntPtr id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_;
		public unsafe global::Android.Content.Res.Resources.Theme DropDownViewTheme {
			get {
				if (id_getDropDownViewTheme == IntPtr.Zero)
					id_getDropDownViewTheme = JNIEnv.GetMethodID (class_ref, "getDropDownViewTheme", "()Landroid/content/res/Resources$Theme;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (JNIEnv.CallObjectMethod (Handle, id_getDropDownViewTheme), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ == IntPtr.Zero)
					id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ = JNIEnv.GetMethodID (class_ref, "setDropDownViewTheme", "(Landroid/content/res/Resources$Theme;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_, __args);
			}
		}

		static Delegate cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int position, IntPtr native_convertView, IntPtr native_parent)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View convertView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_convertView, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup parent = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_parent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDropDownView (position, convertView, parent));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_;
		public unsafe global::Android.Views.View GetDropDownView (int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent)
		{
			if (id_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (position);
			__args [1] = new JValue (convertView);
			__args [2] = new JValue (parent);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		IntPtr id_getCount;
		public unsafe global::System.Int32 Count {
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getCount);
			}
		}

		static Delegate cb_hasStableIds;
#pragma warning disable 0169
		static Delegate GetGetHasStableIdsHandler ()
		{
			if (cb_hasStableIds == null)
				cb_hasStableIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHasStableIds);
			return cb_hasStableIds;
		}

		static bool n_GetHasStableIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasStableIds;
		}
#pragma warning restore 0169

		IntPtr id_hasStableIds;
		public unsafe global::System.Boolean HasStableIds {
			get {
				if (id_hasStableIds == IntPtr.Zero)
					id_hasStableIds = JNIEnv.GetMethodID (class_ref, "hasStableIds", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasStableIds);
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		IntPtr id_isEmpty;
		public unsafe global::System.Boolean IsEmpty {
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isEmpty);
			}
		}

		static Delegate cb_getViewTypeCount;
#pragma warning disable 0169
		static Delegate GetGetViewTypeCountHandler ()
		{
			if (cb_getViewTypeCount == null)
				cb_getViewTypeCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetViewTypeCount);
			return cb_getViewTypeCount;
		}

		static int n_GetViewTypeCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ViewTypeCount;
		}
#pragma warning restore 0169

		IntPtr id_getViewTypeCount;
		public unsafe global::System.Int32 ViewTypeCount {
			get {
				if (id_getViewTypeCount == IntPtr.Zero)
					id_getViewTypeCount = JNIEnv.GetMethodID (class_ref, "getViewTypeCount", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getViewTypeCount);
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (position));
		}
#pragma warning restore 0169

		IntPtr id_getItem_I;
		public unsafe global::Java.Lang.Object GetItem (int position)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (position);
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (position);
		}
#pragma warning restore 0169

		IntPtr id_getItemId_I;
		public unsafe global::System.Int64 GetItemId (int position)
		{
			if (id_getItemId_I == IntPtr.Zero)
				id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (position);
			return JNIEnv.CallLongMethod (Handle, id_getItemId_I, __args);
		}

		static Delegate cb_getItemViewType_I;
#pragma warning disable 0169
		static Delegate GetGetItemViewType_IHandler ()
		{
			if (cb_getItemViewType_I == null)
				cb_getItemViewType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetItemViewType_I);
			return cb_getItemViewType_I;
		}

		static int n_GetItemViewType_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemViewType (position);
		}
#pragma warning restore 0169

		IntPtr id_getItemViewType_I;
		public unsafe global::System.Int32 GetItemViewType (int position)
		{
			if (id_getItemViewType_I == IntPtr.Zero)
				id_getItemViewType_I = JNIEnv.GetMethodID (class_ref, "getItemViewType", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (position);
			return JNIEnv.CallIntMethod (Handle, id_getItemViewType_I, __args);
		}

		static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int position, IntPtr native_convertView, IntPtr native_parent)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View convertView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_convertView, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup parent = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_parent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (position, convertView, parent));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		public unsafe global::Android.Views.View GetView (int position, global::Android.Views.View convertView, global::Android.Views.ViewGroup parent)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (position);
			__args [1] = new JValue (convertView);
			__args [2] = new JValue (parent);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
#pragma warning disable 0169
		static Delegate GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler ()
		{
			if (cb_registerDataSetObserver_Landroid_database_DataSetObserver_ == null)
				cb_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterDataSetObserver_Landroid_database_DataSetObserver_);
			return cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
		}

		static void n_RegisterDataSetObserver_Landroid_database_DataSetObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver observer = global::Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDataSetObserver (observer);
		}
#pragma warning restore 0169

		IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;
		public unsafe void RegisterDataSetObserver (global::Android.Database.DataSetObserver observer)
		{
			if (id_registerDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (observer);
			JNIEnv.CallVoidMethod (Handle, id_registerDataSetObserver_Landroid_database_DataSetObserver_, __args);
		}

		static Delegate cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
#pragma warning disable 0169
		static Delegate GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler ()
		{
			if (cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == null)
				cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_);
			return cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		}

		static void n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			global::Android.Support.V7.Widget.IThemedSpinnerAdapter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.IThemedSpinnerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.DataSetObserver observer = global::Java.Lang.Object.GetObject<global::Android.Database.DataSetObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterDataSetObserver (observer);
		}
#pragma warning restore 0169

		IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		public unsafe void UnregisterDataSetObserver (global::Android.Database.DataSetObserver observer)
		{
			if (id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
				id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID (class_ref, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (observer);
			JNIEnv.CallVoidMethod (Handle, id_unregisterDataSetObserver_Landroid_database_DataSetObserver_, __args);
		}

	}

}
