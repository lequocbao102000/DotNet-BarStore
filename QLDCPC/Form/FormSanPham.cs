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
    public partial class FormSanPham : Form
    {
        XuLySanPham xuly = new XuLySanPham();
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            xuly.LoadSanPham(datasanpham);
            txtidsp.Enabled = false;
        }

        private void datasanpham_SelectionChanged(object sender, EventArgs e)
        {
            
            try
            {
                txtidsp.Text = datasanpham.CurrentRow.Cells[0].Value.ToString();
                txttensp.Text = datasanpham.CurrentRow.Cells[1].Value.ToString();
                txtgiasp.Text = datasanpham.CurrentRow.Cells[4].Value.ToString();
                txtmotasp.Text = datasanpham.CurrentRow.Cells[2].Value.ToString();
                string tenhinh = datasanpham.CurrentRow.Cells[3].Value.ToString();
                hinhsp.Image = new Bitmap(Application.StartupPath + "\\hinhanh\\" + tenhinh);
            }
            catch { };
        }

        private void hinhsp_Click(object sender, EventArgs e)
        {

        }

        private void txttimkiem_OnTextChange(object sender, EventArgs e)
        {
            xuly.TimKiem(txttimkiem.text, datasanpham);
        }

        private void btnsuadm_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            xuly.XoaSanPham(txtidsp.Text);
            MessageBox.Show("Deleted");
            xuly.LoadSanPham(datasanpham);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xuly.SuaSanPham(txtidsp.Text, txttensp.Text, txtmotasp.Text, txtgiasp.Text);
            MessageBox.Show("Edited");
            xuly.LoadSanPham(datasanpham);
        }

        private void txtgiasp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
