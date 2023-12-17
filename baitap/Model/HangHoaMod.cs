using baitap.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap.Model
{
    internal class HangHoaMod
    {
        ConnectToSQL conn = new ConnectToSQL();
        public DataTable LayDuLieuHangHoa()
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM HangHoa", conn.KetNoi))
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
        public bool ThemDuLieuHangHoa(HanghoaObj hhObj)
        {

            using (SqlCommand cmd = new SqlCommand("INSERT INTO HangHoa (SoLuong, DonGia, TenHangHoa) " +
                                                  "VALUES (@SoLuong, @DonGia, @TenHangHoa)", conn.KetNoi))
            {
                SetKhachHangParameters(cmd, hhObj);

                try
                {
                    conn.MoKetNoi();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc thêm dữ liệu", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return false;
        }

        public void CapNhatDuLieuHangHoa(HanghoaObj hhObj)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE HangHoa SET SoLuong = @SoLuong, DonGia = @DonGia, TenHangHoa = @TenHangHoa, " +
                                                  "WHERE ID = @ID", conn.KetNoi))
            {
                SetKhachHangParameters(cmd, hhObj);
                cmd.Parameters.AddWithValue("@ID", hhObj.MaHangHoa);

                try
                {
                    conn.MoKetNoi();
                    int soDongAnhHuong = cmd.ExecuteNonQuery();

                    if (soDongAnhHuong > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc cập nhật dữ liệu", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }
        }

        public bool XoaDuLieuHangHoa(string id)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM HangHoa WHERE ID = @ID", conn.KetNoi))
            {
                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    conn.MoKetNoi();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc xóa dữ liệu", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return false;
        }
        private void SetKhachHangParameters(SqlCommand cmd, HanghoaObj hhObj)
        {
            cmd.Parameters.AddWithValue("@SoLuong", hhObj.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", hhObj.DonGia);
            cmd.Parameters.AddWithValue("@TenHangHoa", hhObj.TenHangHoa);
        }


        private void XuLyLoi(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
