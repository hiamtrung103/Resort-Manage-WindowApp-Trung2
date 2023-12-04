using baitap.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmDanhGia : Form
    {
        private frmKhachHang kh = new frmKhachHang();
        private ConnectToSQL conn = new ConnectToSQL();
        public frmDanhGia()
        {
            InitializeComponent();
        }

        private void FeedBack_RatTe_Click(object sender, EventArgs e)
        {
            lbFeedBack.Text = "Tôi cảm thấy chuyến đi rất tệ";
        }

        private void FeedBack_NhamChan_Click(object sender, EventArgs e)
        {
            lbFeedBack.Text = "Tôi cảm thấy chuyến đi rấ nhàm chán";

        }

        private void FeedBack_BinhThuong_Click(object sender, EventArgs e)
        {
            lbFeedBack.Text = "Tôi cảm thấy chuyến đi bình thường";

        }

        private void FeedBack_VuiVe_Click(object sender, EventArgs e)
        {
            lbFeedBack.Text = "Tôi cảm thấy chuyến đi khá vui";

        }

        private void FeedBack_RatVuiVe_Click(object sender, EventArgs e)
        {
            lbFeedBack.Text = "Tôi cảm thấy chuyến đi rất vui";

        }

    }
}
