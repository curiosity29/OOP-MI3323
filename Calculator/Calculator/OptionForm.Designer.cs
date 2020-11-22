namespace Calculator
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_PtBac2 = new System.Windows.Forms.Button();
            this.button_PtBac3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_PtBac2
            // 
            this.button_PtBac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_PtBac2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_PtBac2.Location = new System.Drawing.Point(12, 12);
            this.button_PtBac2.Name = "button_PtBac2";
            this.button_PtBac2.Size = new System.Drawing.Size(291, 54);
            this.button_PtBac2.TabIndex = 28;
            this.button_PtBac2.Text = "Phương trình bậc 2";
            this.button_PtBac2.UseVisualStyleBackColor = true;
            this.button_PtBac2.Click += new System.EventHandler(this.ShowPtBac2Solver);
            // 
            // button_PtBac3
            // 
            this.button_PtBac3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_PtBac3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_PtBac3.Location = new System.Drawing.Point(12, 84);
            this.button_PtBac3.Name = "button_PtBac3";
            this.button_PtBac3.Size = new System.Drawing.Size(291, 54);
            this.button_PtBac3.TabIndex = 29;
            this.button_PtBac3.Text = "Phương trình bậc 3";
            this.button_PtBac3.UseVisualStyleBackColor = true;
            this.button_PtBac3.Click += new System.EventHandler(this.ShowPtBac3Solver);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 54);
            this.button1.TabIndex = 30;
            this.button1.Text = "Hệ phương trình 2 ẩn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowPt2AnSolver);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_PtBac3);
            this.Controls.Add(this.button_PtBac2);
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Option";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_PtBac2;
        private System.Windows.Forms.Button button_PtBac3;
        private System.Windows.Forms.Button button1;
    }
}