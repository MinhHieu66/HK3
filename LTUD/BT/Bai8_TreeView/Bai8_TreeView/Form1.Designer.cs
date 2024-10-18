namespace Bai8_TreeView
{
    partial class frmBai8_TV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai8_TV));
            this.tvDemo = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDemo
            // 
            this.tvDemo.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvDemo.FullRowSelect = true;
            this.tvDemo.ImageIndex = 0;
            this.tvDemo.ImageList = this.imgIcon;
            this.tvDemo.Location = new System.Drawing.Point(0, 0);
            this.tvDemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvDemo.Name = "tvDemo";
            this.tvDemo.SelectedImageIndex = 0;
            this.tvDemo.Size = new System.Drawing.Size(454, 562);
            this.tvDemo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLN);
            this.panel1.Controls.Add(this.txtFN);
            this.panel1.Location = new System.Drawing.Point(536, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 382);
            this.panel1.TabIndex = 1;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(22, 65);
            this.txtFN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(286, 27);
            this.txtFN.TabIndex = 0;
            this.txtFN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(22, 196);
            this.txtLN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(286, 27);
            this.txtLN.TabIndex = 0;
            this.txtLN.TextChanged += new System.EventHandler(this.txtLN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 279);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Name";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(681, 461);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "porlfolio7.jpg");
            this.imgIcon.Images.SetKeyName(1, "porlfolio1.jpg");
            this.imgIcon.Images.SetKeyName(2, "porlfolio3.jpg");
            this.imgIcon.Images.SetKeyName(3, "porlfolio4.jpg");
            this.imgIcon.Images.SetKeyName(4, "porlfolio5.jpg");
            this.imgIcon.Images.SetKeyName(5, "porlfolio6.jpg");
            // 
            // frmBai8_TV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 562);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvDemo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBai8_TV";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBai8_TV_FormClosing);
            this.Load += new System.EventHandler(this.frmBai8_TV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDemo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imgIcon;
    }
}

