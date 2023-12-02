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
    class KhachHangCtr
    {
        class KhachHangControl
        {
            KhachHangMod khMod = new KhachHangMod();
            public string tinnhanLoi { get; private set; }

            public DataTable GetData()
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

            public bool AddData(KhachHangObj khObj)
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

            public bool DelData(string id)
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
        }
    }
}
