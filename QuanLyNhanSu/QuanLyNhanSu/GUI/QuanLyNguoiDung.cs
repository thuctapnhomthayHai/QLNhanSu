using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class QuanLyNguoiDung : Form
    {
        public QuanLyNguoiDung()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=BAOMINH180-PC\sqlexpress;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        private void show()
        {
               if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            string sql = "SELECT * FROM NguoiDung";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "INSERT INTO NguoiDung VALUES (@TAIKHOAN @MATKHAU, @IDTAIKHOAN, @QUYEN)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("TAIKHOAN", txttk.Text);
            cmd.Parameters.AddWithValue("MATKHAU", txtmk.Text);
            cmd.Parameters.AddWithValue("IDTAIKHOAN", txtidtk.Text);
            cmd.Parameters.AddWithValue("QUYEN", cbpq.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "UPDATE NguoiDung SET MATKHAU=@MATKHAU, IDTAIKHOAN=@IDTAIKHOAN, QUYEN=@QUYEN WHERE TAIKHOAN=@TAIKHOAN";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("TAIKHOAN", txttk.Text);
            cmd.Parameters.AddWithValue("MATKHAU", txtmk.Text);
            cmd.Parameters.AddWithValue("IDTAIKHOAN", txtidtk.Text);
            cmd.Parameters.AddWithValue("QUYEN", cbpq.Text);
            cmd.ExecuteNonQuery();
            show();
            con.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "DELETE FROM NguoiDung WHERE TAIKHOAN = @TAIKHOAN";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("TAIKHOAN", txttk.Text);
            cmd.Parameters.AddWithValue("MATKHAU", txtmk.Text);
            cmd.Parameters.AddWithValue("IDTAIKHOAN", txtidtk.Text);
            cmd.Parameters.AddWithValue("QUYEN", cbpq.Text);
            cmd.ExecuteNonQuery();
            show();
            con.Close();
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
