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
    public class ChineseActivity : Activity
    {
        Button btn_translate;
        Button btn_copyOutput;
        Button btn_clearOutput;
        TextView input;
        TextView output;
        EditText inputText;
        EditText outputText;
        LinearLayout btn_Container;
        CheckBox chkBx_removeSpaces;
        CheckBox chkBx_addSpaces;

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
            SetContentView(Resource.Layout.Chinese);
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
            SetTitle(Resource.String.ChineseTitl);
            btn_translate = FindViewById<Button>(Resource.Id.TranslateBtn);
            btn_copyOutput = FindViewById<Button>(Resource.Id.copyOutputBtn);
            btn_clearOutput = FindViewById<Button>(Resource.Id.clearOutputBtn);

            chkBx_removeSpaces = FindViewById<CheckBox>(Resource.Id.chkBxRemoveSpaces);
            chkBx_addSpaces = FindViewById<CheckBox>(Resource.Id.chkBxAddSpaces);

            input = FindViewById<TextView>(Resource.Id.input);
            output = FindViewById<TextView>(Resource.Id.output);
            inputText = FindViewById<EditText>(Resource.Id.inputText);
            outputText = FindViewById<EditText>(Resource.Id.outputText);
            btn_Container = FindViewById<LinearLayout>(Resource.Id.TranslateBtnContainer);
            cCtrl = new CodeCtrl();
            userInput = "";
            result = "";

            input.Text = GetString(Resource.String.InputText);
            output.Text = GetString(Resource.String.OutputCode);
        }

        private void HandleEvents()
        {
            btn_translate.Click += Btn_Translate_Click;
            btn_copyOutput.Click += Btn_CopyOutput_Click;
            btn_clearOutput.Click += Btn_ClearOutput_Click;
            inputText.EditorAction += Btn_Translate_Click;
        }

        private void Btn_Translate_Click(object sender, EventArgs e)
        {
            userInput = inputText.Text;

            bool removeSpaces = false;
            bool addSpaces = false;

            removeSpaces = chkBx_removeSpaces.Checked;
            addSpaces = chkBx_addSpaces.Checked;

            result = cCtrl.Chinese(userInput, removeSpaces, addSpaces);
            
            outputText.Text = result;
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