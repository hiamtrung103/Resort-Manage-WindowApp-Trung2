using baitap.Control;
using baitap.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmKeToan : Form
    {
        NhanVienCtr nhanVienCtr = new NhanVienCtr();

        public frmKeToan()
        {
            InitializeComponent();
        }
        private void frmKeToan_Load(object sender, EventArgs e)
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
                txtQuyenHan.Text = row.Cells["QuyenHan"].Value.ToString();
            }
        }


        public void btnThemLuong()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                NhanvienObj nvObj = new NhanvienObj();
                //nvObj.Luong = txtLuong.Text;

                nvObj.MaNhanVien = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                nhanVienCtr.CapNhatDuLieuNhanVien(nvObj);
                dataGridView1.DataSource = nhanVienCtr.LayDuLieuNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThemLuong();
        }
    }
}
