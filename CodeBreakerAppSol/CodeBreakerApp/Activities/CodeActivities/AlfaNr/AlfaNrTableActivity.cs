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
    [Activity(Label = "AlfaNrTableActivity")]
    public class AlfaNrTableActivity : Activity
    {
        ImageView iv;

        string atokKeyTitl;
        string atokTableTitl;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AlfaNrTable);
            
            FindViews();
        }

        private void FindViews()
        {
        }
    }
}