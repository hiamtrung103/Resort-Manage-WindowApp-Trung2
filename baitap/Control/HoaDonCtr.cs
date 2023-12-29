using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using baitap.Model;
using baitap.Object;
using OfficeOpenXml;

namespace baitap.Control
{
    internal class HoaDonCtr
    {
        private HoaDonMod billMod = new HoaDonMod();

        public DataTable LayDuLieuHoaDon()
        {
            try
            {
                return billMod.LayDuLieuHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool ThemDuLieuHoaDon(HoadonObj billObj)
        {
            try
            {
                return billMod.ThemDuLieuHoaDon(billObj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void XuatRaExcel(string filePath)
        {
            DataTable dataTable = LayDuLieuHoaDon();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("DuLieuHoaDon");

                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                    }

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataTable.Rows[i][j];
                        }
                    }

                    using (var stream = new MemoryStream())
                    {
                        package.SaveAs(stream);

                        using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                        {
                            stream.WriteTo(fileStream);
                        }
                    }

                    MessageBox.Show("Dữ liệu đã được xuất ra Excel.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel.", "Thông báo");
            }
        }
    }
}
