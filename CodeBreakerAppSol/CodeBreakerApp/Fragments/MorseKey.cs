using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace CodeBreakerApp.Fragments
{
    public class MorseKey : Fragment
    {
        ImageView morseKeyFrame;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            FindViews();
            HandleEvents();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return base.OnCreateView(inflater, container, savedInstanceState);
            //return inflater.Inflate(Resource.Layout.MorseKey);
        }

        protected void FindViews()
        {
            //morseKeyFrame = FindViewById(Resource.Id.morseKeyFrame);
        }

        protected void HandleEvents()
        {

        }
    }
}