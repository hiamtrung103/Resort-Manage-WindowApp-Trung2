using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using baitap.Control;
using baitap.Model;
using baitap.Object;

namespace baitap.View
{
    public partial class frmDanhGia : Form
    {
        private ConnectToSQL conn = new ConnectToSQL();
        private string luaChonDanhGia = "";

        public frmDanhGia()
        {
            InitializeComponent();
        }

        private void FeedBack_RatTe_Click(object sender, EventArgs e)
        {
            lbFeedBack.Text = "Tôi cảm thấy rất tệ";
            luaChonDanhGia = lbFeedBack.Text;
        }

        private void FeedBack_NhamChan_Click(object sender, EventArgs e)
        {
            lbFeedBack.Text = "Tôi cảm thấy rất nhàm chán";
            luaChonDanhGia = lbFeedBack.Text;
        }

        private void FeedBack_BinhThuong_Click(object sender, EventArgs e)
        {
            lbFeedBack.Text = "Tôi cảm thấy bình thường";
            luaChonDanhGia = lbFeedBack.Text;
        }

        private void FeedBack_VuiVe_Click(object sender, EventArgs e)
        {
            lbFeedBack.Text = "Tôi cảm thấy khá vui";
            luaChonDanhGia = lbFeedBack.Text;
        }

        private void FeedBack_RatVuiVe_Click(object sender, EventArgs e)
        {
            lbFeedBack.Text = "Tôi cảm thấy rất vui";
            luaChonDanhGia = lbFeedBack.Text;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(luaChonDanhGia))
            {
                MessageBox.Show("Vui lòng chọn một đánh giá trước khi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string tenKhachHang = txtHoTen.Text;
                string trangThai = luaChonDanhGia;
                string tieuDe = txtTieuDe.Text;
                string phanHoi = txtPhanHoi.Text;
                DateTime ngayGui = DateTime.Now;

                if (!DaDanhGia(tenKhachHang))
                {
                    string chenFeedbackSql = "INSERT INTO feedback (TenKhachHang, TrangThai, TieuDe, PhanHoi, NgayGui, TenTaiKhoan) VALUES (@tenKhachHang, @trangThai, @tieuDe, @phanHoi, @ngayGui, @tenTaiKhoan)";
                    using (SqlCommand chenFeedbackCmd = new SqlCommand(chenFeedbackSql, conn.KetNoi))
                    {
                        conn.MoKetNoi();
                        chenFeedbackCmd.Parameters.AddWithValue("@tenKhachHang", tenKhachHang);
                        chenFeedbackCmd.Parameters.AddWithValue("@trangThai", trangThai);
                        chenFeedbackCmd.Parameters.AddWithValue("@tieuDe", tieuDe);
                        chenFeedbackCmd.Parameters.AddWithValue("@phanHoi", phanHoi);
                        chenFeedbackCmd.Parameters.AddWithValue("@ngayGui", ngayGui);
                        chenFeedbackCmd.Parameters.AddWithValue("@tenTaiKhoan", Session.TenTaiKhoan);

                        int FeedBackChuaDu = chenFeedbackCmd.ExecuteNonQuery();

                        if (FeedBackChuaDu > 0)
                        {
                            MessageBox.Show("Đánh giá đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể lưu đánh giá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã đánh giá trước đó, chỉ được đánh giá một lần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi("Lỗi khi lưu đánh giá", ex);
            }
            finally
            {
                conn.DongKetNoi();
            }
        }

        private bool DaDanhGia(string tenKhachHang)
        {
            string kiemTraFeedbackSql = "SELECT COUNT(*) FROM feedback WHERE TenKhachHang = @tenKhachHang AND TenTaiKhoan = @tenTaiKhoan";
            using (SqlCommand kiemTraFeedbackCmd = new SqlCommand(kiemTraFeedbackSql, conn.KetNoi))
            {
                kiemTraFeedbackCmd.Parameters.AddWithValue("@tenKhachHang", tenKhachHang);
                kiemTraFeedbackCmd.Parameters.AddWithValue("@tenTaiKhoan", Session.TenTaiKhoan);

                conn.MoKetNoi();
                int soLuongDanhGia = (int)kiemTraFeedbackCmd.ExecuteScalar();
                return soLuongDanhGia > 0;
            }
        }


        private void XuLyLoi(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmDanhGia_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                string selectKhachHangSql = "SELECT * FROM KhachHang WHERE TenTaiKhoan=@tenTaiKhoan";
                using (SqlCommand selectKhachHangCmd = new SqlCommand(selectKhachHangSql, conn.KetNoi))
                {
                    conn.MoKetNoi();
                    selectKhachHangCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);

                    using (SqlDataAdapter khachHangDataAdapter = new SqlDataAdapter(selectKhachHangCmd))
                    {
                        DataTable khachHangDataTable = new DataTable();
                        khachHangDataAdapter.Fill(khachHangDataTable);

                        if (khachHangDataTable.Rows.Count > 0)
                        {
                            txtHoTen.Text = khachHangDataTable.Rows[0]["HoTen"].ToString();
                        }
                    }
                }
            }
        }
    }
}
