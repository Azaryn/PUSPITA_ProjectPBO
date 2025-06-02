namespace PUSPITA.Views
{
    partial class Dashboard_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Admin));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnKelolaProduk = new PictureBox();
            btnHistoryTransaksi = new PictureBox();
            btnLogoutDashboard = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHistoryTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogoutDashboard).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1813, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Background;
            pictureBox2.Image = Properties.Resources.selamat_datang__Admin_;
            pictureBox2.Location = new Point(607, 249);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(661, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Background;
            pictureBox3.Image = Properties.Resources.Image_Admin;
            pictureBox3.Location = new Point(39, 333);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(800, 923);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // btnKelolaProduk
            // 
            btnKelolaProduk.BackgroundImage = Properties.Resources.Background;
            btnKelolaProduk.Image = Properties.Resources.Kelola_Produk_Button;
            btnKelolaProduk.Location = new Point(1099, 467);
            btnKelolaProduk.Margin = new Padding(3, 4, 3, 4);
            btnKelolaProduk.Name = "btnKelolaProduk";
            btnKelolaProduk.Size = new Size(547, 120);
            btnKelolaProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnKelolaProduk.TabIndex = 3;
            btnKelolaProduk.TabStop = false;
            btnKelolaProduk.Click += btnKelolaProduk_Click;
            // 
            // btnHistoryTransaksi
            // 
            btnHistoryTransaksi.BackgroundImage = Properties.Resources.Background;
            btnHistoryTransaksi.Image = Properties.Resources.History_Transaksi_Button;
            btnHistoryTransaksi.Location = new Point(1099, 617);
            btnHistoryTransaksi.Margin = new Padding(3, 4, 3, 4);
            btnHistoryTransaksi.Name = "btnHistoryTransaksi";
            btnHistoryTransaksi.Size = new Size(547, 120);
            btnHistoryTransaksi.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHistoryTransaksi.TabIndex = 4;
            btnHistoryTransaksi.TabStop = false;
            btnHistoryTransaksi.Click += btnHistoryTransaksi_Click;
            // 
            // btnLogoutDashboard
            // 
            btnLogoutDashboard.BackgroundImage = Properties.Resources.Background;
            btnLogoutDashboard.Image = Properties.Resources.Button_Log_out;
            btnLogoutDashboard.Location = new Point(1581, 936);
            btnLogoutDashboard.Margin = new Padding(3, 4, 3, 4);
            btnLogoutDashboard.Name = "btnLogoutDashboard";
            btnLogoutDashboard.Size = new Size(203, 84);
            btnLogoutDashboard.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogoutDashboard.TabIndex = 5;
            btnLogoutDashboard.TabStop = false;
            btnLogoutDashboard.Click += btnLogoutDashboard_Click;
            // 
            // Dashboard_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1810, 1055);
            Controls.Add(btnLogoutDashboard);
            Controls.Add(btnHistoryTransaksi);
            Controls.Add(btnKelolaProduk);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard_Admin";
            Text = "Dashboard_Admin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKelolaProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHistoryTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogoutDashboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox btnKelolaProduk;
        private PictureBox btnHistoryTransaksi;
        private PictureBox btnLogoutDashboard;

        public Dashboard_Admin(PictureBox btnKelolaProduk)
        {
            this.btnKelolaProduk = btnKelolaProduk;
        }
    }
}