using System;
using System.Data;
using System.Windows.Forms;
using baitap.Model;
using baitap.Object;

namespace baitap.Control
{
    internal class BanCtr
    {
        private BanMod banMod = new BanMod();

        public DataTable LayDuLieuBan()
        {
            try
            {
                return banMod.LayDuLieuBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool ThemDuLieuBan(BanObj banObj)
        {
            try
            {
                return banMod.ThemDuLieuBan(banObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void CapNhatDuLieuBan(BanObj banObj)
        {
            try
            {
                banMod.CapNhatDuLieuBan(banObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool XoaDuLieuBan(string maBan)
        {
            try
            {
                return banMod.XoaDuLieuBan(maBan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
