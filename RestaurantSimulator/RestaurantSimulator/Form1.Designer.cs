namespace RestaurantSimulator
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("STT");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Món ăn");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Số lượng");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Thành tiền");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Ghi chú");
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Menu_Fish = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listview = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu_Quantity = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Menu_Cafe = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Menu_Noodle = new System.Windows.Forms.CheckedListBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.richTextBox2);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox3.Location = new System.Drawing.Point(51, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(1167, 281);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serve Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(26, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bill";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(93, 164);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(797, 100);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(93, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(797, 79);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.Menu_Fish);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listview);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Menu_Quantity);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Menu_Cafe);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.richTextBox3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.Menu_Noodle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(51, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(1167, 445);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // Menu_Fish
            // 
            this.Menu_Fish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Menu_Fish.FormattingEnabled = true;
            this.Menu_Fish.Items.AddRange(new object[] {
            "Nướng mật ong",
            "Xào bò",
            "Xào gà",
            "Sốt bò hầm"});
            this.Menu_Fish.Location = new System.Drawing.Point(415, 37);
            this.Menu_Fish.Name = "Menu_Fish";
            this.Menu_Fish.Size = new System.Drawing.Size(165, 114);
            this.Menu_Fish.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(368, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cá";
            // 
            // listview
            // 
            this.listview.FullRowSelect = true;
            this.listview.GridLines = true;
            this.listview.HideSelection = false;
            this.listview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listview.Location = new System.Drawing.Point(600, 37);
            this.listview.Margin = new System.Windows.Forms.Padding(2);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(552, 318);
            this.listview.TabIndex = 17;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.SmallIcon;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(154, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Order);
            // 
            // Menu_Quantity
            // 
            this.Menu_Quantity.Location = new System.Drawing.Point(80, 223);
            this.Menu_Quantity.Name = "Menu_Quantity";
            this.Menu_Quantity.Size = new System.Drawing.Size(260, 21);
            this.Menu_Quantity.TabIndex = 15;
            this.Menu_Quantity.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số lượng";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Menu_Cafe
            // 
            this.Menu_Cafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Menu_Cafe.FormattingEnabled = true;
            this.Menu_Cafe.Items.AddRange(new object[] {
            "Bạc sỉu",
            "Đen đá",
            "Đen nâu",
            "Đen",
            "Cốt dừa"});
            this.Menu_Cafe.Location = new System.Drawing.Point(242, 37);
            this.Menu_Cafe.Name = "Menu_Cafe";
            this.Menu_Cafe.Size = new System.Drawing.Size(98, 114);
            this.Menu_Cafe.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(195, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cafe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(14, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mì";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Other";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(80, 177);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(260, 21);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "Modify";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Menu_Noodle
            // 
            this.Menu_Noodle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Menu_Noodle.FormattingEnabled = true;
            this.Menu_Noodle.Items.AddRange(new object[] {
            "Ý",
            "Xào bò",
            "Xào gà",
            "Sốt bò hầm"});
            this.Menu_Noodle.Location = new System.Drawing.Point(45, 37);
            this.Menu_Noodle.Name = "Menu_Noodle";
            this.Menu_Noodle.Size = new System.Drawing.Size(131, 114);
            this.Menu_Noodle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1407, 793);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Restaurant Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Menu_Quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox Menu_Cafe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckedListBox Menu_Noodle;
        private System.Windows.Forms.CheckedListBox Menu_Fish;
        private System.Windows.Forms.Label label6;
    }
}

