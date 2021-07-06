namespace QLDCPC
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datasanpham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbdanggiao = new System.Windows.Forms.RadioButton();
            this.rdbchuagiao = new System.Windows.Forms.RadioButton();
            this.rdbdagiao = new System.Windows.Forms.RadioButton();
            this.rdball = new System.Windows.Forms.RadioButton();
            this.cbomahd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblthogntin = new System.Windows.Forms.Label();
            this.lbltinhtrang = new System.Windows.Forms.Label();
            this.lblngaydat = new System.Windows.Forms.Label();
            this.lblmahd = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datasanpham);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(971, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin các sản phẩm";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Column5,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datasanpham.DefaultCellStyle = dataGridViewCellStyle3;
            this.datasanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datasanpham.DoubleBuffered = true;
            this.datasanpham.EnableHeadersVisualStyles = false;
            this.datasanpham.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.datasanpham.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.datasanpham.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.datasanpham.Location = new System.Drawing.Point(10, 37);
            this.datasanpham.Name = "datasanpham";
            this.datasanpham.ReadOnly = true;
            this.datasanpham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.datasanpham.Size = new System.Drawing.Size(951, 186);
            this.datasanpham.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MASP";
            this.Column1.HeaderText = "Mã sản phẩm";
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
            this.Column3.DataPropertyName = "SOLUONG";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GIABAN";
            this.Column5.HeaderText = "Giá bán";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "THANHTIEN";
            this.Column4.HeaderText = "Thành tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbdanggiao);
            this.panel1.Controls.Add(this.rdbchuagiao);
            this.panel1.Controls.Add(this.rdbdagiao);
            this.panel1.Controls.Add(this.rdball);
            this.panel1.Controls.Add(this.cbomahd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 84);
            this.panel1.TabIndex = 0;
            // 
            // rdbdanggiao
            // 
            this.rdbdanggiao.AutoSize = true;
            this.rdbdanggiao.Location = new System.Drawing.Point(613, 45);
            this.rdbdanggiao.Name = "rdbdanggiao";
            this.rdbdanggiao.Size = new System.Drawing.Size(94, 21);
            this.rdbdanggiao.TabIndex = 9;
            this.rdbdanggiao.TabStop = true;
            this.rdbdanggiao.Text = "Đang giao";
            this.rdbdanggiao.UseVisualStyleBackColor = true;
            this.rdbdanggiao.CheckedChanged += new System.EventHandler(this.rdbdanggiao_CheckedChanged);
            // 
            // rdbchuagiao
            // 
            this.rdbchuagiao.AutoSize = true;
            this.rdbchuagiao.Location = new System.Drawing.Point(514, 45);
            this.rdbchuagiao.Name = "rdbchuagiao";
            this.rdbchuagiao.Size = new System.Drawing.Size(93, 21);
            this.rdbchuagiao.TabIndex = 8;
            this.rdbchuagiao.TabStop = true;
            this.rdbchuagiao.Text = "Chưa giao";
            this.rdbchuagiao.UseVisualStyleBackColor = true;
            this.rdbchuagiao.CheckedChanged += new System.EventHandler(this.rdbchuagiao_CheckedChanged);
            // 
            // rdbdagiao
            // 
            this.rdbdagiao.AutoSize = true;
            this.rdbdagiao.Location = new System.Drawing.Point(430, 45);
            this.rdbdagiao.Name = "rdbdagiao";
            this.rdbdagiao.Size = new System.Drawing.Size(78, 21);
            this.rdbdagiao.TabIndex = 7;
            this.rdbdagiao.TabStop = true;
            this.rdbdagiao.Text = "Đã giao";
            this.rdbdagiao.UseVisualStyleBackColor = true;
            this.rdbdagiao.CheckedChanged += new System.EventHandler(this.rdbdagiao_CheckedChanged);
            // 
            // rdball
            // 
            this.rdball.AutoSize = true;
            this.rdball.Location = new System.Drawing.Point(355, 45);
            this.rdball.Name = "rdball";
            this.rdball.Size = new System.Drawing.Size(69, 21);
            this.rdball.TabIndex = 6;
            this.rdball.TabStop = true;
            this.rdball.Text = "Tất cả";
            this.rdball.UseVisualStyleBackColor = true;
            this.rdball.CheckedChanged += new System.EventHandler(this.rdball_CheckedChanged);
            // 
            // cbomahd
            // 
            this.cbomahd.FormattingEnabled = true;
            this.cbomahd.Location = new System.Drawing.Point(109, 41);
            this.cbomahd.Name = "cbomahd";
            this.cbomahd.Size = new System.Drawing.Size(208, 24);
            this.cbomahd.TabIndex = 5;
            this.cbomahd.SelectedIndexChanged += new System.EventHandler(this.cbomahd_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(23, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnword);
            this.groupBox2.Controls.Add(this.lbltongtien);
            this.groupBox2.Controls.Add(this.lbldiachi);
            this.groupBox2.Controls.Add(this.lblthogntin);
            this.groupBox2.Controls.Add(this.lbltinhtrang);
            this.groupBox2.Controls.Add(this.lblngaydat);
            this.groupBox2.Controls.Add(this.lblmahd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(971, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.ForeColor = System.Drawing.Color.Crimson;
            this.lbltongtien.Location = new System.Drawing.Point(589, 184);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(109, 26);
            this.lbltongtien.TabIndex = 17;
            this.lbltongtien.Text = "Tổng tiền";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(589, 117);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(87, 26);
            this.lbldiachi.TabIndex = 16;
            this.lbldiachi.Text = "địa chỉ ";
            // 
            // lblthogntin
            // 
            this.lblthogntin.AutoSize = true;
            this.lblthogntin.Location = new System.Drawing.Point(589, 52);
            this.lblthogntin.Name = "lblthogntin";
            this.lblthogntin.Size = new System.Drawing.Size(104, 26);
            this.lblthogntin.TabIndex = 15;
            this.lblthogntin.Text = "thông tin";
            // 
            // lbltinhtrang
            // 
            this.lbltinhtrang.AutoSize = true;
            this.lbltinhtrang.Location = new System.Drawing.Point(136, 184);
            this.lbltinhtrang.Name = "lbltinhtrang";
            this.lbltinhtrang.Size = new System.Drawing.Size(115, 26);
            this.lbltinhtrang.TabIndex = 14;
            this.lbltinhtrang.Text = "tình trang";
            // 
            // lblngaydat
            // 
            this.lblngaydat.AutoSize = true;
            this.lblngaydat.Location = new System.Drawing.Point(136, 117);
            this.lblngaydat.Name = "lblngaydat";
            this.lblngaydat.Size = new System.Drawing.Size(104, 26);
            this.lblngaydat.TabIndex = 13;
            this.lblngaydat.Text = "Ngày đặt";
            // 
            // lblmahd
            // 
            this.lblmahd.AutoSize = true;
            this.lblmahd.Location = new System.Drawing.Point(136, 52);
            this.lblmahd.Name = "lblmahd";
            this.lblmahd.Size = new System.Drawing.Size(75, 26);
            this.lblmahd.TabIndex = 12;
            this.lblmahd.Text = "mã hd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(434, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tổng tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(434, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(434, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thông tin khách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(23, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(23, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày đặt";
            // 
            // btnword
            // 
            this.btnword.Activecolor = System.Drawing.Color.DarkBlue;
            this.btnword.BackColor = System.Drawing.Color.DarkBlue;
            this.btnword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnword.BorderRadius = 0;
            this.btnword.ButtonText = "Xuất vouncher";
            this.btnword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnword.DisabledColor = System.Drawing.Color.Gray;
            this.btnword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnword.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnword.Iconimage")));
            this.btnword.Iconimage_right = null;
            this.btnword.Iconimage_right_Selected = null;
            this.btnword.Iconimage_Selected = null;
            this.btnword.IconMarginLeft = 0;
            this.btnword.IconMarginRight = 0;
            this.btnword.IconRightVisible = true;
            this.btnword.IconRightZoom = 0D;
            this.btnword.IconVisible = true;
            this.btnword.IconZoom = 90D;
            this.btnword.IsTab = false;
            this.btnword.Location = new System.Drawing.Point(27, 243);
            this.btnword.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnword.Name = "btnword";
            this.btnword.Normalcolor = System.Drawing.Color.DarkBlue;
            this.btnword.OnHovercolor = System.Drawing.Color.Blue;
            this.btnword.OnHoverTextColor = System.Drawing.Color.White;
            this.btnword.selected = false;
            this.btnword.Size = new System.Drawing.Size(236, 56);
            this.btnword.TabIndex = 18;
            this.btnword.Text = "Xuất vouncher";
            this.btnword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnword.Textcolor = System.Drawing.Color.White;
            this.btnword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnword.Click += new System.EventHandler(this.btnword_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datasanpham;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbomahd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltinhtrang;
        private System.Windows.Forms.Label lblngaydat;
        private System.Windows.Forms.Label lblmahd;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblthogntin;
        private System.Windows.Forms.RadioButton rdbchuagiao;
        private System.Windows.Forms.RadioButton rdbdagiao;
        private System.Windows.Forms.RadioButton rdball;
        private System.Windows.Forms.RadioButton rdbdanggiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuFlatButton btnword;
    }
}