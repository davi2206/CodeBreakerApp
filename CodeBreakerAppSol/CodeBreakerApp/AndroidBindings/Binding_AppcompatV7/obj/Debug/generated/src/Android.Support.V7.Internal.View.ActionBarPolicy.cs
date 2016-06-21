using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ActionBarPolicy']"
	[global::Android.Runtime.Register ("android/support/v7/internal/view/ActionBarPolicy", DoNotGenerateAcw=true)]
	public partial class ActionBarPolicy : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/view/ActionBarPolicy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBarPolicy); }
		}

		protected ActionBarPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getEmbeddedMenuWidthLimit;
#pragma warning disable 0169
		static Delegate GetGetEmbeddedMenuWidthLimitHandler ()
		{
			if (cb_getEmbeddedMenuWidthLimit == null)
				cb_getEmbeddedMenuWidthLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEmbeddedMenuWidthLimit);
			return cb_getEmbeddedMenuWidthLimit;
		}

		static int n_GetEmbeddedMenuWidthLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.ActionBarPolicy __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.ActionBarPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EmbeddedMenuWidthLimit;
		}
#pragma warning restore 0169

		static IntPtr id_getEmbeddedMenuWidthLimit;
		public virtual unsafe int EmbeddedMenuWidthLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ActionBarPolicy']/method[@name='getEmbeddedMenuWidthLimit' and count(parameter)=0]"
			[Register ("getEmbeddedMenuWidthLimit", "()I", "GetGetEmbeddedMenuWidthLimitHandler")]
			get {
				if (id_getEmbeddedMenuWidthLimit == IntPtr.Zero)
					id_getEmbeddedMenuWidthLimit = JNIEnv.GetMethodID (class_ref, "getEmbeddedMenuWidthLimit", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getEmbeddedMenuWidthLimit);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmbeddedMenuWidthLimit", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_hasEmbeddedTabs;
#pragma warning disable 0169
		static Delegate GetHasEmbeddedTabsHandler ()
		{
			if (cb_hasEmbeddedTabs == null)
				cb_hasEmbeddedTabs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasEmbeddedTabs);
			return cb_hasEmbeddedTabs;
		}

		static bool n_HasEmbeddedTabs (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.ActionBarPolicy __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.ActionBarPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasEmbeddedTabs;
		}
#pragma warning restore 0169

		static IntPtr id_hasEmbeddedTabs;
		public virtual unsafe bool HasEmbeddedTabs {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ActionBarPolicy']/method[@name='hasEmbeddedTabs' and count(parameter)=0]"
			[Register ("hasEmbeddedTabs", "()Z", "GetHasEmbeddedTabsHandler")]
			get {
				if (id_hasEmbeddedTabs == IntPtr.Zero)
					id_hasEmbeddedTabs = JNIEnv.GetMethodID (class_ref, "hasEmbeddedTabs", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasEmbeddedTabs);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasEmbeddedTabs", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxActionButtons;
#pragma warning disable 0169
		static Delegate GetGetMaxActionButtonsHandler ()
		{
			if (cb_getMaxActionButtons == null)
				cb_getMaxActionButtons = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxActionButtons);
			return cb_getMaxActionButtons;
		}

		static int n_GetMaxActionButtons (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.ActionBarPolicy __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.ActionBarPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxActionButtons;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxActionButtons;
		public virtual unsafe int MaxActionButtons {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ActionBarPolicy']/method[@name='getMaxActionButtons' and count(parameter)=0]"
			[Register ("getMaxActionButtons", "()I", "GetGetMaxActionButtonsHandler")]
			get {
				if (id_getMaxActionButtons == IntPtr.Zero)
					id_getMaxActionButtons = JNIEnv.GetMethodID (class_ref, "getMaxActionButtons", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMaxActionButtons);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxActionButtons", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStackedTabMaxWidth;
#pragma warning disable 0169
		static Delegate GetGetStackedTabMaxWidthHandler ()
		{
			if (cb_getStackedTabMaxWidth == null)
				cb_getStackedTabMaxWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStackedTabMaxWidth);
			return cb_getStackedTabMaxWidth;
		}

		static int n_GetStackedTabMaxWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.ActionBarPolicy __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.ActionBarPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StackedTabMaxWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getStackedTabMaxWidth;
		public virtual unsafe int StackedTabMaxWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ActionBarPolicy']/method[@name='getStackedTabMaxWidth' and count(parameter)=0]"
			[Register ("getStackedTabMaxWidth", "()I", "GetGetStackedTabMaxWidthHandler")]
			get {
				if (id_getStackedTabMaxWidth == IntPtr.Zero)
					id_getStackedTabMaxWidth = JNIEnv.GetMethodID (class_ref, "getStackedTabMaxWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getStackedTabMaxWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStackedTabMaxWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTabContainerHeight;
#pragma warning disable 0169
		static Delegate GetGetTabContainerHeightHandler ()
		{
			if (cb_getTabContainerHeight == null)
				cb_getTabContainerHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTabContainerHeight);
			return cb_getTabContainerHeight;
		}

		static int n_GetTabContainerHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.ActionBarPolicy __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.ActionBarPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabContainerHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getTabContainerHeight;
		public virtual unsafe int TabContainerHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ActionBarPolicy']/method[@name='getTabContainerHeight' and count(parameter)=0]"
			[Register ("getTabContainerHeight", "()I", "GetGetTabContainerHeightHandler")]
			get {
				if (id_getTabContainerHeight == IntPtr.Zero)
					id_getTabContainerHeight = JNIEnv.GetMethodID (class_ref, "getTabContainerHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTabContainerHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTabContainerHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_enableHomeButtonByDefault;
#pragma warning disable 0169
		static Delegate GetEnableHomeButtonByDefaultHandler ()
		{
			if (cb_enableHomeButtonByDefault == null)
				cb_enableHomeButtonByDefault = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_EnableHomeButtonByDefault);
			return cb_enableHomeButtonByDefault;
		}

		static bool n_EnableHomeButtonByDefault (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.ActionBarPolicy __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.ActionBarPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableHomeButtonByDefault ();
		}
#pragma warning restore 0169

		static IntPtr id_enableHomeButtonByDefault;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ActionBarPolicy']/method[@name='enableHomeButtonByDefault' and count(parameter)=0]"
		[Register ("enableHomeButtonByDefault", "()Z", "GetEnableHomeButtonByDefaultHandler")]
		public virtual unsafe bool EnableHomeButtonByDefault ()
		{
			if (id_enableHomeButtonByDefault == IntPtr.Zero)
				id_enableHomeButtonByDefault = JNIEnv.GetMethodID (class_ref, "enableHomeButtonByDefault", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_enableHomeButtonByDefault);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableHomeButtonByDefault", "()Z"));
			} finally {
			}
		}

		static IntPtr id_get_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ActionBarPolicy']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("get", "(Landroid/content/Context;)Landroid/support/v7/internal/view/ActionBarPolicy;", "")]
		public static unsafe global::Android.Support.V7.Internal.View.ActionBarPolicy Get (global::Android.Content.Context p0)
		{
			if (id_get_Landroid_content_Context_ == IntPtr.Zero)
				id_get_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Landroid/content/Context;)Landroid/support/v7/internal/view/ActionBarPolicy;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Support.V7.Internal.View.ActionBarPolicy __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.ActionBarPolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_showsOverflowMenuButton;
#pragma warning disable 0169
		static Delegate GetShowsOverflowMenuButtonHandler ()
		{
			if (cb_showsOverflowMenuButton == null)
				cb_showsOverflowMenuButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShowsOverflowMenuButton);
			return cb_showsOverflowMenuButton;
		}

		static bool n_ShowsOverflowMenuButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.View.ActionBarPolicy __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.View.ActionBarPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowsOverflowMenuButton ();
		}
#pragma warning restore 0169

		static IntPtr id_showsOverflowMenuButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.view']/class[@name='ActionBarPolicy']/method[@name='showsOverflowMenuButton' and count(parameter)=0]"
		[Register ("showsOverflowMenuButton", "()Z", "GetShowsOverflowMenuButtonHandler")]
		public virtual unsafe bool ShowsOverflowMenuButton ()
		{
			if (id_showsOverflowMenuButton == IntPtr.Zero)
				id_showsOverflowMenuButton = JNIEnv.GetMethodID (class_ref, "showsOverflowMenuButton", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_showsOverflowMenuButton);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showsOverflowMenuButton", "()Z"));
			} finally {
			}
		}

	}
}
