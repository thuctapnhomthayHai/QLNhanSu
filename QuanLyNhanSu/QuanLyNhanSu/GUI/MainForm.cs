using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Visible = true;
            IsMdiContainer = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void grbFormCha_Enter(object sender, EventArgs e)
        {

        }

        private void btnQLNhanSu_Click(object sender, EventArgs e)
        {
            QuanLyNhanSu frm = new QuanLyNhanSu();
            frm.Show();
          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
