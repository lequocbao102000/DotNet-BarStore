using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDCPC
{
    class XuLyTaiKhoan
    {
        QL_DUNGCUDataContext qldc = new QL_DUNGCUDataContext();
        public bool DangNhap(string pUser, string pPass)
        {
            var tks1 = qldc.TAIKHOANs.Where(tk => tk.TENTK == pUser).FirstOrDefault();
            var tks = from tk in qldc.TAIKHOANs where tk.TENTK == pUser select tk.MATKHAU;
            var tts = from tk1 in qldc.TAIKHOANs where tk1.TENTK == pUser select tk1.TRANGTHAI;
            var vaitro = from tk2 in qldc.TAIKHOANs where tk2.TENTK == pUser select tk2.VAITRO;
            if (qldc.TAIKHOANs.Contains(tks1))
            {
                if (tks.FirstOrDefault().ToString().Trim() == pPass && 
                    tts.FirstOrDefault().ToString().Trim() == "ok"&&
                    vaitro.FirstOrDefault().ToString().Trim()!="Khách hàng")
                {
                    return true;
                }
               
                else
                { return false; }
            }
            else
            { return false; }



        }
        public string HienThiTen(string pUser)
        {
            var showten = from tk2 in qldc.TAIKHOANs where tk2.TENTK == pUser select tk2.HOTEN;
            return showten.FirstOrDefault().ToString().Trim();
        }
        public string HienThiChucVu(string pTen)
        {
            var showchuc = from tk3 in qldc.TAIKHOANs where tk3.HOTEN == pTen select tk3.VAITRO;
            return showchuc.FirstOrDefault().ToString().Trim();
        }



        public void LoadTaiKhoan(DataGridView dgv)
        {

            var taikhoan = from tk in qldc.TAIKHOANs select new { tk.TENTK, tk.HOTEN, tk.VAITRO };
            dgv.DataSource = taikhoan;
        }
        public bool DoiMatKhau(string pid, string pmkcu, string pmkmoi, string pxacnhanmk)
        {
            var doimk = from tk4 in qldc.TAIKHOANs select tk4.MATKHAU;
            if (doimk.FirstOrDefault().ToString().Trim() == pmkcu)
            {
                if (String.Compare(pmkmoi, pxacnhanmk, true) == 0)
                {
                    TAIKHOAN tk = new TAIKHOAN();
                    tk = qldc.TAIKHOANs.Where(t => t.TENTK == pid).FirstOrDefault();
                    tk.MATKHAU = pmkmoi;
                    qldc.SubmitChanges();
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }
        }
    }
}
