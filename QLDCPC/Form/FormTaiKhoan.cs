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
    public partial class FormTaiKhoan : Form
    {
        XuLyTaiKhoan xuly = new XuLyTaiKhoan();
        public FormTaiKhoan()
        {
            InitializeComponent();
        }
        
        public string setchuc
        {
            set { lblphanquyen.Text = value; }
        }
        public string setid
        {
            set { label4.Text = value; }
        }
        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            xuly.LoadTaiKhoan(datataikhoan);
            if (lblphanquyen.Text != "ADMIN")
            {
                paneldoimk.Dock = DockStyle.Fill;
                panelquanly.Visible = false;
                paneltaotk.Visible = false;
            }
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            if (xuly.DoiMatKhau(label4.Text, txtmkht.Text, txtmkmoi.Text, txtconfirm.Text) == true)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
            }
            else { MessageBox.Show("Đổi mật khẩu thát bại"); }
        }

        private void paneldoimk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntaotk_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "" || txttkmoi.Text == ""||mktaomoi.Text=="")
            { MessageBox.Show("Vui lòng nhập đầy đủ thông tin"); }
            else
            {
                xuly.ThemTaiKhoan(txtten.Text, txttkmoi.Text, mktaomoi.Text);
                xuly.LoadTaiKhoan(datataikhoan);
            }
            
        }
    }
}
