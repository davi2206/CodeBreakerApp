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
using CodeBreakerApp.Fragments;

namespace CodeBreakerApp.Activities
{
    [Activity(Label = "AtoKTableActivity")]
    public class AtoKTableActivity : Activity
    {
        TableRow table_Alfabet;
        TableRow table_PushedAlfabet;

        string atokKeyTitl;
        string atokTableTitl;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MorseTable);

            atokKeyTitl = GetString(Resource.String.atokKeyTitl);
            atokTableTitl = GetString(Resource.String.atokTableTitl);

            FindViews();
        }

        private void FindViews()
        {
            table_Alfabet = FindViewById<TableRow>(Resource.Id.tr_alfabet);
            table_PushedAlfabet = FindViewById<TableRow>(Resource.Id.tr_pushedAlfabet);

            for(int i = 0; i< 5; i++)
            {
                TextView tv = new TextView(this);
                tv.Text = i.ToString();
            }
        }
    }
}