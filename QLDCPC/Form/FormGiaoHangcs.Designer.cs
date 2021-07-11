namespace QLDCPC
{
    partial class FormGiaoHangcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoHangcs));
            this.datagiaohang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btngiaohang = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagiaohang)).BeginInit();
            this.SuspendLayout();
            // 
            // datagiaohang
            // 
            this.datagiaohang.AllowUserToAddRows = false;
            this.datagiaohang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagiaohang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagiaohang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagiaohang.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagiaohang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagiaohang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagiaohang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagiaohang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagiaohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagiaohang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagiaohang.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagiaohang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagiaohang.DoubleBuffered = true;
            this.datagiaohang.EnableHeadersVisualStyles = false;
            this.datagiaohang.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.datagiaohang.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.datagiaohang.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.datagiaohang.Location = new System.Drawing.Point(0, 332);
            this.datagiaohang.Name = "datagiaohang";
            this.datagiaohang.ReadOnly = true;
            this.datagiaohang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagiaohang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagiaohang.RowHeadersVisible = false;
            this.datagiaohang.RowTemplate.Height = 50;
            this.datagiaohang.RowTemplate.ReadOnly = true;
            this.datagiaohang.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datagiaohang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagiaohang.Size = new System.Drawing.Size(927, 299);
            this.datagiaohang.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHD";
            this.Column1.HeaderText = "Mã HD";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HOTEN";
            this.Column2.HeaderText = "Khách Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NGAYDAT";
            this.Column4.HeaderText = "Ngày Đặt";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHIGIAO";
            this.Column3.HeaderText = "Địa Chỉ Giao";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TONGTIEN";
            this.Column5.HeaderText = "Tổng Tiền";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cbotype
            // 
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "Chưa giao",
            "Đang giao"});
            this.cbotype.Location = new System.Drawing.Point(12, 348);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(190, 24);
            this.cbotype.TabIndex = 7;
            this.cbotype.SelectedIndexChanged += new System.EventHandler(this.cbotype_SelectedIndexChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(927, 274);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Điểm bắt đầu";
            this.columnHeader1.Width = 329;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Điểm kết thúc";
            this.columnHeader2.Width = 461;
            // 
            // btngiaohang
            // 
            this.btngiaohang.Activecolor = System.Drawing.Color.Firebrick;
            this.btngiaohang.BackColor = System.Drawing.Color.IndianRed;
            this.btngiaohang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngiaohang.BorderRadius = 0;
            this.btngiaohang.ButtonText = "Xử lý giao hàng";
            this.btngiaohang.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btngiaohang.IconZoom = 90D;
            this.btngiaohang.IsTab = false;
            this.btngiaohang.Location = new System.Drawing.Point(242, 332);
            this.btngiaohang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngiaohang.Name = "btngiaohang";
            this.btngiaohang.Normalcolor = System.Drawing.Color.IndianRed;
            this.btngiaohang.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btngiaohang.OnHoverTextColor = System.Drawing.Color.White;
            this.btngiaohang.selected = false;
            this.btngiaohang.Size = new System.Drawing.Size(262, 59);
            this.btngiaohang.TabIndex = 9;
            this.btngiaohang.Text = "Xử lý giao hàng";
            this.btngiaohang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btngiaohang.Textcolor = System.Drawing.Color.White;
            this.btngiaohang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiaohang.Click += new System.EventHandler(this.btngiaohang_Click);
            // 
            // FormGiaoHangcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 631);
            this.Controls.Add(this.btngiaohang);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbotype);
            this.Controls.Add(this.datagiaohang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiaoHangcs";
            this.Text = "FormGiaoHangcs";
            this.Load += new System.EventHandler(this.FormGiaoHangcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagiaohang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datagiaohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cbotype;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private Bunifu.Framework.UI.BunifuFlatButton btngiaohang;
    }
}