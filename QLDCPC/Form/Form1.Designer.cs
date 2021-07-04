namespace QLDCPC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.paneldn = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndangnhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtpassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtusername = new Bunifu.Framework.UI.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndangxuat = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnhome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnhideshowmenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelmain = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.logoanimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelanimaor = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btngiaohang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnthongke = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelmenu.SuspendLayout();
            this.paneldn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndangxuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhideshowmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelmenu.Controls.Add(this.btnthongke);
            this.panelmenu.Controls.Add(this.btngiaohang);
            this.panelmenu.Controls.Add(this.paneldn);
            this.panelmenu.Controls.Add(this.label1);
            this.panelmenu.Controls.Add(this.btndangxuat);
            this.panelmenu.Controls.Add(this.bunifuFlatButton6);
            this.panelmenu.Controls.Add(this.bunifuFlatButton5);
            this.panelmenu.Controls.Add(this.bunifuFlatButton4);
            this.panelmenu.Controls.Add(this.bunifuFlatButton3);
            this.panelmenu.Controls.Add(this.btnhome);
            this.panelmenu.Controls.Add(this.btnhideshowmenu);
            this.panelmenu.Controls.Add(this.logo);
            this.panelanimaor.SetDecoration(this.panelmenu, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.panelmenu, BunifuAnimatorNS.DecorationType.None);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 59);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(313, 710);
            this.panelmenu.TabIndex = 0;
            // 
            // paneldn
            // 
            this.paneldn.BackColor = System.Drawing.Color.Transparent;
            this.paneldn.Controls.Add(this.pictureBox1);
            this.paneldn.Controls.Add(this.btndangnhap);
            this.paneldn.Controls.Add(this.txtpassword);
            this.paneldn.Controls.Add(this.txtusername);
            this.panelanimaor.SetDecoration(this.paneldn, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.paneldn, BunifuAnimatorNS.DecorationType.None);
            this.paneldn.Location = new System.Drawing.Point(-10, 326);
            this.paneldn.Name = "paneldn";
            this.paneldn.Size = new System.Drawing.Size(328, 303);
            this.paneldn.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.logoanimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimaor.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Activecolor = System.Drawing.Color.IndianRed;
            this.btndangnhap.BackColor = System.Drawing.Color.IndianRed;
            this.btndangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndangnhap.BorderRadius = 0;
            this.btndangnhap.ButtonText = "LOGIN";
            this.btndangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimaor.SetDecoration(this.btndangnhap, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.btndangnhap, BunifuAnimatorNS.DecorationType.None);
            this.btndangnhap.DisabledColor = System.Drawing.Color.Gray;
            this.btndangnhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btndangnhap.Iconimage = null;
            this.btndangnhap.Iconimage_right = null;
            this.btndangnhap.Iconimage_right_Selected = null;
            this.btndangnhap.Iconimage_Selected = null;
            this.btndangnhap.IconMarginLeft = 0;
            this.btndangnhap.IconMarginRight = 0;
            this.btndangnhap.IconRightVisible = true;
            this.btndangnhap.IconRightZoom = 0D;
            this.btndangnhap.IconVisible = true;
            this.btndangnhap.IconZoom = 90D;
            this.btndangnhap.IsTab = false;
            this.btndangnhap.Location = new System.Drawing.Point(14, 228);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Normalcolor = System.Drawing.Color.IndianRed;
            this.btndangnhap.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btndangnhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btndangnhap.selected = false;
            this.btndangnhap.Size = new System.Drawing.Size(297, 59);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "LOGIN";
            this.btndangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndangnhap.Textcolor = System.Drawing.Color.White;
            this.btndangnhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Silver;
            this.txtpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpassword.BackgroundImage")));
            this.txtpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelanimaor.SetDecoration(this.txtpassword, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.txtpassword, BunifuAnimatorNS.DecorationType.None);
            this.txtpassword.ForeColor = System.Drawing.Color.IndianRed;
            this.txtpassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtpassword.Icon")));
            this.txtpassword.Location = new System.Drawing.Point(14, 149);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(302, 52);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.text = "";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Silver;
            this.txtusername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtusername.BackgroundImage")));
            this.txtusername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelanimaor.SetDecoration(this.txtusername, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.txtusername, BunifuAnimatorNS.DecorationType.None);
            this.txtusername.ForeColor = System.Drawing.Color.IndianRed;
            this.txtusername.Icon = ((System.Drawing.Image)(resources.GetObject("txtusername.Icon")));
            this.txtusername.Location = new System.Drawing.Point(14, 75);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(302, 52);
            this.txtusername.TabIndex = 0;
            this.txtusername.text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoanimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.panelanimaor.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 647);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bạn chưa đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.BackColor = System.Drawing.Color.Transparent;
            this.panelanimaor.SetDecoration(this.btndangxuat, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.btndangxuat, BunifuAnimatorNS.DecorationType.None);
            this.btndangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btndangxuat.Image")));
            this.btndangxuat.ImageActive = null;
            this.btndangxuat.Location = new System.Drawing.Point(255, 635);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(46, 46);
            this.btndangxuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btndangxuat.TabIndex = 9;
            this.btndangxuat.TabStop = false;
            this.btndangxuat.Zoom = 10;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "               Nhập hàng";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimaor.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 60D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(-1, 192);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(319, 59);
            this.bunifuFlatButton6.TabIndex = 7;
            this.bunifuFlatButton6.Text = "               Nhập hàng";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "               Hóa đơn";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimaor.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 60D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(-1, 393);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(319, 59);
            this.bunifuFlatButton5.TabIndex = 6;
            this.bunifuFlatButton5.Text = "               Hóa đơn";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "               Sản phẩm";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimaor.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 60D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(-1, 326);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(319, 59);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Text = "               Sản phẩm";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "               Danh mục sản phẩm";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimaor.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(-1, 259);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(319, 59);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "               Danh mục sản phẩm";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // btnhome
            // 
            this.btnhome.Activecolor = System.Drawing.Color.IndianRed;
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhome.BorderRadius = 0;
            this.btnhome.ButtonText = "               Trang chủ";
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimaor.SetDecoration(this.btnhome, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.btnhome, BunifuAnimatorNS.DecorationType.None);
            this.btnhome.DisabledColor = System.Drawing.Color.Gray;
            this.btnhome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnhome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnhome.Iconimage")));
            this.btnhome.Iconimage_right = null;
            this.btnhome.Iconimage_right_Selected = null;
            this.btnhome.Iconimage_Selected = null;
            this.btnhome.IconMarginLeft = 0;
            this.btnhome.IconMarginRight = 0;
            this.btnhome.IconRightVisible = true;
            this.btnhome.IconRightZoom = 0D;
            this.btnhome.IconVisible = true;
            this.btnhome.IconZoom = 60D;
            this.btnhome.IsTab = true;
            this.btnhome.Location = new System.Drawing.Point(-1, 125);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnhome.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btnhome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnhome.selected = true;
            this.btnhome.Size = new System.Drawing.Size(319, 59);
            this.btnhome.TabIndex = 3;
            this.btnhome.Text = "               Trang chủ";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Textcolor = System.Drawing.Color.White;
            this.btnhome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnhideshowmenu
            // 
            this.btnhideshowmenu.BackColor = System.Drawing.Color.Transparent;
            this.panelanimaor.SetDecoration(this.btnhideshowmenu, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.btnhideshowmenu, BunifuAnimatorNS.DecorationType.None);
            this.btnhideshowmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnhideshowmenu.Image")));
            this.btnhideshowmenu.ImageActive = null;
            this.btnhideshowmenu.Location = new System.Drawing.Point(-1, 0);
            this.btnhideshowmenu.Name = "btnhideshowmenu";
            this.btnhideshowmenu.Size = new System.Drawing.Size(37, 33);
            this.btnhideshowmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnhideshowmenu.TabIndex = 1;
            this.btnhideshowmenu.TabStop = false;
            this.btnhideshowmenu.Zoom = 10;
            this.btnhideshowmenu.Click += new System.EventHandler(this.btnhideshowmenu_Click);
            // 
            // logo
            // 
            this.logoanimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.panelanimaor.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-1, 48);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(316, 79);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.btnclose);
            this.panelanimaor.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 59);
            this.panel2.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.panelanimaor.SetDecoration(this.btnclose, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.btnclose, BunifuAnimatorNS.DecorationType.None);
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageActive = null;
            this.btnclose.Location = new System.Drawing.Point(1150, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(54, 52);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 0;
            this.btnclose.TabStop = false;
            this.btnclose.Zoom = 10;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.SystemColors.Control;
            this.panelanimaor.SetDecoration(this.panelmain, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.panelmain, BunifuAnimatorNS.DecorationType.None);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(313, 59);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(904, 710);
            this.panelmain.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // logoanimator
            // 
            this.logoanimator.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.logoanimator.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 0F;
            this.logoanimator.DefaultAnimation = animation12;
            // 
            // panelanimaor
            // 
            this.panelanimaor.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelanimaor.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 0F;
            this.panelanimaor.DefaultAnimation = animation11;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btngiaohang
            // 
            this.btngiaohang.Activecolor = System.Drawing.Color.IndianRed;
            this.btngiaohang.BackColor = System.Drawing.Color.Transparent;
            this.btngiaohang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngiaohang.BorderRadius = 0;
            this.btngiaohang.ButtonText = "               Giao hàng";
            this.btngiaohang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimaor.SetDecoration(this.btngiaohang, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.btngiaohang, BunifuAnimatorNS.DecorationType.None);
            this.btngiaohang.DisabledColor = System.Drawing.Color.Gray;
            this.btngiaohang.Iconcolor = System.Drawing.Color.Transparent;
            this.btngiaohang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btngiaohang.Iconimage")));
            this.btngiaohang.Iconimage_right = null;
            this.btngiaohang.Iconimage_right_Selected = null;
            this.btngiaohang.Iconimage_Selected = null;
            this.btngiaohang.IconMarginLeft = 0;
            this.btngiaohang.IconMarginRight = 0;
            this.btngiaohang.IconRightVisible = true;
            this.btngiaohang.IconRightZoom = 0D;
            this.btngiaohang.IconVisible = true;
            this.btngiaohang.IconZoom = 60D;
            this.btngiaohang.IsTab = true;
            this.btngiaohang.Location = new System.Drawing.Point(-1, 460);
            this.btngiaohang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngiaohang.Name = "btngiaohang";
            this.btngiaohang.Normalcolor = System.Drawing.Color.Transparent;
            this.btngiaohang.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btngiaohang.OnHoverTextColor = System.Drawing.Color.White;
            this.btngiaohang.selected = false;
            this.btngiaohang.Size = new System.Drawing.Size(319, 59);
            this.btngiaohang.TabIndex = 12;
            this.btngiaohang.Text = "               Giao hàng";
            this.btngiaohang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiaohang.Textcolor = System.Drawing.Color.White;
            this.btngiaohang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiaohang.Click += new System.EventHandler(this.btngiaohang_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.Activecolor = System.Drawing.Color.IndianRed;
            this.btnthongke.BackColor = System.Drawing.Color.Transparent;
            this.btnthongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthongke.BorderRadius = 0;
            this.btnthongke.ButtonText = "               Thống kê";
            this.btnthongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelanimaor.SetDecoration(this.btnthongke, BunifuAnimatorNS.DecorationType.None);
            this.logoanimator.SetDecoration(this.btnthongke, BunifuAnimatorNS.DecorationType.None);
            this.btnthongke.DisabledColor = System.Drawing.Color.Gray;
            this.btnthongke.Iconcolor = System.Drawing.Color.Transparent;
            this.btnthongke.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnthongke.Iconimage")));
            this.btnthongke.Iconimage_right = null;
            this.btnthongke.Iconimage_right_Selected = null;
            this.btnthongke.Iconimage_Selected = null;
            this.btnthongke.IconMarginLeft = 0;
            this.btnthongke.IconMarginRight = 0;
            this.btnthongke.IconRightVisible = true;
            this.btnthongke.IconRightZoom = 0D;
            this.btnthongke.IconVisible = true;
            this.btnthongke.IconZoom = 60D;
            this.btnthongke.IsTab = true;
            this.btnthongke.Location = new System.Drawing.Point(0, 527);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Normalcolor = System.Drawing.Color.Transparent;
            this.btnthongke.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btnthongke.OnHoverTextColor = System.Drawing.Color.White;
            this.btnthongke.selected = false;
            this.btnthongke.Size = new System.Drawing.Size(319, 59);
            this.btnthongke.TabIndex = 13;
            this.btnthongke.Text = "               Thống kê";
            this.btnthongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthongke.Textcolor = System.Drawing.Color.White;
            this.btnthongke.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 769);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panel2);
            this.logoanimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelanimaor.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            this.paneldn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndangxuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhideshowmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton btnhideshowmenu;
        private Bunifu.Framework.UI.BunifuImageButton btnclose;
        private Bunifu.Framework.UI.BunifuFlatButton btnhome;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Panel panelmain;
        private BunifuAnimatorNS.BunifuTransition panelanimaor;
        private BunifuAnimatorNS.BunifuTransition logoanimator;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btndangxuat;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paneldn;
        private Bunifu.Framework.UI.BunifuFlatButton btndangnhap;
        private Bunifu.Framework.UI.BunifuTextbox txtpassword;
        private Bunifu.Framework.UI.BunifuTextbox txtusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnthongke;
        private Bunifu.Framework.UI.BunifuFlatButton btngiaohang;
    }
}

