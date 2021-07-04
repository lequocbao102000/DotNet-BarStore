namespace QLDCPC
{
    partial class FormDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhMuc));
            this.datadanhmuc = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnthemdm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnxoadm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsuadm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsavedm = new System.Windows.Forms.ToolStripMenuItem();
            this.txtiddm = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txttendm = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthinhdm = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datadanhmuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datadanhmuc
            // 
            this.datadanhmuc.AllowUserToAddRows = false;
            this.datadanhmuc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datadanhmuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datadanhmuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datadanhmuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datadanhmuc.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datadanhmuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datadanhmuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datadanhmuc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datadanhmuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datadanhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadanhmuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.datadanhmuc.DefaultCellStyle = dataGridViewCellStyle3;
            this.datadanhmuc.DoubleBuffered = true;
            this.datadanhmuc.EnableHeadersVisualStyles = false;
            this.datadanhmuc.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.datadanhmuc.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.datadanhmuc.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.datadanhmuc.Location = new System.Drawing.Point(0, 258);
            this.datadanhmuc.Name = "datadanhmuc";
            this.datadanhmuc.ReadOnly = true;
            this.datadanhmuc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datadanhmuc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datadanhmuc.RowHeadersVisible = false;
            this.datadanhmuc.RowTemplate.Height = 50;
            this.datadanhmuc.RowTemplate.ReadOnly = true;
            this.datadanhmuc.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datadanhmuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datadanhmuc.Size = new System.Drawing.Size(1073, 311);
            this.datadanhmuc.TabIndex = 0;
            this.datadanhmuc.SelectionChanged += new System.EventHandler(this.datadanhmuc_SelectionChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthemdm,
            this.btnxoadm,
            this.btnsuadm,
            this.btnsavedm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 51);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnthemdm
            // 
            this.btnthemdm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemdm.Image = ((System.Drawing.Image)(resources.GetObject("btnthemdm.Image")));
            this.btnthemdm.Margin = new System.Windows.Forms.Padding(10);
            this.btnthemdm.Name = "btnthemdm";
            this.btnthemdm.Size = new System.Drawing.Size(89, 27);
            this.btnthemdm.Text = "Thêm";
            this.btnthemdm.Click += new System.EventHandler(this.btnthemdm_Click);
            // 
            // btnxoadm
            // 
            this.btnxoadm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoadm.Image = ((System.Drawing.Image)(resources.GetObject("btnxoadm.Image")));
            this.btnxoadm.Margin = new System.Windows.Forms.Padding(10);
            this.btnxoadm.Name = "btnxoadm";
            this.btnxoadm.Size = new System.Drawing.Size(75, 27);
            this.btnxoadm.Text = "Xóa";
            this.btnxoadm.Click += new System.EventHandler(this.btnxoadm_Click);
            // 
            // btnsuadm
            // 
            this.btnsuadm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuadm.Image = ((System.Drawing.Image)(resources.GetObject("btnsuadm.Image")));
            this.btnsuadm.Margin = new System.Windows.Forms.Padding(10);
            this.btnsuadm.Name = "btnsuadm";
            this.btnsuadm.Size = new System.Drawing.Size(75, 27);
            this.btnsuadm.Text = "Sửa";
            this.btnsuadm.Click += new System.EventHandler(this.btnsuadm_Click);
            // 
            // btnsavedm
            // 
            this.btnsavedm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavedm.Image = ((System.Drawing.Image)(resources.GetObject("btnsavedm.Image")));
            this.btnsavedm.Margin = new System.Windows.Forms.Padding(10);
            this.btnsavedm.Name = "btnsavedm";
            this.btnsavedm.Size = new System.Drawing.Size(77, 27);
            this.btnsavedm.Text = "Lưu";
            this.btnsavedm.Click += new System.EventHandler(this.btnsavedm_Click);
            // 
            // txtiddm
            // 
            this.txtiddm.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtiddm.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtiddm.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtiddm.BorderThickness = 3;
            this.txtiddm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtiddm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtiddm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtiddm.isPassword = false;
            this.txtiddm.Location = new System.Drawing.Point(236, 64);
            this.txtiddm.Margin = new System.Windows.Forms.Padding(4);
            this.txtiddm.Name = "txtiddm";
            this.txtiddm.Size = new System.Drawing.Size(362, 50);
            this.txtiddm.TabIndex = 5;
            this.txtiddm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txttendm
            // 
            this.txttendm.BorderColorFocused = System.Drawing.Color.Blue;
            this.txttendm.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttendm.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txttendm.BorderThickness = 3;
            this.txttendm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttendm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txttendm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttendm.isPassword = false;
            this.txttendm.Location = new System.Drawing.Point(236, 133);
            this.txttendm.Margin = new System.Windows.Forms.Padding(4);
            this.txttendm.Name = "txttendm";
            this.txttendm.Size = new System.Drawing.Size(362, 50);
            this.txttendm.TabIndex = 6;
            this.txttendm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Danh Mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Danh Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hình";
            // 
            // txthinhdm
            // 
            this.txthinhdm.BorderColorFocused = System.Drawing.Color.Blue;
            this.txthinhdm.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txthinhdm.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txthinhdm.BorderThickness = 3;
            this.txthinhdm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthinhdm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txthinhdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txthinhdm.isPassword = false;
            this.txthinhdm.Location = new System.Drawing.Point(236, 201);
            this.txthinhdm.Margin = new System.Windows.Forms.Padding(4);
            this.txthinhdm.Name = "txthinhdm";
            this.txthinhdm.Size = new System.Drawing.Size(362, 50);
            this.txthinhdm.TabIndex = 9;
            this.txthinhdm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MADM";
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENDM";
            this.Column2.HeaderText = "Tên danh mục";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HINH";
            this.Column3.HeaderText = "Hình";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 569);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthinhdm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttendm);
            this.Controls.Add(this.txtiddm);
            this.Controls.Add(this.datadanhmuc);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhMuc";
            this.Text = "FormDanhMuc";
            this.Load += new System.EventHandler(this.FormDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datadanhmuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid datadanhmuc;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnthemdm;
        private System.Windows.Forms.ToolStripMenuItem btnxoadm;
        private System.Windows.Forms.ToolStripMenuItem btnsuadm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txttendm;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtiddm;
        private System.Windows.Forms.ToolStripMenuItem btnsavedm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txthinhdm;
    }
}