using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDCPC
{
    public partial class FormThongKe : Form
    {
        XuLyThongKe xuly = new XuLyThongKe();
        ExcelExport excel = new ExcelExport();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            cbodate.SelectedIndex = 0;
            xuly.ShowDate(cbodate, monthCalendar1, lblsodate);
            xuly.ShowThongTin(lblchuahoanthanh, lbldonhoanthanh, lbldttam, lbldtthucte,lblsodate);
            xuly.ShowChiTiet(lblsodate, rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, datahoadon);
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            xuly.ShowDate(cbodate, monthCalendar1, lblsodate);
            xuly.ShowThongTin(lblchuahoanthanh, lbldonhoanthanh, lbldttam, lbldtthucte, lblsodate);
            xuly.ShowChiTiet(lblsodate, rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, datahoadon);
        }

        private void cbodate_SelectedIndexChanged(object sender, EventArgs e)
        {
            xuly.ShowDate(cbodate, monthCalendar1, lblsodate);
            xuly.ShowThongTin(lblchuahoanthanh, lbldonhoanthanh, lbldttam, lbldtthucte, lblsodate);
            xuly.ShowChiTiet(lblsodate, rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, datahoadon);
        }

        private void rdball_CheckedChanged(object sender, EventArgs e)
        {
            xuly.ShowDate(cbodate, monthCalendar1, lblsodate);
            xuly.ShowThongTin(lblchuahoanthanh, lbldonhoanthanh, lbldttam, lbldtthucte, lblsodate);
            xuly.ShowChiTiet(lblsodate, rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, datahoadon);
        }

        private void rdbdagiao_CheckedChanged(object sender, EventArgs e)
        {
            xuly.ShowDate(cbodate, monthCalendar1, lblsodate);
            xuly.ShowThongTin(lblchuahoanthanh, lbldonhoanthanh, lbldttam, lbldtthucte, lblsodate);
            xuly.ShowChiTiet(lblsodate, rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, datahoadon);
        }

        private void rdbchuagiao_CheckedChanged(object sender, EventArgs e)
        {
            xuly.ShowDate(cbodate, monthCalendar1, lblsodate);
            xuly.ShowThongTin(lblchuahoanthanh, lbldonhoanthanh, lbldttam, lbldtthucte, lblsodate);
            xuly.ShowChiTiet(lblsodate, rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, datahoadon);
        }

        private void rdbdanggiao_CheckedChanged(object sender, EventArgs e)
        {
            xuly.ShowDate(cbodate, monthCalendar1, lblsodate);
            xuly.ShowThongTin(lblchuahoanthanh, lbldonhoanthanh, lbldttam, lbldtthucte, lblsodate);
            xuly.ShowChiTiet(lblsodate, rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, datahoadon);
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            try{
                ExcelExport excel = new ExcelExport();
                SaveFileDialog saveFile = new SaveFileDialog();
                if (datahoadon.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất");
                    return;
                }
                List<HOADON> pListHD = new List<HOADON>();
                // Đổ dữ liệu vào danh sách
                foreach (DataGridViewRow item in datahoadon.Rows)
                {
                    HOADON i = new HOADON();
                    i.MAHD = int.Parse(item.Cells[0].Value.ToString());
                    i.TENTK = item.Cells[1].Value.ToString();
                    i.NGAYDAT = Convert.ToDateTime(item.Cells[2].Value.ToString());
                    i.DIACHIGIAO = item.Cells[3].Value.ToString();
                    i.TONGTIEN = double.Parse(item.Cells[4].Value.ToString());
                    pListHD.Add(i);
                }
                string path = string.Empty;
                excel.ExportKhoa(pListHD, ref path, false, datahoadon);
                // Confirm for open file was exported
                if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thông tin",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(path);
                }
            }
            catch { }
        }
    }
}
