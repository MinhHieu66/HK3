namespace TinhTienDien
{
    partial class FrmTienDien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoCu = new System.Windows.Forms.TextBox();
            this.txtDinhMuc = new System.Windows.Forms.TextBox();
            this.txtSoMoi = new System.Windows.Forms.TextBox();
            this.txtTieuThu = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.combKhuVuc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstLists = new System.Windows.Forms.ListView();
            this.colFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNorms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colConsume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.btnMo = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstLists);
            this.panel1.Location = new System.Drawing.Point(429, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 430);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnMo);
            this.panel2.Controls.Add(this.combKhuVuc);
            this.panel2.Controls.Add(this.txtDinhMuc);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.txtTieuThu);
            this.panel2.Controls.Add(this.txtSoMoi);
            this.panel2.Controls.Add(this.txtSoCu);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnNhapMoi);
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(30, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 498);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỌ TÊN KH: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "KHU VỰC: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ĐỊNH MỨC: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "SỐ CŨ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "SỐ MỚI: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "TIÊU THỤ: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "THÀNH TIỀN: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTinhTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTinhTien.Location = new System.Drawing.Point(13, 385);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 55);
            this.btnTinhTien.TabIndex = 1;
            this.btnTinhTien.Text = "TÍNH TIỀN";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNhapMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhapMoi.Location = new System.Drawing.Point(152, 385);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(75, 55);
            this.btnNhapMoi.TabIndex = 1;
            this.btnNhapMoi.Text = "NHẬP MỚI";
            this.btnNhapMoi.UseVisualStyleBackColor = false;
            this.btnNhapMoi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(296, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 55);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(152, 29);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(219, 27);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSoCu
            // 
            this.txtSoCu.Location = new System.Drawing.Point(152, 171);
            this.txtSoCu.Name = "txtSoCu";
            this.txtSoCu.Size = new System.Drawing.Size(219, 27);
            this.txtSoCu.TabIndex = 2;
            this.txtSoCu.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDinhMuc
            // 
            this.txtDinhMuc.BackColor = System.Drawing.Color.Silver;
            this.txtDinhMuc.Location = new System.Drawing.Point(152, 124);
            this.txtDinhMuc.Name = "txtDinhMuc";
            this.txtDinhMuc.ReadOnly = true;
            this.txtDinhMuc.Size = new System.Drawing.Size(219, 27);
            this.txtDinhMuc.TabIndex = 2;
            this.txtDinhMuc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSoMoi
            // 
            this.txtSoMoi.Location = new System.Drawing.Point(152, 219);
            this.txtSoMoi.Name = "txtSoMoi";
            this.txtSoMoi.Size = new System.Drawing.Size(219, 27);
            this.txtSoMoi.TabIndex = 2;
            this.txtSoMoi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTieuThu
            // 
            this.txtTieuThu.BackColor = System.Drawing.Color.Silver;
            this.txtTieuThu.Location = new System.Drawing.Point(152, 268);
            this.txtTieuThu.Name = "txtTieuThu";
            this.txtTieuThu.ReadOnly = true;
            this.txtTieuThu.Size = new System.Drawing.Size(219, 27);
            this.txtTieuThu.TabIndex = 2;
            this.txtTieuThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTieuThu.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.Silver;
            this.txtThanhTien.Location = new System.Drawing.Point(152, 323);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(219, 27);
            this.txtThanhTien.TabIndex = 2;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // combKhuVuc
            // 
            this.combKhuVuc.FormattingEnabled = true;
            this.combKhuVuc.Items.AddRange(new object[] {
            "Khu vuc 1",
            "Khu vuc 2",
            "Khu vuc 3"});
            this.combKhuVuc.Location = new System.Drawing.Point(152, 76);
            this.combKhuVuc.Name = "combKhuVuc";
            this.combKhuVuc.Size = new System.Drawing.Size(219, 27);
            this.combKhuVuc.TabIndex = 3;
            this.combKhuVuc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.combKhuVuc.Click += new System.EventHandler(this.combKhuVuc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "TỔNG  TIỀN: ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.Silver;
            this.txtTongTien.Location = new System.Drawing.Point(542, 487);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(256, 27);
            this.txtTongTien.TabIndex = 3;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTongTien.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(937, 470);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 52);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.button4_Click);
            // 
            // lstLists
            // 
            this.lstLists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFullName,
            this.colArea,
            this.colNorms,
            this.colConsume,
            this.colMoney});
            this.lstLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLists.FullRowSelect = true;
            this.lstLists.GridLines = true;
            this.lstLists.HideSelection = false;
            this.lstLists.Location = new System.Drawing.Point(0, 0);
            this.lstLists.MultiSelect = false;
            this.lstLists.Name = "lstLists";
            this.lstLists.Size = new System.Drawing.Size(584, 430);
            this.lstLists.TabIndex = 0;
            this.lstLists.UseCompatibleStateImageBehavior = false;
            this.lstLists.View = System.Windows.Forms.View.Details;
            this.lstLists.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colFullName
            // 
            this.colFullName.Text = "Họ tên";
            this.colFullName.Width = 125;
            // 
            // colArea
            // 
            this.colArea.Text = "Khu vực";
            this.colArea.Width = 144;
            // 
            // colNorms
            // 
            this.colNorms.Text = "Định mức";
            this.colNorms.Width = 103;
            // 
            // colConsume
            // 
            this.colConsume.Text = "Tiêu thụ";
            this.colConsume.Width = 92;
            // 
            // colMoney
            // 
            this.colMoney.Text = "Thành tiền";
            this.colMoney.Width = 188;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(96, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "BÁO CÁO TIÊU THỤ ĐIỆN";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(10, 457);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(75, 38);
            this.btnMo.TabIndex = 4;
            this.btnMo.Text = "Mở";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(296, 460);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 38);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmTienDien
            // 
            this.AcceptButton = this.btnTinhTien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1025, 570);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTienDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền điện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTienDien_FormClosing);
            this.Load += new System.EventHandler(this.FrmTienDien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combKhuVuc;
        private System.Windows.Forms.TextBox txtDinhMuc;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtTieuThu;
        private System.Windows.Forms.TextBox txtSoMoi;
        private System.Windows.Forms.TextBox txtSoCu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView lstLists;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colArea;
        private System.Windows.Forms.ColumnHeader colNorms;
        private System.Windows.Forms.ColumnHeader colConsume;
        private System.Windows.Forms.ColumnHeader colMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnMo;
    }
}

