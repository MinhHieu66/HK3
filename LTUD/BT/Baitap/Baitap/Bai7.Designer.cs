namespace Baitap
{
    partial class frmBai7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listDanhSach = new System.Windows.Forms.ListBox();
            this.btnTongUoc = new System.Windows.Forms.Button();
            this.btnSoUocChan = new System.Windows.Forms.Button();
            this.btnSoUocSoNguyenTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(26, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(412, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 107);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(343, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Gray;
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Location = new System.Drawing.Point(267, 43);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 45);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(18, 53);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(227, 27);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            this.txtNhap.Leave += new System.EventHandler(this.txtNhap_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(499, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(329, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // listDanhSach
            // 
            this.listDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDanhSach.FormattingEnabled = true;
            this.listDanhSach.ItemHeight = 19;
            this.listDanhSach.Location = new System.Drawing.Point(4, 24);
            this.listDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.listDanhSach.Name = "listDanhSach";
            this.listDanhSach.Size = new System.Drawing.Size(321, 182);
            this.listDanhSach.TabIndex = 0;
            // 
            // btnTongUoc
            // 
            this.btnTongUoc.BackColor = System.Drawing.Color.Gray;
            this.btnTongUoc.Location = new System.Drawing.Point(503, 276);
            this.btnTongUoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnTongUoc.Name = "btnTongUoc";
            this.btnTongUoc.Size = new System.Drawing.Size(329, 39);
            this.btnTongUoc.TabIndex = 2;
            this.btnTongUoc.Text = "&Tổng các ước số";
            this.btnTongUoc.UseVisualStyleBackColor = false;
            this.btnTongUoc.Click += new System.EventHandler(this.btnTongUoc_Click);
            // 
            // btnSoUocChan
            // 
            this.btnSoUocChan.BackColor = System.Drawing.Color.Gray;
            this.btnSoUocChan.Location = new System.Drawing.Point(503, 341);
            this.btnSoUocChan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoUocChan.Name = "btnSoUocChan";
            this.btnSoUocChan.Size = new System.Drawing.Size(329, 39);
            this.btnSoUocChan.TabIndex = 3;
            this.btnSoUocChan.Text = "&Số lượng các ước số chẵn";
            this.btnSoUocChan.UseVisualStyleBackColor = false;
            this.btnSoUocChan.Click += new System.EventHandler(this.btnSoUocChan_Click);
            // 
            // btnSoUocSoNguyenTo
            // 
            this.btnSoUocSoNguyenTo.BackColor = System.Drawing.Color.Gray;
            this.btnSoUocSoNguyenTo.Location = new System.Drawing.Point(503, 400);
            this.btnSoUocSoNguyenTo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSoUocSoNguyenTo.Name = "btnSoUocSoNguyenTo";
            this.btnSoUocSoNguyenTo.Size = new System.Drawing.Size(329, 39);
            this.btnSoUocSoNguyenTo.TabIndex = 4;
            this.btnSoUocSoNguyenTo.Text = "Số lượng các ước số &nguyên tố";
            this.btnSoUocSoNguyenTo.UseVisualStyleBackColor = false;
            this.btnSoUocSoNguyenTo.Click += new System.EventHandler(this.btnSoUocSoNguyenTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.Location = new System.Drawing.Point(310, 397);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 45);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBai7
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(880, 464);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSoUocSoNguyenTo);
            this.Controls.Add(this.btnSoUocChan);
            this.Controls.Add(this.btnTongUoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBai7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai7_FormClosing);
            this.Load += new System.EventHandler(this.frmBai7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listDanhSach;
        private System.Windows.Forms.Button btnTongUoc;
        private System.Windows.Forms.Button btnSoUocChan;
        private System.Windows.Forms.Button btnSoUocSoNguyenTo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}