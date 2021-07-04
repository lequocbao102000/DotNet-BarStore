namespace QLDCPC
{
    partial class FormThongKe
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
            this.lblthongke = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldtthucte = new System.Windows.Forms.Label();
            this.lbldttam = new System.Windows.Forms.Label();
            this.lblchuahoanthanh = new System.Windows.Forms.Label();
            this.lbldonhoanthanh = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbdanggiao = new System.Windows.Forms.RadioButton();
            this.rdbchuagiao = new System.Windows.Forms.RadioButton();
            this.rdbdagiao = new System.Windows.Forms.RadioButton();
            this.rdball = new System.Windows.Forms.RadioButton();
            this.datahoadon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbodate = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblsodate = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datahoadon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblthongke
            // 
            this.lblthongke.AutoSize = true;
            this.lblthongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblthongke.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthongke.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblthongke.Location = new System.Drawing.Point(0, 0);
            this.lblthongke.Name = "lblthongke";
            this.lblthongke.Size = new System.Drawing.Size(127, 32);
            this.lblthongke.TabIndex = 5;
            this.lblthongke.Text = "Thống kê";
            this.lblthongke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbldtthucte);
            this.groupBox1.Controls.Add(this.lbldttam);
            this.groupBox1.Controls.Add(this.lblchuahoanthanh);
            this.groupBox1.Controls.Add(this.lbldonhoanthanh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 272);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doanh thu thực tế: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doanh thu tạm tính: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số đơn chưa hoàn thành: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số đơn đã hoàn thành: ";
            // 
            // lbldtthucte
            // 
            this.lbldtthucte.AutoSize = true;
            this.lbldtthucte.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtthucte.Location = new System.Drawing.Point(278, 180);
            this.lbldtthucte.Name = "lbldtthucte";
            this.lbldtthucte.Size = new System.Drawing.Size(20, 22);
            this.lbldtthucte.TabIndex = 3;
            this.lbldtthucte.Text = "0";
            // 
            // lbldttam
            // 
            this.lbldttam.AutoSize = true;
            this.lbldttam.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldttam.Location = new System.Drawing.Point(278, 129);
            this.lbldttam.Name = "lbldttam";
            this.lbldttam.Size = new System.Drawing.Size(20, 22);
            this.lbldttam.TabIndex = 2;
            this.lbldttam.Text = "0";
            // 
            // lblchuahoanthanh
            // 
            this.lblchuahoanthanh.AutoSize = true;
            this.lblchuahoanthanh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchuahoanthanh.Location = new System.Drawing.Point(278, 82);
            this.lblchuahoanthanh.Name = "lblchuahoanthanh";
            this.lblchuahoanthanh.Size = new System.Drawing.Size(20, 22);
            this.lblchuahoanthanh.TabIndex = 1;
            this.lblchuahoanthanh.Text = "0";
            // 
            // lbldonhoanthanh
            // 
            this.lbldonhoanthanh.AutoSize = true;
            this.lbldonhoanthanh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonhoanthanh.Location = new System.Drawing.Point(278, 35);
            this.lbldonhoanthanh.Name = "lbldonhoanthanh";
            this.lbldonhoanthanh.Size = new System.Drawing.Size(20, 22);
            this.lbldonhoanthanh.TabIndex = 0;
            this.lbldonhoanthanh.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbdanggiao);
            this.groupBox2.Controls.Add(this.rdbchuagiao);
            this.groupBox2.Controls.Add(this.rdbdagiao);
            this.groupBox2.Controls.Add(this.rdball);
            this.groupBox2.Controls.Add(this.datahoadon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(949, 315);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // rdbdanggiao
            // 
            this.rdbdanggiao.AutoSize = true;
            this.rdbdanggiao.Location = new System.Drawing.Point(323, 34);
            this.rdbdanggiao.Name = "rdbdanggiao";
            this.rdbdanggiao.Size = new System.Drawing.Size(115, 27);
            this.rdbdanggiao.TabIndex = 13;
            this.rdbdanggiao.Text = "Đang giao";
            this.rdbdanggiao.UseVisualStyleBackColor = true;
            this.rdbdanggiao.CheckedChanged += new System.EventHandler(this.rdbdanggiao_CheckedChanged);
            // 
            // rdbchuagiao
            // 
            this.rdbchuagiao.AutoSize = true;
            this.rdbchuagiao.Location = new System.Drawing.Point(200, 34);
            this.rdbchuagiao.Name = "rdbchuagiao";
            this.rdbchuagiao.Size = new System.Drawing.Size(117, 27);
            this.rdbchuagiao.TabIndex = 12;
            this.rdbchuagiao.Text = "Chưa giao";
            this.rdbchuagiao.UseVisualStyleBackColor = true;
            this.rdbchuagiao.CheckedChanged += new System.EventHandler(this.rdbchuagiao_CheckedChanged);
            // 
            // rdbdagiao
            // 
            this.rdbdagiao.AutoSize = true;
            this.rdbdagiao.Location = new System.Drawing.Point(97, 34);
            this.rdbdagiao.Name = "rdbdagiao";
            this.rdbdagiao.Size = new System.Drawing.Size(95, 27);
            this.rdbdagiao.TabIndex = 11;
            this.rdbdagiao.Text = "Đã giao";
            this.rdbdagiao.UseVisualStyleBackColor = true;
            this.rdbdagiao.CheckedChanged += new System.EventHandler(this.rdbdagiao_CheckedChanged);
            // 
            // rdball
            // 
            this.rdball.AutoSize = true;
            this.rdball.Checked = true;
            this.rdball.Location = new System.Drawing.Point(6, 34);
            this.rdball.Name = "rdball";
            this.rdball.Size = new System.Drawing.Size(85, 27);
            this.rdball.TabIndex = 10;
            this.rdball.TabStop = true;
            this.rdball.Text = "Tất cả";
            this.rdball.UseVisualStyleBackColor = true;
            this.rdball.CheckedChanged += new System.EventHandler(this.rdball_CheckedChanged);
            // 
            // datahoadon
            // 
            this.datahoadon.AllowUserToAddRows = false;
            this.datahoadon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datahoadon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datahoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datahoadon.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datahoadon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datahoadon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datahoadon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datahoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datahoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datahoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.datahoadon.DefaultCellStyle = dataGridViewCellStyle3;
            this.datahoadon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datahoadon.DoubleBuffered = true;
            this.datahoadon.EnableHeadersVisualStyles = false;
            this.datahoadon.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.datahoadon.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.datahoadon.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.datahoadon.Location = new System.Drawing.Point(3, 61);
            this.datahoadon.Name = "datahoadon";
            this.datahoadon.ReadOnly = true;
            this.datahoadon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datahoadon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datahoadon.RowHeadersVisible = false;
            this.datahoadon.RowTemplate.Height = 50;
            this.datahoadon.RowTemplate.ReadOnly = true;
            this.datahoadon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datahoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datahoadon.Size = new System.Drawing.Size(943, 251);
            this.datahoadon.TabIndex = 5;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbodate);
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(609, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 272);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tùy chọn";
            // 
            // cbodate
            // 
            this.cbodate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodate.FormattingEnabled = true;
            this.cbodate.Items.AddRange(new object[] {
            "Ngày-Tháng-Năm",
            "Tháng",
            "Năm"});
            this.cbodate.Location = new System.Drawing.Point(27, 30);
            this.cbodate.Name = "cbodate";
            this.cbodate.Size = new System.Drawing.Size(262, 27);
            this.cbodate.TabIndex = 1;
            this.cbodate.SelectedIndexChanged += new System.EventHandler(this.cbodate_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged_1);
            // 
            // lblsodate
            // 
            this.lblsodate.AutoSize = true;
            this.lblsodate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsodate.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblsodate.Location = new System.Drawing.Point(136, 0);
            this.lblsodate.Name = "lblsodate";
            this.lblsodate.Size = new System.Drawing.Size(93, 32);
            this.lblsodate.TabIndex = 6;
            this.lblsodate.Text = "NULL";
            this.lblsodate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 619);
            this.Controls.Add(this.lblsodate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblthongke);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datahoadon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblthongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldonhoanthanh;
        private System.Windows.Forms.Label lbldtthucte;
        private System.Windows.Forms.Label lbldttam;
        private System.Windows.Forms.Label lblchuahoanthanh;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datahoadon;
        private System.Windows.Forms.RadioButton rdbdanggiao;
        private System.Windows.Forms.RadioButton rdbchuagiao;
        private System.Windows.Forms.RadioButton rdbdagiao;
        private System.Windows.Forms.RadioButton rdball;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cbodate;
        private System.Windows.Forms.Label lblsodate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}