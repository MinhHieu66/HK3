namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nguyen Van Tuan");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nguyen Thi Lan");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nguyen Van Lan");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("THTH5A", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Le Nghiep");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tran Long");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ly Hai");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("THTH5B", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Le Trung");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Ton Thi Mai");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Tran Minh");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("THTH5C", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Khoa Tin Hoc", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tvKhoa = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstDS = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(692, 22);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 30);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(421, 25);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(247, 27);
            this.txtTim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên: ";
            // 
            // tvKhoa
            // 
            this.tvKhoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvKhoa.ImageIndex = 0;
            this.tvKhoa.ImageList = this.imgList;
            this.tvKhoa.Location = new System.Drawing.Point(0, 77);
            this.tvKhoa.Name = "tvKhoa";
            treeNode1.Name = "NVT";
            treeNode1.Text = "Nguyen Van Tuan";
            treeNode2.Name = "NTL";
            treeNode2.Text = "Nguyen Thi Lan";
            treeNode3.Name = "NGL";
            treeNode3.Text = "Nguyen Van Lan";
            treeNode4.ImageKey = "porlfolio6.jpg";
            treeNode4.Name = "THTH5A";
            treeNode4.Text = "THTH5A";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Le Nghiep";
            treeNode6.Name = "TL";
            treeNode6.Text = "Tran Long";
            treeNode7.Name = "LH";
            treeNode7.Text = "Ly Hai";
            treeNode8.Name = "THTH5B";
            treeNode8.Text = "THTH5B";
            treeNode9.Name = "LT";
            treeNode9.Text = "Le Trung";
            treeNode10.Name = "TTM";
            treeNode10.Text = "Ton Thi Mai";
            treeNode11.Name = "TM";
            treeNode11.Text = "Tran Minh";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "THTH5C";
            treeNode12.Text = "THTH5C";
            treeNode13.Name = "TinHoc";
            treeNode13.Text = "Khoa Tin Hoc";
            this.tvKhoa.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.tvKhoa.SelectedImageIndex = 0;
            this.tvKhoa.Size = new System.Drawing.Size(235, 412);
            this.tvKhoa.TabIndex = 1;
            this.tvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "porlfolio1.jpg");
            this.imgList.Images.SetKeyName(1, "porlfolio3.jpg");
            this.imgList.Images.SetKeyName(2, "porlfolio4.jpg");
            this.imgList.Images.SetKeyName(3, "porlfolio5.jpg");
            this.imgList.Images.SetKeyName(4, "porlfolio6.jpg");
            this.imgList.Images.SetKeyName(5, "porlfolio7.jpg");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstDS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(241, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 412);
            this.panel2.TabIndex = 2;
            // 
            // lstDS
            // 
            this.lstDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colLop});
            this.lstDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDS.FullRowSelect = true;
            this.lstDS.GridLines = true;
            this.lstDS.HideSelection = false;
            this.lstDS.Location = new System.Drawing.Point(0, 0);
            this.lstDS.Name = "lstDS";
            this.lstDS.Size = new System.Drawing.Size(559, 412);
            this.lstDS.TabIndex = 0;
            this.lstDS.UseCompatibleStateImageBehavior = false;
            this.lstDS.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Ten SV";
            this.colName.Width = 229;
            // 
            // colLop
            // 
            this.colLop.Text = "Lop";
            this.colLop.Width = 257;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tvKhoa);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvKhoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstDS;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLop;
    }
}

