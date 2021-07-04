using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDCPC
{
    class XuLyThongKe
    {
        QL_DUNGCUDataContext qldc = new QL_DUNGCUDataContext();
        public void ShowDate(ComboBox cbodate,MonthCalendar date, Label pdate)
        {
            string ngay = date.SelectionRange.Start.Day.ToString();
            string thang = date.SelectionRange.Start.Month.ToString();
            string nam = date.SelectionRange.Start.Year.ToString();
            if (cbodate.SelectedIndex == 0)
            {
                if (int.Parse(ngay) < 10 && int.Parse(thang) < 10)
                {
                    pdate.Text = nam + "-0" + thang + "-0" + ngay;
                }
                else if (int.Parse(ngay) < 10)
                { pdate.Text = nam + "-" + thang + "-0" + ngay; }
                else if (int.Parse(thang) < 10)
                { pdate.Text = nam + "-0" + thang + "-" + ngay; }
                
                else
                { pdate.Text = nam + "-" + thang + "-" + ngay; }

            }
            else if (cbodate.SelectedIndex == 1)
            {
                if ( int.Parse(thang) < 10)
                {
                    pdate.Text = nam + "-0" + thang;

                }
                else
                { pdate.Text = nam + "-" + thang; }

            }
            else
            {
                pdate.Text = nam;
            }
        }

        public void ShowThongTin(Label pchua,Label pda, Label pdoanhthutam,Label tongdoanhthu,Label pdate)
        {
            var sohdchuagiao = from hd in qldc.HOADONs where hd.TRANGTHAI.Contains("Chưa giao") && hd.NGAYDAT.ToString().Contains(pdate.Text)  select hd;
            pchua.Text = sohdchuagiao.Count().ToString();

            var sohddagiao = from hd in qldc.HOADONs where hd.TRANGTHAI.Contains("Đã giao") && hd.NGAYDAT.ToString().Contains(pdate.Text) select hd;
            pda.Text = sohddagiao.Count().ToString();

            var doanhthutam = from hd in qldc.HOADONs where hd.TRANGTHAI.Contains("") && hd.NGAYDAT.ToString().Contains(pdate.Text) select hd.TONGTIEN;
            if (doanhthutam.Sum().ToString() == "")
            { pdoanhthutam.Text = "0"; }
            else
            {
                pdoanhthutam.Text = doanhthutam.Sum().ToString();
            }

            var doanhthuthuc = from hd in qldc.HOADONs where hd.TRANGTHAI.Contains("Đã giao") && hd.NGAYDAT.ToString().Contains(pdate.Text) select hd.TONGTIEN;
            if (doanhthuthuc.Sum().ToString() == "")
            {
                tongdoanhthu.Text = "0";
            }
            else
            {
                tongdoanhthu.Text = doanhthuthuc.Sum().ToString();
            }
        }

        public void ShowChiTiet(Label pdate, RadioButton rdall, RadioButton rddagiao, RadioButton rdchuagiao, RadioButton rddanggiao,DataGridView dgv)
        {
            string tinhtrang = "";
            if (rddagiao.Checked == true)
            { tinhtrang = rddagiao.Text; }
            else if (rdchuagiao.Checked == true)
            { tinhtrang = rdchuagiao.Text; }
            else if (rddanggiao.Checked == true)
            { tinhtrang = rddanggiao.Text; }
            else
            { tinhtrang = ""; }
            var loadhd = from hd in qldc.HOADONs
                              where hd.TRANGTHAI.Contains(tinhtrang)&&hd.NGAYDAT.ToString().Contains(pdate.Text)
                              join tk in qldc.TAIKHOANs
                              on hd.TENTK equals tk.TENTK
                              select new { hd.MAHD,tk.HOTEN,hd.NGAYDAT,hd.DIACHIGIAO,hd.TONGTIEN };
            dgv.DataSource = loadhd;
        }
    }
}
