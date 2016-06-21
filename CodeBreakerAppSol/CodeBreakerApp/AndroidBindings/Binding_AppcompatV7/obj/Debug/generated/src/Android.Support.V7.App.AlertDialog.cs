using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']"
	[global::Android.Runtime.Register ("android/support/v7/app/AlertDialog", DoNotGenerateAcw=true)]
	public partial class AlertDialog : global::Android.Support.V7.App.AppCompatDialog, global::Android.Content.IDialogInterface {

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']"
		[global::Android.Runtime.Register ("android/support/v7/app/AlertDialog$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/app/AlertDialog$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/constructor[@name='AlertDialog.Builder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Landroid/content/Context;I)V", "")]
			public unsafe Builder (global::Android.Content.Context p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;I)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
						id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_I, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/constructor[@name='AlertDialog.Builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (Builder)) {
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

			static Delegate cb_getContext;
#pragma warning disable 0169
			static Delegate GetGetContextHandler ()
			{
				if (cb_getContext == null)
					cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
				return cb_getContext;
			}

			static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Context);
			}
#pragma warning restore 0169

			static IntPtr id_getContext;
			public virtual unsafe global::Android.Content.Context Context {
				// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='getContext' and count(parameter)=0]"
				[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
				get {
					if (id_getContext == IntPtr.Zero)
						id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod  (Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_create;
#pragma warning disable 0169
			static Delegate GetCreateHandler ()
			{
				if (cb_create == null)
					cb_create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Create);
				return cb_create;
			}

			static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Create ());
			}
#pragma warning restore 0169

			static IntPtr id_create;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='create' and count(parameter)=0]"
			[Register ("create", "()Landroid/support/v7/app/AlertDialog;", "GetCreateHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog Create ()
			{
				if (id_create == IntPtr.Zero)
					id_create = JNIEnv.GetMethodID (class_ref, "create", "()Landroid/support/v7/app/AlertDialog;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (JNIEnv.CallObjectMethod  (Handle, id_create), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "()Landroid/support/v7/app/AlertDialog;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_);
				return cb_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.IListAdapter p0 = (global::Android.Widget.IListAdapter)global::Java.Lang.Object.GetObject<global::Android.Widget.IListAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p1 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAdapter (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setAdapter' and count(parameter)=2 and parameter[1][@type='android.widget.ListAdapter'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetAdapter (global::Android.Widget.IListAdapter p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				if (id_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setCancelable_Z;
#pragma warning disable 0169
			static Delegate GetSetCancelable_ZHandler ()
			{
				if (cb_setCancelable_Z == null)
					cb_setCancelable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetCancelable_Z);
				return cb_setCancelable_Z;
			}

			static IntPtr n_SetCancelable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCancelable (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setCancelable_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setCancelable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCancelable", "(Z)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetCancelable_ZHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetCancelable (bool p0)
			{
				if (id_setCancelable_Z == IntPtr.Zero)
					id_setCancelable_Z = JNIEnv.GetMethodID (class_ref, "setCancelable", "(Z)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setCancelable_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCancelable", "(Z)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_Handler ()
			{
				if (cb_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_ == null)
					cb_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_);
				return cb_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_;
			}

			static IntPtr n_SetCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p1 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCursor (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setCursor' and count(parameter)=3 and parameter[1][@type='android.database.Cursor'] and parameter[2][@type='android.content.DialogInterface.OnClickListener'] and parameter[3][@type='java.lang.String']]"
			[Register ("setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetCursor (global::Android.Database.ICursor p0, global::Android.Content.IDialogInterfaceOnClickListener p1, string p2)
			{
				if (id_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_ == IntPtr.Zero)
					id_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_setCustomTitle_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetSetCustomTitle_Landroid_view_View_Handler ()
			{
				if (cb_setCustomTitle_Landroid_view_View_ == null)
					cb_setCustomTitle_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomTitle_Landroid_view_View_);
				return cb_setCustomTitle_Landroid_view_View_;
			}

			static IntPtr n_SetCustomTitle_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomTitle (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setCustomTitle_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setCustomTitle' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setCustomTitle", "(Landroid/view/View;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetCustomTitle_Landroid_view_View_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetCustomTitle (global::Android.Views.View p0)
			{
				if (id_setCustomTitle_Landroid_view_View_ == IntPtr.Zero)
					id_setCustomTitle_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setCustomTitle", "(Landroid/view/View;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setCustomTitle_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomTitle", "(Landroid/view/View;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

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
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetIcon (global::Android.Graphics.Drawables.Drawable p0)
			{
				if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

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
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetIcon (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setIcon_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIcon", "(I)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetIcon_IHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetIcon (int p0)
			{
				if (id_setIcon_I == IntPtr.Zero)
					id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setIcon_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(I)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setIconAttribute_I;
#pragma warning disable 0169
			static Delegate GetSetIconAttribute_IHandler ()
			{
				if (cb_setIconAttribute_I == null)
					cb_setIconAttribute_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetIconAttribute_I);
				return cb_setIconAttribute_I;
			}

			static IntPtr n_SetIconAttribute_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetIconAttribute (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setIconAttribute_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setIconAttribute' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIconAttribute", "(I)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetIconAttribute_IHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetIconAttribute (int p0)
			{
				if (id_setIconAttribute_I == IntPtr.Zero)
					id_setIconAttribute_I = JNIEnv.GetMethodID (class_ref, "setIconAttribute", "(I)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setIconAttribute_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIconAttribute", "(I)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setInverseBackgroundForced_Z;
#pragma warning disable 0169
			static Delegate GetSetInverseBackgroundForced_ZHandler ()
			{
				if (cb_setInverseBackgroundForced_Z == null)
					cb_setInverseBackgroundForced_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetInverseBackgroundForced_Z);
				return cb_setInverseBackgroundForced_Z;
			}

			static IntPtr n_SetInverseBackgroundForced_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetInverseBackgroundForced (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setInverseBackgroundForced_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setInverseBackgroundForced' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setInverseBackgroundForced", "(Z)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetInverseBackgroundForced_ZHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetInverseBackgroundForced (bool p0)
			{
				if (id_setInverseBackgroundForced_Z == IntPtr.Zero)
					id_setInverseBackgroundForced_Z = JNIEnv.GetMethodID (class_ref, "setInverseBackgroundForced", "(Z)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setInverseBackgroundForced_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInverseBackgroundForced", "(Z)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setItems_ILandroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetItems_ILandroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setItems_ILandroid_content_DialogInterface_OnClickListener_ == null)
					cb_setItems_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetItems_ILandroid_content_DialogInterface_OnClickListener_);
				return cb_setItems_ILandroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetItems_ILandroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p1 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetItems (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setItems_ILandroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setItems' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetItems_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetItems (int p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				if (id_setItems_ILandroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setItems_ILandroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setItems_ILandroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_);
				return cb_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence[] p0 = (global::Java.Lang.ICharSequence[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.ICharSequence));
				global::Android.Content.IDialogInterfaceOnClickListener p1 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetItems (p0, p1));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setItems' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence[]'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetItems (global::Java.Lang.ICharSequence[] p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				if (id_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			public global::Android.Support.V7.App.AlertDialog.Builder SetItems (string[] p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				global::Java.Lang.ICharSequence[] jlca_p0 = CharSequence.ArrayFromStringArray(p0);
				global::Android.Support.V7.App.AlertDialog.Builder __result = SetItems (jlca_p0, p1);
				if (jlca_p0 != null) foreach (global::Java.Lang.String s in jlca_p0) if (s != null) s.Dispose ();
				return __result;
			}

			static Delegate cb_setMessage_I;
#pragma warning disable 0169
			static Delegate GetSetMessage_IHandler ()
			{
				if (cb_setMessage_I == null)
					cb_setMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMessage_I);
				return cb_setMessage_I;
			}

			static IntPtr n_SetMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetMessage (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setMessage_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMessage", "(I)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetMessage_IHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetMessage (int p0)
			{
				if (id_setMessage_I == IntPtr.Zero)
					id_setMessage_I = JNIEnv.GetMethodID (class_ref, "setMessage", "(I)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMessage_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(I)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setMessage_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetMessage_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setMessage_Ljava_lang_CharSequence_ == null)
					cb_setMessage_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_CharSequence_);
				return cb_setMessage_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetMessage_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setMessage_Ljava_lang_CharSequence_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setMessage", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetMessage_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetMessage (global::Java.Lang.ICharSequence p0)
			{
				if (id_setMessage_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMessage_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			public global::Android.Support.V7.App.AlertDialog.Builder SetMessage (string p0)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				global::Android.Support.V7.App.AlertDialog.Builder __result = SetMessage (jls_p0);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

			static Delegate cb_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_;
#pragma warning disable 0169
			static Delegate GetSetMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_Handler ()
			{
				if (cb_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_ == null)
					cb_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_);
				return cb_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_;
			}

			static IntPtr n_SetMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener p3 = (global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener> (native_p3, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMultiChoiceItems (p0, p1, p2, p3));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setMultiChoiceItems' and count(parameter)=4 and parameter[1][@type='android.database.Cursor'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.DialogInterface.OnMultiChoiceClickListener']]"
			[Register ("setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetMultiChoiceItems (global::Android.Database.ICursor p0, string p1, string p2, global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener p3)
			{
				if (id_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_ == IntPtr.Zero)
					id_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_ = JNIEnv.GetMethodID (class_ref, "setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_;
#pragma warning disable 0169
			static Delegate GetSetMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_Handler ()
			{
				if (cb_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ == null)
					cb_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_SetMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_);
				return cb_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_;
			}

			static IntPtr n_SetMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				bool[] p1 = (bool[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (bool));
				global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener p2 = (global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMultiChoiceItems (p0, p1, p2));
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setMultiChoiceItems' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean[]'] and parameter[3][@type='android.content.DialogInterface.OnMultiChoiceClickListener']]"
			[Register ("setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetMultiChoiceItems (int p0, bool[] p1, global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener p2)
			{
				if (id_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ == IntPtr.Zero)
					id_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ = JNIEnv.GetMethodID (class_ref, "setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_;
#pragma warning disable 0169
			static Delegate GetSetMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_Handler ()
			{
				if (cb_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ == null)
					cb_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_);
				return cb_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_;
			}

			static IntPtr n_SetMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence[] p0 = (global::Java.Lang.ICharSequence[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.ICharSequence));
				bool[] p1 = (bool[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (bool));
				global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener p2 = (global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMultiChoiceItems (p0, p1, p2));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setMultiChoiceItems' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence[]'] and parameter[2][@type='boolean[]'] and parameter[3][@type='android.content.DialogInterface.OnMultiChoiceClickListener']]"
			[Register ("setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetMultiChoiceItems (global::Java.Lang.ICharSequence[] p0, bool[] p1, global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener p2)
			{
				if (id_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ == IntPtr.Zero)
					id_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ = JNIEnv.GetMethodID (class_ref, "setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			public global::Android.Support.V7.App.AlertDialog.Builder SetMultiChoiceItems (string[] p0, bool[] p1, global::Android.Content.IDialogInterfaceOnMultiChoiceClickListener p2)
			{
				global::Java.Lang.ICharSequence[] jlca_p0 = CharSequence.ArrayFromStringArray(p0);
				global::Android.Support.V7.App.AlertDialog.Builder __result = SetMultiChoiceItems (jlca_p0, p1, p2);
				if (jlca_p0 != null) foreach (global::Java.Lang.String s in jlca_p0) if (s != null) s.Dispose ();
				return __result;
			}

			static Delegate cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_ == null)
					cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_);
				return cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p1 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNegativeButton (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setNegativeButton' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetNegativeButton (int p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				if (id_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_);
				return cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p1 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNegativeButton (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setNegativeButton' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetNegativeButton (global::Java.Lang.ICharSequence p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				if (id_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			public global::Android.Support.V7.App.AlertDialog.Builder SetNegativeButton (string p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				global::Android.Support.V7.App.AlertDialog.Builder __result = SetNegativeButton (jls_p0, p1);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

			static Delegate cb_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetNeutralButton_ILandroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_ == null)
					cb_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetNeutralButton_ILandroid_content_DialogInterface_OnClickListener_);
				return cb_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetNeutralButton_ILandroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p1 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNeutralButton (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setNeutralButton' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetNeutralButton_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetNeutralButton (int p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				if (id_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_);
				return cb_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p1 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNeutralButton (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setNeutralButton' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetNeutralButton (global::Java.Lang.ICharSequence p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				if (id_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			public global::Android.Support.V7.App.AlertDialog.Builder SetNeutralButton (string p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				global::Android.Support.V7.App.AlertDialog.Builder __result = SetNeutralButton (jls_p0, p1);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

			static Delegate cb_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_;
#pragma warning disable 0169
			static Delegate GetSetOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_Handler ()
			{
				if (cb_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_ == null)
					cb_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_);
				return cb_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_;
			}

			static IntPtr n_SetOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnCancelListener p0 = (global::Android.Content.IDialogInterfaceOnCancelListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnCancelListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnCancelListener (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setOnCancelListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnCancelListener']]"
			[Register ("setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetOnCancelListener (global::Android.Content.IDialogInterfaceOnCancelListener p0)
			{
				if (id_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_ == IntPtr.Zero)
					id_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_ = JNIEnv.GetMethodID (class_ref, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_;
#pragma warning disable 0169
			static Delegate GetSetOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_Handler ()
			{
				if (cb_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_ == null)
					cb_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_);
				return cb_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_;
			}

			static IntPtr n_SetOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnDismissListener p0 = (global::Android.Content.IDialogInterfaceOnDismissListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnDismissListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnDismissListener (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setOnDismissListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnDismissListener']]"
			[Register ("setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetOnDismissListener (global::Android.Content.IDialogInterfaceOnDismissListener p0)
			{
				if (id_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_ == IntPtr.Zero)
					id_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_ = JNIEnv.GetMethodID (class_ref, "setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_;
#pragma warning disable 0169
			static Delegate GetSetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_Handler ()
			{
				if (cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ == null)
					cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_);
				return cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_;
			}

			static IntPtr n_SetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AdapterView.IOnItemSelectedListener p0 = (global::Android.Widget.AdapterView.IOnItemSelectedListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView.IOnItemSelectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnItemSelectedListener (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setOnItemSelectedListener' and count(parameter)=1 and parameter[1][@type='android.widget.AdapterView.OnItemSelectedListener']]"
			[Register ("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetOnItemSelectedListener (global::Android.Widget.AdapterView.IOnItemSelectedListener p0)
			{
				if (id_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ == IntPtr.Zero)
					id_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_;
#pragma warning disable 0169
			static Delegate GetSetOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_Handler ()
			{
				if (cb_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_ == null)
					cb_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_);
				return cb_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_;
			}

			static IntPtr n_SetOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnKeyListener p0 = (global::Android.Content.IDialogInterfaceOnKeyListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnKeyListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnKeyListener (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setOnKeyListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnKeyListener']]"
			[Register ("setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetOnKeyListener (global::Android.Content.IDialogInterfaceOnKeyListener p0)
			{
				if (id_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_ == IntPtr.Zero)
					id_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_ = JNIEnv.GetMethodID (class_ref, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetPositiveButton_ILandroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_ == null)
					cb_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetPositiveButton_ILandroid_content_DialogInterface_OnClickListener_);
				return cb_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetPositiveButton_ILandroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p1 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPositiveButton (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setPositiveButton' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetPositiveButton_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetPositiveButton (int p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				if (id_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_);
				return cb_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p1 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPositiveButton (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setPositiveButton' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetPositiveButton (global::Java.Lang.ICharSequence p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				if (id_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			public global::Android.Support.V7.App.AlertDialog.Builder SetPositiveButton (string p0, global::Android.Content.IDialogInterfaceOnClickListener p1)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				global::Android.Support.V7.App.AlertDialog.Builder __result = SetPositiveButton (jls_p0, p1);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

			static Delegate cb_setRecycleOnMeasureEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetRecycleOnMeasureEnabled_ZHandler ()
			{
				if (cb_setRecycleOnMeasureEnabled_Z == null)
					cb_setRecycleOnMeasureEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetRecycleOnMeasureEnabled_Z);
				return cb_setRecycleOnMeasureEnabled_Z;
			}

			static IntPtr n_SetRecycleOnMeasureEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetRecycleOnMeasureEnabled (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setRecycleOnMeasureEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setRecycleOnMeasureEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRecycleOnMeasureEnabled", "(Z)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetRecycleOnMeasureEnabled_ZHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetRecycleOnMeasureEnabled (bool p0)
			{
				if (id_setRecycleOnMeasureEnabled_Z == IntPtr.Zero)
					id_setRecycleOnMeasureEnabled_Z = JNIEnv.GetMethodID (class_ref, "setRecycleOnMeasureEnabled", "(Z)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setRecycleOnMeasureEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecycleOnMeasureEnabled", "(Z)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_ == null)
					cb_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_SetSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_);
				return cb_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p3 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p3, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSingleChoiceItems (p0, p1, p2, p3));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setSingleChoiceItems' and count(parameter)=4 and parameter[1][@type='android.database.Cursor'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetSingleChoiceItems (global::Android.Database.ICursor p0, int p1, string p2, global::Android.Content.IDialogInterfaceOnClickListener p3)
			{
				if (id_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_ == null)
					cb_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_);
				return cb_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.IListAdapter p0 = (global::Android.Widget.IListAdapter)global::Java.Lang.Object.GetObject<global::Android.Widget.IListAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p2 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSingleChoiceItems (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setSingleChoiceItems' and count(parameter)=3 and parameter[1][@type='android.widget.ListAdapter'] and parameter[2][@type='int'] and parameter[3][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetSingleChoiceItems (global::Android.Widget.IListAdapter p0, int p1, global::Android.Content.IDialogInterfaceOnClickListener p2)
			{
				if (id_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_ == null)
					cb_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_SetSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_);
				return cb_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterfaceOnClickListener p2 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSingleChoiceItems (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setSingleChoiceItems' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetSingleChoiceItems (int p0, int p1, global::Android.Content.IDialogInterfaceOnClickListener p2)
			{
				if (id_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
			static Delegate GetSetSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_Handler ()
			{
				if (cb_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_ == null)
					cb_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_);
				return cb_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_;
			}

			static IntPtr n_SetSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence[] p0 = (global::Java.Lang.ICharSequence[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.ICharSequence));
				global::Android.Content.IDialogInterfaceOnClickListener p2 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSingleChoiceItems (p0, p1, p2));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setSingleChoiceItems' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence[]'] and parameter[2][@type='int'] and parameter[3][@type='android.content.DialogInterface.OnClickListener']]"
			[Register ("setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetSingleChoiceItems (global::Java.Lang.ICharSequence[] p0, int p1, global::Android.Content.IDialogInterfaceOnClickListener p2)
			{
				if (id_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
					id_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			public global::Android.Support.V7.App.AlertDialog.Builder SetSingleChoiceItems (string[] p0, int p1, global::Android.Content.IDialogInterfaceOnClickListener p2)
			{
				global::Java.Lang.ICharSequence[] jlca_p0 = CharSequence.ArrayFromStringArray(p0);
				global::Android.Support.V7.App.AlertDialog.Builder __result = SetSingleChoiceItems (jlca_p0, p1, p2);
				if (jlca_p0 != null) foreach (global::Java.Lang.String s in jlca_p0) if (s != null) s.Dispose ();
				return __result;
			}

			static Delegate cb_setTitle_I;
#pragma warning disable 0169
			static Delegate GetSetTitle_IHandler ()
			{
				if (cb_setTitle_I == null)
					cb_setTitle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTitle_I);
				return cb_setTitle_I;
			}

			static IntPtr n_SetTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetTitle (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setTitle_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTitle", "(I)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetTitle_IHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetTitle (int p0)
			{
				if (id_setTitle_I == IntPtr.Zero)
					id_setTitle_I = JNIEnv.GetMethodID (class_ref, "setTitle", "(I)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setTitle_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(I)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_setTitle_Ljava_lang_CharSequence_ == null)
					cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_CharSequence_);
				return cb_setTitle_Ljava_lang_CharSequence_;
			}

			static IntPtr n_SetTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitle (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setTitle_Ljava_lang_CharSequence_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setTitle", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetTitle (global::Java.Lang.ICharSequence p0)
			{
				if (id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/AlertDialog$Builder;");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setTitle_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			public global::Android.Support.V7.App.AlertDialog.Builder SetTitle (string p0)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				global::Android.Support.V7.App.AlertDialog.Builder __result = SetTitle (jls_p0);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

			static Delegate cb_setView_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetSetView_Landroid_view_View_Handler ()
			{
				if (cb_setView_Landroid_view_View_ == null)
					cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetView_Landroid_view_View_);
				return cb_setView_Landroid_view_View_;
			}

			static IntPtr n_SetView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetView (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setView_Landroid_view_View_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setView", "(Landroid/view/View;)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetView_Landroid_view_View_Handler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetView (global::Android.Views.View p0)
			{
				if (id_setView_Landroid_view_View_ == IntPtr.Zero)
					id_setView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setView", "(Landroid/view/View;)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setView", "(Landroid/view/View;)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setView_Landroid_view_View_IIII;
#pragma warning disable 0169
			static Delegate GetSetView_Landroid_view_View_IIIIHandler ()
			{
				if (cb_setView_Landroid_view_View_IIII == null)
					cb_setView_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr>) n_SetView_Landroid_view_View_IIII);
				return cb_setView_Landroid_view_View_IIII;
			}

			static IntPtr n_SetView_Landroid_view_View_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetView (p0, p1, p2, p3, p4));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setView_Landroid_view_View_IIII;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setView' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("setView", "(Landroid/view/View;IIII)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetView_Landroid_view_View_IIIIHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetView (global::Android.Views.View p0, int p1, int p2, int p3, int p4)
			{
				if (id_setView_Landroid_view_View_IIII == IntPtr.Zero)
					id_setView_Landroid_view_View_IIII = JNIEnv.GetMethodID (class_ref, "setView", "(Landroid/view/View;IIII)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);

					global::Android.Support.V7.App.AlertDialog.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setView_Landroid_view_View_IIII, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setView", "(Landroid/view/View;IIII)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setView_I;
#pragma warning disable 0169
			static Delegate GetSetView_IHandler ()
			{
				if (cb_setView_I == null)
					cb_setView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetView_I);
				return cb_setView_I;
			}

			static IntPtr n_SetView_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetView (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setView_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='setView' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setView", "(I)Landroid/support/v7/app/AlertDialog$Builder;", "GetSetView_IHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog.Builder SetView (int p0)
			{
				if (id_setView_I == IntPtr.Zero)
					id_setView_I = JNIEnv.GetMethodID (class_ref, "setView", "(I)Landroid/support/v7/app/AlertDialog$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setView_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setView", "(I)Landroid/support/v7/app/AlertDialog$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_show;
#pragma warning disable 0169
			static Delegate GetShowHandler ()
			{
				if (cb_show == null)
					cb_show = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Show);
				return cb_show;
			}

			static IntPtr n_Show (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Support.V7.App.AlertDialog.Builder __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Show ());
			}
#pragma warning restore 0169

			static IntPtr id_show;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog.Builder']/method[@name='show' and count(parameter)=0]"
			[Register ("show", "()Landroid/support/v7/app/AlertDialog;", "GetShowHandler")]
			public virtual unsafe global::Android.Support.V7.App.AlertDialog Show ()
			{
				if (id_show == IntPtr.Zero)
					id_show = JNIEnv.GetMethodID (class_ref, "show", "()Landroid/support/v7/app/AlertDialog;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (JNIEnv.CallObjectMethod  (Handle, id_show), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "()Landroid/support/v7/app/AlertDialog;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/app/AlertDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlertDialog); }
		}

		protected AlertDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/constructor[@name='AlertDialog' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		protected unsafe AlertDialog (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AlertDialog)) {
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

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/constructor[@name='AlertDialog' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		protected unsafe AlertDialog (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AlertDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_ZLandroid_content_DialogInterface_OnCancelListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/constructor[@name='AlertDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='android.content.DialogInterface.OnCancelListener']]"
		[Register (".ctor", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", "")]
		protected unsafe AlertDialog (global::Android.Content.Context p0, bool p1, global::Android.Content.IDialogInterfaceOnCancelListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (AlertDialog)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ZLandroid_content_DialogInterface_OnCancelListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ZLandroid_content_DialogInterface_OnCancelListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ZLandroid_content_DialogInterface_OnCancelListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_ZLandroid_content_DialogInterface_OnCancelListener_, __args);
			} finally {
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
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListView);
		}
#pragma warning restore 0169

		static IntPtr id_getListView;
		public virtual unsafe global::Android.Widget.ListView ListView {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='getListView' and count(parameter)=0]"
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

		static Delegate cb_getButton_I;
#pragma warning disable 0169
		static Delegate GetGetButton_IHandler ()
		{
			if (cb_getButton_I == null)
				cb_getButton_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetButton_I);
			return cb_getButton_I;
		}

		static IntPtr n_GetButton_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetButton (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getButton_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='getButton' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getButton", "(I)Landroid/widget/Button;", "GetGetButton_IHandler")]
		public virtual unsafe global::Android.Widget.Button GetButton (int p0)
		{
			if (id_getButton_I == IntPtr.Zero)
				id_getButton_I = JNIEnv.GetMethodID (class_ref, "getButton", "(I)Landroid/widget/Button;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (JNIEnv.CallObjectMethod  (Handle, id_getButton_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getButton", "(I)Landroid/widget/Button;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler ()
		{
			if (cb_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
				cb_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_);
			return cb_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
		}

		static void n_SetButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IDialogInterfaceOnClickListener p2 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetButton (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='setButton' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", "GetSetButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
		public virtual unsafe void SetButton (int p0, global::Java.Lang.ICharSequence p1, global::Android.Content.IDialogInterfaceOnClickListener p2)
		{
			if (id_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
				id_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			IntPtr native_p1 = CharSequence.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		public void SetButton (int p0, string p1, global::Android.Content.IDialogInterfaceOnClickListener p2)
		{
			global::Java.Lang.String jls_p1 = p1 == null ? null : new global::Java.Lang.String (p1);
			SetButton (p0, jls_p1, p2);
			if (jls_p1 != null) jls_p1.Dispose ();
		}

		static Delegate cb_setButton_ILjava_lang_CharSequence_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetSetButton_ILjava_lang_CharSequence_Landroid_os_Message_Handler ()
		{
			if (cb_setButton_ILjava_lang_CharSequence_Landroid_os_Message_ == null)
				cb_setButton_ILjava_lang_CharSequence_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetButton_ILjava_lang_CharSequence_Landroid_os_Message_);
			return cb_setButton_ILjava_lang_CharSequence_Landroid_os_Message_;
		}

		static void n_SetButton_ILjava_lang_CharSequence_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetButton (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setButton_ILjava_lang_CharSequence_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='setButton' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='android.os.Message']]"
		[Register ("setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V", "GetSetButton_ILjava_lang_CharSequence_Landroid_os_Message_Handler")]
		public virtual unsafe void SetButton (int p0, global::Java.Lang.ICharSequence p1, global::Android.OS.Message p2)
		{
			if (id_setButton_ILjava_lang_CharSequence_Landroid_os_Message_ == IntPtr.Zero)
				id_setButton_ILjava_lang_CharSequence_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V");
			IntPtr native_p1 = CharSequence.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setButton_ILjava_lang_CharSequence_Landroid_os_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		public void SetButton (int p0, string p1, global::Android.OS.Message p2)
		{
			global::Java.Lang.String jls_p1 = p1 == null ? null : new global::Java.Lang.String (p1);
			SetButton (p0, jls_p1, p2);
			if (jls_p1 != null) jls_p1.Dispose ();
		}

		static Delegate cb_setCustomTitle_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetCustomTitle_Landroid_view_View_Handler ()
		{
			if (cb_setCustomTitle_Landroid_view_View_ == null)
				cb_setCustomTitle_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomTitle_Landroid_view_View_);
			return cb_setCustomTitle_Landroid_view_View_;
		}

		static void n_SetCustomTitle_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCustomTitle_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='setCustomTitle' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setCustomTitle", "(Landroid/view/View;)V", "GetSetCustomTitle_Landroid_view_View_Handler")]
		public virtual unsafe void SetCustomTitle (global::Android.Views.View p0)
		{
			if (id_setCustomTitle_Landroid_view_View_ == IntPtr.Zero)
				id_setCustomTitle_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setCustomTitle", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCustomTitle_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomTitle", "(Landroid/view/View;)V"), __args);
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
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

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
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIcon", "(I)V", "GetSetIcon_IHandler")]
		public virtual unsafe void SetIcon (int p0)
		{
			if (id_setIcon_I == IntPtr.Zero)
				id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIcon_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIconAttribute_I;
#pragma warning disable 0169
		static Delegate GetSetIconAttribute_IHandler ()
		{
			if (cb_setIconAttribute_I == null)
				cb_setIconAttribute_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIconAttribute_I);
			return cb_setIconAttribute_I;
		}

		static void n_SetIconAttribute_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIconAttribute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIconAttribute_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='setIconAttribute' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIconAttribute", "(I)V", "GetSetIconAttribute_IHandler")]
		public virtual unsafe void SetIconAttribute (int p0)
		{
			if (id_setIconAttribute_I == IntPtr.Zero)
				id_setIconAttribute_I = JNIEnv.GetMethodID (class_ref, "setIconAttribute", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIconAttribute_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIconAttribute", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMessage_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setMessage_Ljava_lang_CharSequence_ == null)
				cb_setMessage_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_CharSequence_);
			return cb_setMessage_Ljava_lang_CharSequence_;
		}

		static void n_SetMessage_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessage_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setMessage", "(Ljava/lang/CharSequence;)V", "GetSetMessage_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe void SetMessage (global::Java.Lang.ICharSequence p0)
		{
			if (id_setMessage_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_setMessage_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMessage_Ljava_lang_CharSequence_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/CharSequence;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void SetMessage (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			SetMessage (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_setView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetView_Landroid_view_View_Handler ()
		{
			if (cb_setView_Landroid_view_View_ == null)
				cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetView_Landroid_view_View_);
			return cb_setView_Landroid_view_View_;
		}

		static void n_SetView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='setView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setView", "(Landroid/view/View;)V", "GetSetView_Landroid_view_View_Handler")]
		public virtual unsafe void SetView (global::Android.Views.View p0)
		{
			if (id_setView_Landroid_view_View_ == IntPtr.Zero)
				id_setView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setView_Landroid_view_View_IIII;
#pragma warning disable 0169
		static Delegate GetSetView_Landroid_view_View_IIIIHandler ()
		{
			if (cb_setView_Landroid_view_View_IIII == null)
				cb_setView_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_SetView_Landroid_view_View_IIII);
			return cb_setView_Landroid_view_View_IIII;
		}

		static void n_SetView_Landroid_view_View_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4)
		{
			global::Android.Support.V7.App.AlertDialog __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.AlertDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetView (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_setView_Landroid_view_View_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.app']/class[@name='AlertDialog']/method[@name='setView' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("setView", "(Landroid/view/View;IIII)V", "GetSetView_Landroid_view_View_IIIIHandler")]
		public virtual unsafe void SetView (global::Android.Views.View p0, int p1, int p2, int p3, int p4)
		{
			if (id_setView_Landroid_view_View_IIII == IntPtr.Zero)
				id_setView_Landroid_view_View_IIII = JNIEnv.GetMethodID (class_ref, "setView", "(Landroid/view/View;IIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setView_Landroid_view_View_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setView", "(Landroid/view/View;IIII)V"), __args);
			} finally {
			}
		}

	}
}
