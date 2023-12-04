using baitap.Control;
using baitap.Model;
using baitap.Object;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmKhachHang : KryptonForm
    {
        private KhachHangCtr khachHangCtr = new KhachHangCtr();


        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = khachHangCtr.LayDuLieuKhachHang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtHoTenKhachHang.Text = row.Cells["HoTen"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtNamSinh.Text = row.Cells["NamSinh"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();
                txtTenTaiKhoan.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtGiamGia.Text = row.Cells["MaGiamGia"].Value.ToString();
            }
        }

        public void ThemKhachHang()
        {
            if (string.IsNullOrWhiteSpace(txtHoTenKhachHang.Text) ||
                string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
                string.IsNullOrWhiteSpace(txtNamSinh.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
                string.IsNullOrWhiteSpace(txtTenTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            KhachHangObj khachHangObj = new KhachHangObj();
            khachHangObj.HoTen = txtHoTenKhachHang.Text;
            khachHangObj.GioiTinh = txtGioiTinh.Text;
            khachHangObj.NamSinh = txtNamSinh.Text;
            khachHangObj.DiaChi = txtDiaChi.Text;
            khachHangObj.DienThoai = txtDienThoai.Text;
            khachHangObj.TenTaiKhoan = txtTenTaiKhoan.Text;
            khachHangObj.Email = txtEmail.Text;
            khachHangObj.Password = txtPassword.Text;
            khachHangObj.MaGiamGia = txtGiamGia.Text;

            bool result = khachHangCtr.ThemDuLieuKhachHang(khachHangObj);

            if (result)
            {
                MessageBox.Show("Thêm dữ liệu thành công.");
                dataGridView1.DataSource = khachHangCtr.LayDuLieuKhachHang();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại.");
            }
        }

        public void XoaKhachHang()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá người dùng này?", "Xoá người dùng!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    khachHangCtr.XoaDuLieuKhachHang(id);
                    MessageBox.Show("Xoá dữ liệu thành công.");
                    ClearTextBox();
                    dataGridView1.DataSource = khachHangCtr.LayDuLieuKhachHang();
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

        public void SuaKhachHang()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                KhachHangObj khachHangObj = new KhachHangObj();
                khachHangObj.HoTen = txtHoTenKhachHang.Text;
                khachHangObj.GioiTinh = txtGioiTinh.Text;
                khachHangObj.NamSinh = txtNamSinh.Text;
                khachHangObj.DiaChi = txtDiaChi.Text;
                khachHangObj.DienThoai = txtDienThoai.Text;
                khachHangObj.TenTaiKhoan = txtTenTaiKhoan.Text;
                khachHangObj.Email = txtEmail.Text;
                khachHangObj.Password = txtPassword.Text;
                khachHangObj.MaGiamGia = txtGiamGia.Text;

                khachHangObj.MaKhachHang = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                khachHangCtr.CapNhatDuLieuKhachHang(khachHangObj);
                dataGridView1.DataSource = khachHangCtr.LayDuLieuKhachHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        public void ClearTextBox()
        {
            txtHoTenKhachHang.Text = "";
            txtGioiTinh.Text = "";
            txtNamSinh.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtTenTaiKhoan.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtGiamGia.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaKhachHang();
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
