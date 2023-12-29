using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using baitap.Object;
using OfficeOpenXml;

namespace baitap.Model
{
    internal class HoaDonMod
    {
        private ConnectToSQL conn = new ConnectToSQL();

        public DataTable LayDuLieuHoaDon()
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Bill", conn.KetNoi))
            {
                try
                {
                    conn.MoKetNoi();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
                catch (Exception ex)
                {
                    HandleError("Lỗi kết nối hoặc đọc dữ liệu", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return dt;
        }

        public bool ThemDuLieuHoaDon(HoadonObj billObj)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Bill (TenKhachHang, ThucUong, SoLuong, DonGia, ThanhTien, ThoiGian) " +
                                                  "VALUES (@TenKhachHang, @ThucUong, @SoLuong, @DonGia, @ThanhTien, @ThoiGian)", conn.KetNoi))
            {
                DuLieuHoaDonParameter(cmd, billObj);

                try
                {
                    conn.MoKetNoi();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    HandleError("Lỗi kết nối hoặc thêm dữ liệu", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return false;
        }

        private void DuLieuHoaDonParameter(SqlCommand cmd, HoadonObj billObj)
        {
            cmd.Parameters.AddWithValue("@TenKhachHang", billObj.TenKhachHang);
            cmd.Parameters.AddWithValue("@ThucUong", billObj.ThucUong);
            cmd.Parameters.AddWithValue("@SoLuong", billObj.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", billObj.DonGia);
            cmd.Parameters.AddWithValue("@ThanhTien", billObj.ThanhTien);
            cmd.Parameters.AddWithValue("@ThoiGian", billObj.ThoiGian);
        }

        private void HandleError(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}