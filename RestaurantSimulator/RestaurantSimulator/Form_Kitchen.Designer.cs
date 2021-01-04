
namespace RestaurantSimulator
{
    partial class Form_Kitchen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_holding = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.text_holding);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox1.Location = new System.Drawing.Point(71, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 432);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitchen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Holding:";
            // 
            // text_holding
            // 
            this.text_holding.Location = new System.Drawing.Point(185, 40);
            this.text_holding.Name = "text_holding";
            this.text_holding.Size = new System.Drawing.Size(334, 38);
            this.text_holding.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(94, 242);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 100);
            this.button8.TabIndex = 5;
            this.button8.Text = "Take Available";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(344, 242);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 100);
            this.button6.TabIndex = 4;
            this.button6.Text = "Serve";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Serve);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "Make Dish";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MakeDish);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit Recipes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 473);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Kitchen";
            this.Text = "Kitchen_Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_holding;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}