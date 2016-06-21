using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Support.V7.Internal.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']"
	[global::Android.Runtime.Register ("android/support/v7/internal/widget/ActivityChooserModel", DoNotGenerateAcw=true)]
	public partial class ActivityChooserModel : global::Android.Database.DataSetObservable {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/field[@name='DEFAULT_HISTORY_FILE_NAME']"
		[Register ("DEFAULT_HISTORY_FILE_NAME")]
		public const string DefaultHistoryFileName = (string) "activity_choser_model_history.xml";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/field[@name='DEFAULT_HISTORY_MAX_LENGTH']"
		[Register ("DEFAULT_HISTORY_MAX_LENGTH")]
		public const int DefaultHistoryMaxLength = (int) 50;
		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ActivityChooserModel.ActivityChooserModelClient']"
		[Register ("android/support/v7/internal/widget/ActivityChooserModel$ActivityChooserModelClient", "", "Android.Support.V7.Internal.Widget.ActivityChooserModel/IActivityChooserModelClientInvoker")]
		public partial interface IActivityChooserModelClient : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ActivityChooserModel.ActivityChooserModelClient']/method[@name='setActivityChooserModel' and count(parameter)=1 and parameter[1][@type='android.support.v7.internal.widget.ActivityChooserModel']]"
			[Register ("setActivityChooserModel", "(Landroid/support/v7/internal/widget/ActivityChooserModel;)V", "GetSetActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_Handler:Android.Support.V7.Internal.Widget.ActivityChooserModel/IActivityChooserModelClientInvoker, Binding_AppcompatV7")]
			void SetActivityChooserModel (global::Android.Support.V7.Internal.Widget.ActivityChooserModel p0);

		}

		[global::Android.Runtime.Register ("android/support/v7/internal/widget/ActivityChooserModel$ActivityChooserModelClient", DoNotGenerateAcw=true)]
		internal class IActivityChooserModelClientInvoker : global::Java.Lang.Object, IActivityChooserModelClient {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/internal/widget/ActivityChooserModel$ActivityChooserModelClient");
			IntPtr class_ref;

			public static IActivityChooserModelClient GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IActivityChooserModelClient> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.internal.widget.ActivityChooserModel.ActivityChooserModelClient"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IActivityChooserModelClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IActivityChooserModelClientInvoker); }
			}

			static Delegate cb_setActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_;
#pragma warning disable 0169
			static Delegate GetSetActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_Handler ()
			{
				if (cb_setActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_ == null)
					cb_setActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_);
				return cb_setActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_;
			}

			static void n_SetActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IActivityChooserModelClient __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IActivityChooserModelClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.Internal.Widget.ActivityChooserModel p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetActivityChooserModel (p0);
			}
#pragma warning restore 0169

			IntPtr id_setActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_;
			public unsafe void SetActivityChooserModel (global::Android.Support.V7.Internal.Widget.ActivityChooserModel p0)
			{
				if (id_setActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_ == IntPtr.Zero)
					id_setActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_ = JNIEnv.GetMethodID (class_ref, "setActivityChooserModel", "(Landroid/support/v7/internal/widget/ActivityChooserModel;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_setActivityChooserModel_Landroid_support_v7_internal_widget_ActivityChooserModel_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.ActivityResolveInfo']"
		[global::Android.Runtime.Register ("android/support/v7/internal/widget/ActivityChooserModel$ActivityResolveInfo", DoNotGenerateAcw=true)]
		public sealed partial class ActivityResolveInfo : global::Java.Lang.Object, global::Java.Lang.IComparable {


			static IntPtr resolveInfo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.ActivityResolveInfo']/field[@name='resolveInfo']"
			[Register ("resolveInfo")]
			public global::Android.Content.PM.ResolveInfo ResolveInfo {
				get {
					if (resolveInfo_jfieldId == IntPtr.Zero)
						resolveInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "resolveInfo", "Landroid/content/pm/ResolveInfo;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, resolveInfo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Content.PM.ResolveInfo> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (resolveInfo_jfieldId == IntPtr.Zero)
						resolveInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "resolveInfo", "Landroid/content/pm/ResolveInfo;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, resolveInfo_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr weight_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.ActivityResolveInfo']/field[@name='weight']"
			[Register ("weight")]
			public float Weight {
				get {
					if (weight_jfieldId == IntPtr.Zero)
						weight_jfieldId = JNIEnv.GetFieldID (class_ref, "weight", "F");
					return JNIEnv.GetFloatField (Handle, weight_jfieldId);
				}
				set {
					if (weight_jfieldId == IntPtr.Zero)
						weight_jfieldId = JNIEnv.GetFieldID (class_ref, "weight", "F");
					try {
						JNIEnv.SetField (Handle, weight_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/internal/widget/ActivityChooserModel$ActivityResolveInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ActivityResolveInfo); }
			}

			internal ActivityResolveInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_pm_ResolveInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.ActivityResolveInfo']/constructor[@name='ActivityChooserModel.ActivityResolveInfo' and count(parameter)=2 and parameter[1][@type='android.support.v7.internal.widget.ActivityChooserModel'] and parameter[2][@type='android.content.pm.ResolveInfo']]"
			[Register (".ctor", "(Landroid/support/v7/internal/widget/ActivityChooserModel;Landroid/content/pm/ResolveInfo;)V", "")]
			public unsafe ActivityResolveInfo (global::Android.Support.V7.Internal.Widget.ActivityChooserModel __self, global::Android.Content.PM.ResolveInfo p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (ActivityResolveInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/pm/ResolveInfo;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/pm/ResolveInfo;)V", __args);
						return;
					}

					if (id_ctor_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_pm_ResolveInfo_ == IntPtr.Zero)
						id_ctor_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_pm_ResolveInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v7/internal/widget/ActivityChooserModel;Landroid/content/pm/ResolveInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_pm_ResolveInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_pm_ResolveInfo_, __args);
				} finally {
				}
			}

			static IntPtr id_compareTo_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivityResolveInfo_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.ActivityResolveInfo']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='android.support.v7.internal.widget.ActivityChooserModel.ActivityResolveInfo']]"
			[Register ("compareTo", "(Landroid/support/v7/internal/widget/ActivityChooserModel$ActivityResolveInfo;)I", "")]
			public unsafe int CompareTo (global::Android.Support.V7.Internal.Widget.ActivityChooserModel.ActivityResolveInfo p0)
			{
				if (id_compareTo_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivityResolveInfo_ == IntPtr.Zero)
					id_compareTo_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivityResolveInfo_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Landroid/support/v7/internal/widget/ActivityChooserModel$ActivityResolveInfo;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					int __ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivityResolveInfo_, __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ActivityChooserModel.ActivitySorter']"
		[Register ("android/support/v7/internal/widget/ActivityChooserModel$ActivitySorter", "", "Android.Support.V7.Internal.Widget.ActivityChooserModel/IActivitySorterInvoker")]
		public partial interface IActivitySorter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ActivityChooserModel.ActivitySorter']/method[@name='sort' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.util.List&lt;android.support.v7.internal.widget.ActivityChooserModel.ActivityResolveInfo&gt;'] and parameter[3][@type='java.util.List&lt;android.support.v7.internal.widget.ActivityChooserModel.HistoricalRecord&gt;']]"
			[Register ("sort", "(Landroid/content/Intent;Ljava/util/List;Ljava/util/List;)V", "GetSort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_Handler:Android.Support.V7.Internal.Widget.ActivityChooserModel/IActivitySorterInvoker, Binding_AppcompatV7")]
			void Sort (global::Android.Content.Intent p0, global::System.Collections.Generic.IList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.ActivityResolveInfo> p1, global::System.Collections.Generic.IList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.HistoricalRecord> p2);

		}

		[global::Android.Runtime.Register ("android/support/v7/internal/widget/ActivityChooserModel$ActivitySorter", DoNotGenerateAcw=true)]
		internal class IActivitySorterInvoker : global::Java.Lang.Object, IActivitySorter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/internal/widget/ActivityChooserModel$ActivitySorter");
			IntPtr class_ref;

			public static IActivitySorter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IActivitySorter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.internal.widget.ActivityChooserModel.ActivitySorter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IActivitySorterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IActivitySorterInvoker); }
			}

			static Delegate cb_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetSort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_Handler ()
			{
				if (cb_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_ == null)
					cb_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_);
				return cb_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_;
			}

			static void n_Sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IActivitySorter __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IActivitySorter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Android.Runtime.JavaList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.ActivityResolveInfo>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.HistoricalRecord>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.Sort (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_;
			public unsafe void Sort (global::Android.Content.Intent p0, global::System.Collections.Generic.IList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.ActivityResolveInfo> p1, global::System.Collections.Generic.IList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.HistoricalRecord> p2)
			{
				if (id_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
					id_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "sort", "(Landroid/content/Intent;Ljava/util/List;Ljava/util/List;)V");
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.ActivityResolveInfo>.ToLocalJniHandle (p1);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.HistoricalRecord>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (Handle, id_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.DefaultSorter']"
		[global::Android.Runtime.Register ("android/support/v7/internal/widget/ActivityChooserModel$DefaultSorter", DoNotGenerateAcw=true)]
		public sealed partial class DefaultSorter : global::Java.Lang.Object, global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IActivitySorter {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/internal/widget/ActivityChooserModel$DefaultSorter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultSorter); }
			}

			internal DefaultSorter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.DefaultSorter']/method[@name='sort' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.util.List&lt;android.support.v7.internal.widget.ActivityChooserModel.ActivityResolveInfo&gt;'] and parameter[3][@type='java.util.List&lt;android.support.v7.internal.widget.ActivityChooserModel.HistoricalRecord&gt;']]"
			[Register ("sort", "(Landroid/content/Intent;Ljava/util/List;Ljava/util/List;)V", "")]
			public unsafe void Sort (global::Android.Content.Intent p0, global::System.Collections.Generic.IList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.ActivityResolveInfo> p1, global::System.Collections.Generic.IList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.HistoricalRecord> p2)
			{
				if (id_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
					id_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "sort", "(Landroid/content/Intent;Ljava/util/List;Ljava/util/List;)V");
				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.ActivityResolveInfo>.ToLocalJniHandle (p1);
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.HistoricalRecord>.ToLocalJniHandle (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					JNIEnv.CallVoidMethod  (Handle, id_sort_Landroid_content_Intent_Ljava_util_List_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.HistoricalRecord']"
		[global::Android.Runtime.Register ("android/support/v7/internal/widget/ActivityChooserModel$HistoricalRecord", DoNotGenerateAcw=true)]
		public sealed partial class HistoricalRecord : global::Java.Lang.Object {


			static IntPtr activity_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.HistoricalRecord']/field[@name='activity']"
			[Register ("activity")]
			public global::Android.Content.ComponentName Activity {
				get {
					if (activity_jfieldId == IntPtr.Zero)
						activity_jfieldId = JNIEnv.GetFieldID (class_ref, "activity", "Landroid/content/ComponentName;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, activity_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (activity_jfieldId == IntPtr.Zero)
						activity_jfieldId = JNIEnv.GetFieldID (class_ref, "activity", "Landroid/content/ComponentName;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, activity_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr time_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.HistoricalRecord']/field[@name='time']"
			[Register ("time")]
			public long Time {
				get {
					if (time_jfieldId == IntPtr.Zero)
						time_jfieldId = JNIEnv.GetFieldID (class_ref, "time", "J");
					return JNIEnv.GetLongField (Handle, time_jfieldId);
				}
				set {
					if (time_jfieldId == IntPtr.Zero)
						time_jfieldId = JNIEnv.GetFieldID (class_ref, "time", "J");
					try {
						JNIEnv.SetField (Handle, time_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr weight_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.HistoricalRecord']/field[@name='weight']"
			[Register ("weight")]
			public float Weight {
				get {
					if (weight_jfieldId == IntPtr.Zero)
						weight_jfieldId = JNIEnv.GetFieldID (class_ref, "weight", "F");
					return JNIEnv.GetFloatField (Handle, weight_jfieldId);
				}
				set {
					if (weight_jfieldId == IntPtr.Zero)
						weight_jfieldId = JNIEnv.GetFieldID (class_ref, "weight", "F");
					try {
						JNIEnv.SetField (Handle, weight_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/internal/widget/ActivityChooserModel$HistoricalRecord", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HistoricalRecord); }
			}

			internal HistoricalRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_JF;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.HistoricalRecord']/constructor[@name='ActivityChooserModel.HistoricalRecord' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='float']]"
			[Register (".ctor", "(Ljava/lang/String;JF)V", "")]
			public unsafe HistoricalRecord (string p0, long p1, float p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (HistoricalRecord)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JF)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;JF)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_JF == IntPtr.Zero)
						id_ctor_Ljava_lang_String_JF = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JF)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JF, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_JF, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_ctor_Landroid_content_ComponentName_JF;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.HistoricalRecord']/constructor[@name='ActivityChooserModel.HistoricalRecord' and count(parameter)=3 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='long'] and parameter[3][@type='float']]"
			[Register (".ctor", "(Landroid/content/ComponentName;JF)V", "")]
			public unsafe HistoricalRecord (global::Android.Content.ComponentName p0, long p1, float p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (HistoricalRecord)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/ComponentName;JF)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/ComponentName;JF)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_ComponentName_JF == IntPtr.Zero)
						id_ctor_Landroid_content_ComponentName_JF = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/ComponentName;JF)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_ComponentName_JF, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_ComponentName_JF, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ActivityChooserModel.OnChooseActivityListener']"
		[Register ("android/support/v7/internal/widget/ActivityChooserModel$OnChooseActivityListener", "", "Android.Support.V7.Internal.Widget.ActivityChooserModel/IOnChooseActivityListenerInvoker")]
		public partial interface IOnChooseActivityListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/interface[@name='ActivityChooserModel.OnChooseActivityListener']/method[@name='onChooseActivity' and count(parameter)=2 and parameter[1][@type='android.support.v7.internal.widget.ActivityChooserModel'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onChooseActivity", "(Landroid/support/v7/internal/widget/ActivityChooserModel;Landroid/content/Intent;)Z", "GetOnChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_Handler:Android.Support.V7.Internal.Widget.ActivityChooserModel/IOnChooseActivityListenerInvoker, Binding_AppcompatV7")]
			bool OnChooseActivity (global::Android.Support.V7.Internal.Widget.ActivityChooserModel p0, global::Android.Content.Intent p1);

		}

		[global::Android.Runtime.Register ("android/support/v7/internal/widget/ActivityChooserModel$OnChooseActivityListener", DoNotGenerateAcw=true)]
		internal class IOnChooseActivityListenerInvoker : global::Java.Lang.Object, IOnChooseActivityListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("android/support/v7/internal/widget/ActivityChooserModel$OnChooseActivityListener");
			IntPtr class_ref;

			public static IOnChooseActivityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnChooseActivityListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "android.support.v7.internal.widget.ActivityChooserModel.OnChooseActivityListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnChooseActivityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnChooseActivityListenerInvoker); }
			}

			static Delegate cb_onChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_Handler ()
			{
				if (cb_onChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_ == null)
					cb_onChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_);
				return cb_onChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_;
			}

			static bool n_OnChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListener __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.Internal.Widget.ActivityChooserModel p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnChooseActivity (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_;
			public unsafe bool OnChooseActivity (global::Android.Support.V7.Internal.Widget.ActivityChooserModel p0, global::Android.Content.Intent p1)
			{
				if (id_onChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_ == IntPtr.Zero)
					id_onChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onChooseActivity", "(Landroid/support/v7/internal/widget/ActivityChooserModel;Landroid/content/Intent;)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onChooseActivity_Landroid_support_v7_internal_widget_ActivityChooserModel_Landroid_content_Intent_, __args);
				return __ret;
			}

		}

		public partial class ChooseActivityEventArgs : global::System.EventArgs {

			public ChooseActivityEventArgs (bool handled, global::Android.Support.V7.Internal.Widget.ActivityChooserModel p0, global::Android.Content.Intent p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Android.Support.V7.Internal.Widget.ActivityChooserModel p0;
			public global::Android.Support.V7.Internal.Widget.ActivityChooserModel P0 {
				get { return p0; }
			}

			global::Android.Content.Intent p1;
			public global::Android.Content.Intent P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/android/support/v7/internal/widget/ActivityChooserModel_OnChooseActivityListenerImplementor")]
		internal sealed partial class IOnChooseActivityListenerImplementor : global::Java.Lang.Object, IOnChooseActivityListener {

			object sender;

			public IOnChooseActivityListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/android/support/v7/internal/widget/ActivityChooserModel_OnChooseActivityListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ChooseActivityEventArgs> Handler;
#pragma warning restore 0649

			public bool OnChooseActivity (global::Android.Support.V7.Internal.Widget.ActivityChooserModel p0, global::Android.Content.Intent p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new ChooseActivityEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnChooseActivityListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.PersistHistoryAsyncTask']"
		[global::Android.Runtime.Register ("android/support/v7/internal/widget/ActivityChooserModel$PersistHistoryAsyncTask", DoNotGenerateAcw=true)]
		public sealed partial class PersistHistoryAsyncTask : global::Android.OS.AsyncTask {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("android/support/v7/internal/widget/ActivityChooserModel$PersistHistoryAsyncTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PersistHistoryAsyncTask); }
			}

			internal PersistHistoryAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel.PersistHistoryAsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
			[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Void;", "")]
			public unsafe global::Java.Lang.Void DoInBackground (params global:: Java.Lang.Object[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Void;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Java.Lang.Void __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("android/support/v7/internal/widget/ActivityChooserModel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActivityChooserModel); }
		}

		protected ActivityChooserModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getActivityCount;
#pragma warning disable 0169
		static Delegate GetGetActivityCountHandler ()
		{
			if (cb_getActivityCount == null)
				cb_getActivityCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetActivityCount);
			return cb_getActivityCount;
		}

		static int n_GetActivityCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActivityCount;
		}
#pragma warning restore 0169

		static IntPtr id_getActivityCount;
		public virtual unsafe int ActivityCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='getActivityCount' and count(parameter)=0]"
			[Register ("getActivityCount", "()I", "GetGetActivityCountHandler")]
			get {
				if (id_getActivityCount == IntPtr.Zero)
					id_getActivityCount = JNIEnv.GetMethodID (class_ref, "getActivityCount", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getActivityCount);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivityCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultActivity;
#pragma warning disable 0169
		static Delegate GetGetDefaultActivityHandler ()
		{
			if (cb_getDefaultActivity == null)
				cb_getDefaultActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultActivity);
			return cb_getDefaultActivity;
		}

		static IntPtr n_GetDefaultActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultActivity);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultActivity;
		public virtual unsafe global::Android.Content.PM.ResolveInfo DefaultActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='getDefaultActivity' and count(parameter)=0]"
			[Register ("getDefaultActivity", "()Landroid/content/pm/ResolveInfo;", "GetGetDefaultActivityHandler")]
			get {
				if (id_getDefaultActivity == IntPtr.Zero)
					id_getDefaultActivity = JNIEnv.GetMethodID (class_ref, "getDefaultActivity", "()Landroid/content/pm/ResolveInfo;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.PM.ResolveInfo> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultActivity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.PM.ResolveInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultActivity", "()Landroid/content/pm/ResolveInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHistoryMaxSize;
#pragma warning disable 0169
		static Delegate GetGetHistoryMaxSizeHandler ()
		{
			if (cb_getHistoryMaxSize == null)
				cb_getHistoryMaxSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHistoryMaxSize);
			return cb_getHistoryMaxSize;
		}

		static int n_GetHistoryMaxSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HistoryMaxSize;
		}
#pragma warning restore 0169

		static Delegate cb_setHistoryMaxSize_I;
#pragma warning disable 0169
		static Delegate GetSetHistoryMaxSize_IHandler ()
		{
			if (cb_setHistoryMaxSize_I == null)
				cb_setHistoryMaxSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHistoryMaxSize_I);
			return cb_setHistoryMaxSize_I;
		}

		static void n_SetHistoryMaxSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HistoryMaxSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHistoryMaxSize;
		static IntPtr id_setHistoryMaxSize_I;
		public virtual unsafe int HistoryMaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='getHistoryMaxSize' and count(parameter)=0]"
			[Register ("getHistoryMaxSize", "()I", "GetGetHistoryMaxSizeHandler")]
			get {
				if (id_getHistoryMaxSize == IntPtr.Zero)
					id_getHistoryMaxSize = JNIEnv.GetMethodID (class_ref, "getHistoryMaxSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHistoryMaxSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHistoryMaxSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='setHistoryMaxSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHistoryMaxSize", "(I)V", "GetSetHistoryMaxSize_IHandler")]
			set {
				if (id_setHistoryMaxSize_I == IntPtr.Zero)
					id_setHistoryMaxSize_I = JNIEnv.GetMethodID (class_ref, "setHistoryMaxSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHistoryMaxSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHistoryMaxSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHistorySize;
#pragma warning disable 0169
		static Delegate GetGetHistorySizeHandler ()
		{
			if (cb_getHistorySize == null)
				cb_getHistorySize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHistorySize);
			return cb_getHistorySize;
		}

		static int n_GetHistorySize (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HistorySize;
		}
#pragma warning restore 0169

		static IntPtr id_getHistorySize;
		public virtual unsafe int HistorySize {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='getHistorySize' and count(parameter)=0]"
			[Register ("getHistorySize", "()I", "GetGetHistorySizeHandler")]
			get {
				if (id_getHistorySize == IntPtr.Zero)
					id_getHistorySize = JNIEnv.GetMethodID (class_ref, "getHistorySize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getHistorySize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHistorySize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getIntent;
#pragma warning disable 0169
		static Delegate GetGetIntentHandler ()
		{
			if (cb_getIntent == null)
				cb_getIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntent);
			return cb_getIntent;
		}

		static IntPtr n_GetIntent (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intent);
		}
#pragma warning restore 0169

		static Delegate cb_setIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSetIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_setIntent_Landroid_content_Intent_ == null)
				cb_setIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntent_Landroid_content_Intent_);
			return cb_setIntent_Landroid_content_Intent_;
		}

		static void n_SetIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Intent = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIntent;
		static IntPtr id_setIntent_Landroid_content_Intent_;
		public virtual unsafe global::Android.Content.Intent Intent {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='getIntent' and count(parameter)=0]"
			[Register ("getIntent", "()Landroid/content/Intent;", "GetGetIntentHandler")]
			get {
				if (id_getIntent == IntPtr.Zero)
					id_getIntent = JNIEnv.GetMethodID (class_ref, "getIntent", "()Landroid/content/Intent;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getIntent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntent", "()Landroid/content/Intent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='setIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
			[Register ("setIntent", "(Landroid/content/Intent;)V", "GetSetIntent_Landroid_content_Intent_Handler")]
			set {
				if (id_setIntent_Landroid_content_Intent_ == IntPtr.Zero)
					id_setIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "setIntent", "(Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setIntent_Landroid_content_Intent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntent", "(Landroid/content/Intent;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_chooseActivity_I;
#pragma warning disable 0169
		static Delegate GetChooseActivity_IHandler ()
		{
			if (cb_chooseActivity_I == null)
				cb_chooseActivity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ChooseActivity_I);
			return cb_chooseActivity_I;
		}

		static IntPtr n_ChooseActivity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChooseActivity (p0));
		}
#pragma warning restore 0169

		static IntPtr id_chooseActivity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='chooseActivity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("chooseActivity", "(I)Landroid/content/Intent;", "GetChooseActivity_IHandler")]
		public virtual unsafe global::Android.Content.Intent ChooseActivity (int p0)
		{
			if (id_chooseActivity_I == IntPtr.Zero)
				id_chooseActivity_I = JNIEnv.GetMethodID (class_ref, "chooseActivity", "(I)Landroid/content/Intent;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_chooseActivity_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "chooseActivity", "(I)Landroid/content/Intent;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_get_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='get' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("get", "(Landroid/content/Context;Ljava/lang/String;)Landroid/support/v7/internal/widget/ActivityChooserModel;", "")]
		public static unsafe global::Android.Support.V7.Internal.Widget.ActivityChooserModel Get (global::Android.Content.Context p0, string p1)
		{
			if (id_get_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Landroid/content/Context;Ljava/lang/String;)Landroid/support/v7/internal/widget/ActivityChooserModel;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Android.Support.V7.Internal.Widget.ActivityChooserModel __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getActivity_I;
#pragma warning disable 0169
		static Delegate GetGetActivity_IHandler ()
		{
			if (cb_getActivity_I == null)
				cb_getActivity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetActivity_I);
			return cb_getActivity_I;
		}

		static IntPtr n_GetActivity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetActivity (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getActivity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='getActivity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getActivity", "(I)Landroid/content/pm/ResolveInfo;", "GetGetActivity_IHandler")]
		public virtual unsafe global::Android.Content.PM.ResolveInfo GetActivity (int p0)
		{
			if (id_getActivity_I == IntPtr.Zero)
				id_getActivity_I = JNIEnv.GetMethodID (class_ref, "getActivity", "(I)Landroid/content/pm/ResolveInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Content.PM.ResolveInfo> (JNIEnv.CallObjectMethod  (Handle, id_getActivity_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Content.PM.ResolveInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivity", "(I)Landroid/content/pm/ResolveInfo;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getActivityIndex_Landroid_content_pm_ResolveInfo_;
#pragma warning disable 0169
		static Delegate GetGetActivityIndex_Landroid_content_pm_ResolveInfo_Handler ()
		{
			if (cb_getActivityIndex_Landroid_content_pm_ResolveInfo_ == null)
				cb_getActivityIndex_Landroid_content_pm_ResolveInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetActivityIndex_Landroid_content_pm_ResolveInfo_);
			return cb_getActivityIndex_Landroid_content_pm_ResolveInfo_;
		}

		static int n_GetActivityIndex_Landroid_content_pm_ResolveInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.PM.ResolveInfo p0 = global::Java.Lang.Object.GetObject<global::Android.Content.PM.ResolveInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetActivityIndex (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getActivityIndex_Landroid_content_pm_ResolveInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='getActivityIndex' and count(parameter)=1 and parameter[1][@type='android.content.pm.ResolveInfo']]"
		[Register ("getActivityIndex", "(Landroid/content/pm/ResolveInfo;)I", "GetGetActivityIndex_Landroid_content_pm_ResolveInfo_Handler")]
		public virtual unsafe int GetActivityIndex (global::Android.Content.PM.ResolveInfo p0)
		{
			if (id_getActivityIndex_Landroid_content_pm_ResolveInfo_ == IntPtr.Zero)
				id_getActivityIndex_Landroid_content_pm_ResolveInfo_ = JNIEnv.GetMethodID (class_ref, "getActivityIndex", "(Landroid/content/pm/ResolveInfo;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getActivityIndex_Landroid_content_pm_ResolveInfo_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivityIndex", "(Landroid/content/pm/ResolveInfo;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_;
#pragma warning disable 0169
		static Delegate GetSetActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_Handler ()
		{
			if (cb_setActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_ == null)
				cb_setActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_);
			return cb_setActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_;
		}

		static void n_SetActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IActivitySorter p0 = (global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IActivitySorter)global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IActivitySorter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActivitySorter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='setActivitySorter' and count(parameter)=1 and parameter[1][@type='android.support.v7.internal.widget.ActivityChooserModel.ActivitySorter']]"
		[Register ("setActivitySorter", "(Landroid/support/v7/internal/widget/ActivityChooserModel$ActivitySorter;)V", "GetSetActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_Handler")]
		public virtual unsafe void SetActivitySorter (global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IActivitySorter p0)
		{
			if (id_setActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_ == IntPtr.Zero)
				id_setActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_ = JNIEnv.GetMethodID (class_ref, "setActivitySorter", "(Landroid/support/v7/internal/widget/ActivityChooserModel$ActivitySorter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setActivitySorter_Landroid_support_v7_internal_widget_ActivityChooserModel_ActivitySorter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivitySorter", "(Landroid/support/v7/internal/widget/ActivityChooserModel$ActivitySorter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDefaultActivity_I;
#pragma warning disable 0169
		static Delegate GetSetDefaultActivity_IHandler ()
		{
			if (cb_setDefaultActivity_I == null)
				cb_setDefaultActivity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDefaultActivity_I);
			return cb_setDefaultActivity_I;
		}

		static void n_SetDefaultActivity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultActivity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultActivity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='setDefaultActivity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDefaultActivity", "(I)V", "GetSetDefaultActivity_IHandler")]
		public virtual unsafe void SetDefaultActivity (int p0)
		{
			if (id_setDefaultActivity_I == IntPtr.Zero)
				id_setDefaultActivity_I = JNIEnv.GetMethodID (class_ref, "setDefaultActivity", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDefaultActivity_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultActivity", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_;
#pragma warning disable 0169
		static Delegate GetSetOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_Handler ()
		{
			if (cb_setOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_ == null)
				cb_setOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_);
			return cb_setOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_;
		}

		static void n_SetOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel __this = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListener p0 = (global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListener)global::Java.Lang.Object.GetObject<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnChooseActivityListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='android.support.v7.internal.widget']/class[@name='ActivityChooserModel']/method[@name='setOnChooseActivityListener' and count(parameter)=1 and parameter[1][@type='android.support.v7.internal.widget.ActivityChooserModel.OnChooseActivityListener']]"
		[Register ("setOnChooseActivityListener", "(Landroid/support/v7/internal/widget/ActivityChooserModel$OnChooseActivityListener;)V", "GetSetOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_Handler")]
		public virtual unsafe void SetOnChooseActivityListener (global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListener p0)
		{
			if (id_setOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_ == IntPtr.Zero)
				id_setOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_ = JNIEnv.GetMethodID (class_ref, "setOnChooseActivityListener", "(Landroid/support/v7/internal/widget/ActivityChooserModel$OnChooseActivityListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnChooseActivityListener_Landroid_support_v7_internal_widget_ActivityChooserModel_OnChooseActivityListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnChooseActivityListener", "(Landroid/support/v7/internal/widget/ActivityChooserModel$OnChooseActivityListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListener"
		public event EventHandler<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.ChooseActivityEventArgs> ChooseActivityEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListener, global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListenerImplementor>(
						ref weak_implementor_SetOnChooseActivityListener,
						__CreateIOnChooseActivityListenerImplementor,
						SetOnChooseActivityListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListener, global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListenerImplementor>(
						ref weak_implementor_SetOnChooseActivityListener,
						global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListenerImplementor.__IsEmpty,
						__v => SetOnChooseActivityListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnChooseActivityListener;

		global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListenerImplementor __CreateIOnChooseActivityListenerImplementor ()
		{
			return new global::Android.Support.V7.Internal.Widget.ActivityChooserModel.IOnChooseActivityListenerImplementor (this);
		}
#endregion
	}
}
