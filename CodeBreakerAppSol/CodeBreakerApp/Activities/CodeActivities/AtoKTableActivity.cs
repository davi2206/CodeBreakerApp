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
using Translator.core;
using CodeBreakerApp.Fragments;

namespace CodeBreakerApp.Activities
{
    [Activity(Label = "AtoKTableActivity")]
    public class AtoKTableActivity : Activity
    {
        ImageView iv;

        string atokKeyTitl;
        string atokTableTitl;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AtoKTable);

            atokKeyTitl = GetString(Resource.String.atokKeyTitl);
            atokTableTitl = GetString(Resource.String.atokTableTitl);
            
            FindViews();
        }

        private void FindViews()
        {
            iv = FindViewById<ImageView>(Resource.Id.AtoKImg);
            iv.SetImageResource(Resource.Drawable.AtoK);
        }
    }
}