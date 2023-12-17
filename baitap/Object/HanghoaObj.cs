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
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string TenHangHoa { get; set; }

        public HanghoaObj() { }
        public HanghoaObj(string ma, string sl, string dg, string tenhh) {
            MaHangHoa = ma;
            SoLuong = sl;
            DonGia = dg;
            TenHangHoa = tenhh;
        }
    }
}
