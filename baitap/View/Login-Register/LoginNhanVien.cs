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
    public partial class LoginNhanVien : KryptonForm
    {
        private ConnectToSQL conn = new ConnectToSQL();
        public LoginNhanVien()
        {
            InitializeComponent();

        }

        private void LoginNhanVien_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=Trunq;Initial Catalog=ql_resort;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    string taikhoan = txtUserName1.Texts;
                    string matkhau = txtPassword1.Texts;
                    string selectSql = "SELECT * FROM NhanVien WHERE TenTaiKhoan=@taikhoan AND MatKhau=@matkhau";

                    using (SqlCommand selectCmd = new SqlCommand(selectSql, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                        selectCmd.Parameters.AddWithValue("@matkhau", matkhau);

                        using (SqlDataAdapter dta = new SqlDataAdapter(selectCmd))
                        {
                            DataTable dataTable = new DataTable();
                            dta.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                Session.TenTaiKhoan = taikhoan;
                                string tenTaiKhoan = dataTable.Rows[0]["TenTaiKhoan"].ToString();

                                string insertSql = "INSERT INTO ThongTinDangNhap (TenTaiKhoan, ThoiGianDangNhap) VALUES (@tenTaiKhoan, GETDATE())";
                                using (SqlCommand insertCmd = new SqlCommand(insertSql, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);
                                    insertCmd.ExecuteNonQuery();
                                }

                                this.Hide();
                                frmMain2 main2 = new frmMain2();
                                main2.Show();

                                MessageBox.Show("Đăng nhập thành công");
                            }
                            else if (string.IsNullOrEmpty(txtUserName1.Text) || string.IsNullOrEmpty(txtPassword1.Text))
                            {
                                txtUserName1.Text = "";
                                txtPassword1.Text = "";
                                MessageBox.Show("Bạn cần điền đủ thông tin đăng nhập để có thể tiếp tục", "Thiếu thông tin đăng nhập");
                            }
                            else
                            {
                                txtUserName1.Text = "";
                                txtPassword1.Text = "";
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
    }
}
