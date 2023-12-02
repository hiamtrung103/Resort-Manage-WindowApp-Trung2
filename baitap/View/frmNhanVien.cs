using baitap.Model;
using baitap.Object;
using Krypton.Toolkit;
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

namespace baitap.View
{
    public partial class frmNhanVien : KryptonForm
    {
        NhanVienMod nhanVienMod = new NhanVienMod();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanVienMod.LayDuLieuNhanVien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtTenNV.Text = row.Cells["ho_ten"].Value.ToString();
                txtGioiTinh.Text = row.Cells["gioi_tinh"].Value.ToString();
                txtNamSinh.Text = row.Cells["nam_sinh"].Value.ToString();
                txtDiaChi.Text = row.Cells["dia_chi"].Value.ToString();
                txtDienThoai.Text = row.Cells["sdt"].Value.ToString();
                txtMatkhau.Text = row.Cells["mat_khau"].Value.ToString();
                txtTenTaiKhoan.Text = row.Cells["ten_tai_khoan"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtQuyenHan.Text = row.Cells["quyen_han"].Value.ToString();
            }
        }

        public void btnThem()
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
                string.IsNullOrWhiteSpace(txtNamSinh.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtMatkhau.Text) ||
                string.IsNullOrWhiteSpace(txtTenTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtQuyenHan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            NhanvienObj nvObj = new NhanvienObj();
            nvObj.TenNhanVien = txtTenNV.Text;
            nvObj.GioiTinh = txtGioiTinh.Text;
            nvObj.NamSinh = txtNamSinh.Text;
            nvObj.DiaChi = txtDiaChi.Text;
            nvObj.DienThoai = txtDienThoai.Text;
            nvObj.MatKhau = txtMatkhau.Text;
            nvObj.TenTaiKhoan = txtTenTaiKhoan.Text;
            nvObj.Email = txtEmail.Text;
            nvObj.QuyenHan = txtQuyenHan.Text;

            bool result = nhanVienMod.ThemDuLieuNhanVien(nvObj);

            if (result)
            {
                MessageBox.Show("Thêm dữ liệu thành công.");
                dataGridView1.DataSource = nhanVienMod.LayDuLieuNhanVien();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại.");
            }
        }

        public void btnXoa()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                bool result = nhanVienMod.XoaDuLieuNhanVien(id);

                if (result)
                {
                    MessageBox.Show("Xoá dữ liệu thành công.");
                    ClearTextBox();
                    dataGridView1.DataSource = nhanVienMod.LayDuLieuNhanVien();
                }
                else
                {
                    MessageBox.Show("Xoá dữ liệu thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xoá.");
            }
        }

        public void btnSua()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                NhanvienObj nvObj = new NhanvienObj();
                nvObj.TenNhanVien = txtTenNV.Text;
                nvObj.GioiTinh = txtGioiTinh.Text;
                nvObj.NamSinh = txtNamSinh.Text;
                nvObj.DiaChi = txtDiaChi.Text;
                nvObj.DienThoai = txtDienThoai.Text;
                nvObj.MatKhau = txtMatkhau.Text;
                nvObj.TenTaiKhoan = txtTenTaiKhoan.Text;
                nvObj.Email = txtEmail.Text;
                nvObj.QuyenHan = txtQuyenHan.Text;

                nvObj.MaNhanVien = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                nhanVienMod.CapNhatDuLieuNhanVien(nvObj);
                dataGridView1.DataSource = nhanVienMod.LayDuLieuNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        public void ClearTextBox()
        {
            txtTenNV.Text = "";
            txtMatkhau.Text = "";
            txtGioiTinh.Text = "";
            txtNamSinh.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtTenTaiKhoan.Text = "";
            txtEmail.Text = "";
            txtQuyenHan.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void nhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
