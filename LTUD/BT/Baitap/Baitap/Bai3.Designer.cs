namespace Baitap
{
    partial class frmBai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCong = new System.Windows.Forms.RadioButton();
            this.radTru = new System.Windows.Forms.RadioButton();
            this.radNhan = new System.Windows.Forms.RadioButton();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(157, 34);
            this.txtSo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(283, 28);
            this.txtSo1.TabIndex = 1;
            this.txtSo1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSo1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(157, 118);
            this.txtSo2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(283, 28);
            this.txtSo2.TabIndex = 2;
            this.txtSo2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(157, 329);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(283, 28);
            this.txtKQ.TabIndex = 3;
            this.txtKQ.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radChia);
            this.groupBox1.Controls.Add(this.radNhan);
            this.groupBox1.Controls.Add(this.radTru);
            this.groupBox1.Controls.Add(this.radCong);
            this.groupBox1.Location = new System.Drawing.Point(35, 184);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(405, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radCong
            // 
            this.radCong.AutoSize = true;
            this.radCong.Enabled = false;
            this.radCong.ForeColor = System.Drawing.Color.Red;
            this.radCong.Location = new System.Drawing.Point(17, 46);
            this.radCong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radCong.Name = "radCong";
            this.radCong.Size = new System.Drawing.Size(72, 24);
            this.radCong.TabIndex = 0;
            this.radCong.TabStop = true;
            this.radCong.Text = "Cộng";
            this.radCong.UseVisualStyleBackColor = true;
            this.radCong.CheckedChanged += new System.EventHandler(this.radCong_CheckedChanged);
            // 
            // radTru
            // 
            this.radTru.AutoSize = true;
            this.radTru.Enabled = false;
            this.radTru.ForeColor = System.Drawing.Color.Yellow;
            this.radTru.Location = new System.Drawing.Point(122, 46);
            this.radTru.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radTru.Name = "radTru";
            this.radTru.Size = new System.Drawing.Size(58, 24);
            this.radTru.TabIndex = 1;
            this.radTru.TabStop = true;
            this.radTru.Text = "Trừ";
            this.radTru.UseVisualStyleBackColor = true;
            this.radTru.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radNhan
            // 
            this.radNhan.AutoSize = true;
            this.radNhan.Enabled = false;
            this.radNhan.ForeColor = System.Drawing.Color.Blue;
            this.radNhan.Location = new System.Drawing.Point(218, 46);
            this.radNhan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radNhan.Name = "radNhan";
            this.radNhan.Size = new System.Drawing.Size(72, 24);
            this.radNhan.TabIndex = 2;
            this.radNhan.TabStop = true;
            this.radNhan.Text = "Nhân";
            this.radNhan.UseVisualStyleBackColor = true;
            this.radNhan.CheckedChanged += new System.EventHandler(this.radNhan_CheckedChanged);
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Enabled = false;
            this.radChia.ForeColor = System.Drawing.Color.White;
            this.radChia.Location = new System.Drawing.Point(323, 46);
            this.radChia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(67, 24);
            this.radChia.TabIndex = 3;
            this.radChia.TabStop = true;
            this.radChia.Text = "Chia";
            this.radChia.UseVisualStyleBackColor = true;
            this.radChia.CheckedChanged += new System.EventHandler(this.radChia_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số 2: ";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(497, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBai3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả:";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radChia;
        private System.Windows.Forms.RadioButton radNhan;
        private System.Windows.Forms.RadioButton radTru;
        private System.Windows.Forms.RadioButton radCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}