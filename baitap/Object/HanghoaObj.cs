using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap.Object
{
    public class HanghoaObj
    {
        public string MaHangHoa { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public string TenHangHoa { get; set; }
        public byte[] Avatar { get; set; } 

        public HanghoaObj() { }
        public HanghoaObj(string ma, int sl, int dg, string tenhh, byte[] avatar)
        {
            MaHangHoa = ma;
            SoLuong = sl;
            DonGia = dg;
            TenHangHoa = tenhh;
            Avatar = avatar;
        }
    }
}
