using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/TintTypedArray", DoNotGenerateAcw=true)]
	public partial class TintTypedArray : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/TintTypedArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TintTypedArray); }
		}

		protected TintTypedArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getChangingConfigurations;
#pragma warning disable 0169
		static Delegate GetGetChangingConfigurationsHandler ()
		{
			if (cb_getChangingConfigurations == null)
				cb_getChangingConfigurations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChangingConfigurations);
			return cb_getChangingConfigurations;
		}

		static int n_GetChangingConfigurations (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChangingConfigurations;
		}
#pragma warning restore 0169

		static IntPtr id_getChangingConfigurations;
		public virtual unsafe int ChangingConfigurations {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getChangingConfigurations' and count(parameter)=0]"
			[Register ("getChangingConfigurations", "()I", "GetGetChangingConfigurationsHandler")]
			get {
				if (id_getChangingConfigurations == IntPtr.Zero)
					id_getChangingConfigurations = JNIEnv.GetMethodID (class_ref, "getChangingConfigurations", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getChangingConfigurations);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChangingConfigurations", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getIndexCount;
#pragma warning disable 0169
		static Delegate GetGetIndexCountHandler ()
		{
			if (cb_getIndexCount == null)
				cb_getIndexCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndexCount);
			return cb_getIndexCount;
		}

		static int n_GetIndexCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexCount;
		}
#pragma warning restore 0169

		static IntPtr id_getIndexCount;
		public virtual unsafe int IndexCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getIndexCount' and count(parameter)=0]"
			[Register ("getIndexCount", "()I", "GetGetIndexCountHandler")]
			get {
				if (id_getIndexCount == IntPtr.Zero)
					id_getIndexCount = JNIEnv.GetMethodID (class_ref, "getIndexCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getIndexCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPositionDescription;
#pragma warning disable 0169
		static Delegate GetGetPositionDescriptionHandler ()
		{
			if (cb_getPositionDescription == null)
				cb_getPositionDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPositionDescription);
			return cb_getPositionDescription;
		}

		static IntPtr n_GetPositionDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PositionDescription);
		}
#pragma warning restore 0169

		static IntPtr id_getPositionDescription;
		public virtual unsafe string PositionDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getPositionDescription' and count(parameter)=0]"
			[Register ("getPositionDescription", "()Ljava/lang/String;", "GetGetPositionDescriptionHandler")]
			get {
				if (id_getPositionDescription == IntPtr.Zero)
					id_getPositionDescription = JNIEnv.GetMethodID (class_ref, "getPositionDescription", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPositionDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositionDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResources;
#pragma warning disable 0169
		static Delegate GetGetResourcesHandler ()
		{
			if (cb_getResources == null)
				cb_getResources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResources);
			return cb_getResources;
		}

		static IntPtr n_GetResources (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resources);
		}
#pragma warning restore 0169

		static IntPtr id_getResources;
		public virtual unsafe global::Android.Content.Res.Resources Resources {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getResources' and count(parameter)=0]"
			[Register ("getResources", "()Landroid/content/res/Resources;", "GetGetResourcesHandler")]
			get {
				if (id_getResources == IntPtr.Zero)
					id_getResources = JNIEnv.GetMethodID (class_ref, "getResources", "()Landroid/content/res/Resources;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (JNIEnv.CallObjectMethod  (Handle, id_getResources), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResources", "()Landroid/content/res/Resources;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTintManager;
#pragma warning disable 0169
		static Delegate GetGetTintManagerHandler ()
		{
			if (cb_getTintManager == null)
				cb_getTintManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTintManager);
			return cb_getTintManager;
		}

		static IntPtr n_GetTintManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TintManager);
		}
#pragma warning restore 0169

		static IntPtr id_getTintManager;
		public virtual unsafe global::Android.Support.V7.Internal.Widget.TintManager TintManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getTintManager' and count(parameter)=0]"
			[Register ("getTintManager", "()Landroid/support/v7/internal/widget/TintManager;", "GetGetTintManagerHandler")]
			get {
				if (id_getTintManager == IntPtr.Zero)
					id_getTintManager = JNIEnv.GetMethodID (class_ref, "getTintManager", "()Landroid/support/v7/internal/widget/TintManager;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintManager> (JNIEnv.CallObjectMethod  (Handle, id_getTintManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTintManager", "()Landroid/support/v7/internal/widget/TintManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBoolean_IZ;
#pragma warning disable 0169
		static Delegate GetGetBoolean_IZHandler ()
		{
			if (cb_getBoolean_IZ == null)
				cb_getBoolean_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, bool>) n_GetBoolean_IZ);
			return cb_getBoolean_IZ;
		}

		static bool n_GetBoolean_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetBoolean (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getBoolean_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getBoolean' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("getBoolean", "(IZ)Z", "GetGetBoolean_IZHandler")]
		public virtual unsafe bool GetBoolean (int p0, bool p1)
		{
			if (id_getBoolean_IZ == IntPtr.Zero)
				id_getBoolean_IZ = JNIEnv.GetMethodID (class_ref, "getBoolean", "(IZ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getBoolean_IZ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoolean", "(IZ)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_getColor_II;
#pragma warning disable 0169
		static Delegate GetGetColor_IIHandler ()
		{
			if (cb_getColor_II == null)
				cb_getColor_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetColor_II);
			return cb_getColor_II;
		}

		static int n_GetColor_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetColor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getColor_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getColor", "(II)I", "GetGetColor_IIHandler")]
		public virtual unsafe int GetColor (int p0, int p1)
		{
			if (id_getColor_II == IntPtr.Zero)
				id_getColor_II = JNIEnv.GetMethodID (class_ref, "getColor", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getColor_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getColorStateList_I;
#pragma warning disable 0169
		static Delegate GetGetColorStateList_IHandler ()
		{
			if (cb_getColorStateList_I == null)
				cb_getColorStateList_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetColorStateList_I);
			return cb_getColorStateList_I;
		}

		static IntPtr n_GetColorStateList_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetColorStateList (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getColorStateList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getColorStateList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColorStateList", "(I)Landroid/content/res/ColorStateList;", "GetGetColorStateList_IHandler")]
		public virtual unsafe global::Android.Content.Res.ColorStateList GetColorStateList (int p0)
		{
			if (id_getColorStateList_I == IntPtr.Zero)
				id_getColorStateList_I = JNIEnv.GetMethodID (class_ref, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (JNIEnv.CallObjectMethod  (Handle, id_getColorStateList_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDimension_IF;
#pragma warning disable 0169
		static Delegate GetGetDimension_IFHandler ()
		{
			if (cb_getDimension_IF == null)
				cb_getDimension_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, float>) n_GetDimension_IF);
			return cb_getDimension_IF;
		}

		static float n_GetDimension_IF (IntPtr jnienv, IntPtr native__this, int p0, float p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDimension (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getDimension_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getDimension' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("getDimension", "(IF)F", "GetGetDimension_IFHandler")]
		public virtual unsafe float GetDimension (int p0, float p1)
		{
			if (id_getDimension_IF == IntPtr.Zero)
				id_getDimension_IF = JNIEnv.GetMethodID (class_ref, "getDimension", "(IF)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getDimension_IF, __args);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimension", "(IF)F"), __args);
			} finally {
			}
		}

		static Delegate cb_getDimensionPixelOffset_II;
#pragma warning disable 0169
		static Delegate GetGetDimensionPixelOffset_IIHandler ()
		{
			if (cb_getDimensionPixelOffset_II == null)
				cb_getDimensionPixelOffset_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetDimensionPixelOffset_II);
			return cb_getDimensionPixelOffset_II;
		}

		static int n_GetDimensionPixelOffset_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDimensionPixelOffset (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getDimensionPixelOffset_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getDimensionPixelOffset' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDimensionPixelOffset", "(II)I", "GetGetDimensionPixelOffset_IIHandler")]
		public virtual unsafe int GetDimensionPixelOffset (int p0, int p1)
		{
			if (id_getDimensionPixelOffset_II == IntPtr.Zero)
				id_getDimensionPixelOffset_II = JNIEnv.GetMethodID (class_ref, "getDimensionPixelOffset", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDimensionPixelOffset_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimensionPixelOffset", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getDimensionPixelSize_II;
#pragma warning disable 0169
		static Delegate GetGetDimensionPixelSize_IIHandler ()
		{
			if (cb_getDimensionPixelSize_II == null)
				cb_getDimensionPixelSize_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetDimensionPixelSize_II);
			return cb_getDimensionPixelSize_II;
		}

		static int n_GetDimensionPixelSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDimensionPixelSize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getDimensionPixelSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getDimensionPixelSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDimensionPixelSize", "(II)I", "GetGetDimensionPixelSize_IIHandler")]
		public virtual unsafe int GetDimensionPixelSize (int p0, int p1)
		{
			if (id_getDimensionPixelSize_II == IntPtr.Zero)
				id_getDimensionPixelSize_II = JNIEnv.GetMethodID (class_ref, "getDimensionPixelSize", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDimensionPixelSize_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimensionPixelSize", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getDrawable_I;
#pragma warning disable 0169
		static Delegate GetGetDrawable_IHandler ()
		{
			if (cb_getDrawable_I == null)
				cb_getDrawable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDrawable_I);
			return cb_getDrawable_I;
		}

		static IntPtr n_GetDrawable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDrawable (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getDrawable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_IHandler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (int p0)
		{
			if (id_getDrawable_I == IntPtr.Zero)
				id_getDrawable_I = JNIEnv.GetMethodID (class_ref, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDrawable_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDrawableIfKnown_I;
#pragma warning disable 0169
		static Delegate GetGetDrawableIfKnown_IHandler ()
		{
			if (cb_getDrawableIfKnown_I == null)
				cb_getDrawableIfKnown_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDrawableIfKnown_I);
			return cb_getDrawableIfKnown_I;
		}

		static IntPtr n_GetDrawableIfKnown_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDrawableIfKnown (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getDrawableIfKnown_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getDrawableIfKnown' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDrawableIfKnown", "(I)Landroid/graphics/drawable/Drawable;", "GetGetDrawableIfKnown_IHandler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable GetDrawableIfKnown (int p0)
		{
			if (id_getDrawableIfKnown_I == IntPtr.Zero)
				id_getDrawableIfKnown_I = JNIEnv.GetMethodID (class_ref, "getDrawableIfKnown", "(I)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDrawableIfKnown_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawableIfKnown", "(I)Landroid/graphics/drawable/Drawable;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getFloat_IF;
#pragma warning disable 0169
		static Delegate GetGetFloat_IFHandler ()
		{
			if (cb_getFloat_IF == null)
				cb_getFloat_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, float>) n_GetFloat_IF);
			return cb_getFloat_IF;
		}

		static float n_GetFloat_IF (IntPtr jnienv, IntPtr native__this, int p0, float p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetFloat (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getFloat_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getFloat' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("getFloat", "(IF)F", "GetGetFloat_IFHandler")]
		public virtual unsafe float GetFloat (int p0, float p1)
		{
			if (id_getFloat_IF == IntPtr.Zero)
				id_getFloat_IF = JNIEnv.GetMethodID (class_ref, "getFloat", "(IF)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getFloat_IF, __args);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFloat", "(IF)F"), __args);
			} finally {
			}
		}

		static Delegate cb_getFraction_IIIF;
#pragma warning disable 0169
		static Delegate GetGetFraction_IIIFHandler ()
		{
			if (cb_getFraction_IIIF == null)
				cb_getFraction_IIIF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, float, float>) n_GetFraction_IIIF);
			return cb_getFraction_IIIF;
		}

		static float n_GetFraction_IIIF (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, float p3)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetFraction (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_getFraction_IIIF;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getFraction' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("getFraction", "(IIIF)F", "GetGetFraction_IIIFHandler")]
		public virtual unsafe float GetFraction (int p0, int p1, int p2, float p3)
		{
			if (id_getFraction_IIIF == IntPtr.Zero)
				id_getFraction_IIIF = JNIEnv.GetMethodID (class_ref, "getFraction", "(IIIF)F");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getFraction_IIIF, __args);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFraction", "(IIIF)F"), __args);
			} finally {
			}
		}

		static Delegate cb_getIndex_I;
#pragma warning disable 0169
		static Delegate GetGetIndex_IHandler ()
		{
			if (cb_getIndex_I == null)
				cb_getIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetIndex_I);
			return cb_getIndex_I;
		}

		static int n_GetIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndex (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIndex", "(I)I", "GetGetIndex_IHandler")]
		public virtual unsafe int GetIndex (int p0)
		{
			if (id_getIndex_I == IntPtr.Zero)
				id_getIndex_I = JNIEnv.GetMethodID (class_ref, "getIndex", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getIndex_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndex", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getInt_II;
#pragma warning disable 0169
		static Delegate GetGetInt_IIHandler ()
		{
			if (cb_getInt_II == null)
				cb_getInt_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetInt_II);
			return cb_getInt_II;
		}

		static int n_GetInt_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetInt (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getInt_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getInt", "(II)I", "GetGetInt_IIHandler")]
		public virtual unsafe int GetInt (int p0, int p1)
		{
			if (id_getInt_II == IntPtr.Zero)
				id_getInt_II = JNIEnv.GetMethodID (class_ref, "getInt", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getInt_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInt", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getInteger_II;
#pragma warning disable 0169
		static Delegate GetGetInteger_IIHandler ()
		{
			if (cb_getInteger_II == null)
				cb_getInteger_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetInteger_II);
			return cb_getInteger_II;
		}

		static int n_GetInteger_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetInteger (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getInteger_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getInteger' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getInteger", "(II)I", "GetGetInteger_IIHandler")]
		public virtual unsafe int GetInteger (int p0, int p1)
		{
			if (id_getInteger_II == IntPtr.Zero)
				id_getInteger_II = JNIEnv.GetMethodID (class_ref, "getInteger", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getInteger_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInteger", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getLayoutDimension_II;
#pragma warning disable 0169
		static Delegate GetGetLayoutDimension_IIHandler ()
		{
			if (cb_getLayoutDimension_II == null)
				cb_getLayoutDimension_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetLayoutDimension_II);
			return cb_getLayoutDimension_II;
		}

		static int n_GetLayoutDimension_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLayoutDimension (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getLayoutDimension_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getLayoutDimension' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getLayoutDimension", "(II)I", "GetGetLayoutDimension_IIHandler")]
		public virtual unsafe int GetLayoutDimension (int p0, int p1)
		{
			if (id_getLayoutDimension_II == IntPtr.Zero)
				id_getLayoutDimension_II = JNIEnv.GetMethodID (class_ref, "getLayoutDimension", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLayoutDimension_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayoutDimension", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getLayoutDimension_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLayoutDimension_ILjava_lang_String_Handler ()
		{
			if (cb_getLayoutDimension_ILjava_lang_String_ == null)
				cb_getLayoutDimension_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetLayoutDimension_ILjava_lang_String_);
			return cb_getLayoutDimension_ILjava_lang_String_;
		}

		static int n_GetLayoutDimension_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetLayoutDimension (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLayoutDimension_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getLayoutDimension' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLayoutDimension", "(ILjava/lang/String;)I", "GetGetLayoutDimension_ILjava_lang_String_Handler")]
		public virtual unsafe int GetLayoutDimension (int p0, string p1)
		{
			if (id_getLayoutDimension_ILjava_lang_String_ == IntPtr.Zero)
				id_getLayoutDimension_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLayoutDimension", "(ILjava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getLayoutDimension_ILjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayoutDimension", "(ILjava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getNonResourceString_I;
#pragma warning disable 0169
		static Delegate GetGetNonResourceString_IHandler ()
		{
			if (cb_getNonResourceString_I == null)
				cb_getNonResourceString_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetNonResourceString_I);
			return cb_getNonResourceString_I;
		}

		static IntPtr n_GetNonResourceString_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetNonResourceString (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getNonResourceString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getNonResourceString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNonResourceString", "(I)Ljava/lang/String;", "GetGetNonResourceString_IHandler")]
		public virtual unsafe string GetNonResourceString (int p0)
		{
			if (id_getNonResourceString_I == IntPtr.Zero)
				id_getNonResourceString_I = JNIEnv.GetMethodID (class_ref, "getNonResourceString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getNonResourceString_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNonResourceString", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getResourceId_II;
#pragma warning disable 0169
		static Delegate GetGetResourceId_IIHandler ()
		{
			if (cb_getResourceId_II == null)
				cb_getResourceId_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetResourceId_II);
			return cb_getResourceId_II;
		}

		static int n_GetResourceId_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetResourceId (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getResourceId_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getResourceId' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getResourceId", "(II)I", "GetGetResourceId_IIHandler")]
		public virtual unsafe int GetResourceId (int p0, int p1)
		{
			if (id_getResourceId_II == IntPtr.Zero)
				id_getResourceId_II = JNIEnv.GetMethodID (class_ref, "getResourceId", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getResourceId_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceId", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getString_I;
#pragma warning disable 0169
		static Delegate GetGetString_IHandler ()
		{
			if (cb_getString_I == null)
				cb_getString_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetString_I);
			return cb_getString_I;
		}

		static IntPtr n_GetString_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetString (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getString", "(I)Ljava/lang/String;", "GetGetString_IHandler")]
		public virtual unsafe string GetString (int p0)
		{
			if (id_getString_I == IntPtr.Zero)
				id_getString_I = JNIEnv.GetMethodID (class_ref, "getString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getText_I;
#pragma warning disable 0169
		static Delegate GetGetText_IHandler ()
		{
			if (cb_getText_I == null)
				cb_getText_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetText_I);
			return cb_getText_I;
		}

		static IntPtr n_GetText_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.GetTextFormatted (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getText_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getText' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getText", "(I)Ljava/lang/CharSequence;", "GetGetText_IHandler")]
		public virtual unsafe global::Java.Lang.ICharSequence GetTextFormatted (int p0)
		{
			if (id_getText_I == IntPtr.Zero)
				id_getText_I = JNIEnv.GetMethodID (class_ref, "getText", "(I)Ljava/lang/CharSequence;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod  (Handle, id_getText_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getText", "(I)Ljava/lang/CharSequence;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public string GetText (int p0)
		{
			global::Java.Lang.ICharSequence __result = GetTextFormatted (p0);
			return __result == null ? null : __result.ToString ();
		}

		static Delegate cb_getTextArray_I;
#pragma warning disable 0169
		static Delegate GetGetTextArray_IHandler ()
		{
			if (cb_getTextArray_I == null)
				cb_getTextArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTextArray_I);
			return cb_getTextArray_I;
		}

		static IntPtr n_GetTextArray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTextArrayFormatted (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getTextArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getTextArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTextArray", "(I)[Ljava/lang/CharSequence;", "GetGetTextArray_IHandler")]
		public virtual unsafe global::Java.Lang.ICharSequence[] GetTextArrayFormatted (int p0)
		{
			if (id_getTextArray_I == IntPtr.Zero)
				id_getTextArray_I = JNIEnv.GetMethodID (class_ref, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return (global::Java.Lang.ICharSequence[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTextArray_I, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.ICharSequence));
				else
					return (global::Java.Lang.ICharSequence[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextArray", "(I)[Ljava/lang/CharSequence;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.ICharSequence));
			} finally {
			}
		}

		public string[] GetTextArray (int p0)
		{
			global::Java.Lang.ICharSequence[] __result = GetTextArrayFormatted (p0);
			return CharSequence.ArrayToStringArray (__result);
		}

		static Delegate cb_getType_I;
#pragma warning disable 0169
		static Delegate GetGetType_IHandler ()
		{
			if (cb_getType_I == null)
				cb_getType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetType_I);
			return cb_getType_I;
		}

		static int n_GetType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getType", "(I)I", "GetGetType_IHandler")]
		public virtual unsafe int GetType (int p0)
		{
			if (id_getType_I == IntPtr.Zero)
				id_getType_I = JNIEnv.GetMethodID (class_ref, "getType", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getType_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getValue_ILandroid_util_TypedValue_;
#pragma warning disable 0169
		static Delegate GetGetValue_ILandroid_util_TypedValue_Handler ()
		{
			if (cb_getValue_ILandroid_util_TypedValue_ == null)
				cb_getValue_ILandroid_util_TypedValue_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_GetValue_ILandroid_util_TypedValue_);
			return cb_getValue_ILandroid_util_TypedValue_;
		}

		static bool n_GetValue_ILandroid_util_TypedValue_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.TypedValue p1 = global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetValue (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getValue_ILandroid_util_TypedValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='getValue' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.util.TypedValue']]"
		[Register ("getValue", "(ILandroid/util/TypedValue;)Z", "GetGetValue_ILandroid_util_TypedValue_Handler")]
		public virtual unsafe bool GetValue (int p0, global::Android.Util.TypedValue p1)
		{
			if (id_getValue_ILandroid_util_TypedValue_ == IntPtr.Zero)
				id_getValue_ILandroid_util_TypedValue_ = JNIEnv.GetMethodID (class_ref, "getValue", "(ILandroid/util/TypedValue;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_getValue_ILandroid_util_TypedValue_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "(ILandroid/util/TypedValue;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_hasValue_I;
#pragma warning disable 0169
		static Delegate GetHasValue_IHandler ()
		{
			if (cb_hasValue_I == null)
				cb_hasValue_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_HasValue_I);
			return cb_hasValue_I;
		}

		static bool n_HasValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_hasValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='hasValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasValue", "(I)Z", "GetHasValue_IHandler")]
		public virtual unsafe bool HasValue (int p0)
		{
			if (id_hasValue_I == IntPtr.Zero)
				id_hasValue_I = JNIEnv.GetMethodID (class_ref, "hasValue", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasValue_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasValue", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Length);
			return cb_length;
		}

		static int n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		public virtual unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_length);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()I"));
			} finally {
			}
		}

		static IntPtr id_obtainStyledAttributes_Landroid_content_Context_Landroid_util_AttributeSet_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='obtainStyledAttributes' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int[]']]"
		[Register ("obtainStyledAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;[I)Landroid/support/v7/internal/widget/TintTypedArray;", "")]
		public static unsafe global::Android.Support.V7.Internal.Widget.TintTypedArray ObtainStyledAttributes (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int[] p2)
		{
			if (id_obtainStyledAttributes_Landroid_content_Context_Landroid_util_AttributeSet_arrayI == IntPtr.Zero)
				id_obtainStyledAttributes_Landroid_content_Context_Landroid_util_AttributeSet_arrayI = JNIEnv.GetStaticMethodID (class_ref, "obtainStyledAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;[I)Landroid/support/v7/internal/widget/TintTypedArray;");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Android.Support.V7.Internal.Widget.TintTypedArray __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (JNIEnv.CallStaticObjectMethod  (class_ref, id_obtainStyledAttributes_Landroid_content_Context_Landroid_util_AttributeSet_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_obtainStyledAttributes_Landroid_content_Context_Landroid_util_AttributeSet_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='obtainStyledAttributes' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int[]'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("obtainStyledAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;[III)Landroid/support/v7/internal/widget/TintTypedArray;", "")]
		public static unsafe global::Android.Support.V7.Internal.Widget.TintTypedArray ObtainStyledAttributes (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int[] p2, int p3, int p4)
		{
			if (id_obtainStyledAttributes_Landroid_content_Context_Landroid_util_AttributeSet_arrayIII == IntPtr.Zero)
				id_obtainStyledAttributes_Landroid_content_Context_Landroid_util_AttributeSet_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "obtainStyledAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;[III)Landroid/support/v7/internal/widget/TintTypedArray;");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Android.Support.V7.Internal.Widget.TintTypedArray __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (JNIEnv.CallStaticObjectMethod  (class_ref, id_obtainStyledAttributes_Landroid_content_Context_Landroid_util_AttributeSet_arrayIII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_peekValue_I;
#pragma warning disable 0169
		static Delegate GetPeekValue_IHandler ()
		{
			if (cb_peekValue_I == null)
				cb_peekValue_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PeekValue_I);
			return cb_peekValue_I;
		}

		static IntPtr n_PeekValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekValue (p0));
		}
#pragma warning restore 0169

		static IntPtr id_peekValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='peekValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("peekValue", "(I)Landroid/util/TypedValue;", "GetPeekValue_IHandler")]
		public virtual unsafe global::Android.Util.TypedValue PeekValue (int p0)
		{
			if (id_peekValue_I == IntPtr.Zero)
				id_peekValue_I = JNIEnv.GetMethodID (class_ref, "peekValue", "(I)Landroid/util/TypedValue;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallObjectMethod  (Handle, id_peekValue_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Util.TypedValue> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekValue", "(I)Landroid/util/TypedValue;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_recycle;
#pragma warning disable 0169
		static Delegate GetRecycleHandler ()
		{
			if (cb_recycle == null)
				cb_recycle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recycle);
			return cb_recycle;
		}

		static void n_Recycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.TintTypedArray __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.TintTypedArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='TintTypedArray']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public virtual unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_recycle);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycle", "()V"));
			} finally {
			}
		}

	}
}
