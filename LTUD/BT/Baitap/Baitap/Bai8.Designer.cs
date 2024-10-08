namespace Baitap
{
    partial class frmBai8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(38, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(250, 435);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listbox";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(4, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(242, 304);
            this.listBox1.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.Enabled = false;
            this.btnNhap.Location = new System.Drawing.Point(7, 79);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(235, 42);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "&Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(7, 39);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(236, 27);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn7);
            this.groupBox2.Controls.Add(this.btn6);
            this.groupBox2.Controls.Add(this.btn5);
            this.groupBox2.Controls.Add(this.btn4);
            this.groupBox2.Controls.Add(this.btn3);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.Location = new System.Drawing.Point(357, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(413, 435);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử lý Listbox";
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(29, 388);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(364, 40);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "Chọn số lẻ";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(29, 331);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(364, 40);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "Chọn số chẵn";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(29, 273);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(364, 40);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "Thay bằng bình phương";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(29, 214);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(364, 40);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Tăng mỗi phần tử lên 2";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(29, 157);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(364, 40);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Xóa phần tử đang chọn";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(29, 101);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(364, 40);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Xóa các phần tử đầu và cuối";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(29, 39);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(364, 40);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Tổng các phần tử trong List";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKetThuc.Location = new System.Drawing.Point(38, 556);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(732, 56);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "&KẾT THÚC";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBai8
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(807, 625);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "frmBai8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai8";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai8_FormClosing);
            this.Load += new System.EventHandler(this.frmBai8_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}