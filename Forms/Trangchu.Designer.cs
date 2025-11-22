namespace fightCrypto.Forms
{
    partial class Trangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trangchu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Taskbar = new System.Windows.Forms.Panel();
            this.btn_future = new System.Windows.Forms.Button();
            this.btnGiaoDich = new System.Windows.Forms.Button();
            this.btn_thịtruong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuGiaoDich = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.p2pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Thitruong = new System.Windows.Forms.Panel();
            this.panel_future = new System.Windows.Forms.Panel();
            this.dgv_Thitruong = new System.Windows.Forms.DataGridView();
            this.colIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.colSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceChangePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuoteVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Taskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuGiaoDich.SuspendLayout();
            this.panel_future.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thitruong)).BeginInit();
            this.SuspendLayout();
            // 
            // Taskbar
            // 
            this.Taskbar.Controls.Add(this.btn_future);
            this.Taskbar.Controls.Add(this.btnGiaoDich);
            this.Taskbar.Controls.Add(this.btn_thịtruong);
            this.Taskbar.Controls.Add(this.pictureBox1);
            this.Taskbar.Location = new System.Drawing.Point(2, 1);
            this.Taskbar.Name = "Taskbar";
            this.Taskbar.Size = new System.Drawing.Size(798, 38);
            this.Taskbar.TabIndex = 0;
            // 
            // btn_future
            // 
            this.btn_future.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btn_future.FlatAppearance.BorderSize = 0;
            this.btn_future.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_future.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_future.ForeColor = System.Drawing.Color.White;
            this.btn_future.Location = new System.Drawing.Point(228, 11);
            this.btn_future.Name = "btn_future";
            this.btn_future.Size = new System.Drawing.Size(75, 23);
            this.btn_future.TabIndex = 9;
            this.btn_future.Text = "Future";
            this.btn_future.UseVisualStyleBackColor = false;
            // 
            // btnGiaoDich
            // 
            this.btnGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.btnGiaoDich.FlatAppearance.BorderSize = 0;
            this.btnGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoDich.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btnGiaoDich.Location = new System.Drawing.Point(151, 9);
            this.btnGiaoDich.Name = "btnGiaoDich";
            this.btnGiaoDich.Size = new System.Drawing.Size(91, 27);
            this.btnGiaoDich.TabIndex = 8;
            this.btnGiaoDich.Text = "Giao dịch▾";
            this.btnGiaoDich.UseVisualStyleBackColor = false;
            this.btnGiaoDich.Click += new System.EventHandler(this.btnGiaoDich_Click);
            // 
            // btn_thịtruong
            // 
            this.btn_thịtruong.FlatAppearance.BorderSize = 0;
            this.btn_thịtruong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thịtruong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thịtruong.ForeColor = System.Drawing.Color.White;
            this.btn_thịtruong.Location = new System.Drawing.Point(71, 9);
            this.btn_thịtruong.Name = "btn_thịtruong";
            this.btn_thịtruong.Size = new System.Drawing.Size(86, 26);
            this.btn_thịtruong.TabIndex = 7;
            this.btn_thịtruong.Text = "Thị trường";
            this.btn_thịtruong.UseVisualStyleBackColor = false;
            this.btn_thịtruong.Click += new System.EventHandler(this.btn_thịtruong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuGiaoDich
            // 
            this.menuGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.menuGiaoDich.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuGiaoDich.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.p2pToolStripMenuItem,
            this.spotToolStripMenuItem,
            this.marginToolStripMenuItem});
            this.menuGiaoDich.Name = "menuGiaoDich";
            this.menuGiaoDich.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuGiaoDich.ShowImageMargin = false;
            this.menuGiaoDich.Size = new System.Drawing.Size(97, 70);
            // 
            // p2pToolStripMenuItem
            // 
            this.p2pToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2pToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.p2pToolStripMenuItem.Name = "p2pToolStripMenuItem";
            this.p2pToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.p2pToolStripMenuItem.Text = "P2p";
            // 
            // spotToolStripMenuItem
            // 
            this.spotToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spotToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.spotToolStripMenuItem.Name = "spotToolStripMenuItem";
            this.spotToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.spotToolStripMenuItem.Text = "Spot";
            // 
            // marginToolStripMenuItem
            // 
            this.marginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marginToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.marginToolStripMenuItem.Name = "marginToolStripMenuItem";
            this.marginToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.marginToolStripMenuItem.Text = "Margin";
            // 
            // panel_Thitruong
            // 
            this.panel_Thitruong.Location = new System.Drawing.Point(2, 45);
            this.panel_Thitruong.Name = "panel_Thitruong";
            this.panel_Thitruong.Size = new System.Drawing.Size(798, 407);
            this.panel_Thitruong.TabIndex = 1;
            // 
            // panel_future
            // 
            this.panel_future.Controls.Add(this.dgv_Thitruong);
            this.panel_future.Location = new System.Drawing.Point(2, 45);
            this.panel_future.Name = "panel_future";
            this.panel_future.Size = new System.Drawing.Size(798, 407);
            this.panel_future.TabIndex = 2;
            // 
            // dgv_Thitruong
            // 
            this.dgv_Thitruong.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.dgv_Thitruong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Thitruong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Thitruong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.dgv_Thitruong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Thitruong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Thitruong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Thitruong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Thitruong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIcon,
            this.colSymbol,
            this.colLastPrice,
            this.colPriceChangePercent,
            this.colQuoteVolume});
            this.dgv_Thitruong.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Thitruong.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Thitruong.EnableHeadersVisualStyles = false;
            this.dgv_Thitruong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.dgv_Thitruong.Location = new System.Drawing.Point(20, 3);
            this.dgv_Thitruong.Margin = new System.Windows.Forms.Padding(20);
            this.dgv_Thitruong.Name = "dgv_Thitruong";
            this.dgv_Thitruong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Thitruong.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Thitruong.RowHeadersVisible = false;
            this.dgv_Thitruong.RowHeadersWidth = 80;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.dgv_Thitruong.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Thitruong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_Thitruong.Size = new System.Drawing.Size(765, 373);
            this.dgv_Thitruong.TabIndex = 0;
            this.dgv_Thitruong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Thitruong_CellFormatting);
            // 
            // colIcon
            // 
            this.colIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIcon.HeaderText = "";
            this.colIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colIcon.MinimumWidth = 10;
            this.colIcon.Name = "colIcon";
            this.colIcon.Width = 60;
            // 
            // colSymbol
            // 
            this.colSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSymbol.DataPropertyName = "Symbol";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.colSymbol.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSymbol.FillWeight = 93.2741F;
            this.colSymbol.HeaderText = "Tên";
            this.colSymbol.Name = "colSymbol";
            // 
            // colLastPrice
            // 
            this.colLastPrice.DataPropertyName = "LastPrice";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Format = "C1";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.colLastPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.colLastPrice.FillWeight = 93.2741F;
            this.colLastPrice.HeaderText = "Giá";
            this.colLastPrice.Name = "colLastPrice";
            // 
            // colPriceChangePercent
            // 
            this.colPriceChangePercent.DataPropertyName = "PriceChangePercent";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.colPriceChangePercent.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPriceChangePercent.FillWeight = 93.2741F;
            this.colPriceChangePercent.HeaderText = "Thay đổi (24h)";
            this.colPriceChangePercent.Name = "colPriceChangePercent";
            // 
            // colQuoteVolume
            // 
            this.colQuoteVolume.DataPropertyName = "QuoteVolume";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.colQuoteVolume.DefaultCellStyle = dataGridViewCellStyle6;
            this.colQuoteVolume.FillWeight = 93.2741F;
            this.colQuoteVolume.HeaderText = "KL 24h ($)";
            this.colQuoteVolume.Name = "colQuoteVolume";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_future);
            this.Controls.Add(this.panel_Thitruong);
            this.Controls.Add(this.Taskbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Trangchu";
            this.Text = "Trang chủ";
            this.Taskbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuGiaoDich.ResumeLayout(false);
            this.panel_future.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thitruong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Taskbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_thịtruong;
        private System.Windows.Forms.Button btnGiaoDich;
        private System.Windows.Forms.ContextMenuStrip menuGiaoDich;
        private System.Windows.Forms.ToolStripMenuItem p2pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marginToolStripMenuItem;
        private System.Windows.Forms.Button btn_future;
        private System.Windows.Forms.Panel panel_Thitruong;
        private System.Windows.Forms.Panel panel_future;
        private System.Windows.Forms.DataGridView dgv_Thitruong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewImageColumn colIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceChangePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuoteVolume;
    }
}