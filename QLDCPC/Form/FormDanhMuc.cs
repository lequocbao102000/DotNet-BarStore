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
    public partial class FormDanhMuc : Form
    {
        XuLyDanhMuc xuly = new XuLyDanhMuc();
        public FormDanhMuc()
        {
            InitializeComponent();
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            xuly.LoadDanhMuc(datadanhmuc);
            txtiddm.Enabled = false;
            btnxoadm.Enabled = btnsuadm.Enabled = false;
        }

        private void btnthemdm_Click(object sender, EventArgs e)
        {
            txtiddm.Enabled = true;
            btnsuadm.Enabled = btnxoadm.Enabled = false;
            txtiddm.Text = "";
            txttendm.Text = "";
            txthinhdm.Text = "";
        }

        private void btnsavedm_Click(object sender, EventArgs e)
        {
            
            
            if (txtiddm.Enabled==true)
            {
                xuly.ThemDanhMuc(txtiddm.Text, txttendm.Text,txthinhdm.Text);
                xuly.LuuDanhMuc(datadanhmuc);
                txtiddm.Enabled = false;
                txtiddm.Text = "";
                txttendm.Text = "";
                txthinhdm.Text = "";
                btnsuadm.Enabled = btnxoadm.Enabled = false;
                btnthemdm.Enabled = true;
            }
            else
            {
                xuly.LuuDanhMuc(datadanhmuc);
                txtiddm.Enabled = false;
                txtiddm.Text = "";
                txttendm.Text = "";
                txthinhdm.Text = "";
                btnsuadm.Enabled = btnxoadm.Enabled = false;
                btnthemdm.Enabled = true;
            }
        }

        private void datadanhmuc_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btnxoadm.Enabled = btnsuadm.Enabled = true;
                txtiddm.Enabled = false;
                btnthemdm.Enabled = false;
                txtiddm.Text = datadanhmuc.CurrentRow.Cells[0].Value.ToString();
                txttendm.Text = datadanhmuc.CurrentRow.Cells[1].Value.ToString();
                txthinhdm.Text = datadanhmuc.CurrentRow.Cells[2].Value.ToString();
            }
            catch { };
        }

        private void btnxoadm_Click(object sender, EventArgs e)
        {
            xuly.XoaDanhMuc(txtiddm.Text);
            MessageBox.Show("OK");
        }

        private void btnsuadm_Click(object sender, EventArgs e)
        {
            xuly.SuaDanhMuc(txtiddm.Text, txttendm.Text,txthinhdm.Text);
            MessageBox.Show("OK");
        }

       
    }
}
