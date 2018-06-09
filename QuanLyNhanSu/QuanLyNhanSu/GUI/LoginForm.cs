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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GUI.MainForm mf = new GUI.MainForm();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";
                txtUser.Text = "";
            }    

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (dr == DialogResult.No)
            {
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
