using baitap.Object;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace baitap.Model
{
    class KhachHangMod
    {
        private ConnectToSQL conn = new ConnectToSQL();
        private SqlCommand cmd = new SqlCommand();

        public DataTable LayDuLieuKhachHang()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "SELECT * FROM KhachHang";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            try
            {
                conn.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc đọc dữ liệu: " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.CloseConn();
            }

            return dt;
        }

        public bool ThemDuLieuKhachHang(KhachHangObj khObj)
        {
            cmd.CommandText = "INSERT INTO KhachHang (HoTen, GioiTinh, NamSinh, DiaChi, DienThoai, TenTaiKhoan, Email, Password, MaGiamGia) " +
                              "VALUES (@HoTen, @GioiTinh, @NamSinh, @DiaChi, @DienThoai, @TenTaiKhoan, @Email, @Password, @MaGiamGia)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@HoTen", khObj.HoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", khObj.GioiTinh);
            cmd.Parameters.AddWithValue("@NamSinh", khObj.NamSinh);
            cmd.Parameters.AddWithValue("@DiaChi", khObj.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", khObj.DienThoai);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", khObj.TenTaiKhoan);
            cmd.Parameters.AddWithValue("@Email", khObj.Email);
            cmd.Parameters.AddWithValue("@Password", khObj.Password);
            cmd.Parameters.AddWithValue("@MaGiamGia", khObj.MaGiamGia);

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.CloseConn();
            }

            return false;
        }

        public void CapNhatDuLieuKhachHang(KhachHangObj khObj)
        {
            cmd.CommandText = "UPDATE KhachHang SET HoTen = @HoTen, GioiTinh = @GioiTinh, NamSinh = @NamSinh, " +
                              "DiaChi = @DiaChi, DienThoai = @DienThoai, TenTaiKhoan = @TenTaiKhoan, Email = @Email, Password = @Password, MaGiamGia = @MaGiamGia" +
                              "WHERE ID = @ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@HoTen", khObj.HoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", khObj.GioiTinh);
            cmd.Parameters.AddWithValue("@NamSinh", khObj.NamSinh);
            cmd.Parameters.AddWithValue("@DiaChi", khObj.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", khObj.DienThoai);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", khObj.TenTaiKhoan);
            cmd.Parameters.AddWithValue("@Email", khObj.Email);
            cmd.Parameters.AddWithValue("@Password", khObj.Password);
            cmd.Parameters.AddWithValue("@MaGiamGia", khObj.MaGiamGia);
            cmd.Parameters.AddWithValue("@ID", khObj.MaKhachHang);

            try
            {
                conn.OpenConn();
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
                MessageBox.Show("Lỗi kết nối hoặc cập nhật dữ liệu: " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.CloseConn();
            }
        }

        public bool XoaDuLieuKhachHang(string id)
        {
            cmd.CommandText = "DELETE FROM KhachHang WHERE ID = @ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);

            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.CloseConn();
            }

            return false;
        }
    }
}
