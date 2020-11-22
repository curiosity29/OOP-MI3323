using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void ShowPtBac2Solver(object sender, EventArgs e)
        {
            (new PtBac2()).Show();
            this.Close();
        }

        private void ShowPtBac3Solver(object sender, EventArgs e)
        {
            (new PtBac3()).Show();
            this.Close();
        }

        private void ShowPt2AnSolver(object sender, EventArgs e)
        {
            (new Pt2An()).Show();
            this.Close();
        }
    }
}
