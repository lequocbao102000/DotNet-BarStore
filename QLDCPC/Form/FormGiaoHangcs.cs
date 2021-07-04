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
    public partial class FormGiaoHangcs : Form
    {
        XuLyGiaoHang xuly = new XuLyGiaoHang();
        public FormGiaoHangcs()
        {
            InitializeComponent();
        }

        private void FormGiaoHangcs_Load(object sender, EventArgs e)
        {
            cbotype.SelectedIndex = 0;
            xuly.LoadDSShip(cbotype, datagiaohang);

        }

        private void cbotype_SelectedIndexChanged(object sender, EventArgs e)
        {
            xuly.LoadDSShip(cbotype, datagiaohang);
        }
    }
}
