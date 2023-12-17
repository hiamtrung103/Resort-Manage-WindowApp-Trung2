using baitap.Model;
using baitap.Object;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitap.View
{
    public partial class frmNhaHang : Form
    {
        private ConnectToSQL conn = new ConnectToSQL();
        public frmNhaHang()
        {
            InitializeComponent();
        }

        private void frmNhaHang_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                string selectKhachHangSql = "SELECT * FROM KhachHang WHERE TenTaiKhoan=@tenTaiKhoan";
                    using (SqlCommand selectKhachHangCmd = new SqlCommand(selectKhachHangSql, conn.KetNoi))
                    {
                        selectKhachHangCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);

                        using (SqlDataAdapter khachHangDataAdapter = new SqlDataAdapter(selectKhachHangCmd))
                        {
                            DataTable khachHangDataTable = new DataTable();
                            khachHangDataAdapter.Fill(khachHangDataTable);

                            if (khachHangDataTable.Rows.Count > 0)
                            {
                                txtHoTen.Text = khachHangDataTable.Rows[0]["HoTen"].ToString();
                                txtGioiTinh.Text = khachHangDataTable.Rows[0]["GioiTinh"].ToString();
                                txtNamSinh.Text = khachHangDataTable.Rows[0]["NamSinh"].ToString();
                                txtDiaChi.Text = khachHangDataTable.Rows[0]["DiaChi"].ToString();
                                txtDienThoai.Text = khachHangDataTable.Rows[0]["DienThoai"].ToString();
                                txtEmail.Text = khachHangDataTable.Rows[0]["Email"].ToString();
                                txtTen.Text = "Riverview Dining";
                            }
                        }
                    }
            }

        }

        private void card_1_Click(object sender, EventArgs e)
        {
            lbTen.Text = "Riverview Dining";
            lbGioiThieu.Text = "Đối thoại cùng ẩm thực ";
            lbMoTa.Text =
                "River View Dining với kiến trúc mở, mang đến không" +
                "\ngian tiệc tối thoáng đãng, không kém phần lãng mạn," +
                "\nnhư thể bạn chỉ cần vươn tay đã chạm đến trời sao." +
                "\n\nĐừng tự bó hẹp mình trong không gian của bốn bức" +
                "\ntường ngột ngạt, một chút gió trời và cảnh quan tự" +
                "\nnhiên sẽ giúp tìm lại sự an yên đích thực.Hãy đến" +
                "\nvới River View Dining để vừa nhìn ngắm Sài Gòn về" +
                "\nđêm lung linh trong ánh đèn huyền ảo, vừa thưởng" +
                "\nthức những món ăn nóng hổi. Hương vị phong phú" +
                "\ntrong sự giao thoa các nền ẩm thực thế giới hứa hẹn" +
                "\nmang lại những trải nghiệm vị giác phong phú và" +
                "\nkhơi gợi mạch nguồn cảm xúc trong tâm hồn mỗi người.";

            lbThoiGian.Text = "Thời gian phục vụ\r\n";
            lbMoTa2.Text = "Hoạt động từ 17:30 đến 23:30 mỗi ngày" +
                "\nTrải nghiệm vị giác phong phú với các món " +
                "\năn và rượu thượng hạng được phục vụ theo " +
                "\nthực đơn đặc biệt.";
            lbThoiGian2.Text = "";
            lbMoTa3.Text = "";
            txtTen.Text = "Riverview Dining";
            cardd.BackgroundImage = Properties.Resources.restaurant_1_1;

        }

        private void card_2_Click(object sender, EventArgs e)
        {
            lbTen.Text = "Red Chilli Seafood Buffet";
            lbGioiThieu.Text = "Đánh thức vị giác tìm về " +
                "\nhạnh phúc";
            lbMoTa.Text =
                "Lấy cảm hứng từ ký ức miền Viễn Đông pha trộn" +
                "\ngiữa yếu tố phương Tây hiện đại, Red Chilli sở" +
                "\nhữu cung cách bài trí độc đáo với tường gạch cổ" +
                "\nđiển, nội thất gỗ sang trọng và ánh nến ấm cúng." +
                "\nTại đây, mỗi món ăn là một công thức sáng tạo đầy" +
                "\ntâm huyết, là một câu chuyện được gửi gắm. Còn gì" +
                "\ntuyệt vời hơn khi cùng gia đình và ng thân thương" +
                "\nthương dùng bữa bên những bàn tiệc đẹp mắt, trải" +
                "\nnghiệm phong cách ẩm thực đa văn hóa được biến tấu " +
                "\nngẫu hứng, sáng tạo và đẳng cấp?" +
                "\n\nHãy để Red Chilli đánh thức giác quan và khơi gợi " +
                "\nniềm hạnh phúc chân phương trong mỗi người.";

            lbThoiGian.Text = "Thời gian phục vụ\r\n";
            lbMoTa2.Text = "Áp dụng cho tiệc tối thiểu 60 khách";
            lbThoiGian2.Text = "Buffet hải sản & đồ nướng";
            lbMoTa3.Text = "Buffet Món Việt Nam 290.000vnd++" +
                "\nBuffet Hải Sản 590.000vnd++" +
                "\nBuffet Hải Sản Tôm Hùm 880.000vnd++" +
                "\nBBQ Buffet 690.000vnd++";
            txtTen.Text = "Red Chilli Seafood Buffet";
            cardd.BackgroundImage = Properties.Resources.restaurant_2_1;

        }

        private void card_3_Click(object sender, EventArgs e)
        {
            lbTen.Text = "Rooftop Dining";
            lbGioiThieu.Text = "Lãng mạng từ khung trời tầng " +
                "\nthượng";
            lbMoTa.Text =
                "Sở hữu không gian trên cao với nền ẩm thực Á đông" +
                "\nđậm đà và giàu hương vị, Rooftop Dining mang bạn" +
                "\nqua những nền văn hóa riêng biệt cùng những đặc" +
                "\nsản được kết hợp tinh tế và khéo léo." +
                "\n\nNếu bạn đang tìm kiếm một buổi tối tuyệt vời dưới" +
                "\nánh nến, thưởng thức rượu vang cùng những món ăn" +
                "\nđẹp mắt, ngon miệng trong không gian lãng mạn," +
                "\nriêng tư, Rooftop Dining chính là sự lựa" +
                "\nchọn hoàn hảo cho bạn.";

            lbThoiGian.Text = "Thời gian phục vụ\r\n";
            lbMoTa2.Text = "Hoạt động từ 17:30 đến 23:30 mỗi ngày" +
                "\nTrải nghiệm vị giác phong phú với các món " +
                "\năn và rượu thượng hạng được phục vụ theo " +
                "\nthực đơn đặc biệt.";
            lbThoiGian2.Text = "";
            lbMoTa3.Text = "";
            txtTen.Text = "Rooftop Dining";
            cardd.BackgroundImage = Properties.Resources.restaurant_3_1;

        }

        private void card_4_Click(object sender, EventArgs e)
        {
            lbTen.Text = "Tiệc Trưa Chủ Nhật";
            lbGioiThieu.Text = "Phong cách";
            lbMoTa.Text =
                "Là sự kết hợp ngẫu hứng giữa bữa sáng muộn và bữa" +
                "\ntrưa sớm, brunch dành cho những người yêu thích" +
                "\nđời sống phóng khoáng và tận hưởng một ngày đầy" +
                "\ntự do tự tại sau giấc ngủ dài sảng khoái dịp " +
                "\ncuối tuần." +
                "\n\nCHLOE Gallery phục vụ brunch từ 10:00 đến 15:00 " +
                "\nvào chủ nhật mỗi tuần.";
            lbThoiGian2.Text = "";
            lbMoTa3.Text = "";
            txtTen.Text = "Tiệc Trưa Chủ Nhật";
            cardd.BackgroundImage = Properties.Resources.restaurant_4_1;

        }
    }
}
