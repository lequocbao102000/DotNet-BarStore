using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDCPC
{
    class XuLyGiaoHang
    {
        QL_DUNGCUDataContext qldc = new QL_DUNGCUDataContext();
        public void LoadDSShip(ComboBox cbo,DataGridView dgv)
        {
            var loadhd = from hd in qldc.HOADONs
                         where hd.TRANGTHAI.Contains(cbo.Text)
                         join tk in qldc.TAIKHOANs
                         on hd.TENTK equals tk.TENTK
                         select new { hd.MAHD, tk.HOTEN, hd.NGAYDAT, hd.DIACHIGIAO, hd.TONGTIEN };
            dgv.DataSource = loadhd;
        }
    }
}
