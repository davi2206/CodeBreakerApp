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
    public class SpejdTableActivity : Activity
    {
        TextView top;
        TextView bottom;

        string spejdKeyTitl;
        string spejdTableTitl;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SpejdTable);

            spejdKeyTitl = GetString(Resource.String.SpejdKeyTitl);
            spejdTableTitl = GetString(Resource.String.SpejdTableTitl);

            FindViews();

            string password = "";
            bool danish = false;

            try
            {
                password = savedInstanceState.GetString("password");
                danish = savedInstanceState.GetBoolean("danish");
            }
            catch (Exception)
            {
                password = "SPEJD";
                danish = false;
            }

            FillTextVievs(password, danish);
        }

        private void FindViews()
        {
            top = FindViewById<TextView>(Resource.Id.topHalf);
            bottom = FindViewById<TextView>(Resource.Id.bottomHalf);
        }

        private void FillTextVievs(string pass, bool danish)
        {
            CodeCtrl cCtrl = new CodeCtrl();
            string topSt = "";
            string bottomSt = "";
            Dictionary<char, char> alfabet = cCtrl.GetSpejdAlfabet(pass, danish);

            int length = (alfabet.Count / 2);
            int count = 0;

            foreach (KeyValuePair<char, char> kv in alfabet)
            {
                if(count < length)
                {
                    topSt += kv.Key;
                    bottomSt += kv.Value;
                    count++;
                }
            }

            top.Text = topSt;
            bottom.Text = bottomSt;
        }
    }
}