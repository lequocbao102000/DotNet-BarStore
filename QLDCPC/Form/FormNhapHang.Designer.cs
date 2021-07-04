namespace QLDCPC
{
    partial class FormNhapHang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnthemmoi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnnhaphang = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txttensp = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtsoluong = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txthinhanh = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtmota = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtgiaban = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbodanhmuc = new System.Windows.Forms.ComboBox();
            this.cbonhacungcap = new System.Windows.Forms.ComboBox();
            this.btnnhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbotensp = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthemmoi,
            this.btnnhaphang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnthemmoi.Size = new System.Drawing.Size(188, 26);
            this.btnthemmoi.Text = "Thêm sản phẩm mới";
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // btnnhaphang
            // 
            this.btnnhaphang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhaphang.Name = "btnnhaphang";
            this.btnnhaphang.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnnhaphang.Size = new System.Drawing.Size(113, 26);
            this.btnnhaphang.Text = "Nhập hàng";
            this.btnnhaphang.Click += new System.EventHandler(this.btnnhaphang_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình ảnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhà cung cấp";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Danh mục ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giá bán";
            // 
            // txtid
            // 
            this.txtid.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtid.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtid.BorderThickness = 3;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtid.isPassword = false;
            this.txtid.Location = new System.Drawing.Point(229, 46);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(286, 44);
            this.txtid.TabIndex = 8;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txttensp
            // 
            this.txttensp.BorderColorFocused = System.Drawing.Color.Blue;
            this.txttensp.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttensp.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txttensp.BorderThickness = 3;
            this.txttensp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttensp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txttensp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttensp.isPassword = false;
            this.txttensp.Location = new System.Drawing.Point(229, 98);
            this.txttensp.Margin = new System.Windows.Forms.Padding(4);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(286, 44);
            this.txttensp.TabIndex = 9;
            this.txttensp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtsoluong
            // 
            this.txtsoluong.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtsoluong.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsoluong.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtsoluong.BorderThickness = 3;
            this.txtsoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoluong.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsoluong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsoluong.isPassword = false;
            this.txtsoluong.Location = new System.Drawing.Point(229, 150);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(286, 44);
            this.txtsoluong.TabIndex = 10;
            this.txtsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // txthinhanh
            // 
            this.txthinhanh.BorderColorFocused = System.Drawing.Color.Blue;
            this.txthinhanh.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txthinhanh.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txthinhanh.BorderThickness = 3;
            this.txthinhanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthinhanh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txthinhanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txthinhanh.isPassword = false;
            this.txthinhanh.Location = new System.Drawing.Point(229, 202);
            this.txthinhanh.Margin = new System.Windows.Forms.Padding(4);
            this.txthinhanh.Name = "txthinhanh";
            this.txthinhanh.Size = new System.Drawing.Size(286, 44);
            this.txthinhanh.TabIndex = 11;
            this.txthinhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtmota
            // 
            this.txtmota.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtmota.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmota.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtmota.BorderThickness = 3;
            this.txtmota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmota.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmota.isPassword = false;
            this.txtmota.Location = new System.Drawing.Point(229, 254);
            this.txtmota.Margin = new System.Windows.Forms.Padding(4);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(286, 44);
            this.txtmota.TabIndex = 12;
            this.txtmota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtgiaban
            // 
            this.txtgiaban.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtgiaban.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtgiaban.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtgiaban.BorderThickness = 3;
            this.txtgiaban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgiaban.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtgiaban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtgiaban.isPassword = false;
            this.txtgiaban.Location = new System.Drawing.Point(229, 304);
            this.txtgiaban.Margin = new System.Windows.Forms.Padding(4);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(286, 44);
            this.txtgiaban.TabIndex = 13;
            this.txtgiaban.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtgiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiaban_KeyPress);
            // 
            // cbodanhmuc
            // 
            this.cbodanhmuc.FormattingEnabled = true;
            this.cbodanhmuc.Location = new System.Drawing.Point(229, 368);
            this.cbodanhmuc.Name = "cbodanhmuc";
            this.cbodanhmuc.Size = new System.Drawing.Size(290, 24);
            this.cbodanhmuc.TabIndex = 14;
            // 
            // cbonhacungcap
            // 
            this.cbonhacungcap.FormattingEnabled = true;
            this.cbonhacungcap.Location = new System.Drawing.Point(229, 422);
            this.cbonhacungcap.Name = "cbonhacungcap";
            this.cbonhacungcap.Size = new System.Drawing.Size(290, 24);
            this.cbonhacungcap.TabIndex = 15;
            // 
            // btnnhap
            // 
            this.btnnhap.Activecolor = System.Drawing.Color.IndianRed;
            this.btnnhap.BackColor = System.Drawing.Color.IndianRed;
            this.btnnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnhap.BorderRadius = 0;
            this.btnnhap.ButtonText = "Xác nhận";
            this.btnnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnhap.DisabledColor = System.Drawing.Color.Gray;
            this.btnnhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnhap.Iconimage = null;
            this.btnnhap.Iconimage_right = null;
            this.btnnhap.Iconimage_right_Selected = null;
            this.btnnhap.Iconimage_Selected = null;
            this.btnnhap.IconMarginLeft = 0;
            this.btnnhap.IconMarginRight = 0;
            this.btnnhap.IconRightVisible = true;
            this.btnnhap.IconRightZoom = 0D;
            this.btnnhap.IconVisible = true;
            this.btnnhap.IconZoom = 90D;
            this.btnnhap.IsTab = false;
            this.btnnhap.Location = new System.Drawing.Point(623, 336);
            this.btnnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnnhap.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnnhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnnhap.selected = false;
            this.btnnhap.Size = new System.Drawing.Size(243, 110);
            this.btnnhap.TabIndex = 16;
            this.btnnhap.Text = "Xác nhận";
            this.btnnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnhap.Textcolor = System.Drawing.Color.White;
            this.btnnhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // cbotensp
            // 
            this.cbotensp.FormattingEnabled = true;
            this.cbotensp.Location = new System.Drawing.Point(229, 111);
            this.cbotensp.Name = "cbotensp";
            this.cbotensp.Size = new System.Drawing.Size(286, 24);
            this.cbotensp.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbotensp);
            this.panel1.Controls.Add(this.btnnhap);
            this.panel1.Controls.Add(this.cbonhacungcap);
            this.panel1.Controls.Add(this.cbodanhmuc);
            this.panel1.Controls.Add(this.txtgiaban);
            this.panel1.Controls.Add(this.txtmota);
            this.panel1.Controls.Add(this.txthinhanh);
            this.panel1.Controls.Add(this.txtsoluong);
            this.panel1.Controls.Add(this.txttensp);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 545);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnthemmoi;
        private System.Windows.Forms.ToolStripMenuItem btnnhaphang;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbotensp;
        private Bunifu.Framework.UI.BunifuFlatButton btnnhap;
        private System.Windows.Forms.ComboBox cbonhacungcap;
        private System.Windows.Forms.ComboBox cbodanhmuc;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtgiaban;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtmota;
        private Bunifu.Framework.UI.BunifuMetroTextbox txthinhanh;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsoluong;
        private Bunifu.Framework.UI.BunifuMetroTextbox txttensp;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}