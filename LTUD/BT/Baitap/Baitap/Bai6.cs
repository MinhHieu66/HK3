using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class frmBai6 : Form
    {
        public frmBai6()
        {
            InitializeComponent();
        }

        private void frmBai6_Load(object sender, EventArgs e)
        {
            radVN.Checked = true;
            picFlag.Image = Image.FromFile("D:\\HK3\\LTUD\\Images\\vn.png");
        }

        private void radVN_CheckedChanged(object sender, EventArgs e)
        {
            picFlag.Image = Image.FromFile("D:\\HK3\\LTUD\\Images\\vn.png");
        }

        private void radUSA_CheckedChanged(object sender, EventArgs e)
        {
            picFlag.Image = Image.FromFile("D:\\HK3\\LTUD\\Images\\usa.png");
        }

        private void radItalia_CheckedChanged(object sender, EventArgs e)
        {
            picFlag.Image = Image.FromFile("D:\\HK3\\LTUD\\Images\\italia.png");
        }

        private void radPhilippine_CheckedChanged(object sender, EventArgs e)
        {
            picFlag.Image = Image.FromFile("D:\\HK3\\LTUD\\Images\\philippine.png");
        }
    }
}
