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
    public partial class Form1 : Form
    {
        XuLyTaiKhoan xuly = new XuLyTaiKhoan();
      
        public Form1()
        {
            InitializeComponent();
         
        }
        string vaitro = "";
        public string getchuc
        { get { return vaitro; } }
        public string gettentk
        { get { return txtusername.text; } }
        
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            panelmain.Controls.Clear();
            FormHome frmhome = new FormHome();
            frmhome.TopLevel = false;
            panelmain.Controls.Add(frmhome);
            frmhome.Dock = DockStyle.Fill;
            frmhome.Show();
        }

        private void btnhideshowmenu_Click(object sender, EventArgs e)
        {
            if (panelmenu.Width == 48)
            {
                if(label1.Text== "Bạn chưa đăng nhập")
                {
                    panelmenu.Width = 238;
                    paneldn.Visible = true;
                    label1.Visible = true;
                    panelmenu.Visible = false;
                    panelanimaor.ShowSync(panelmenu);
                    logoanimator.ShowSync(logo);
                }
                else
                {
                    panelmenu.Width = 238;
                    paneldn.Visible = false;
                    label1.Visible = true;
                    panelmenu.Visible = false;
                    panelanimaor.ShowSync(panelmenu);
                    logoanimator.ShowSync(logo);
                }
                
            }
            else
            {
                paneldn.Visible = false;
                label1.Visible = false;
                logoanimator.Hide(logo);
                panelmenu.Visible = false;
                panelmenu.Width = 48;
                panelanimaor.ShowSync(panelmenu);
            }
        }


       

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            FormDanhMuc frmdm = new FormDanhMuc();
            frmdm.TopLevel = false;
            panelmain.Controls.Add(frmdm);
            frmdm.Dock = DockStyle.Fill;
            frmdm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuFlatButton2_Click(null, null);
            bunifuFlatButton3.Visible = false;
            bunifuFlatButton4.Visible = false;
            bunifuFlatButton5.Visible = false;
            bunifuFlatButton6.Visible = false;
            btngiaohang.Visible = false;
            btnthongke.Visible = false;
            btndangxuat.Visible = false;
            
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (xuly.DangNhap(txtusername.text,txtpassword.text))
            {
          
                label1.Text = xuly.HienThiTen(txtusername.text);
                FormTaiKhoan frmtk = new FormTaiKhoan();
                frmtk.setid = gettentk;
                paneldn.Visible = false;
                bunifuFlatButton3.Visible = true;
                bunifuFlatButton4.Visible = true;
                bunifuFlatButton5.Visible = true;
                bunifuFlatButton6.Visible = true;
                btnthongke.Visible = btngiaohang.Visible = true;
                btndangxuat.Visible = true;
                
                
                

            }
            else
            { MessageBox.Show("Dang Nhap That Bai"); }
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            bunifuFlatButton3.Visible = false;
            bunifuFlatButton4.Visible = false;
            bunifuFlatButton5.Visible = false;
            bunifuFlatButton6.Visible = false;
            btngiaohang.Visible = btnthongke.Visible = false;
            btndangxuat.Visible = false;
            paneldn.Visible = true;
            txtusername.text = txtpassword.text = "";
            label1.Text = "Bạn chưa đăng nhập";
            panelmain.Controls.Clear();
            bunifuFlatButton2_Click(null, null);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "Bạn chưa đăng nhập")
            {
                vaitro = xuly.HienThiChucVu(label1.Text);
                panelmain.Controls.Clear();
                FormTaiKhoan frmtk = new FormTaiKhoan();
                frmtk.setchuc = getchuc;
                frmtk.setid = gettentk;
                frmtk.TopLevel = false;
                panelmain.Controls.Add(frmtk);
                frmtk.Dock = DockStyle.Fill;
                frmtk.Show();
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            FormNhapHang frmhang = new FormNhapHang();
            frmhang.TopLevel = false;
            panelmain.Controls.Add(frmhang);
            frmhang.Dock = DockStyle.Fill;
            frmhang.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            FormSanPham frmsp = new FormSanPham();
            frmsp.TopLevel = false;
            panelmain.Controls.Add(frmsp);
            frmsp.Dock = DockStyle.Fill;
            frmsp.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            FormHoaDon frmhd = new FormHoaDon();
            frmhd.TopLevel = false;
            panelmain.Controls.Add(frmhd);
            frmhd.Dock = DockStyle.Fill;
            frmhd.Show();
        }

        private void btngiaohang_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            FormGiaoHangcs frmgh = new FormGiaoHangcs();
            frmgh.TopLevel = false;
            panelmain.Controls.Add(frmgh);
            frmgh.Dock = DockStyle.Fill;
            frmgh.Show();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();
            FormThongKe frmthongke = new FormThongKe();
            frmthongke.TopLevel = false;
            panelmain.Controls.Add(frmthongke);
            frmthongke.Dock = DockStyle.Fill;
            frmthongke.Show();
        }
    }
    
}
