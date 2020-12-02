using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            Screen.Focus();
        }

        Dictionary<string, double> variables = new Dictionary<string, double>()
        {
            { "x", 0 } , {"Ans", 0}
        };

        /// <summary>
        /// Open Paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPaint(object sender, EventArgs e)
        {
            (new Paint()).Show();
        }



        /// <summary>
        /// Print the name of pushed button to Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonToScreen(object sender, EventArgs e)
        {
            Screen.Text += ((Button)sender).Text;
            Screen.Text.Insert(Screen.SelectionStart, ((Button)sender).Text);
        }


        // Edit

        /// <summary>
        /// remove the last component
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Backspace(object sender, EventArgs e)
        {
            var s = Screen.Text;
            if (s != "") Screen.Text = s.Remove(s.Length-1);
        }

        // this should reset state, now with just screen, used for AC
        private void Clear(object sender, EventArgs e)
        {
            Screen.Clear();
            ResultScreen.Clear();
        }

        private void OpenOption(object sender, EventArgs e)
        {
            (new OptionForm()).Show();
        }


        #region Special Mode
        private void ToggleCtrl(object sender, EventArgs e)
        {
            label_ctrl.Visible = !label_ctrl.Visible;
        }
        private void ToggleAlpha(object sender, EventArgs e)
        {
            label_alpha.Visible = !label_alpha.Visible;
        }
        #endregion

        #region Navigate



        #endregion

        private void PrintResult(object sender, EventArgs e)
        {
            try
            {
                variables["Ans"] = StringEvaluater.Eval(Screen.Text, variables);
                ResultScreen.Text = variables["Ans"].ToString();
            }
            catch(Exception)
            {
                ResultScreen.Text = "MATH ERROR";
                //MessageBox.Show(exception.Message);
            }
        }


        private void PrintResult(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                label_ctrl.Visible = !label_ctrl.Visible;
            if(e.KeyCode == Keys.Enter)
            {
                PrintResult(sender, (EventArgs)e);
            }
        }

        private void StoreValue(object sender, EventArgs e)
        {
                if (ResultScreen.Text != "")
                    variables["x"] = double.Parse(ResultScreen.Text);
        }

        private void Screen_Refocus(object sender, EventArgs e)
        {
            Screen.Focus();
            Screen.SelectionStart = Screen.Text.Length;
        }
 
    }
}
