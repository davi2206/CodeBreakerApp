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
    [Activity(Label = "MorseTableActivity")]
    public class MorseTableActivity : Activity
    {
        ImageView morseKeyView;

        string morseKeyTitl;
        string morseTableTitl;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MorseTable);

            morseKeyTitl = GetString(Resource.String.morseKeyTitl);
            morseTableTitl = GetString(Resource.String.morseTableTitl);

            FindViews();
        }

        private void FindViews()
        {
            SetTitle(Resource.String.morseTableTitl);

            morseKeyView = FindViewById<ImageView>(Resource.Id.morseKeyFrame);
            morseKeyView.SetImageResource(Resource.Drawable.MorseKey);
        }
    }
}