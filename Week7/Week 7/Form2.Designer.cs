namespace Week_6
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.getInfo_Button = new System.Windows.Forms.Button();
            this.close_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Quequan = new System.Windows.Forms.ComboBox();
            this.Hoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Doc = new System.Windows.Forms.CheckedListBox();
            this.NgheNhac = new System.Windows.Forms.CheckBox();
            this.Choi = new System.Windows.Forms.CheckBox();
            this.Xemphim = new System.Windows.Forms.CheckBox();
            this.Thethao = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(405, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // getInfo_Button
            // 
            this.getInfo_Button.Location = new System.Drawing.Point(290, 395);
            this.getInfo_Button.Name = "getInfo_Button";
            this.getInfo_Button.Size = new System.Drawing.Size(147, 42);
            this.getInfo_Button.TabIndex = 6;
            this.getInfo_Button.Text = "Lấy thông tin";
            this.getInfo_Button.UseVisualStyleBackColor = true;
            this.getInfo_Button.Click += new System.EventHandler(this.ShowInfo);
            // 
            // close_Button
            // 
            this.close_Button.Location = new System.Drawing.Point(607, 395);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(147, 42);
            this.close_Button.TabIndex = 7;
            this.close_Button.Text = "Đóng Form";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ngaysinh);
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Controls.Add(this.Quequan);
            this.groupBox1.Controls.Add(this.Hoten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(200, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 157);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.CalendarForeColor = System.Drawing.SystemColors.HotTrack;
            this.Ngaysinh.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.Ngaysinh.CustomFormat = "dd/mm/yyyy";
            this.Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Ngaysinh.Location = new System.Drawing.Point(100, 108);
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.Size = new System.Drawing.Size(137, 26);
            this.Ngaysinh.TabIndex = 9;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Female.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Female.Location = new System.Drawing.Point(494, 104);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(47, 24);
            this.Female.TabIndex = 8;
            this.Female.TabStop = true;
            this.Female.Text = "Nữ";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Male.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Male.Location = new System.Drawing.Point(407, 105);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(60, 24);
            this.Male.TabIndex = 7;
            this.Male.TabStop = true;
            this.Male.Text = "Nam";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Quequan
            // 
            this.Quequan.FormattingEnabled = true;
            this.Quequan.Items.AddRange(new object[] {
            "Hà Nội",
            "Hòa Bình",
            "TP HCM"});
            this.Quequan.Location = new System.Drawing.Point(420, 35);
            this.Quequan.Name = "Quequan";
            this.Quequan.Size = new System.Drawing.Size(121, 28);
            this.Quequan.TabIndex = 6;
            // 
            // Hoten
            // 
            this.Hoten.Location = new System.Drawing.Point(100, 35);
            this.Hoten.Name = "Hoten";
            this.Hoten.Size = new System.Drawing.Size(186, 26);
            this.Hoten.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(315, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(9, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(322, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quê quán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Doc);
            this.groupBox2.Controls.Add(this.NgheNhac);
            this.groupBox2.Controls.Add(this.Choi);
            this.groupBox2.Controls.Add(this.Xemphim);
            this.groupBox2.Controls.Add(this.Thethao);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(200, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 141);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sở thích";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(344, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Đọc";
            // 
            // Doc
            // 
            this.Doc.FormattingEnabled = true;
            this.Doc.Items.AddRange(new object[] {
            " Truyện cười",
            "Tiểu thuyết",
            "Truyện tranh"});
            this.Doc.Location = new System.Drawing.Point(404, 77);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(179, 49);
            this.Doc.Sorted = true;
            this.Doc.TabIndex = 15;
            // 
            // NgheNhac
            // 
            this.NgheNhac.AutoSize = true;
            this.NgheNhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NgheNhac.ForeColor = System.Drawing.Color.Red;
            this.NgheNhac.Location = new System.Drawing.Point(420, 36);
            this.NgheNhac.Name = "NgheNhac";
            this.NgheNhac.Size = new System.Drawing.Size(105, 24);
            this.NgheNhac.TabIndex = 14;
            this.NgheNhac.Text = "Nghe nhạc";
            this.NgheNhac.UseVisualStyleBackColor = true;
            // 
            // Choi
            // 
            this.Choi.AutoSize = true;
            this.Choi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Choi.ForeColor = System.Drawing.Color.Red;
            this.Choi.Location = new System.Drawing.Point(282, 36);
            this.Choi.Name = "Choi";
            this.Choi.Size = new System.Drawing.Size(60, 24);
            this.Choi.TabIndex = 13;
            this.Choi.Text = "Chơi";
            this.Choi.UseVisualStyleBackColor = true;
            // 
            // Xemphim
            // 
            this.Xemphim.AutoSize = true;
            this.Xemphim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Xemphim.ForeColor = System.Drawing.Color.Red;
            this.Xemphim.Location = new System.Drawing.Point(122, 36);
            this.Xemphim.Name = "Xemphim";
            this.Xemphim.Size = new System.Drawing.Size(99, 24);
            this.Xemphim.TabIndex = 12;
            this.Xemphim.Text = "Xem phim";
            this.Xemphim.UseVisualStyleBackColor = true;
            // 
            // Thethao
            // 
            this.Thethao.FormattingEnabled = true;
            this.Thethao.Items.AddRange(new object[] {
            "Bóng đá",
            "Bơi lội",
            "Cờ vua"});
            this.Thethao.Location = new System.Drawing.Point(91, 79);
            this.Thethao.Name = "Thethao";
            this.Thethao.Size = new System.Drawing.Size(146, 43);
            this.Thethao.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Thể thao";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Free time";
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(200, 443);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(699, 200);
            this.Info.TabIndex = 12;
            this.Info.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 671);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.getInfo_Button);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getInfo_Button;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.ComboBox Quequan;
        private System.Windows.Forms.TextBox Hoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox Doc;
        private System.Windows.Forms.CheckBox NgheNhac;
        private System.Windows.Forms.CheckBox Choi;
        private System.Windows.Forms.CheckBox Xemphim;
        private System.Windows.Forms.ListBox Thethao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Ngaysinh;
        private System.Windows.Forms.RichTextBox Info;
    }
}