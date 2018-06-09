﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DataLayer;

namespace QuanLyNhanSu.GUI
{
    public partial class QuanLyNhanSu : Form
    {
        public QuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaNV.Enabled = true;
            txtMaNV.Focus();
        }
        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            dt_Ngaysinh.Text = "";
            txtGT.Text = "";
            txtSDT.Text = "";
            txtBacLuong.Text = "";
            txtCV.Text = "";
            txtDT.Text = "";
            txtPB.Text = "";
            txtQueQuan.Text = "";

        }


        private void QuanLyNhanSu_Load(object sender, EventArgs e)
        {
            DataLayer.DataAccess.Connect();
            //txt_Madocgia.Enabled = false;
            // btn_Luu.Enabled = false;
            //btnHuy.Enabled = false;
            LoadDataGridView();

        }
        DataTable NhanSu;
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNV,HoTen,DanToc,GioiTinh,QueQuan,NgaySinh,SoDienThoai,MaCV,MaPB,MaTDHV,BacLuong From NhanVien";
            NhanSu = DataAccess.GetDataToTable(sql); //lấy dữ liệu
            dtgNhanSu.DataSource = NhanSu;

            dtgNhanSu.Columns[0].HeaderText = "Mã nhân viên";
            dtgNhanSu.Columns[1].HeaderText = "Họ tên";
            dtgNhanSu.Columns[2].HeaderText = "Dân tộc";
            dtgNhanSu.Columns[3].HeaderText = "Giới tính";
            dtgNhanSu.Columns[4].HeaderText = "Quê quán";
            dtgNhanSu.Columns[5].HeaderText = "Ngày sinh";
            dtgNhanSu.Columns[6].HeaderText = "SDT";
            dtgNhanSu.Columns[7].HeaderText = "Công việc";
            dtgNhanSu.Columns[8].HeaderText = "Phòng ban";
            dtgNhanSu.Columns[9].HeaderText = "Trình độ học vấn";
            dtgNhanSu.Columns[10].HeaderText = "Bậc lương";
            

            dtgNhanSu.Columns[0].Width = 150;
            dtgNhanSu.Columns[1].Width = 200;
            dtgNhanSu.Columns[2].Width = 150;
            dtgNhanSu.Columns[3].Width = 150;
            dtgNhanSu.Columns[4].Width = 150;
            dtgNhanSu.Columns[5].Width = 150;
            dtgNhanSu.Columns[6].Width = 150;
            dtgNhanSu.Columns[7].Width = 200;
            dtgNhanSu.Columns[8].Width = 150;
            dtgNhanSu.Columns[9].Width = 150;
            dtgNhanSu.Columns[10].Width = 150;
            //dtgNhanSu.Columns[11].Width = 150;

            dtgNhanSu.AllowUserToAddRows = false;
            dtgNhanSu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dtgNhanSu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (NhanSu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNV.Text = dtgNhanSu.CurrentRow.Cells["MaNV"].Value.ToString();
            txtHoTen.Text = dtgNhanSu.CurrentRow.Cells["HoTen"].Value.ToString();
            txtDT.Text = dtgNhanSu.CurrentRow.Cells["DanToc"].Value.ToString();
            txtGT.Text = dtgNhanSu.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txtQueQuan.Text = dtgNhanSu.CurrentRow.Cells["QueQuan"].Value.ToString();
            dt_Ngaysinh.Text = dtgNhanSu.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtSDT.Text = dtgNhanSu.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            txtCV.Text = dtgNhanSu.CurrentRow.Cells["MaCV"].Value.ToString();
            txtPB.Text = dtgNhanSu.CurrentRow.Cells["MaPB"].Value.ToString();
            txtTDHV.Text = dtgNhanSu.CurrentRow.Cells["MaTDHV"].Value.ToString();
            txtBacLuong.Text = dtgNhanSu.CurrentRow.Cells["BacLuong"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (NhanSu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (txtDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDT.Focus();
                return;
            }
            if (txtGT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGT.Focus();
                return;
            }
            if (txtQueQuan.Text == "   ")
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQueQuan.Focus();
                return;
            }
            if (dt_Ngaysinh.Text == "   ")
            {
                MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_Ngaysinh.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCV.Focus();
                return;
            }
            if (txtPB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPB.Focus();
                return;
            }
            if (txtTDHV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTDHV.Focus();
                return;
            }
            if (txtBacLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBacLuong.Focus();
                return;
            }



            sql = "UPDATE NhanVien SET  HoTen=N'" + txtHoTen.Text.Trim().ToString() +
                    "',DanToc='" + txtDT.Text.Trim().ToString() +
                    "',GioiTinh='" + txtGT.Text.ToString() +
                    "',QueQuan='" + txtQueQuan.Text.Trim().ToString() +
                    "',NgaySinh='" + dt_Ngaysinh.Text.Trim().ToString() +
                    "',SoDienThoai='" + txtSDT.Text.Trim().ToString() +
                    "',MaCV='" + txtSDT.Text.Trim().ToString() +
                    "',MaPB='" + txtPB.Text.Trim().ToString() +
                    "',MaTDHV='" + txtTDHV.Text.Trim().ToString() +
                    "',BacLuong='" + txtBacLuong.Text.Trim().ToString() +
                    "' WHERE MaKH=N'" + txtMaNV.Text + "'";
            DataAccess.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            //btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (NhanSu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhanVien WHERE MaNV=N'" + txtMaNV.Text + "'";
                DataAccess.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (txtDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDT.Focus();
                return;
            }
            if (txtGT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGT.Focus();
                return;
            }
            if (txtQueQuan.Text == "  ")
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQueQuan.Focus();
                return;
            }
            if (dt_Ngaysinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_Ngaysinh.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (txtCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCV.Focus();
                return;
            }
            if (txtPB.Text == "  ")
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPB.Focus();
                return;
            }
            if (txtTDHV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTDHV.Focus();
                return;
            }
            if (txtBacLuong.Text == "  ")
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBacLuong.Focus();
                return;
            }


            sql = "SELECT MaNV FROM NhanVien WHERE MaNV=N'" + txtMaNV.Text.Trim() + "'";

            if (DataAccess.CheckKey(sql))
            {
                MessageBox.Show("Mã  hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }
            sql = "INSERT INTO NhanVien(MaNV,HoTen, DanToc,GioiTinh,QueQuan,NgaySinh,SoDienThoai,MaCV,MaPB,MaTDHV,BacLuong) VALUES (N'" + txtMaNV.Text.Trim() + "',N'" + txtHoTen.Text.Trim() + "',N'" + txtDT.Text.Trim() + "',N'" + txtGT.Text + "',N'" + txtQueQuan.Text.Trim() + "','" +
                dt_Ngaysinh.Text + "',N'" + txtSDT.Text.Trim() + "',N'" + txtCV.Text.Trim() + "',N'" + txtPB.Text.Trim() + "',N'" + txtTDHV.Text.Trim()  +"',N'" + txtBacLuong.Text.Trim() + "')";
            //sql1 = "insert into NhaSanXuat(MaNhaSX,TenNhaSX) Values (N'"+null + "',N'" + txtTenNSX.Text.Trim() +"') ";
            //sql2 = "insert into LoaiHang(MaLoai,TenLoai) Values (N'" + null + "',N'" + txtTenLoai.Text.Trim() + "') ";
            DataAccess.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            //btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbxTimKiemTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbxTimKiemTheo.DisplayMember = "Text";
            //cbxTimKiemTheo.ValueMember = "Value";

            //cbxTimKiemTheo.Items.Add(new { Text = "Mã nhân viên", Value = "Mã nhân viên" });
            //cbxTimKiemTheo.Items.Add(new { Text = "Mã phòng ban", Value = "Mã phòng ban" });
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Càn Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                if (cbxTimKiemTheo.Text == "Mã nhân viên")
                {
                    dtgNhanSu.DataSource = DataAccess.GetDataToTable("select * from NhanVien where MaNV  = " + txtNhap.Text.Trim() + " ");
                }
                if (cbxTimKiemTheo.Text == "Mã phòng ban")
                {
                    dtgNhanSu.DataSource = DataAccess.GetDataToTable("select * from NhanVien where MaPB like '%" + txtNhap.Text.Trim() + "%'");
                }

            }
        }

        private void cbxTimKiemTheo_Click(object sender, EventArgs e)
        {
            cbxTimKiemTheo.DisplayMember = "Text";
            cbxTimKiemTheo.ValueMember = "Value";

            cbxTimKiemTheo.Items.Add(new { Text = "Mã nhân viên", Value = "Mã nhân viên" });
            cbxTimKiemTheo.Items.Add(new { Text = "Mã phòng ban", Value = "Mã phòng ban" });
        }
    }
}
