namespace BKFoodCourt
{
    partial class TinhTrangDonHang
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.tinhtrangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monAnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uocTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tomato;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(715, 455);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monAnDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn,
            this.uocTinhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tinhtrangBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(715, 347);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tình Trạng Đơn Hàng Của Bạn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.OrangeRed;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(553, 11);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 33);
            this.button9.TabIndex = 16;
            this.button9.Text = "Quay lại";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tinhtrangBindingSource
            // 
            this.tinhtrangBindingSource.DataSource = typeof(BKFoodCourt.tinhtrang);
            this.tinhtrangBindingSource.CurrentChanged += new System.EventHandler(this.tinhtrangBindingSource_CurrentChanged);
            // 
            // monAnDataGridViewTextBoxColumn
            // 
            this.monAnDataGridViewTextBoxColumn.DataPropertyName = "MonAn";
            this.monAnDataGridViewTextBoxColumn.HeaderText = "Món Ăn";
            this.monAnDataGridViewTextBoxColumn.Name = "monAnDataGridViewTextBoxColumn";
            this.monAnDataGridViewTextBoxColumn.Width = 200;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            // 
            // uocTinhDataGridViewTextBoxColumn
            // 
            this.uocTinhDataGridViewTextBoxColumn.DataPropertyName = "UocTinh";
            this.uocTinhDataGridViewTextBoxColumn.HeaderText = "Ước tính";
            this.uocTinhDataGridViewTextBoxColumn.Name = "uocTinhDataGridViewTextBoxColumn";
            this.uocTinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // TinhTrangDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(715, 455);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TinhTrangDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TinhTrangDonHang";
            this.Load += new System.EventHandler(this.TinhTrangDonHang_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhtrangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.BindingSource tinhtrangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn monAnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uocTinhDataGridViewTextBoxColumn;
    }
}