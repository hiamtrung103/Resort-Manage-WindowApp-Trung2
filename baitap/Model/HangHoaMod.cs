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
            using (SqlCommand cmd = new SqlCommand("UPDATE HangHoa SET SoLuong = @SoLuong, DonGia = @DonGia, TenHangHoa = @TenHangHoa " +
                                                  "WHERE ID = @ID", conn.KetNoi))
            {
                SetKhachHangParameters(cmd, hhObj);
                cmd.Parameters.AddWithValue("@ID", hhObj.MaHangHoa);

                try
                {
                    conn.MoKetNoi();
                    int soDongAnhHuong = cmd.ExecuteNonQuery();
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

        public void CapNhatAvatar(string maHangHoa, byte[] avatar)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE HangHoa SET Avatar = @Avatar WHERE ID = @ID", conn.KetNoi))
            {
                cmd.Parameters.AddWithValue("@ID", maHangHoa);
                cmd.Parameters.AddWithValue("@Avatar", avatar);

                try
                {
                    conn.MoKetNoi();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc cập nhật dữ liệu hàng hóa", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }
        }

        public HanghoaObj LayThongTinHangHoa(string tenHangHoa)
        {
            HanghoaObj hhObj = new HanghoaObj();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM HangHoa WHERE TenHangHoa = @TenHangHoa", conn.KetNoi))
            {
                cmd.Parameters.AddWithValue("@TenHangHoa", tenHangHoa);

                try
                {
                    conn.MoKetNoi();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hhObj.MaHangHoa = reader["ID"].ToString();
                            hhObj.SoLuong = int.Parse(reader["SoLuong"].ToString());
                            hhObj.DonGia = int.Parse(reader["DonGia"].ToString());
                            hhObj.TenHangHoa = reader["TenHangHoa"].ToString();

                            if (reader["Avatar"] != DBNull.Value)
                            {
                                hhObj.Avatar = (byte[])reader["Avatar"];
                            }
                            else
                            {
                                hhObj.Avatar = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc đọc dữ liệu hàng hóa", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return hhObj;
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
