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
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                panelMain.BackColor = Color.FromArgb(51, 51, 51);
                label1.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                panel1.BackgroundImage = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\5166950.jpg");

            }
            else
            {
                panelMain.BackColor = System.Drawing.SystemColors.Control;
                label1.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                panel1.BackgroundImage = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\5153829.jpg");
            }
        }

        private void btnDangNhap_click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=Trunq;Initial Catalog=ql_resort;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string tk = txtUserName.Text;
                    string mk = txtPassword.Text;
                    string sql = "SELECT * FROM KhachHang WHERE TenTaiKhoan=@tk AND Password=@mk";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tk", tk);
                        cmd.Parameters.AddWithValue("@mk", mk);

                        using (SqlDataAdapter dta = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            dta.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
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
        }

        private void btnDangKy_click(object sender, EventArgs e)
        {
            this.Hide();
            Dangky UI = new Dangky();
            UI.Show();
        }

    }
}
