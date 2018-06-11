using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class TienLuong : Form
    {
        public TienLuong()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        private void show()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            string sql = "SELECT * FROM Luong";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dgvLuong.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "INSERT INTO Luong VALUES (@BACLUONG, @LUONGCB, @HSLUONG, @HSPC)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("BacLuong", txtBacLuong.Text);
            cmd.Parameters.AddWithValue("LuongCB", txtLuongCB.Text);
            cmd.Parameters.AddWithValue("HSLuong", txtHSL.Text);
            cmd.Parameters.AddWithValue("HSPC", txtHSPC.Text);
            cmd.ExecuteNonQuery();
            show();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "UPDATE Luong SET @LUONGCB=LuongCB, @HSLUONG=HSLuong, @HSPC=HSPC WHERE @BACLUONG=BacLuong";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("BacLuong", txtBacLuong.Text);
            cmd.Parameters.AddWithValue("LuongCB", txtLuongCB.Text);
            cmd.Parameters.AddWithValue("HSLuong", txtHSL.Text);
            cmd.Parameters.AddWithValue("HSPC", txtHSPC.Text);
            cmd.ExecuteNonQuery();
            show();
            con.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM Luong WHERE @BACLUONG=BacLuong";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("BacLuong", txtBacLuong.Text);
            cmd.Parameters.AddWithValue("LuongCB", txtLuongCB.Text);
            cmd.Parameters.AddWithValue("HSLuong", txtHSL.Text);
            cmd.Parameters.AddWithValue("HSPC", txtHSPC.Text);
            cmd.ExecuteNonQuery();
            show();
            con.Close();
        }
    }
}
