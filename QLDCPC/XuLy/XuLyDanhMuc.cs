using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDCPC
{
    class XuLyDanhMuc
    {
        QL_DUNGCUDataContext qldc = new QL_DUNGCUDataContext();
        public void LoadDanhMuc(DataGridView dgv)
        {
            var danhmuc = from dm in qldc.DANHMUCs select dm;
            dgv.DataSource = danhmuc;
        }
        public void LuuDanhMuc(DataGridView dgv)
        {
            qldc.SubmitChanges();
            //refresh
            var danhmuc1 = from dm1 in qldc.DANHMUCs select dm1;
            dgv.DataSource = danhmuc1;
        }
        public void ThemDanhMuc(string pMadm, string pTendm,string pHinhdm)
        {
            DANHMUC dm = new DANHMUC();

            dm.MADM = pMadm;
            dm.TENDM = pTendm;
            dm.HINH = pHinhdm;
            qldc.DANHMUCs.InsertOnSubmit(dm);

        }

        public void XoaDanhMuc(string pMadm)
        {
            DANHMUC dm = new DANHMUC();
            dm = qldc.DANHMUCs.Where(d => d.MADM == pMadm).FirstOrDefault();

            qldc.DANHMUCs.DeleteOnSubmit(dm);


        }

        public void SuaDanhMuc(string pMadm, string pTendm,string pHinhdm)
        {
            DANHMUC dm = new DANHMUC();
            dm = qldc.DANHMUCs.Where(d => d.MADM == pMadm).FirstOrDefault();

            dm.TENDM = pTendm;
            dm.HINH = pHinhdm;
        }
    }
}
