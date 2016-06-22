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
using Android.Views.InputMethods;

namespace CodeBreakerApp.Activities
{
    [Activity(Label = "", Icon = "@drawable/icon")]
    public class AtoKActivity : Activity
    {
        Button btn_translate;
        Button btn_showTable;
        Button btn_copyOutput;
        Button btn_clearOutput;
        Spinner chooseSeed_spin;
        CheckBox chkBx_KtoA;
        TextView input;
        TextView output;
        EditText inputText;
        EditText outputText;
        LinearLayout options;
        LinearLayout btnContainer;

        CodeCtrl cCtrl;

        string userInput;
        string result;

        //For saved state
        string inputTextLbl = "";
        string outputTextLbl = "";
        bool btnContainerVert = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AtoK);
            FindViews();
            HandleEvents();

            if (savedInstanceState != null)
            {
                try
                {
                    inputTextLbl = savedInstanceState.GetString("inputLbl");
                    outputTextLbl = savedInstanceState.GetString("outputLbl");

                    input.Text = inputTextLbl;
                    output.Text = outputTextLbl;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        protected override void OnSaveInstanceState(Bundle bundle)
        {
            btnContainerVert = !btnContainerVert;
            bundle.PutString("inputLbl", input.Text);
            bundle.PutString("outputLbl", output.Text);
            bundle.PutBoolean("showKeyboard", inputText.ShowSoftInputOnFocus);
            bundle.PutBoolean("focusable", inputText.Focusable);
            bundle.PutBoolean("container", btnContainerVert);

            base.OnSaveInstanceState(bundle);
        }

        private void FindViews()
        {
            SetTitle(Resource.String.MorseTitl);
            btn_translate = FindViewById<Button>(Resource.Id.TranslateBtn);
            btn_showTable = FindViewById<Button>(Resource.Id.ShowTableBtn);
            btn_copyOutput = FindViewById<Button>(Resource.Id.copyOutputBtn);
            btn_clearOutput = FindViewById<Button>(Resource.Id.clearOutputBtn);

            chooseSeed_spin = FindViewById<Spinner>(Resource.Id.spin_seedChooser);
            ArrayAdapter seed_adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.alfabet, Android.Resource.Layout.SimpleSpinnerItem);
            seed_adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerItem);
            chooseSeed_spin.Adapter = seed_adapter;
            chooseSeed_spin.SetSelection(10);

            chkBx_KtoA = FindViewById<CheckBox>(Resource.Id.ktoaChkBx);
            
            input = FindViewById<TextView>(Resource.Id.input);
            output = FindViewById<TextView>(Resource.Id.output);
            inputText = FindViewById<EditText>(Resource.Id.inputText);
            outputText = FindViewById<EditText>(Resource.Id.outputText);
            btnContainer = FindViewById<LinearLayout>(Resource.Id.TranslateBtnContainer);
            cCtrl = new CodeCtrl();
            userInput = "";
            result = "";
            options = FindViewById<LinearLayout>(Resource.Id.MorseAlfabetContainer);

            input.Text = GetString(Resource.String.InputText);
            output.Text = GetString(Resource.String.OutputCode);
        }

        private void HandleEvents()
        {
            btn_translate.Click += Btn_Translate_Click;
            btn_showTable.Click += Btn_ShowTable_Click;
            btn_copyOutput.Click += Btn_CopyOutput_Click;
            btn_clearOutput.Click += Btn_ClearOutput_Click;
            inputText.EditorAction += Btn_Translate_Click;
        }

        private void Btn_Translate_Click(object sender, EventArgs e)
        {
            userInput = inputText.Text;

            bool danish = false;
            string[] list = Resources.GetStringArray(Resource.Array.alfabet);
            if(list.Contains("ø"))
            {
                danish = true;
            }

            bool fromText = true;

            if (chkBx_KtoA.Checked)
            {
                fromText = false;
            }

            char seed = 'a';

            try
            {
                string c = (string)chooseSeed_spin.SelectedItem;
                seed = c[0];
            }
            catch(Exception ex)
            {
                throw ex;
            }


            result = cCtrl.AtoK(userInput, danish, fromText, seed);
            
            outputText.Text = result;
        }

        private void Btn_ShowTable_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AtoKTableActivity));
            StartActivity(intent);
        }

        private void Btn_CopyOutput_Click(object sender, EventArgs e)
        {
            string output = outputText.Text;

            ClipboardManager cm = (ClipboardManager)GetSystemService(ClipboardService);
            ClipData cd = ClipData.NewPlainText("Code", output);
            cm.PrimaryClip = cd;
        }

        private void Btn_ClearOutput_Click(object sender, EventArgs e)
        {
            outputText.Text = "";
        }
    }
}