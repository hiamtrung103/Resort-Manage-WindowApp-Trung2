using System;
using System.Data;
using System.Windows.Forms;
using baitap.Model;
using baitap.Object;

namespace baitap.Control
{
    internal class NhanVienCtr
    {
        private NhanVienMod nvMod = new NhanVienMod();

        public DataTable LayDuLieuNhanVien()
        {
            try
            {
                return nvMod.LayDuLieuNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool ThemDuLieuNhanVien(NhanvienObj nvobj)
        {
            try
            {
                return nvMod.ThemDuLieuNhanVien(nvobj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool XoaDuLieuNhanVien(string id)
        {
            try
            {
                return nvMod.XoaDuLieuNhanVien(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void CapNhatDuLieuNhanVien(NhanvienObj nvobj)
        {
            try
            {
                nvMod.CapNhatDuLieuNhanVien(nvobj);
                MessageBox.Show("Cập nhật dữ liệu thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
