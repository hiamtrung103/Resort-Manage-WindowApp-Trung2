using baitap.Model;
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
    public partial class Register : Form
    {
        private bool isDarkMode = false;
        private frmNhanVien nv = new frmNhanVien();
        public Register()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(menu, menu.Width, 0);
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                panelMain.BackColor = Color.FromArgb(51, 51, 51);
                label1.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;

            }
            else
            {
                panelMain.BackColor = System.Drawing.SystemColors.Control;
                label1.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            }
        }
        private void btnDangNhap_click(object sender, EventArgs e)
        {
            this.Hide();
            Login UI = new Login();
            UI.Show();
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thoát chương trình", "Thông báo");
                Application.Exit();
            }
        }
        private void ClearTextBox()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtDienThoai.Text = "";
        }

        private string duongDanAnh = "";
        private void btnChonAnhDaiDien_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                duongDanAnh = openFileDialog1.FileName;

                pictureBox2.Image = Image.FromFile(duongDanAnh);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private byte[] ChuyenDoiHinhAnh(string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    return File.ReadAllBytes(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc hình ảnh: " + ex.Message);
            }

            return null;
        }


        private ConnectToSQL conn = new ConnectToSQL();
        private void btnDangKy_click(object sender, EventArgs e)
        {
            try
            {
                conn.MoKetNoi();
                string tkMoi = txtUserName.Text;
                string mkMoi = txtPassword.Text;
                string mkXacNhan = txtPassword2.Text;
                string hoTen = txtHoTen.Text;
                string namSinh = txtNgaySinh.Text;
                string gioiTinh = txtGioiTinh.Text;
                string diaChi = txtDiaChi.Text;
                string email = txtEmail.Text;
                byte[] avatar = ChuyenDoiHinhAnh(duongDanAnh);

                if (mkMoi != mkXacNhan)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp. Vui lòng nhập lại.", "Sai mật khẩu");
                    return;
                }

                string truyVanKiemTraKhachHang = "SELECT COUNT(*) FROM KhachHang WHERE TenTaiKhoan=@tkMoi";

                using (SqlCommand cmdKiemTraKhachHang = new SqlCommand(truyVanKiemTraKhachHang, conn.KetNoi))
                {
                    cmdKiemTraKhachHang.Parameters.AddWithValue("@tkMoi", tkMoi);
                    int soLuongKhachHang = (int)cmdKiemTraKhachHang.ExecuteScalar();

                    if (soLuongKhachHang > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.");
                        return;
                    }
                }

                string truyVanThemMoiKhachHang = "INSERT INTO KhachHang (HoTen, NamSinh, GioiTinh, DiaChi, DienThoai, TenTaiKhoan, Email, Password, Avatar) " +
                                                "VALUES (@hoTen, @NamSinh, @gioiTinh, @diaChi, '', @tkMoi, @email, @mkMoi, @avatar)";
                using (SqlCommand cmdThemMoiKhachHang = new SqlCommand(truyVanThemMoiKhachHang, conn.KetNoi))
                {
                    cmdThemMoiKhachHang.Parameters.AddWithValue("@hoTen", hoTen);
                    cmdThemMoiKhachHang.Parameters.AddWithValue("@NamSinh", namSinh);
                    cmdThemMoiKhachHang.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                    cmdThemMoiKhachHang.Parameters.AddWithValue("@diaChi", diaChi);
                    cmdThemMoiKhachHang.Parameters.AddWithValue("@tkMoi", tkMoi);
                    cmdThemMoiKhachHang.Parameters.AddWithValue("@email", email);
                    cmdThemMoiKhachHang.Parameters.AddWithValue("@mkMoi", mkMoi);
                    cmdThemMoiKhachHang.Parameters.AddWithValue("@avatar", avatar);
                    cmdThemMoiKhachHang.ExecuteNonQuery();
                }

                MessageBox.Show("Đăng ký thành công");
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc thêm dữ liệu: " + ex.Message);
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
          nv.ChiNhapSo(e);
        }

    }
}
