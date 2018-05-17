using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.DataLayer;

namespace QuanLyNhanSu
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
        DataTable NhanVien;
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            DataLayer.DataAccess.Connect();
            LoadDataGridView();
        }
            public void LoadDataGridView()
          {
            string sql;
            sql = "SELECT MaNV,HoTen,DanToc,GioiTinh,QueQuan,NgaySinh,SoDienThoai,TenCV,TenPB,TenTDHV,BacLuong From NhanVien,ChucVu,PhongBan,TrinhDoHocVan where NhanVien.MaCV = ChucVu.MaCV and NhanVien.MaPB = PhongBan.MaPB and TrinhDoHocVan.MaTDHV =NhanVien.MaTDHV ";
            //sql1 = "select MaPhong,MaDichVu,ThoiGian,SoLan from ChiTiet_DichVuPhong ";
            NhanVien = DataAccess.GetDataToTable(sql); //lấy dữ liệu
            dtg_QLNV.DataSource = NhanVien;

            dtg_QLNV.Columns[0].HeaderText = "Mã nhân viên";
            dtg_QLNV.Columns[1].HeaderText = "Tên nhân viên";
            dtg_QLNV.Columns[2].HeaderText = "Dân tộc";
            dtg_QLNV.Columns[3].HeaderText = "Giới tính";
            dtg_QLNV.Columns[4].HeaderText = "Quê quán";
            dtg_QLNV.Columns[5].HeaderText = "Ngày sinh";
            dtg_QLNV.Columns[6].HeaderText = "Số điện thoại";
            dtg_QLNV.Columns[7].HeaderText = "Chức vụ";
            dtg_QLNV.Columns[8].HeaderText = "Tên phòng ban";
            dtg_QLNV.Columns[9].HeaderText = "Mã TDHV";
            dtg_QLNV.Columns[10].HeaderText = "Bậc lương";


            dtg_QLNV.Columns[0].Width = 150;
            dtg_QLNV.Columns[1].Width = 200;
            dtg_QLNV.Columns[2].Width = 150;
            dtg_QLNV.Columns[3].Width = 150;
            dtg_QLNV.Columns[4].Width = 150;
            dtg_QLNV.Columns[5].Width = 150;
            dtg_QLNV.Columns[6].Width = 150;
            dtg_QLNV.Columns[7].Width = 150;
            dtg_QLNV.Columns[8].Width = 150;
            dtg_QLNV.Columns[9].Width = 150;
            dtg_QLNV.Columns[10].Width = 150;

            dtg_QLNV.AllowUserToAddRows = false;
            dtg_QLNV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

            private void btn_Them_Click(object sender, EventArgs e)
            {
                   
        
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                    //btnHuy.Enabled = true;
                    btn_Luu.Enabled = true;
                    btn_Them.Enabled = false;
                    ResetValues();
                    //txt_manv.Enabled = true;
                    txt_manv.Focus();
        
            }
            private void ResetValues()
            {
                txt_manv.Text = "";
                txt_tennv.Text = "";
                txt_dantoc.Text = "";
                txt_gioitinh.Text = "";
                txt_quequan.Text = "";
                dt_ngaysinh.Text = "";
                txt_sdt.Text = "";
                txt_macv.Text = "";
                txt_mapb.Text = "";
                txt_matdhv.Text = "";
                txt_bacluong.Text = "";

            }

            private void btn_Sua_Click(object sender, EventArgs e)
            {

                string sql;
                if (NhanVien.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txt_manv.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txt_tennv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_tennv.Focus();
                    return;
                }
                if (txt_dantoc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_dantoc.Focus();
                    return;
                }

                if (txt_gioitinh.Text == "   ")
                {
                    MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_gioitinh.Focus();
                    return;
                }
                if (txt_quequan.Text == "   ")
                {
                    MessageBox.Show("Bạn phải nhập quê quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_quequan.Focus();
                    return;
                }
                if (dt_ngaysinh.Text == "   ")
                {
                    MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dt_ngaysinh.Focus();
                    return;
                }
                if (txt_sdt.Text == "   ")
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_sdt.Focus();
                    return;
                }
                if (txt_macv.Text == "   ")
                {
                    MessageBox.Show("Bạn phải nhập mã chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_macv.Focus();
                    return;
                }
                if (txt_mapb.Text == "   ")
                {
                    MessageBox.Show("Bạn phải nhập mã phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_mapb.Focus();
                    return;
                }
                if (txt_matdhv.Text == "   ")
                {
                    MessageBox.Show("Bạn phải nhập mã trình độ học vấn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_matdhv.Focus();
                    return;
                }

                if (txt_bacluong.Text == "   ")
                {
                    MessageBox.Show("Bạn phải nhập bậc lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_bacluong.Focus();
                    return;
                }


                sql = "UPDATE NhanVien SET  HoTen=N'" + txt_tennv.Text.Trim().ToString() +
                        "',DanToc=N'" + txt_dantoc.Text.Trim().ToString() +
                          "',GioiTinh=N'" + txt_gioitinh.Text.Trim().ToString() +
                          "',QueQuan=N'" + txt_quequan.Text.Trim().ToString() +
                          "',NgaySinh=N'" + dt_ngaysinh.Text.Trim().ToString() +
                          "',SoDienThoai=N'" + txt_sdt.Text.Trim().ToString() +
                          "',MaCV=N'" + txt_macv.Text.Trim().ToString() +
                          "',MaPB=N'" + txt_mapb.Text.Trim().ToString() +
                          "',MaTDHV=N'" + txt_matdhv.Text.Trim().ToString() +
                          "',BacLuong=N'" + txt_bacluong.Text.Trim().ToString() +
                        "' WHERE MaDichVu=N'" + txt_manv.Text + "'";
                DataAccess.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }

            private void btn_Xoa_Click(object sender, EventArgs e)
            {
                string sql;
                if (NhanVien.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txt_manv.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sql = "DELETE DichVu WHERE MaDichVu=N'" + txt_manv.Text + "'";
                    DataAccess.RunSqlDel(sql);
                    LoadDataGridView();
                    ResetValues();
                }
            }

            private void btn_Huy_Click(object sender, EventArgs e)
            {
                DialogResult hoi;
                hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            private void btn_Luu_Click(object sender, EventArgs e)
            {
                string sql;
                if (txt_manv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_manv.Focus();
                    return;
                }
                if (txt_tennv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_tennv.Focus();
                    return;
                }
                if (txt_dantoc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giá dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_dantoc.Focus();
                    return;
                }

                if (txt_gioitinh.Text == "  ")
                {
                    MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_gioitinh.Focus();
                    return;
                }

                if (txt_quequan.Text == "  ")
                {
                    MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_quequan.Focus();
                    return;
                }

                if (dt_ngaysinh.Text == "  ")
                {
                    MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dt_ngaysinh.Focus();
                    return;
                }
                if (txt_sdt.Text == "  ")
                {
                    MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_sdt.Focus();
                    return;
                }
                if (txt_macv.Text == "  ")
                {
                    MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_macv.Focus();
                    return;
                }
                if (txt_mapb.Text == "  ")
                {
                    MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_mapb.Focus();
                    return;
                }
                if (txt_matdhv.Text == "  ")
                {
                    MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_matdhv.Focus();
                    return;
                }
                if (txt_bacluong.Text == "  ")
                {
                    MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_bacluong.Focus();
                    return;
                }



                sql = "SELECT MaNV FROM NhanVien WHERE MaNV=N'" + txt_manv.Text.Trim() + "'";

                if (DataAccess.CheckKey(sql))
                {
                    MessageBox.Show("Mã khách hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_manv.Focus();
                    txt_manv.Text = "";
                    return;
                }
                sql = "INSERT INTO NhanVien(MaNV,HoTen, DanToc,GioiTinh,QueQuan,NgaySinh,SoDienThoai,MaCV,MaPB,MaTDHV,BacLuong) VALUES (N'" + txt_manv.Text.Trim() + "',N'" + txt_tennv.Text.Trim() + "',N'" + txt_dantoc.Text.Trim() + "',N'" + txt_gioitinh.Text + "',N'" + txt_quequan.Text.Trim() + "','" + dt_ngaysinh.Text.Trim() + "',N'" + txt_sdt.Text.Trim() + "',N'" + txt_macv.Text.Trim() + "',N'" + txt_mapb.Text.Trim() + "',N'" + txt_matdhv.Text.Trim() + "',N'" + txt_bacluong.Text.Trim() + "')";
                DataAccess.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
                btn_Xoa.Enabled = true;
                btn_Them.Enabled = true;
                btn_Sua.Enabled = true;
                //btn_uy.Enabled = false;
                btn_Luu.Enabled = false;
                txt_manv.Enabled = false;
        
            }
        
    }
}
