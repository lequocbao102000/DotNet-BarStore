namespace QLDCPC
{
    partial class FormTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblphanquyen = new System.Windows.Forms.Label();
            this.paneldoimk = new System.Windows.Forms.Panel();
            this.btndoimk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtconfirm = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmkmoi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmkht = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltaotk = new System.Windows.Forms.Panel();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelquanly = new System.Windows.Forms.Panel();
            this.datataikhoan = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.paneldoimk.SuspendLayout();
            this.paneltaotk.SuspendLayout();
            this.panelquanly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datataikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblphanquyen
            // 
            this.lblphanquyen.AutoSize = true;
            this.lblphanquyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblphanquyen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphanquyen.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblphanquyen.Location = new System.Drawing.Point(0, 0);
            this.lblphanquyen.Name = "lblphanquyen";
            this.lblphanquyen.Size = new System.Drawing.Size(74, 26);
            this.lblphanquyen.TabIndex = 0;
            this.lblphanquyen.Text = "label1";
            // 
            // paneldoimk
            // 
            this.paneldoimk.Controls.Add(this.btndoimk);
            this.paneldoimk.Controls.Add(this.txtconfirm);
            this.paneldoimk.Controls.Add(this.label3);
            this.paneldoimk.Controls.Add(this.txtmkmoi);
            this.paneldoimk.Controls.Add(this.label2);
            this.paneldoimk.Controls.Add(this.txtmkht);
            this.paneldoimk.Controls.Add(this.label1);
            this.paneldoimk.Controls.Add(this.paneltaotk);
            this.paneldoimk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldoimk.Location = new System.Drawing.Point(0, 0);
            this.paneldoimk.Name = "paneldoimk";
            this.paneldoimk.Size = new System.Drawing.Size(928, 524);
            this.paneldoimk.TabIndex = 1;
            this.paneldoimk.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldoimk_Paint);
            // 
            // btndoimk
            // 
            this.btndoimk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btndoimk.BackColor = System.Drawing.Color.IndianRed;
            this.btndoimk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoimk.BorderRadius = 0;
            this.btndoimk.ButtonText = "Xác nhận";
            this.btndoimk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndoimk.DisabledColor = System.Drawing.Color.Gray;
            this.btndoimk.Iconcolor = System.Drawing.Color.Transparent;
            this.btndoimk.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndoimk.Iconimage")));
            this.btndoimk.Iconimage_right = null;
            this.btndoimk.Iconimage_right_Selected = null;
            this.btndoimk.Iconimage_Selected = null;
            this.btndoimk.IconMarginLeft = 0;
            this.btndoimk.IconMarginRight = 0;
            this.btndoimk.IconRightVisible = true;
            this.btndoimk.IconRightZoom = 0D;
            this.btndoimk.IconVisible = true;
            this.btndoimk.IconZoom = 90D;
            this.btndoimk.IsTab = false;
            this.btndoimk.Location = new System.Drawing.Point(117, 319);
            this.btndoimk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Normalcolor = System.Drawing.Color.IndianRed;
            this.btndoimk.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btndoimk.OnHoverTextColor = System.Drawing.Color.White;
            this.btndoimk.selected = false;
            this.btndoimk.Size = new System.Drawing.Size(221, 78);
            this.btndoimk.TabIndex = 6;
            this.btndoimk.Text = "Xác nhận";
            this.btndoimk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndoimk.Textcolor = System.Drawing.Color.White;
            this.btndoimk.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // txtconfirm
            // 
            this.txtconfirm.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtconfirm.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtconfirm.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtconfirm.BorderThickness = 3;
            this.txtconfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtconfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtconfirm.isPassword = false;
            this.txtconfirm.Location = new System.Drawing.Point(197, 201);
            this.txtconfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(203, 44);
            this.txtconfirm.TabIndex = 5;
            this.txtconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtmkmoi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmkmoi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtmkmoi.BorderThickness = 3;
            this.txtmkmoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmkmoi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmkmoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmkmoi.isPassword = false;
            this.txtmkmoi.Location = new System.Drawing.Point(197, 121);
            this.txtmkmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(203, 44);
            this.txtmkmoi.TabIndex = 3;
            this.txtmkmoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtmkht
            // 
            this.txtmkht.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtmkht.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmkht.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtmkht.BorderThickness = 3;
            this.txtmkht.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmkht.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmkht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmkht.isPassword = false;
            this.txtmkht.Location = new System.Drawing.Point(197, 38);
            this.txtmkht.Margin = new System.Windows.Forms.Padding(4);
            this.txtmkht.Name = "txtmkht";
            this.txtmkht.Size = new System.Drawing.Size(203, 44);
            this.txtmkht.TabIndex = 1;
            this.txtmkht.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // paneltaotk
            // 
            this.paneltaotk.Controls.Add(this.bunifuMetroTextbox1);
            this.paneltaotk.Controls.Add(this.label5);
            this.paneltaotk.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneltaotk.Location = new System.Drawing.Point(479, 0);
            this.paneltaotk.Name = "paneltaotk";
            this.paneltaotk.Size = new System.Drawing.Size(449, 524);
            this.paneltaotk.TabIndex = 7;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(223, 38);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(203, 44);
            this.bunifuMetroTextbox1.TabIndex = 3;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mật khẩu hiện tại";
            // 
            // panelquanly
            // 
            this.panelquanly.Controls.Add(this.datataikhoan);
            this.panelquanly.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelquanly.Location = new System.Drawing.Point(0, 278);
            this.panelquanly.Name = "panelquanly";
            this.panelquanly.Size = new System.Drawing.Size(928, 246);
            this.panelquanly.TabIndex = 2;
            // 
            // datataikhoan
            // 
            this.datataikhoan.AllowUserToAddRows = false;
            this.datataikhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datataikhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datataikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datataikhoan.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datataikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datataikhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datataikhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datataikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datataikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datataikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datataikhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.datataikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datataikhoan.DoubleBuffered = true;
            this.datataikhoan.EnableHeadersVisualStyles = false;
            this.datataikhoan.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.datataikhoan.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.datataikhoan.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.datataikhoan.Location = new System.Drawing.Point(0, 0);
            this.datataikhoan.Name = "datataikhoan";
            this.datataikhoan.ReadOnly = true;
            this.datataikhoan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datataikhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datataikhoan.RowHeadersVisible = false;
            this.datataikhoan.RowTemplate.Height = 50;
            this.datataikhoan.RowTemplate.ReadOnly = true;
            this.datataikhoan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datataikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datataikhoan.Size = new System.Drawing.Size(928, 246);
            this.datataikhoan.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENTK";
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "Tên tài khoản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HOTEN";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VAITRO";
            this.Column3.HeaderText = "Vai trò";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(131, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelquanly);
            this.Controls.Add(this.lblphanquyen);
            this.Controls.Add(this.paneldoimk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.paneldoimk.ResumeLayout(false);
            this.paneldoimk.PerformLayout();
            this.paneltaotk.ResumeLayout(false);
            this.paneltaotk.PerformLayout();
            this.panelquanly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datataikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblphanquyen;
        private System.Windows.Forms.Panel paneldoimk;
        private Bunifu.Framework.UI.BunifuFlatButton btndoimk;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtconfirm;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtmkmoi;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtmkht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelquanly;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datataikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel paneltaotk;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label label5;
    }
}