using baitap.Control;
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
        NhanVienCtr nhanVienCtr = new NhanVienCtr();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nhanVienCtr.LayDuLieuNhanVien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtTenNV.Text = row.Cells["HoTen"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtNamSinh.Text = row.Cells["NamSinh"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienTHoai"].Value.ToString();
                txtMatkhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtTenTaiKhoan.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtQuyenHan.Text = row.Cells["quyenhan"].Value.ToString();
            }
        }

        private NhanvienObj LayNhanVienObjTuForm()
        {
            return new NhanvienObj
            {
                TenNhanVien = txtTenNV.Text,
                GioiTinh = txtGioiTinh.Text,
                NamSinh = txtNamSinh.Text,
                DiaChi = txtDiaChi.Text,
                DienThoai = txtDienThoai.Text,
                TenTaiKhoan = txtTenTaiKhoan.Text,
                Email = txtEmail.Text,
                MatKhau = txtMatkhau.Text,
                QuyenHan = txtQuyenHan.Text
            };
        }
        private void btnThem()
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

            NhanvienObj nvObj = LayNhanVienObjTuForm();

            bool result = nhanVienCtr.ThemDuLieuNhanVien(nvObj);

            if (result)
            {
                MessageBox.Show("Thêm dữ liệu thành công.");
                dataGridView1.DataSource = nhanVienCtr.LayDuLieuNhanVien();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại.");
            }
        }

        private void btnXoa()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá người dùng này?", "Xoá người dùng!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    nhanVienCtr.XoaDuLieuNhanVien(id);
                    MessageBox.Show("Xoá dữ liệu thành công.");
                    ClearTextBox();
                    dataGridView1.DataSource = nhanVienCtr.LayDuLieuNhanVien();
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

        private void btnSua()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                NhanvienObj nvObj = LayNhanVienObjTuForm();

                nvObj.MaNhanVien = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                nhanVienCtr.CapNhatDuLieuNhanVien(nvObj);
                dataGridView1.DataSource = nhanVienCtr.LayDuLieuNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void ClearTextBox()
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
            ChiNhapSo(e);
        }

        internal void ChiNhapSo(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
