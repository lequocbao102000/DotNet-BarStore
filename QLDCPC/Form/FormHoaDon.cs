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
    public partial class FormHoaDon : Form
    {
        XuLyHoaDon xuly = new XuLyHoaDon();
        WordExport word = new WordExport();
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            rdball.Checked = true;
            xuly.LoadHoaDon(rdball, rdbdagiao, rdbchuagiao,rdbdanggiao, cbomahd);
            
        }

        private void rdball_CheckedChanged(object sender, EventArgs e)
        {
            cbomahd.SelectedIndex = -1;
            xuly.LoadHoaDon(rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, cbomahd);
        }

        private void rdbdagiao_CheckedChanged(object sender, EventArgs e)
        {
            cbomahd.SelectedIndex = -1;
            xuly.LoadHoaDon(rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, cbomahd);
        }

        private void rdbchuagiao_CheckedChanged(object sender, EventArgs e)
        {
            cbomahd.SelectedIndex = -1;
            xuly.LoadHoaDon(rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, cbomahd);
        }

        private void rdbdanggiao_CheckedChanged(object sender, EventArgs e)
        {
            cbomahd.SelectedIndex = -1;
            xuly.LoadHoaDon(rdball, rdbdagiao, rdbchuagiao, rdbdanggiao, cbomahd);
        }

        private void cbomahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            xuly.LoadThongTin(cbomahd, lblmahd, lblngaydat, lbltinhtrang, lblthogntin, lbldiachi, lbltongtien);
            xuly.LoadChiTietHD(lblmahd.Text, datasanpham);
        }

        private void btnword_Click(object sender, EventArgs e)
        {
            DateTime currentdate = DateTime.Now;
            string date = "Ngày " + currentdate.Day + " Tháng " + currentdate.Month + " Năm " + currentdate.Year;
            double tien = double.Parse(lbltongtien.Text);
            string vouncher = "";
            if (tien <= 100000){
                vouncher = "20,000 VNĐ";
            }
            else if (tien<=250000&&tien>100000) {
                vouncher = "50,000 VNĐ";
            }
            else if (tien > 250000 && tien < 500000)
            {
                vouncher = "70,000 VNĐ";
            }
            else
            {
                vouncher = "100,000 VNĐ";
            }
            word.CamOnKhachHang(date, lblthogntin.Text, vouncher);
        }
    }
}
