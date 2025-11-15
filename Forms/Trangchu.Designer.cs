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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trangchu));
            this.Taskbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_thịtruong = new System.Windows.Forms.Button();
            this.Cbb_Giaodich = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Taskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Taskbar
            // 
            this.Taskbar.Controls.Add(this.button1);
            this.Taskbar.Controls.Add(this.Cbb_Giaodich);
            this.Taskbar.Controls.Add(this.btn_thịtruong);
            this.Taskbar.Controls.Add(this.pictureBox1);
            this.Taskbar.Location = new System.Drawing.Point(2, 1);
            this.Taskbar.Name = "Taskbar";
            this.Taskbar.Size = new System.Drawing.Size(798, 38);
            this.Taskbar.TabIndex = 0;
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
            // btn_thịtruong
            // 
            this.btn_thịtruong.FlatAppearance.BorderSize = 0;
            this.btn_thịtruong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thịtruong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thịtruong.ForeColor = System.Drawing.Color.White;
            this.btn_thịtruong.Location = new System.Drawing.Point(71, 12);
            this.btn_thịtruong.Name = "btn_thịtruong";
            this.btn_thịtruong.Size = new System.Drawing.Size(75, 23);
            this.btn_thịtruong.TabIndex = 7;
            this.btn_thịtruong.Text = "Thị trường";
            this.btn_thịtruong.UseVisualStyleBackColor = false;
            this.btn_thịtruong.Click += new System.EventHandler(this.btn_thịtruong_Click);
            // 
            // Cbb_Giaodich
            // 
            this.Cbb_Giaodich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.Cbb_Giaodich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbb_Giaodich.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Giaodich.ForeColor = System.Drawing.Color.White;
            this.Cbb_Giaodich.FormattingEnabled = true;
            this.Cbb_Giaodich.Items.AddRange(new object[] {
            "Spot",
            "P2p",
            "Chuyển đổi"});
            this.Cbb_Giaodich.Location = new System.Drawing.Point(152, 13);
            this.Cbb_Giaodich.Name = "Cbb_Giaodich";
            this.Cbb_Giaodich.Size = new System.Drawing.Size(78, 23);
            this.Cbb_Giaodich.TabIndex = 1;
            this.Cbb_Giaodich.Text = "Giao dịch";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(236, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Futures";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Taskbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Trangchu";
            this.Text = "Trang chủ";
            this.Taskbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Taskbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_thịtruong;
        private System.Windows.Forms.ComboBox Cbb_Giaodich;
        private System.Windows.Forms.Button button1;
    }
}