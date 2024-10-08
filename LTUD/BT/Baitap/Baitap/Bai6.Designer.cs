namespace Baitap
{
    partial class frmBai6
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radVN = new System.Windows.Forms.RadioButton();
            this.radUSA = new System.Windows.Forms.RadioButton();
            this.radItalia = new System.Windows.Forms.RadioButton();
            this.radPhilippine = new System.Windows.Forms.RadioButton();
            this.picFlag = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY FLAGS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPhilippine);
            this.groupBox1.Controls.Add(this.radItalia);
            this.groupBox1.Controls.Add(this.radUSA);
            this.groupBox1.Controls.Add(this.radVN);
            this.groupBox1.Location = new System.Drawing.Point(50, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picFlag);
            this.panel1.Location = new System.Drawing.Point(347, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 242);
            this.panel1.TabIndex = 2;
            // 
            // radVN
            // 
            this.radVN.AutoSize = true;
            this.radVN.Location = new System.Drawing.Point(23, 43);
            this.radVN.Name = "radVN";
            this.radVN.Size = new System.Drawing.Size(94, 23);
            this.radVN.TabIndex = 3;
            this.radVN.TabStop = true;
            this.radVN.Text = "Việt Nam";
            this.radVN.UseVisualStyleBackColor = true;
            this.radVN.CheckedChanged += new System.EventHandler(this.radVN_CheckedChanged);
            // 
            // radUSA
            // 
            this.radUSA.AutoSize = true;
            this.radUSA.Location = new System.Drawing.Point(25, 95);
            this.radUSA.Name = "radUSA";
            this.radUSA.Size = new System.Drawing.Size(62, 23);
            this.radUSA.TabIndex = 3;
            this.radUSA.TabStop = true;
            this.radUSA.Text = "USA";
            this.radUSA.UseVisualStyleBackColor = true;
            this.radUSA.CheckedChanged += new System.EventHandler(this.radUSA_CheckedChanged);
            // 
            // radItalia
            // 
            this.radItalia.AutoSize = true;
            this.radItalia.Location = new System.Drawing.Point(23, 149);
            this.radItalia.Name = "radItalia";
            this.radItalia.Size = new System.Drawing.Size(64, 23);
            this.radItalia.TabIndex = 4;
            this.radItalia.TabStop = true;
            this.radItalia.Text = "Italia";
            this.radItalia.UseVisualStyleBackColor = true;
            this.radItalia.CheckedChanged += new System.EventHandler(this.radItalia_CheckedChanged);
            // 
            // radPhilippine
            // 
            this.radPhilippine.AutoSize = true;
            this.radPhilippine.Location = new System.Drawing.Point(25, 199);
            this.radPhilippine.Name = "radPhilippine";
            this.radPhilippine.Size = new System.Drawing.Size(100, 23);
            this.radPhilippine.TabIndex = 5;
            this.radPhilippine.TabStop = true;
            this.radPhilippine.Text = "Philippine";
            this.radPhilippine.UseVisualStyleBackColor = true;
            this.radPhilippine.CheckedChanged += new System.EventHandler(this.radPhilippine_CheckedChanged);
            // 
            // picFlag
            // 
            this.picFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFlag.Location = new System.Drawing.Point(0, 0);
            this.picFlag.Name = "picFlag";
            this.picFlag.Size = new System.Drawing.Size(326, 242);
            this.picFlag.TabIndex = 0;
            this.picFlag.TabStop = false;
            // 
            // frmBai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBai6";
            this.Text = "Bai6";
            this.Load += new System.EventHandler(this.frmBai6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPhilippine;
        private System.Windows.Forms.RadioButton radItalia;
        private System.Windows.Forms.RadioButton radUSA;
        private System.Windows.Forms.RadioButton radVN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFlag;
    }
}