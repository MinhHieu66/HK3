namespace QLSV_MoHinh3Lop
{
    partial class frmTimKiem
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMa = new System.Windows.Forms.RadioButton();
            this.radTen = new System.Windows.Forms.RadioButton();
            this.dgvKQ = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập: ";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(133, 38);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(184, 22);
            this.txtNhap.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.radTen);
            this.groupBox1.Controls.Add(this.radMa);
            this.groupBox1.Location = new System.Drawing.Point(401, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // radMa
            // 
            this.radMa.AutoSize = true;
            this.radMa.Location = new System.Drawing.Point(6, 33);
            this.radMa.Name = "radMa";
            this.radMa.Size = new System.Drawing.Size(47, 20);
            this.radMa.TabIndex = 0;
            this.radMa.TabStop = true;
            this.radMa.Text = "Ma";
            this.radMa.UseVisualStyleBackColor = true;
            // 
            // radTen
            // 
            this.radTen.AutoSize = true;
            this.radTen.Location = new System.Drawing.Point(113, 33);
            this.radTen.Name = "radTen";
            this.radTen.Size = new System.Drawing.Size(52, 20);
            this.radTen.TabIndex = 1;
            this.radTen.TabStop = true;
            this.radTen.Text = "Ten";
            this.radTen.UseVisualStyleBackColor = true;
            // 
            // dgvKQ
            // 
            this.dgvKQ.AllowUserToAddRows = false;
            this.dgvKQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKQ.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKQ.Location = new System.Drawing.Point(0, 148);
            this.dgvKQ.Name = "dgvKQ";
            this.dgvKQ.RowHeadersWidth = 51;
            this.dgvKQ.RowTemplate.Height = 24;
            this.dgvKQ.Size = new System.Drawing.Size(700, 216);
            this.dgvKQ.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(183, 55);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 364);
            this.Controls.Add(this.dgvKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTen;
        private System.Windows.Forms.RadioButton radMa;
        private System.Windows.Forms.DataGridView dgvKQ;
        private System.Windows.Forms.Button btnTim;
    }
}