namespace Baitap
{
    partial class frmBai9
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.lstA = new System.Windows.Forms.ListBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(151, 112);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(276, 27);
            this.txtNhap.TabIndex = 2;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Location = new System.Drawing.Point(547, 111);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(152, 29);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstA);
            this.groupBox1.Location = new System.Drawing.Point(36, 208);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(250, 315);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstB);
            this.groupBox2.Location = new System.Drawing.Point(477, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(250, 311);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(333, 232);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(94, 29);
            this.btn1.TabIndex = 6;
            this.btn1.Text = ">";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(333, 295);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 29);
            this.btn2.TabIndex = 7;
            this.btn2.Text = ">>";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(333, 355);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(94, 29);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "<";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(333, 415);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(94, 29);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "<<";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(51, 546);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(205, 29);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKetThuc.Location = new System.Drawing.Point(504, 546);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(205, 29);
            this.btnKetThuc.TabIndex = 11;
            this.btnKetThuc.Text = "&Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            // 
            // lstA
            // 
            this.lstA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 20;
            this.lstA.Location = new System.Drawing.Point(4, 24);
            this.lstA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstA.Name = "lstA";
            this.lstA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstA.Size = new System.Drawing.Size(242, 287);
            this.lstA.TabIndex = 0;
            // 
            // lstB
            // 
            this.lstB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 20;
            this.lstB.Location = new System.Drawing.Point(4, 24);
            this.lstB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstB.Name = "lstB";
            this.lstB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstB.Size = new System.Drawing.Size(242, 283);
            this.lstB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lớp: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lớp A",
            "Lớp B"});
            this.comboBox1.Location = new System.Drawing.Point(151, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // frmBai9
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(763, 602);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBai9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai9_FormClosing);
            this.Load += new System.EventHandler(this.frmBai9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}