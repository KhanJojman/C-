namespace приложа
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Stalin = new System.Windows.Forms.Button();
            this.TBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stuckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Stalin
            // 
            this.Stalin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Stalin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Stalin.Location = new System.Drawing.Point(293, 132);
            this.Stalin.Name = "Stalin";
            this.Stalin.Size = new System.Drawing.Size(75, 23);
            this.Stalin.TabIndex = 0;
            this.Stalin.Text = "Nekit";
            this.Stalin.UseVisualStyleBackColor = false;
            this.Stalin.Click += new System.EventHandler(this.Stalin_Click);
            // 
            // TBox
            // 
            this.TBox.Location = new System.Drawing.Point(149, 83);
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(386, 23);
            this.TBox.TabIndex = 1;
            this.TBox.TextChanged += new System.EventHandler(this.TBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEToolStripMenuItem,
            this.iToolStripMenuItem,
            this.stuckToolStripMenuItem,
            this.hereToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // mEToolStripMenuItem
            // 
            this.mEToolStripMenuItem.Name = "mEToolStripMenuItem";
            this.mEToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.mEToolStripMenuItem.Text = "ME";
            this.mEToolStripMenuItem.Click += new System.EventHandler(this.mEToolStripMenuItem_Click);
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.iToolStripMenuItem.Text = "I";
            // 
            // stuckToolStripMenuItem
            // 
            this.stuckToolStripMenuItem.Name = "stuckToolStripMenuItem";
            this.stuckToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.stuckToolStripMenuItem.Text = "STUCK";
            this.stuckToolStripMenuItem.Click += new System.EventHandler(this.stuckToolStripMenuItem_Click);
            // 
            // hereToolStripMenuItem
            // 
            this.hereToolStripMenuItem.Name = "hereToolStripMenuItem";
            this.hereToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.hereToolStripMenuItem.Text = "HERE";
            this.hereToolStripMenuItem.Click += new System.EventHandler(this.hereToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.Stalin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Stalin;
        private TextBox TBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem hELPToolStripMenuItem;
        private ToolStripMenuItem mEToolStripMenuItem;
        private ToolStripMenuItem iToolStripMenuItem;
        private ToolStripMenuItem stuckToolStripMenuItem;
        private ToolStripMenuItem hereToolStripMenuItem;
    }
}