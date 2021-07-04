using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDCPC
{
    class XuLySanPham
    {
        QL_DUNGCUDataContext qldc = new QL_DUNGCUDataContext();

        public void LoadDanhMuc(ComboBox cbo)
        {
            var load = from dm in qldc.DANHMUCs select dm;
            cbo.DataSource = load;
            cbo.DisplayMember = "TENDM";
            cbo.ValueMember = "MADM";
        }
        public void LoadNhaCC(ComboBox cbo)
        {
            var loadncc = from ncc in qldc.NHACUNGCAPs select ncc;
            cbo.DataSource = loadncc;
            cbo.DisplayMember = "TENNCC";
            cbo.ValueMember = "MANCC";
        }


        public void ThemSanPham(string pid, string pten, string pmota, string phinhanh, string pgia, string psoluong, string pdm, string pncc)
        {
            try
            {
                SANPHAM sp = new SANPHAM();

                sp.MASP = pid;
                sp.TENSP = pten;
                sp.MOTA = pmota;
                sp.HINHANH = phinhanh;
                sp.GIABAN = int.Parse(pgia);
                sp.SOLUONGTON = int.Parse(psoluong);
                sp.MADM = pdm;
                sp.MANCC = pncc;

                qldc.SANPHAMs.InsertOnSubmit(sp);

                qldc.SubmitChanges();
                var reload = from sp1 in qldc.SANPHAMs select sp1;
                MessageBox.Show("OK!");
            }
            catch { };


        }

        public void NhapSanPham(string pmasp, string soluong)
        {
            SANPHAM sp = new SANPHAM();
            sp = qldc.SANPHAMs.Where(s => s.MASP == pmasp).FirstOrDefault();
            sp.SOLUONGTON = sp.SOLUONGTON + int.Parse(soluong);
            qldc.SubmitChanges();
            MessageBox.Show("OK!");

        }
        public void LoadSanPhamCbo(ComboBox cbo)
        {
            var loadsp = from sp in qldc.SANPHAMs select sp;
            cbo.DataSource = loadsp;
            cbo.DisplayMember = "TENSP";
            cbo.ValueMember = "MASP";

        }
        public void LoadSanPham(DataGridView dgv)
        {
            var loadsp1 = from sp in qldc.SANPHAMs select new { sp.MASP, sp.TENSP, sp.MOTA, sp.HINHANH, sp.GIABAN, sp.SOLUONGTON };
            dgv.DataSource = loadsp1;
        }

        public void TimKiem(string pSearch, DataGridView dgv)
        {

            var loadsp1 = from sp in qldc.SANPHAMs
                          where sp.MASP.Contains(pSearch) || sp.TENSP.Contains(pSearch)
                          select new { sp.MASP, sp.TENSP, sp.MOTA, sp.HINHANH, sp.GIABAN, sp.SOLUONGTON };
            dgv.DataSource = loadsp1;
        }
        public void XoaSanPham(string pma)
        {
            SANPHAM sp = new SANPHAM();
            sp = qldc.SANPHAMs.Where(d => d.MASP == pma).FirstOrDefault();

            qldc.SANPHAMs.DeleteOnSubmit(sp);
            qldc.SubmitChanges();
        }
        public void SuaSanPham(string pma,string pten,string pmota,string gia)
        {
            SANPHAM sp = new SANPHAM();
            sp = qldc.SANPHAMs.Where(d => d.MASP == pma).FirstOrDefault();

            sp.TENSP = pten;
            sp.MOTA = pmota;
            sp.GIABAN = int.Parse(gia);
            qldc.SubmitChanges();
        }
    }
}
