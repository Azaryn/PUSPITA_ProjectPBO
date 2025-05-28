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
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1586, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Background;
            pictureBox2.Image = Properties.Resources.selamat_datang__Admin_;
            pictureBox2.Location = new Point(531, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(578, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Background;
            pictureBox3.Image = Properties.Resources.Image_Admin;
            pictureBox3.Location = new Point(34, 250);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(700, 692);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // btnKelolaProduk
            // 
            btnKelolaProduk.BackgroundImage = Properties.Resources.Background;
            btnKelolaProduk.Image = Properties.Resources.Kelola_Produk_Button;
            btnKelolaProduk.Location = new Point(962, 350);
            btnKelolaProduk.Name = "btnKelolaProduk";
            btnKelolaProduk.Size = new Size(479, 90);
            btnKelolaProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnKelolaProduk.TabIndex = 3;
            btnKelolaProduk.TabStop = false;
            btnKelolaProduk.Click += btnKelolaProduk_Click;
            // 
            // btnHistoryTransaksi
            // 
            btnHistoryTransaksi.BackgroundImage = Properties.Resources.Background;
            btnHistoryTransaksi.Image = Properties.Resources.History_Transaksi_Button;
            btnHistoryTransaksi.Location = new Point(962, 463);
            btnHistoryTransaksi.Name = "btnHistoryTransaksi";
            btnHistoryTransaksi.Size = new Size(479, 90);
            btnHistoryTransaksi.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHistoryTransaksi.TabIndex = 4;
            btnHistoryTransaksi.TabStop = false;
            // 
            // btnLogoutDashboard
            // 
            btnLogoutDashboard.BackgroundImage = Properties.Resources.Background;
            btnLogoutDashboard.Image = Properties.Resources.Button_Log_out;
            btnLogoutDashboard.Location = new Point(1383, 702);
            btnLogoutDashboard.Name = "btnLogoutDashboard";
            btnLogoutDashboard.Size = new Size(178, 63);
            btnLogoutDashboard.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogoutDashboard.TabIndex = 5;
            btnLogoutDashboard.TabStop = false;
            btnLogoutDashboard.Click += btnLogoutDashboard_Click;
            // 
            // Dashboard_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1584, 791);
            Controls.Add(btnLogoutDashboard);
            Controls.Add(btnHistoryTransaksi);
            Controls.Add(btnKelolaProduk);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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