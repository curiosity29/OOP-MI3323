namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Board = new System.Windows.Forms.GroupBox();
            this.button_store = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.label_alpha = new System.Windows.Forms.Label();
            this.label_ctrl = new System.Windows.Forms.Label();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.ResultScreen = new System.Windows.Forms.RichTextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.buttonX10x = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.RichTextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Board.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Board.BackgroundImage")));
            this.Board.Controls.Add(this.button_store);
            this.Board.Controls.Add(this.button34);
            this.Board.Controls.Add(this.button33);
            this.Board.Controls.Add(this.button32);
            this.Board.Controls.Add(this.button28);
            this.Board.Controls.Add(this.label_alpha);
            this.Board.Controls.Add(this.label_ctrl);
            this.Board.Controls.Add(this.button31);
            this.Board.Controls.Add(this.button30);
            this.Board.Controls.Add(this.button29);
            this.Board.Controls.Add(this.ResultScreen);
            this.Board.Controls.Add(this.button23);
            this.Board.Controls.Add(this.button22);
            this.Board.Controls.Add(this.button21);
            this.Board.Controls.Add(this.button20);
            this.Board.Controls.Add(this.button19);
            this.Board.Controls.Add(this.button18);
            this.Board.Controls.Add(this.label2);
            this.Board.Controls.Add(this.label1);
            this.Board.Controls.Add(this.button11);
            this.Board.Controls.Add(this.button10);
            this.Board.Controls.Add(this.button12);
            this.Board.Controls.Add(this.button13);
            this.Board.Controls.Add(this.button14);
            this.Board.Controls.Add(this.button15);
            this.Board.Controls.Add(this.button16);
            this.Board.Controls.Add(this.button17);
            this.Board.Controls.Add(this.buttonX10x);
            this.Board.Controls.Add(this.buttonDot);
            this.Board.Controls.Add(this.Screen);
            this.Board.Controls.Add(this.button0);
            this.Board.Controls.Add(this.button7);
            this.Board.Controls.Add(this.button8);
            this.Board.Controls.Add(this.button9);
            this.Board.Controls.Add(this.button4);
            this.Board.Controls.Add(this.button5);
            this.Board.Controls.Add(this.button6);
            this.Board.Controls.Add(this.button3);
            this.Board.Controls.Add(this.button2);
            this.Board.Controls.Add(this.button1);
            this.Board.Location = new System.Drawing.Point(249, 12);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(444, 677);
            this.Board.TabIndex = 6;
            this.Board.TabStop = false;
            // 
            // button_store
            // 
            this.button_store.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_store.Location = new System.Drawing.Point(337, 363);
            this.button_store.Name = "button_store";
            this.button_store.Size = new System.Drawing.Size(53, 54);
            this.button_store.TabIndex = 48;
            this.button_store.Text = "store to x";
            this.button_store.UseVisualStyleBackColor = true;
            this.button_store.Click += new System.EventHandler(this.StoreValue);
            // 
            // button34
            // 
            this.button34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button34.Location = new System.Drawing.Point(54, 363);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(53, 54);
            this.button34.TabIndex = 47;
            this.button34.Text = "x";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button33
            // 
            this.button33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button33.Location = new System.Drawing.Point(3, 79);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(42, 38);
            this.button33.TabIndex = 46;
            this.button33.Text = "AC";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.Clear);
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button32.Location = new System.Drawing.Point(6, 157);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(39, 37);
            this.button32.TabIndex = 45;
            this.button32.Text = "=";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.PrintResult);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button28.Location = new System.Drawing.Point(194, 303);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(53, 54);
            this.button28.TabIndex = 44;
            this.button28.Text = "^";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // label_alpha
            // 
            this.label_alpha.AutoSize = true;
            this.label_alpha.Location = new System.Drawing.Point(153, 34);
            this.label_alpha.Name = "label_alpha";
            this.label_alpha.Size = new System.Drawing.Size(61, 13);
            this.label_alpha.TabIndex = 43;
            this.label_alpha.Text = "ALPHA ON";
            this.label_alpha.Visible = false;
            this.label_alpha.Click += new System.EventHandler(this.ToggleAlpha);
            // 
            // label_ctrl
            // 
            this.label_ctrl.AutoSize = true;
            this.label_ctrl.Location = new System.Drawing.Point(153, 16);
            this.label_ctrl.Name = "label_ctrl";
            this.label_ctrl.Size = new System.Drawing.Size(54, 13);
            this.label_ctrl.TabIndex = 42;
            this.label_ctrl.Text = "CTRL ON";
            this.label_ctrl.Visible = false;
            // 
            // button31
            // 
            this.button31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button31.Location = new System.Drawing.Point(266, 363);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(53, 54);
            this.button31.TabIndex = 39;
            this.button31.Text = ")";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button30.Location = new System.Drawing.Point(194, 363);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(53, 54);
            this.button30.TabIndex = 38;
            this.button30.Text = ",";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button29
            // 
            this.button29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button29.Location = new System.Drawing.Point(123, 363);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(53, 54);
            this.button29.TabIndex = 37;
            this.button29.Text = "(";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // ResultScreen
            // 
            this.ResultScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ResultScreen.Location = new System.Drawing.Point(54, 157);
            this.ResultScreen.Name = "ResultScreen";
            this.ResultScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultScreen.Size = new System.Drawing.Size(336, 61);
            this.ResultScreen.TabIndex = 30;
            this.ResultScreen.Text = "";
            // 
            // button23
            // 
            this.button23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button23.Location = new System.Drawing.Point(123, 243);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(53, 54);
            this.button23.TabIndex = 29;
            this.button23.Text = "Alpha";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.ToggleAlpha);
            // 
            // button22
            // 
            this.button22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button22.Location = new System.Drawing.Point(54, 240);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(53, 54);
            this.button22.TabIndex = 28;
            this.button22.Text = "Ctrl";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.ToggleCtrl);
            // 
            // button21
            // 
            this.button21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button21.Location = new System.Drawing.Point(337, 243);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(53, 54);
            this.button21.TabIndex = 27;
            this.button21.Text = "On";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button20.Location = new System.Drawing.Point(266, 240);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(53, 54);
            this.button20.TabIndex = 26;
            this.button20.Text = "Option";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.OpenOption);
            // 
            // button19
            // 
            this.button19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button19.Location = new System.Drawing.Point(266, 300);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(53, 54);
            this.button19.TabIndex = 25;
            this.button19.Text = "Nroot(";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button18
            // 
            this.button18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button18.Location = new System.Drawing.Point(123, 303);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(53, 54);
            this.button18.TabIndex = 24;
            this.button18.Text = "Sqrt(";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(260, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "fx - 580VN X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "CASIO";
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.Location = new System.Drawing.Point(266, 603);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(53, 54);
            this.button11.TabIndex = 21;
            this.button11.Text = "Ans";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(337, 603);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(53, 54);
            this.button10.TabIndex = 20;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.PrintResult);
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button12.Location = new System.Drawing.Point(266, 423);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(53, 54);
            this.button12.TabIndex = 18;
            this.button12.Text = "DEL";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Backspace);
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button13.Location = new System.Drawing.Point(337, 423);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(53, 54);
            this.button13.TabIndex = 17;
            this.button13.Text = "AC";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Clear);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button14.Location = new System.Drawing.Point(266, 483);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(53, 54);
            this.button14.TabIndex = 16;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button15.Location = new System.Drawing.Point(337, 483);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(53, 54);
            this.button15.TabIndex = 15;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button16.Location = new System.Drawing.Point(337, 543);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(53, 54);
            this.button16.TabIndex = 14;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button17.Location = new System.Drawing.Point(266, 543);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(53, 54);
            this.button17.TabIndex = 13;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // buttonX10x
            // 
            this.buttonX10x.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonX10x.Location = new System.Drawing.Point(194, 603);
            this.buttonX10x.Name = "buttonX10x";
            this.buttonX10x.Size = new System.Drawing.Size(53, 54);
            this.buttonX10x.TabIndex = 12;
            this.buttonX10x.Text = "*10^";
            this.buttonX10x.UseVisualStyleBackColor = true;
            this.buttonX10x.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDot.Location = new System.Drawing.Point(123, 603);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(53, 54);
            this.buttonDot.TabIndex = 11;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // Screen
            // 
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Screen.Location = new System.Drawing.Point(54, 77);
            this.Screen.Name = "Screen";
            this.Screen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Screen.Size = new System.Drawing.Size(336, 74);
            this.Screen.TabIndex = 10;
            this.Screen.Text = "";
            this.Screen.TextChanged += new System.EventHandler(this.Screen_Refocus);
            this.Screen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintResult);
            // 
            // button0
            // 
            this.button0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button0.Location = new System.Drawing.Point(54, 603);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(53, 54);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(54, 423);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 54);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(123, 423);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 54);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(194, 423);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 54);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(54, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 54);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(123, 483);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 54);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(194, 483);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 54);
            this.button6.TabIndex = 3;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(194, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(123, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(54, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonToScreen);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(71, 34);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.OpenPaint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paintToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 38);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 715);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Board.ResumeLayout(false);
            this.Board.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Board;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Screen;
        private System.Windows.Forms.Button buttonX10x;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.RichTextBox ResultScreen;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Label label_ctrl;
        private System.Windows.Forms.Label label_alpha;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button_store;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Label label2;
    }
}

