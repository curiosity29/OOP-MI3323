namespace Calculator
{
    partial class Paint
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ssssssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.button_hhbh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(98, 26);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(98, 26);
            // 
            // filesToolStripMenuItem1
            // 
            this.filesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paintToolStripMenuItem});
            this.filesToolStripMenuItem1.Name = "filesToolStripMenuItem1";
            this.filesToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.filesToolStripMenuItem1.Text = "Files";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssssssToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(105, 26);
            // 
            // ssssssToolStripMenuItem
            // 
            this.ssssssToolStripMenuItem.Name = "ssssssToolStripMenuItem";
            this.ssssssToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.ssssssToolStripMenuItem.Text = "ssssss";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(122, 72);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(934, 623);
            this.panel.TabIndex = 4;
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // button_hhbh
            // 
            this.button_hhbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_hhbh.Location = new System.Drawing.Point(122, 13);
            this.button_hhbh.Name = "button_hhbh";
            this.button_hhbh.Size = new System.Drawing.Size(204, 53);
            this.button_hhbh.TabIndex = 5;
            this.button_hhbh.Text = "hình bình hành";
            this.button_hhbh.UseVisualStyleBackColor = true;
            this.button_hhbh.Click += new System.EventHandler(this.Draw_hbh);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(350, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "hình hộp bình hành";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Draw_hhbh);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_hhbh);
            this.Controls.Add(this.panel);
            this.Name = "Paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paint";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem ssssssToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_hhbh;
        private System.Windows.Forms.Button button1;
    }
}