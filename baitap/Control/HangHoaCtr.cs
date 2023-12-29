using baitap.Model;
using baitap.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap.Control
{
    internal class HangHoaCtr
    {
        private HangHoaMod hhMod = new HangHoaMod();
        public DataTable LayDuLieuHangHoa()
        {
            try
            {
                return hhMod.LayDuLieuHangHoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool ThemDuLieuHangHoa(HanghoaObj hhobj)
        {
            try
            {
                return hhMod.ThemDuLieuHangHoa(hhobj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool XoaDuLieuHangHoa(string id)
        {
            try
            {
                return hhMod.XoaDuLieuHangHoa(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void CapNhatDuLieuHangHoa(HanghoaObj hhobj)
        {
            try
            {
                hhMod.CapNhatDuLieuHangHoa(hhobj);
                MessageBox.Show("Cập nhật dữ liệu thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CapNhatAvatar(string maHangHoa, byte[] avatar)
        {
            try
            {
                hhMod.CapNhatAvatar(maHangHoa, avatar);
                MessageBox.Show("Cập nhật hình ảnh hàng hóa thành công.", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật hình ảnh hàng hóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
