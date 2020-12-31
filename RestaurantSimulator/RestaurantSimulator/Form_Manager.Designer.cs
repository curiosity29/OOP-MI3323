
namespace RestaurantSimulator
{
    partial class Form_Manager
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox4.Location = new System.Drawing.Point(30, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(502, 341);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manager";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(179, 227);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(173, 85);
            this.button7.TabIndex = 5;
            this.button7.Text = "Adapt";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Refrigerator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(279, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 85);
            this.button5.TabIndex = 3;
            this.button5.Text = "Add Supply";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form_Manager";
            this.Text = "Form_Manager";
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}