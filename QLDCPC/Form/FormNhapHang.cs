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
    public partial class FormNhapHang : Form
    {
        XuLySanPham xuly = new XuLySanPham();
        public FormNhapHang()
        {
            InitializeComponent();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = label8.Visible = false;
            txtid.Visible = txttensp.Visible = txtsoluong.Visible = txtmota.Visible = txtgiaban.Visible = txthinhanh.Visible = cbodanhmuc.Visible = cbonhacungcap.Visible = false;
            cbotensp.Visible = false;
            btnnhap.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = label8.Visible = true;
            txtid.Visible = txttensp.Visible = txtsoluong.Visible = txtmota.Visible = txtgiaban.Visible = txthinhanh.Visible = cbodanhmuc.Visible = cbonhacungcap.Visible = true;
            btnnhap.Visible = true;
            cbotensp.Visible = false;
            xuly.LoadDanhMuc(cbodanhmuc);
            xuly.LoadNhaCC(cbonhacungcap);
           
        }

        private void btnnhaphang_Click(object sender, EventArgs e)
        {
            btnnhap.Visible = true;
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = label8.Visible = false;
            txtid.Visible = txttensp.Visible = txtsoluong.Visible = txtmota.Visible = txtgiaban.Visible = txthinhanh.Visible = cbodanhmuc.Visible = cbonhacungcap.Visible = false;
            label2.Visible = label4.Visible = true;
            txtsoluong.Visible = true;
            cbotensp.Visible = true;
            xuly.LoadSanPhamCbo(cbotensp);
           
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            if (txtid.Visible ==true)
            {
                xuly.ThemSanPham(txtid.Text, txttensp.Text, txtmota.Text, txthinhanh.Text, txtgiaban.Text, txtsoluong.Text, cbodanhmuc.SelectedValue.ToString(), cbonhacungcap.SelectedValue.ToString());
            }
            else
            {
                xuly.NhapSanPham(cbotensp.SelectedValue.ToString(), txtsoluong.Text);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
