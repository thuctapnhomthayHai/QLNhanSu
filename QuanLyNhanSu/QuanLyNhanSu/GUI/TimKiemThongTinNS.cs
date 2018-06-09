using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSu.GUI
{
    public partial class TimKiemThongTinNS : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SNTR6UK;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        public TimKiemThongTinNS()
        {
            InitializeComponent();
        }
        public void Show()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void TimMaNV()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaNV", txt_timkiem.Text); 
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void TimHoTen()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE HoTen = @HoTen";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("HoTen", txt_timkiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void TimDanToc()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE DanToc = @DanToc";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("DanToc", txt_timkiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void TimGioiTinh()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE GioiTinh = @GioiTinh";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("GioiTinh", txt_timkiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void TimQueQuan()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE QueQuan = @QueQuan";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("QueQuan", txt_timkiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void TimNgaySinh()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE NgaySinh = @NgaySinh";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("NgaySinh", txt_timkiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void TimSoDienThoai()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE SoDienThoai = @SoDienThoai";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("SoDienThoai", txt_timkiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void TimMaCV()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE MaCV = @MaCV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaCV", txt_timkiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void TimMaPB()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE MaPB = @MaPB";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaPB", txt_timkiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void TimMaTDHV()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE MaTDHV = @MaTDHV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("MaTDHV", txt_timkiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        public void TimBacLuong()
        {
            con.Open();
            string sql = "SELECT *FROM NhanVien WHERE BacLuong = @BacLuong";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("BacLuong", txt_timkiem.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        /*Mã nhân viên
Họ tên
Dân tộc
Giới tính
Quê quán
Ngày sinh
Số điện thoại
Mã chức vụ
Mã phòng ban
Mã trình độ học vấn
Bậc lương*/
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Mã nhân viên")
            {
                TimMaNV();
            }
            if (comboBox1.Text == "Họ tên")
            {
                TimHoTen();
            }
            if (comboBox1.Text == "Dân tộc")
            {
                TimDanToc();
            }
            if (comboBox1.Text == "Giới tính")
            {
                TimGioiTinh();
            }
            if (comboBox1.Text == "Quê quán")
            {
                TimQueQuan();
            }
            if (comboBox1.Text == "Ngày sinh")
            {
                TimNgaySinh();
            }
            if (comboBox1.Text == "Số điện thoại")
            {
                TimSoDienThoai();
            }
            if (comboBox1.Text == "Mã chức vụ")
            {
                TimMaCV();
            }
            if (comboBox1.Text == "Mã phòng ban")
            {
                TimMaPB();
            }
            if (comboBox1.Text == "Mã trình độ học vấn")
            {
                TimMaTDHV();
            }
            if (comboBox1.Text == "Bậc lương")
            {
                TimBacLuong();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TimKiemThongTinNS_Load(object sender, EventArgs e)
        {
            Show();
        }
    }
}
