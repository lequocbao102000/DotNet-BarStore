namespace QLDCPC
{
    partial class FormSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPham));
            this.datasanpham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhsp = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txttimkiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtidsp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttensp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmotasp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgiasp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnxoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsua = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhsp)).BeginInit();
            this.SuspendLayout();
            // 
            // datasanpham
            // 
            this.datasanpham.AllowUserToAddRows = false;
            this.datasanpham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datasanpham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datasanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datasanpham.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datasanpham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datasanpham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datasanpham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datasanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datasanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datasanpham.DefaultCellStyle = dataGridViewCellStyle3;
            this.datasanpham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datasanpham.DoubleBuffered = true;
            this.datasanpham.EnableHeadersVisualStyles = false;
            this.datasanpham.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.datasanpham.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.datasanpham.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.datasanpham.Location = new System.Drawing.Point(0, 178);
            this.datasanpham.Name = "datasanpham";
            this.datasanpham.ReadOnly = true;
            this.datasanpham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datasanpham.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datasanpham.RowHeadersVisible = false;
            this.datasanpham.RowTemplate.Height = 50;
            this.datasanpham.RowTemplate.ReadOnly = true;
            this.datasanpham.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datasanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datasanpham.Size = new System.Drawing.Size(946, 350);
            this.datasanpham.TabIndex = 1;
            this.datasanpham.SelectionChanged += new System.EventHandler(this.datasanpham_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MASP";
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENSP";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MOTA";
            this.Column3.HeaderText = "Mô tả";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HINHANH";
            this.Column4.HeaderText = "Hình ảnh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GIABAN";
            this.Column5.HeaderText = "Giá bán";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SOLUONGTON";
            this.Column6.HeaderText = "Tồn kho";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // hinhsp
            // 
            this.hinhsp.Location = new System.Drawing.Point(12, 33);
            this.hinhsp.Name = "hinhsp";
            this.hinhsp.Size = new System.Drawing.Size(190, 139);
            this.hinhsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hinhsp.TabIndex = 2;
            this.hinhsp.TabStop = false;
            this.hinhsp.Click += new System.EventHandler(this.hinhsp_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.Color.Silver;
            this.txttimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txttimkiem.BackgroundImage")));
            this.txttimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txttimkiem.ForeColor = System.Drawing.Color.IndianRed;
            this.txttimkiem.Icon = ((System.Drawing.Image)(resources.GetObject("txttimkiem.Icon")));
            this.txttimkiem.Location = new System.Drawing.Point(13, 233);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(316, 34);
            this.txttimkiem.TabIndex = 3;
            this.txttimkiem.text = "";
            this.txttimkiem.OnTextChange += new System.EventHandler(this.txttimkiem_OnTextChange);
            // 
            // txtidsp
            // 
            this.txtidsp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidsp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtidsp.HintForeColor = System.Drawing.Color.Empty;
            this.txtidsp.HintText = "";
            this.txtidsp.isPassword = false;
            this.txtidsp.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtidsp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtidsp.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtidsp.LineThickness = 4;
            this.txtidsp.Location = new System.Drawing.Point(284, 34);
            this.txtidsp.Margin = new System.Windows.Forms.Padding(4);
            this.txtidsp.Name = "txtidsp";
            this.txtidsp.Size = new System.Drawing.Size(124, 36);
            this.txtidsp.TabIndex = 9;
            this.txtidsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(248, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(433, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txttensp
            // 
            this.txttensp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttensp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttensp.HintForeColor = System.Drawing.Color.Empty;
            this.txttensp.HintText = "";
            this.txttensp.isPassword = false;
            this.txttensp.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txttensp.LineIdleColor = System.Drawing.Color.Gray;
            this.txttensp.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txttensp.LineThickness = 4;
            this.txttensp.Location = new System.Drawing.Point(594, 34);
            this.txttensp.Margin = new System.Windows.Forms.Padding(4);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(240, 36);
            this.txttensp.TabIndex = 11;
            this.txttensp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(248, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mô tả";
            // 
            // txtmotasp
            // 
            this.txtmotasp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmotasp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmotasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmotasp.HintForeColor = System.Drawing.Color.Empty;
            this.txtmotasp.HintText = "";
            this.txtmotasp.isPassword = false;
            this.txtmotasp.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtmotasp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtmotasp.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtmotasp.LineThickness = 4;
            this.txtmotasp.Location = new System.Drawing.Point(328, 78);
            this.txtmotasp.Margin = new System.Windows.Forms.Padding(4);
            this.txtmotasp.Name = "txtmotasp";
            this.txtmotasp.Size = new System.Drawing.Size(506, 93);
            this.txtmotasp.TabIndex = 13;
            this.txtmotasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(18, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Giá";
            // 
            // txtgiasp
            // 
            this.txtgiasp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgiasp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiasp.ForeColor = System.Drawing.Color.Red;
            this.txtgiasp.HintForeColor = System.Drawing.Color.Empty;
            this.txtgiasp.HintText = "";
            this.txtgiasp.isPassword = false;
            this.txtgiasp.LineFocusedColor = System.Drawing.Color.LightSeaGreen;
            this.txtgiasp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtgiasp.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtgiasp.LineThickness = 3;
            this.txtgiasp.Location = new System.Drawing.Point(73, 180);
            this.txtgiasp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtgiasp.Name = "txtgiasp";
            this.txtgiasp.Size = new System.Drawing.Size(127, 34);
            this.txtgiasp.TabIndex = 15;
            this.txtgiasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtgiasp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiasp_KeyPress);
            // 
            // btnxoa
            // 
            this.btnxoa.Activecolor = System.Drawing.Color.IndianRed;
            this.btnxoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxoa.BorderRadius = 0;
            this.btnxoa.ButtonText = "Xóa";
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.DisabledColor = System.Drawing.Color.Gray;
            this.btnxoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnxoa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnxoa.Iconimage")));
            this.btnxoa.Iconimage_right = null;
            this.btnxoa.Iconimage_right_Selected = null;
            this.btnxoa.Iconimage_Selected = null;
            this.btnxoa.IconMarginLeft = 0;
            this.btnxoa.IconMarginRight = 0;
            this.btnxoa.IconRightVisible = true;
            this.btnxoa.IconRightZoom = 0D;
            this.btnxoa.IconVisible = true;
            this.btnxoa.IconZoom = 90D;
            this.btnxoa.IsTab = false;
            this.btnxoa.Location = new System.Drawing.Point(372, 220);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnxoa.OnHovercolor = System.Drawing.Color.Salmon;
            this.btnxoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnxoa.selected = false;
            this.btnxoa.Size = new System.Drawing.Size(162, 57);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxoa.Textcolor = System.Drawing.Color.White;
            this.btnxoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Activecolor = System.Drawing.Color.IndianRed;
            this.btnsua.BackColor = System.Drawing.Color.IndianRed;
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsua.BorderRadius = 0;
            this.btnsua.ButtonText = "Sửa";
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.DisabledColor = System.Drawing.Color.Gray;
            this.btnsua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsua.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsua.Iconimage")));
            this.btnsua.Iconimage_right = null;
            this.btnsua.Iconimage_right_Selected = null;
            this.btnsua.Iconimage_Selected = null;
            this.btnsua.IconMarginLeft = 0;
            this.btnsua.IconMarginRight = 0;
            this.btnsua.IconRightVisible = true;
            this.btnsua.IconRightZoom = 0D;
            this.btnsua.IconVisible = true;
            this.btnsua.IconZoom = 90D;
            this.btnsua.IsTab = false;
            this.btnsua.Location = new System.Drawing.Point(594, 220);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnsua.OnHovercolor = System.Drawing.Color.Salmon;
            this.btnsua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsua.selected = false;
            this.btnsua.Size = new System.Drawing.Size(162, 57);
            this.btnsua.TabIndex = 18;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsua.Textcolor = System.Drawing.Color.White;
            this.btnsua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 528);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtgiasp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmotasp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidsp);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.hinhsp);
            this.Controls.Add(this.datasanpham);
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datasanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox hinhsp;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTextbox txttimkiem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtidsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtgiasp;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtmotasp;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txttensp;
        private Bunifu.Framework.UI.BunifuFlatButton btnxoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnsua;
    }
}