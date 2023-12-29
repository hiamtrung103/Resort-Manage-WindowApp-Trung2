using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using baitap.Control;
using baitap.Model;
using baitap.Object;

namespace baitap.View
{
    public partial class frmTrangChu2 : Form
    {
        private ConnectToSQL conn = new ConnectToSQL();

        public frmTrangChu2()
        {
            InitializeComponent();
        }

        private void frmTrangChu2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LayDuLieu("SELECT * FROM ThongTinDangNhap");
            dataGridViewFeedback.DataSource = LayDuLieu("SELECT ID, TrangThai, NgayGui FROM Feedback");
            dataGridView2.DataSource = LayDuLieu("SELECT ID, TenKhachHang, ThoiGian FROM Bill");


            lbID.Text = $"{LayTongSoID("SELECT COUNT(ID) FROM KhachHang")}";
            lbID2.Text = $"{LayTongSoID("SELECT COUNT(ID) FROM NhanVien")}";
            lbID6.Text = $"{LayTongSoID("SELECT COUNT(ID) FROM Bill")}";
            lbID4.Text = $"{LayTongSoID("SELECT COUNT(ID) FROM Feedback")}";
        }

        private DataTable LayDuLieu(string query)
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand(query, conn.KetNoi))
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

            return dt;
        }

        private int LayTongSoID(string query)
        {
            int tongSoID = 0;

            using (SqlCommand cmd = new SqlCommand(query, conn.KetNoi))
            {
                try
                {
                    conn.MoKetNoi();
                    tongSoID = (int)cmd.ExecuteScalar();
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

            return tongSoID;
        }
        private void XuLyLoi(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
