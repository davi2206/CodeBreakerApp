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
    public class MorseActivity : Activity
    {
        Button btn_switch;
        Button btn_translate;
        Button btn_showTable;
        Button btn_dot;
        Button btn_line;
        Button btn_slash;
        Button btn_del;
        Button btn_copyRes;
        Button btn_clearRes;
        TextView input;
        TextView output;
        EditText inputText;
        EditText outputText;
        LinearLayout morseAlfabetBtns;
        LinearLayout btnContainer;

        CodeCtrl cCtrl;

        string userInput;
        string result;

        //For saved state
        bool switched;
        string inputTextLbl = "";
        string outputTextLbl = "";
        bool softInput = true;
        bool morseVisible = false;
        bool btnContainerVert = true;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Morse);
            FindViews();
            HandleEvents();

            if (savedInstanceState != null)
            {
                try
                {
                    switched = savedInstanceState.GetBoolean("switched");
                    inputTextLbl = savedInstanceState.GetString("inputLbl");
                    outputTextLbl = savedInstanceState.GetString("outputLbl");
                    softInput = savedInstanceState.GetBoolean("showKeyboard");
                    morseVisible = savedInstanceState.GetBoolean("morseVisible");

                    if (morseVisible)
                    {
                        morseAlfabetBtns.Visibility = ViewStates.Visible;
                    }
                    else
                    {
                        morseAlfabetBtns.Visibility = ViewStates.Gone;
                    }

                    input.Text = inputTextLbl;
                    output.Text = outputTextLbl;
                    inputText.ShowSoftInputOnFocus = softInput;
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
            bundle.PutBoolean("switched", switched);
            bundle.PutString("inputLbl", input.Text);
            bundle.PutString("outputLbl", output.Text);
            bundle.PutBoolean("showKeyboard", inputText.ShowSoftInputOnFocus);
            bundle.PutBoolean("morseVisible", morseVisible);
            bundle.PutBoolean("container", btnContainerVert);

            base.OnSaveInstanceState(bundle);
        }

        private void FindViews()
        {
            SetTitle(Resource.String.MorseTitl);
            btn_switch = FindViewById<Button>(Resource.Id.SwitchBtn);
            btn_translate = FindViewById<Button>(Resource.Id.TranslateBtn);
            btn_showTable = FindViewById<Button>(Resource.Id.ShowTableBtn);
            btn_dot = FindViewById<Button>(Resource.Id.DotBtn);
            btn_line = FindViewById<Button>(Resource.Id.LineBtn);
            btn_slash = FindViewById<Button>(Resource.Id.SlashBtn);
            btn_del = FindViewById<Button>(Resource.Id.DelBtn);
            btn_copyRes = FindViewById<Button>(Resource.Id.copyOutputBtn);
            btn_clearRes = FindViewById<Button>(Resource.Id.clearOutputBtn);
            input = FindViewById<TextView>(Resource.Id.input);
            output = FindViewById<TextView>(Resource.Id.output);
            inputText = FindViewById<EditText>(Resource.Id.inputText);
            outputText = FindViewById<EditText>(Resource.Id.outputText);
            btnContainer = FindViewById<LinearLayout>(Resource.Id.TranslateBtnContainer);
            cCtrl = new CodeCtrl();
            userInput = "";
            result = "";
            morseAlfabetBtns = FindViewById<LinearLayout>(Resource.Id.MorseAlfabetContainer);
            morseAlfabetBtns.Visibility = ViewStates.Gone;
            input.Text = GetString(Resource.String.InputText);
            output.Text = GetString(Resource.String.OutputCode);
        }

        private void HandleEvents()
        {
            btn_switch.Click += Btn_Switch_Click;
            btn_translate.Click += Btn_Translate_Click;
            btn_showTable.Click += Btn_ShowTable_Click;
            btn_dot.Click += Btn_Dot_Click;
            btn_line.Click += Btn_Line_Click;
            btn_slash.Click += Btn_Slash_Click;
            btn_del.Click += Btn_Del_Click;
            btn_del.LongClick += Btn_Del_Long_Click;
            btn_copyRes.Click += Btn_CopyRes_Click;
            btn_clearRes.Click += Btn_ClearRes_Click;
            inputText.EditorAction += Btn_Translate_Click;
        }

        private void Btn_Switch_Click(object sender, EventArgs e)
        {
            string tempIn = inputText.Text;
            string tempOut = outputText.Text;

            outputText.Text = tempIn;
            inputText.Text = tempOut;

            if (!switched)
            {
                switched = true;
                morseVisible = true;
                input.Text = GetString(Resource.String.InputCode);
                output.Text = GetString(Resource.String.OutputText);
                inputText.ShowSoftInputOnFocus = false;
                morseAlfabetBtns.Visibility = ViewStates.Visible;
            }
            else
            {
                switched = false;
                morseVisible = false;
                input.Text = GetString(Resource.String.InputText);
                output.Text = GetString(Resource.String.OutputCode);
                inputText.ShowSoftInputOnFocus = true;
                morseAlfabetBtns.Visibility = ViewStates.Gone;
            }

            inputTextLbl = input.Text;
            outputTextLbl = output.Text;
            softInput = inputText.ShowSoftInputOnFocus;
        }

        private void Btn_Translate_Click(object sender, EventArgs e)
        {
            userInput = inputText.Text;

            if (!switched)
            {
                result = cCtrl.MorseTtoC(userInput);
            }
            else
            {
                result = cCtrl.MorseCtoT(userInput);
            }
            outputText.Text = result;
        }

        private void Btn_ShowTable_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MorseTableActivity));
            StartActivity(intent);
        }

        private void Btn_Dot_Click(object sender, EventArgs e)
        {
            int pos = (inputText.SelectionStart);

            if (pos > -1)
            {
                inputText.Text = inputText.Text.Insert(pos, "*");
                inputText.SetSelection(pos+1);
            }
            else
            {
                inputText.Text += "*";
            }
        }

        private void Btn_Line_Click(object sender, EventArgs e)
        {
            int pos = (inputText.SelectionStart);

            if (pos > -1)
            {
                inputText.Text = inputText.Text.Insert(pos, "-");
                inputText.SetSelection(pos+1);
            }
            else
            {
                inputText.Text += "-";
            }
        }

        private void Btn_Slash_Click(object sender, EventArgs e)
        {
            int pos = (inputText.SelectionStart);

            if (pos > -1)
            {
                inputText.Text = inputText.Text.Insert(pos, "/");
                inputText.SetSelection(pos+1);
            }
            else
            {
                inputText.Text += "/";
            }
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = (inputText.SelectionStart - 1);
                inputText.Text = inputText.Text.Remove(pos, 1);
                inputText.SetSelection(pos);
            }
            catch { }
        }

        private void Btn_Del_Long_Click(object sender, EventArgs e)
        {
            try
            {
                inputText.Text = "";
            }
            catch { }
        }

        private void Btn_CopyRes_Click(object sender, EventArgs e)
        {
            string output = outputText.Text;

            ClipboardManager cm = (ClipboardManager)GetSystemService(ClipboardService);
            ClipData cd = ClipData.NewPlainText("Code", output);
            cm.PrimaryClip = cd;
        }

        private void Btn_ClearRes_Click(object sender, EventArgs e)
        {
            outputText.Text = "";
        }
    }
}