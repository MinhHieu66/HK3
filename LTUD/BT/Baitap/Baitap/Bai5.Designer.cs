namespace Baitap
{
    partial class frmBai5
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
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập văn bản:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKQ.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtKQ.Location = new System.Drawing.Point(43, 70);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(295, 194);
            this.txtKQ.TabIndex = 1;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(421, 71);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(172, 24);
            this.rad1.TabIndex = 2;
            this.rad1.TabStop = true;
            this.rad1.Text = "Times New Roman";
            this.rad1.UseVisualStyleBackColor = true;
            this.rad1.CheckedChanged += new System.EventHandler(this.rad1_CheckedChanged);
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(421, 119);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(64, 24);
            this.rad2.TabIndex = 3;
            this.rad2.TabStop = true;
            this.rad2.Text = "Arial";
            this.rad2.UseVisualStyleBackColor = true;
            this.rad2.CheckedChanged += new System.EventHandler(this.rad2_CheckedChanged);
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(421, 174);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(90, 24);
            this.rad3.TabIndex = 4;
            this.rad3.TabStop = true;
            this.rad3.Text = "Tahoma";
            this.rad3.UseVisualStyleBackColor = true;
            this.rad3.CheckedChanged += new System.EventHandler(this.rad3_CheckedChanged);
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Location = new System.Drawing.Point(421, 227);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(123, 24);
            this.rad4.TabIndex = 5;
            this.rad4.TabStop = true;
            this.rad4.Text = "Courier New";
            this.rad4.UseVisualStyleBackColor = true;
            this.rad4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(263, 299);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 38);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Th&oat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(614, 365);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rad4);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBai5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai5_FormClosing);
            this.Load += new System.EventHandler(this.frmBai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.Button btnThoat;
    }
}