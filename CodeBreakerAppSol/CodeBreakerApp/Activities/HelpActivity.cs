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
using Android.Text.Method;

namespace CodeBreakerApp.Activities
{
    [Activity(Label = "HelpActivity")]
    public class HelpActivity : Activity
    {
        TextView helpDesc;
        TextView helpMorse;
        TextView helpAtoK;
        TextView helpPassword;
        TextView helpAlfaNr;
        TextView helpChinese;
        TextView helpButtonsAll;
        TextView helpButtonsSome;
        TextView helpFields;
        TextView helpSupp;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Help);

            FindViews();
        }

        private void FindViews()
        {
            SetTitle(Resource.String.help_title);

            helpDesc = FindViewById<TextView>(Resource.Id.help_desc);
            helpMorse = FindViewById<TextView>(Resource.Id.help_morse);
            helpAtoK = FindViewById<TextView>(Resource.Id.help_AtoK);
            helpPassword = FindViewById<TextView>(Resource.Id.help_password);
            helpAlfaNr = FindViewById<TextView>(Resource.Id.help_alfanr);
            helpChinese = FindViewById<TextView>(Resource.Id.help_chinese);
            helpButtonsAll = FindViewById<TextView>(Resource.Id.help_buttons_all);
            helpButtonsSome = FindViewById<TextView>(Resource.Id.help_buttons_some);
            helpFields = FindViewById<TextView>(Resource.Id.help_fields);
            helpSupp = FindViewById<TextView>(Resource.Id.help_support);
            helpSupp.MovementMethod = LinkMovementMethod.Instance;
        }
    }
}