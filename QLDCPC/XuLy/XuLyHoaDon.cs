using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDCPC
{
    class XuLyHoaDon
    {
        QL_DUNGCUDataContext qldc = new QL_DUNGCUDataContext();

        public void LoadHoaDon(RadioButton rdall,RadioButton rddagiao,RadioButton rdchuagiao, RadioButton rddanggiao, ComboBox cboma)
        {
            string tinhtrang = "";
            if (rddagiao.Checked==true)
            { tinhtrang = rddagiao.Text; }
            else if (rdchuagiao.Checked==true)
            { tinhtrang = rdchuagiao.Text; }
            else if (rddanggiao.Checked==true)
            { tinhtrang = rddanggiao.Text; }
            else
            { tinhtrang = ""; }
            var loadhd = from hd in qldc.HOADONs where hd.TRANGTHAI.Contains(tinhtrang) select hd;
            cboma.DataSource = loadhd;
            cboma.DisplayMember = "MAHD";
            cboma.ValueMember = "MAHD";
        }

        public void LoadThongTin(ComboBox pma,Label pmahd,Label pngaydat,Label ptinhtrang,Label pthongtin,Label pdiachi,Label tien)
        {
            try
            {
                if (pma.Text == "")
                {
                    pmahd.Text =     "";
                    pngaydat.Text =  "";
                    ptinhtrang.Text= "";
                    pthongtin.Text = "";
                    pdiachi.Text =   "";
                    tien.Text =      "";
                }
                else
                {
                    var loadma = from tt1 in qldc.HOADONs where tt1.MAHD == int.Parse(pma.Text) select tt1.MAHD;
                    var loadngay = from tt2 in qldc.HOADONs where tt2.MAHD == int.Parse(pma.Text) select tt2.NGAYDAT;
                    var loadtinhtrang = from tt3 in qldc.HOADONs where tt3.MAHD == int.Parse(pma.Text) select tt3.TRANGTHAI;
                    var loaddiachi = from tt5 in qldc.HOADONs where tt5.MAHD == int.Parse(pma.Text) select tt5.DIACHIGIAO;
                    var loadtongtien = from tt6 in qldc.HOADONs where tt6.MAHD == int.Parse(pma.Text) select tt6.TONGTIEN;

                    var loadsdtkhach = from tt7 in qldc.HOADONs
                                       where tt7.MAHD==int.Parse(pma.Text)
                                       join k in qldc.TAIKHOANs on tt7.TENTK equals k.TENTK
                                       select k.SDT;

                    var loadtenkhach = from tt8 in qldc.HOADONs
                                       where tt8.MAHD == int.Parse(pma.Text)
                                       join k in qldc.TAIKHOANs on tt8.TENTK equals k.TENTK
                                       select k.HOTEN;

                    pmahd.Text = loadma.FirstOrDefault().ToString();
                    pngaydat.Text = loadngay.FirstOrDefault().ToString();
                    ptinhtrang.Text = loadtinhtrang.FirstOrDefault().ToString();
                    pthongtin.Text = loadtenkhach.FirstOrDefault().ToString() + " - " + loadsdtkhach.FirstOrDefault().ToString();
                    pdiachi.Text = loaddiachi.FirstOrDefault().ToString();
                    tien.Text = loadtongtien.FirstOrDefault().ToString();
                }
            }
            catch { }
        }

        public void LoadChiTietHD(string pmahd,DataGridView dgvct)
        {
            try
            {
                if (pmahd == "")
                {
                    dgvct.Rows.Clear();
                }
                else
                {
                    var loadchitiet = from ct in qldc.CHITIETHOADONs
                                      where ct.MAHD.ToString().Contains(pmahd)
                                      join sp in qldc.SANPHAMs
                                      on ct.MASP equals sp.MASP
                                      select new { ct.MASP, sp.TENSP, ct.SOLUONG, ct.GIABAN, ct.THANHTIEN };
                    dgvct.DataSource = loadchitiet;
                }
            }
            catch { }
        }
    }
}
