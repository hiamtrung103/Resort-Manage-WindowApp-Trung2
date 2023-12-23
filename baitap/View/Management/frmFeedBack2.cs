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

namespace baitap.View.Management
{
    public partial class frmFeedBack2 : Form
    {
        private ConnectToSQL conn = new ConnectToSQL();
        public frmFeedBack2()
        {
            InitializeComponent();
        }

        private void frmFeedBack2_Load(object sender, EventArgs e)
        {
            HienThiFeedback();
        }

        private void HienThiFeedback()
        {
            dataGridViewFeedback.DataSource = LayDuLieu("SELECT * FROM Feedback");
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
        private void XuLyLoi(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridViewFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewFeedback.Rows[e.RowIndex];
                if (row != null)
                {
                    txtHoTen.Texts = row.Cells["TenKhachHang"].Value?.ToString();
                    txtTrangThai.Texts = row.Cells["TrangThai"].Value?.ToString();
                    lbTieuDe.Text = row.Cells["TieuDe"].Value?.ToString();
                    txtPhanHoi.Text = row.Cells["PhanHoi"].Value?.ToString();
                    lbThoiGian.Text = row.Cells["NgayGui"].Value?.ToString();
                }
            }
        }

    }
}
