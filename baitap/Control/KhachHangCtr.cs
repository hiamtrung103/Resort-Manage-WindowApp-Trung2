using baitap.Model;
using baitap.Object;
using System.Data;

namespace baitap.Control
{
    class KhachHangCtr
    {
        private KhachHangMod khMod = new KhachHangMod();
        public string tinnhanLoi { get; private set; }

        public DataTable LayDuLieuKhachHang()
        {
            try
            {
                return khMod.LayDuLieuKhachHang();
            }
            catch (Exception ex)
            {
                tinnhanLoi = "Lỗi khi lấy dữ liệu: " + ex.Message;
                return null;
            }
        }

        public bool ThemDuLieuKhachHang(KhachHangObj khObj)
        {
            try
            {
                return khMod.ThemDuLieuKhachHang(khObj);
            }
            catch (Exception ex)
            {
                tinnhanLoi = "Lỗi khi thêm dữ liệu: " + ex.Message;
                return false;
            }
        }

        public bool XoaDuLieuKhachHang(string id)
        {
            try
            {
                return khMod.XoaDuLieuKhachHang(id);
            }
            catch (Exception ex)
            {
                tinnhanLoi = "Lỗi khi xóa dữ liệu: " + ex.Message;
                return false;
            }
        }

        public void CapNhatDuLieuKhachHang(KhachHangObj khObj)
        {
            try
            {
                khMod.CapNhatDuLieuKhachHang(khObj);
                tinnhanLoi = "Cập nhật dữ liệu thành công.";
            }
            catch (Exception ex)
            {
                tinnhanLoi = "Lỗi khi cập nhật dữ liệu: " + ex.Message;
            }
        }
    }
}
