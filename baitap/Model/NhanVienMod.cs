using baitap.Object;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace baitap.Model
{
    class NhanVienMod
    {
        ConnectToSQL conn = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable LayDuLieuNhanVien()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM NhanVien";
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

        public bool ThemDuLieuNhanVien(NhanvienObj nvobj)
        {
            cmd.CommandText = "INSERT INTO NhanVien (ho_ten, gioi_tinh, nam_sinh, dia_chi, sdt, mat_khau, ten_tai_khoan, quyen_han, email) " +
                              "VALUES (@TenNhanVien, @GioiTinh, @NamSinh, @DiaChi, @DienThoai, @MatKhau, @TenTaiKhoan, @QuyenHan, @Email)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TenNhanVien", nvobj.TenNhanVien);
            cmd.Parameters.AddWithValue("@GioiTinh", nvobj.GioiTinh);
            cmd.Parameters.AddWithValue("@NamSinh", nvobj.NamSinh);
            cmd.Parameters.AddWithValue("@DiaChi", nvobj.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", nvobj.DienThoai);
            cmd.Parameters.AddWithValue("@MatKhau", nvobj.MatKhau);
            cmd.Parameters.AddWithValue("@TenTaiKhoan", nvobj.TenTaiKhoan);
            cmd.Parameters.AddWithValue("@Email", nvobj.Email);
            cmd.Parameters.AddWithValue("@QuyenHan", nvobj.QuyenHan);

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


        public void CapNhatDuLieuNhanVien(NhanvienObj nvobj)
        {
            cmd.CommandText = "UPDATE NhanVien SET ho_ten = @TenNhanVien, gioi_tinh = @GioiTinh, nam_sinh = @NamSinh, " +
                              "dia_chi = @DiaChi, sdt = @DienThoai, mat_khau = @MatKhau, quyen_han = @QuyenHan, email = @Email WHERE ID = @ID";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@TenNhanVien", nvobj.TenNhanVien);
            cmd.Parameters.AddWithValue("@GioiTinh", nvobj.GioiTinh);
            cmd.Parameters.AddWithValue("@NamSinh", nvobj.NamSinh);
            cmd.Parameters.AddWithValue("@DiaChi", nvobj.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", nvobj.DienThoai);
            cmd.Parameters.AddWithValue("@MatKhau", nvobj.MatKhau);
            cmd.Parameters.AddWithValue("@QuyenHan", nvobj.QuyenHan);
            cmd.Parameters.AddWithValue("@Email", nvobj.Email);
            cmd.Parameters.AddWithValue("@ID", nvobj.MaNhanVien);

            try
            {
                conn.OpenConn();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
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

        public bool XoaDuLieuNhanVien(string id)
        {
            cmd.CommandText = "DELETE FROM NhanVien WHERE ID = @ID";
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
