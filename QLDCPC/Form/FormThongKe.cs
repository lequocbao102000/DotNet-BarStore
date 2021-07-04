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
    }
}
