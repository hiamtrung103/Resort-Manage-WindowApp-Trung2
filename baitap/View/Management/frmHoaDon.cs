using baitap.Control;
using baitap.Object;
using System;
using System.Data;
using System.Windows.Forms;

namespace baitap.View.Management
{
    public partial class frmHoaDon : Form
    {
        private HoaDonCtr hoadonCtr = new HoaDonCtr();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void LoadDataToDataGridView()
        {
            DataTable dataTable = hoadonCtr.LayDuLieuHoaDon();
            if (dataTable != null)
            {
                dataGridView1.DataSource = dataTable;
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hoadonCtr.XuatRaExcel(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất dữ liệu ra Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaHoaDon.Text = row.Cells["ID"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtThucUong.Text = row.Cells["ThucUong"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
                txtThoiGian.Text = row.Cells["ThoiGian"].Value.ToString();
            }
        }
    }
}
