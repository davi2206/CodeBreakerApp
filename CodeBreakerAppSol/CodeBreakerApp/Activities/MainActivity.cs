using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CodeBreakerApp.Activities;

namespace CodeBreakerApp
{
    [Activity(MainLauncher = true, Icon = "@drawable/Icon")]
    public class MainActivity : Activity
    {
        Button btn_morse;
        Button btn_atoK;
        Button btn_passwordCode;
        Button btn_alfaNr;
        Button btn_chineseText;

        Button btn_about;

        //Add the rest of the buttons here!

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            FindViews();
            HandleEvents();
        }

        //Get all the elements, and instasiate them
        private void FindViews()
        {
            SetTitle(Resource.String.ApplicationName);
            btn_morse = FindViewById<Button>(Resource.Id.MorseBtn);
            btn_atoK = FindViewById<Button>(Resource.Id.AtoKBtn);
            btn_passwordCode = FindViewById<Button>(Resource.Id.SpejdBtn);
            btn_alfaNr = FindViewById<Button>(Resource.Id.NrBtn);
            btn_chineseText = FindViewById<Button>(Resource.Id.ChinaBtn);

            btn_about = FindViewById<Button>(Resource.Id.AboutBtn);
        }

        //Add eventhandlers to buttons
        private void HandleEvents()
        {
            btn_morse.Click += Btn_Morse_Click;
            btn_atoK.Click += Btn_AtoK_Click;
            btn_passwordCode.Click += Btn_Spejd_Click;
            btn_alfaNr.Click += Btn_AlfaNr_Click;

            btn_about.Click += Btn_About_Click;
        }

        private void Btn_Morse_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MorseActivity));
            StartActivity(intent);
        }

        private void Btn_AtoK_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AtoKActivity));
            StartActivity(intent);
        }

        private void Btn_Spejd_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(SpejdActivity));
            StartActivity(intent);
        }
        private void Btn_AlfaNr_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AlfaNrActivity));
            StartActivity(intent);
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AboutActivity));
            StartActivity(intent);
        }
    }
}

