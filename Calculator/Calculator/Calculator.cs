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
            { "x", 0 }
        };




        /// <summary>
        /// Open Paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPaint(object sender, EventArgs e)
        {
            (new Paint()).Show();
            //this.Hide();
        }



        /// <summary>
        /// Print the name of pushed button to Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonToScreen(object sender, EventArgs e)
        {
            Screen.Text += ((Button)sender).Text;
        }


        // Modification


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



        //Operator





        //Other

        private void OpenOption(object sender, EventArgs e)
        {
            (new OptionForm()).Show();
        }


        #region Special Mode
        private void ShiftOn(object sender, EventArgs e)
        {
            label_ctrl.Visible = !label_ctrl.Visible;
        }
        #endregion

        #region Navigate
        private void Navigate_CursorToLeft(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void PrintResult(object sender, EventArgs e)
        {
            try
            {
                ResultScreen.Text = StringEvaluater.Eval(Screen.Text, variables).ToString();
            }
            catch(Exception)
            {
                ResultScreen.Text = "MATH ERROR";
            }
        }

        private void AlphaOn(object sender, EventArgs e)
        {
            label_alpha.Visible = !label_alpha.Visible;
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
    }
}
