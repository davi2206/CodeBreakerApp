using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"android/support/v7/widget",
					},
					new Converter<string, Type>[]{
						lookup_android_support_v7_widget_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_android_support_v7_widget_mappings;
		static Type lookup_android_support_v7_widget_package (string klass)
		{
			if (package_android_support_v7_widget_mappings == null) {
				package_android_support_v7_widget_mappings = new string[]{
					"android/support/v7/widget/ThemedSpinnerAdapter$Helper:Android.Support.V7.Widget.ThemedSpinnerAdapterHelper",
				};
			}

			return Lookup (package_android_support_v7_widget_mappings, klass);
		}
	}
}
