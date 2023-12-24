using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using baitap.Object;

namespace baitap.Model
{
    class NhanVienMod
    {
        public ConnectToSQL conn = new ConnectToSQL();

        public DataTable LayDuLieuNhanVien()
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn.KetNoi))
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

        public bool KiemTraTonTai(string tenTaiKhoan, string email)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NhanVien WHERE TenTaiKhoan = @TenTaiKhoan OR email = @Email", conn.KetNoi))
            {
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    conn.MoKetNoi();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc kiểm tra tài khoản/email", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return false;
        }

        public bool ThemDuLieuNhanVien(NhanvienObj nvobj)
        {
            if (KiemTraTonTai(nvobj.TenTaiKhoan, nvobj.Email))
            {
                MessageBox.Show("Tài khoản hoặc email đã tồn tại. Vui lòng chọn tài khoản hoặc email khác.");
                return false;
            }
            using (SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien (HoTen, GioiTinh, NamSinh, DiaChi, DienThoai, MatKhau, TenTaiKhoan, quyenhan, email) " +
                                                  "VALUES (@TenNhanVien, @GioiTinh, @NamSinh, @DiaChi, @DienThoai, @MatKhau, @TenTaiKhoan, @QuyenHan, @Email)", conn.KetNoi))
            {
                DuLieuNhanVienParameter(cmd, nvobj);

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

        public void CapNhatDuLieuNhanVien(NhanvienObj nvobj)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET HoTen = @TenNhanVien, GioiTinh = @GioiTinh, NamSinh = @NamSinh, " +
                                                  "DiaChi = @DiaChi, DienThoai = @DienThoai, MatKhau = @MatKhau, QuyenHan = @QuyenHan, email = @Email WHERE ID = @ID", conn.KetNoi))
            {
                DuLieuNhanVienParameter(cmd, nvobj);
                cmd.Parameters.AddWithValue("@ID", nvobj.MaNhanVien);

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

        public bool XoaDuLieuNhanVien(string id)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE ID = @ID", conn.KetNoi))
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

        internal void CapNhatAvatar(string tenTaiKhoan, byte[] avatar)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET Avatar = @Avatar WHERE TenTaiKhoan = @TenTaiKhoan", conn.KetNoi))
            {
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                cmd.Parameters.AddWithValue("@Avatar", avatar);
                try
                {
                    conn.MoKetNoi();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật dữ liệu cá nhân thành công.", "Thông báo");
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc cập nhật dữ liệu cá nhân", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }
        }

        private void DuLieuNhanVienParameter(SqlCommand cmd, NhanvienObj nvobj)
        {
            cmd.Parameters.AddWithValue("@TenNhanVien", nvobj.TenNhanVien);
            cmd.Parameters.AddWithValue("@GioiTinh", nvobj.GioiTinh);
            cmd.Parameters.AddWithValue("@NamSinh", nvobj.NamSinh);
            cmd.Parameters.AddWithValue("@DiaChi", nvobj.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", nvobj.DienThoai);
            cmd.Parameters.AddWithValue("@MatKhau", nvobj.MatKhau);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", nvobj.TenTaiKhoan);
            cmd.Parameters.AddWithValue("@Email", nvobj.Email);
            cmd.Parameters.AddWithValue("@QuyenHan", nvobj.QuyenHan);
        }

        private void XuLyLoi(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
