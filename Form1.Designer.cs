namespace Lab4BForms
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
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(71, 36);
            toolStripMenuItem1.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(339, 44);
            this.loadFileToolStripMenuItem.Text = "Load File...";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(339, 44);
            this.exitToolStripMenuItem.Text = "Exit          ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem1,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkTagsToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // checkTagsToolStripMenuItem
            // 
            this.checkTagsToolStripMenuItem.Enabled = false;
            this.checkTagsToolStripMenuItem.Name = "checkTagsToolStripMenuItem";
            this.checkTagsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.checkTagsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.checkTagsToolStripMenuItem.Text = "Check Tags";
            this.checkTagsToolStripMenuItem.Click += new System.EventHandler(this.checkTagsToolStripMenuItem_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.CausesValidation = false;
            this.listBox1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(25, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(652, 593);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "No file Loaded";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 748);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Priyank\'s Simple HTML File Checker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkTagsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

