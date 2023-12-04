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
        private void XuLyLoi(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataTable LayDuLieuKhachHang()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(conn.StrCon))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ThongTinDangNhap", connection))
                {
                    try
                    {
                        conn.MoKetNoi();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        XuLyLoi("Lỗi kết nối hoặc đọc dữ liệu", ex);
                    }
                    finally
                    {
                        conn.DongKetNoi();
                    }
                }
            }

            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LayDuLieuKhachHang();
            //LoadDataIntoDataGridView();
        }

        private void LoginNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LayDuLieuKhachHang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
