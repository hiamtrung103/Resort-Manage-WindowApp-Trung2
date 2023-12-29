using baitap.Model;
using baitap.Object;
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
    public partial class Login : Form
    {
        private ConnectToSQL conn = new ConnectToSQL();
        public static string TenTaiKhoanDangNhap { get; private set; }
        private bool isDarkMode = false;

        public Login()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(menu, menu.Width, 0);
        }

        private void chếĐộTốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatTatMode();
        }

        private void BatTatMode()
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                CheDoToi();
            }
            else
            {
                CheDoSang();
            }
        }

        private void CheDoToi()
        {
            panelMain.BackColor = Color.FromArgb(51, 51, 51);
            ApDungMaulb(Color.White);
            panel1.BackgroundImage = Properties.Resources._5166950;
        }

        private void CheDoSang()
        {
            panelMain.BackColor = SystemColors.Control;
            ApDungMaulb(Color.Black);
            panel1.BackgroundImage = Properties.Resources._5153829;
        }
        private void ApDungMaulb(Color color)
        {
            label1.ForeColor = color;
            label4.ForeColor = color;
            label5.ForeColor = color;
            label6.ForeColor = color;
            label7.ForeColor = color;
            label8.ForeColor = color;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
                try
                {
                    conn.MoKetNoi();
                    string tk = txtUserName.Text;
                    string mk = txtPassword.Text;
                    string selectSql = "SELECT * FROM KhachHang WHERE TenTaiKhoan=@tk AND Password=@mk";

                    using (SqlCommand selectCmd = new SqlCommand(selectSql, conn.KetNoi))
                    {
                        selectCmd.Parameters.AddWithValue("@tk", tk);
                        selectCmd.Parameters.AddWithValue("@mk", mk);

                        using (SqlDataAdapter dta = new SqlDataAdapter(selectCmd))
                        {
                            DataTable dataTable = new DataTable();
                            dta.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                Session.TenTaiKhoan = tk;
                                string tenTaiKhoan = dataTable.Rows[0]["TenTaiKhoan"].ToString();

                                string insertSql = "INSERT INTO ThongTinDangNhap (TenTaiKhoan, ThoiGianDangNhap) VALUES (@tenTaiKhoan, GETDATE())";
                                using (SqlCommand insertCmd = new SqlCommand(insertSql, conn.KetNoi))
                                {
                                    insertCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);
                                    insertCmd.ExecuteNonQuery();
                                }

                                this.Hide();
                                loadingUI UI = new loadingUI();
                                UI.Show();

                                MessageBox.Show("Đăng nhập thành công");
                            }
                            else if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
                            {
                                txtUserName.Text = "";
                                txtPassword.Text = "";
                                MessageBox.Show("Bạn cần điền đủ thông tin đăng nhập để có thể tiếp tục", "Thiếu thông tin đăng nhập");
                            }
                            else
                            {
                                txtUserName.Text = "";
                                txtPassword.Text = "";
                                MessageBox.Show("Đăng nhập thất bại");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
        }

        private void btnDangKy_click(object sender, EventArgs e)
        {
            this.Hide();
            Register UI = new Register();
            UI.Show();
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginNhanVien loginNhanVien = new LoginNhanVien();
            loginNhanVien.Show();
        }

        private void lbQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }
    }
}
