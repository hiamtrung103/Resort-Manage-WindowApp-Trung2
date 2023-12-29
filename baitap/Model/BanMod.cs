using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using baitap.Object;

namespace baitap.Model
{
    class BanMod
    {
        public ConnectToSQL conn = new ConnectToSQL();

        public DataTable LayDuLieuBan()
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Ban", conn.KetNoi))
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

        public bool ThemDuLieuBan(BanObj banObj)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Ban (MaBan, TenBan, Lau, Gia, TrangThai) " +
                                                  "VALUES (@MaBan, @TenBan, @Lau, @Gia, @TrangThai)", conn.KetNoi))
            {
                DuLieuBanParameter(cmd, banObj);

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

        public void CapNhatDuLieuBan(BanObj banObj)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Ban SET TenBan = @TenBan, Lau = @Lau, Gia = @Gia, TrangThai = @TrangThai WHERE MaBan = @MaBan", conn.KetNoi))
            {
                DuLieuBanParameter(cmd, banObj);

                try
                {
                    conn.MoKetNoi();
                    int soDongAnhHuong = cmd.ExecuteNonQuery();

                    if (soDongAnhHuong > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu phòng thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu phòng nào được cập nhật.");
                    }
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc cập nhật dữ liệu phòng", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }
        }

        public bool XoaDuLieuBan(string maBan)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Ban WHERE MaBan = @MaBan", conn.KetNoi))
            {
                cmd.Parameters.AddWithValue("@MaBan", maBan);

                try
                {
                    conn.MoKetNoi();
                    int soDongAnhHuong = cmd.ExecuteNonQuery();

                    if (soDongAnhHuong > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu phòng thành công.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu phòng nào được xóa.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc xóa dữ liệu phòng", ex);
                    return false;
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }
        }

        private void DuLieuBanParameter(SqlCommand cmd, BanObj banObj)
        {
            cmd.Parameters.AddWithValue("@MaBan", banObj.MaBan);
            cmd.Parameters.AddWithValue("@TenBan", banObj.TenBan);
            cmd.Parameters.AddWithValue("@Lau", banObj.Lau);
            cmd.Parameters.AddWithValue("@Gia", banObj.Gia);
            cmd.Parameters.AddWithValue("@TrangThai", banObj.TrangThai);
        }

        private void XuLyLoi(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
