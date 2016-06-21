using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CodeBreakerApp.Activities
{
    [Activity(Label = "AboutActivity")]
    public class AboutActivity : Activity
    {
        TextView aboutTextBox;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.About);

            FindViews();
        }

        private void FindViews()
        {
            SetTitle(Resource.String.AboutTitl);
            aboutTextBox = FindViewById<TextView>(Resource.Id.aboutTextBox);
            aboutTextBox.SetText(Resource.String.aboutText);
        }
    }
}