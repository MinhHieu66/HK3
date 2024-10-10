namespace Notepad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFormatColor = new System.Windows.Forms.ToolStripMenuItem();
            this.rtFile = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.menuStripEdit,
            this.menuStripFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripFile
            // 
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFileNew,
            this.menuStripFileOpen,
            this.menuStripFileSave,
            this.menuStripFileExit});
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(46, 24);
            this.menuStripFile.Text = "File";
            // 
            // menuStripFileNew
            // 
            this.menuStripFileNew.Name = "menuStripFileNew";
            this.menuStripFileNew.Size = new System.Drawing.Size(224, 26);
            this.menuStripFileNew.Text = "New";
            this.menuStripFileNew.Click += new System.EventHandler(this.menuStripFileNew_Click);
            // 
            // menuStripFileOpen
            // 
            this.menuStripFileOpen.Name = "menuStripFileOpen";
            this.menuStripFileOpen.Size = new System.Drawing.Size(224, 26);
            this.menuStripFileOpen.Text = "Open";
            this.menuStripFileOpen.Click += new System.EventHandler(this.menuStripFileOpen_Click);
            // 
            // menuStripFileSave
            // 
            this.menuStripFileSave.Name = "menuStripFileSave";
            this.menuStripFileSave.Size = new System.Drawing.Size(224, 26);
            this.menuStripFileSave.Text = "Save";
            this.menuStripFileSave.Click += new System.EventHandler(this.menuStripFileSave_Click);
            // 
            // menuStripFileExit
            // 
            this.menuStripFileExit.Name = "menuStripFileExit";
            this.menuStripFileExit.Size = new System.Drawing.Size(224, 26);
            this.menuStripFileExit.Text = "Exit";
            this.menuStripFileExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStripEdit
            // 
            this.menuStripEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripEditCopy,
            this.menuStripEditCut,
            this.menuStripEditPaste});
            this.menuStripEdit.Name = "menuStripEdit";
            this.menuStripEdit.Size = new System.Drawing.Size(49, 24);
            this.menuStripEdit.Text = "Edit";
            // 
            // menuStripEditCopy
            // 
            this.menuStripEditCopy.Name = "menuStripEditCopy";
            this.menuStripEditCopy.Size = new System.Drawing.Size(224, 26);
            this.menuStripEditCopy.Text = "Copy";
            this.menuStripEditCopy.Click += new System.EventHandler(this.menuStripEditCopy_Click);
            // 
            // menuStripEditCut
            // 
            this.menuStripEditCut.Name = "menuStripEditCut";
            this.menuStripEditCut.Size = new System.Drawing.Size(224, 26);
            this.menuStripEditCut.Text = "Cut";
            this.menuStripEditCut.Click += new System.EventHandler(this.menuStripEditCut_Click);
            // 
            // menuStripEditPaste
            // 
            this.menuStripEditPaste.Name = "menuStripEditPaste";
            this.menuStripEditPaste.Size = new System.Drawing.Size(224, 26);
            this.menuStripEditPaste.Text = "Paste";
            this.menuStripEditPaste.Click += new System.EventHandler(this.menuStripEditPast_Click);
            // 
            // menuStripFormat
            // 
            this.menuStripFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFormatFont,
            this.menuStripFormatColor});
            this.menuStripFormat.Name = "menuStripFormat";
            this.menuStripFormat.Size = new System.Drawing.Size(70, 24);
            this.menuStripFormat.Text = "Format";
            // 
            // menuStripFormatFont
            // 
            this.menuStripFormatFont.Name = "menuStripFormatFont";
            this.menuStripFormatFont.Size = new System.Drawing.Size(224, 26);
            this.menuStripFormatFont.Text = "Font";
            this.menuStripFormatFont.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // menuStripFormatColor
            // 
            this.menuStripFormatColor.Name = "menuStripFormatColor";
            this.menuStripFormatColor.Size = new System.Drawing.Size(224, 26);
            this.menuStripFormatColor.Text = "Clor";
            this.menuStripFormatColor.Click += new System.EventHandler(this.menuStripFormatColor_Click);
            // 
            // rtFile
            // 
            this.rtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtFile.Location = new System.Drawing.Point(0, 28);
            this.rtFile.Name = "rtFile";
            this.rtFile.Size = new System.Drawing.Size(800, 422);
            this.rtFile.TabIndex = 1;
            this.rtFile.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem menuStripFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuStripFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuStripFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuStripFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuStripEdit;
        private System.Windows.Forms.ToolStripMenuItem menuStripEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuStripEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuStripEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuStripFormat;
        private System.Windows.Forms.ToolStripMenuItem menuStripFormatFont;
        private System.Windows.Forms.ToolStripMenuItem menuStripFormatColor;
        private System.Windows.Forms.RichTextBox rtFile;
    }
}

