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
                panel1.BackgroundImage = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\sign-up2.jpg");

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
                panel1.BackgroundImage = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\sign-up1.jpg");
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

        private void btnDangKy_click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=Trunq;Initial Catalog=ql_resort;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string tkMoi = txtUserName.Text;
                    string mkMoi = txtPassword.Text;
                    string mkXacNhan = txtPassword2.Text;
                    string hoTen = txtHoTen.Text;
                    string namSinh = txtNgaySinh.Text;
                    string gioiTinh = txtGioiTinh.Text;
                    string diaChi = txtDiaChi.Text;
                    string email = txtEmail.Text;

                    if (mkMoi != mkXacNhan)
                    {
                        MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp. Vui lòng nhập lại.", "Sai mật khẩu");
                        return;
                    }

                    string truyVanKiemTraKhachHang = "SELECT COUNT(*) FROM KhachHang WHERE TenTaiKhoan=@tkMoi";

                    using (SqlCommand cmdKiemTraKhachHang = new SqlCommand(truyVanKiemTraKhachHang, conn))
                    {
                        cmdKiemTraKhachHang.Parameters.AddWithValue("@tkMoi", tkMoi);
                        int soLuongKhachHang = (int)cmdKiemTraKhachHang.ExecuteScalar();

                        if (soLuongKhachHang > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.");
                            return;
                        }
                    }

                    string truyVanThemMoiKhachHang = "INSERT INTO KhachHang (HoTen, NamSinh, GioiTinh, DiaChi, DienThoai, TenTaiKhoan, Email, Password) " +
                                                    "VALUES (@hoTen, @NamSinh, @gioiTinh, @diaChi, '', @tkMoi, @email, @mkMoi)";
                    using (SqlCommand cmdThemMoiKhachHang = new SqlCommand(truyVanThemMoiKhachHang, conn))
                    {
                        cmdThemMoiKhachHang.Parameters.AddWithValue("@hoTen", hoTen);
                        cmdThemMoiKhachHang.Parameters.AddWithValue("@NamSinh", namSinh);
                        cmdThemMoiKhachHang.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                        cmdThemMoiKhachHang.Parameters.AddWithValue("@diaChi", diaChi);
                        cmdThemMoiKhachHang.Parameters.AddWithValue("@tkMoi", tkMoi);
                        cmdThemMoiKhachHang.Parameters.AddWithValue("@email", email);
                        cmdThemMoiKhachHang.Parameters.AddWithValue("@mkMoi", mkMoi);
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
        }

    }
}
