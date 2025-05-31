namespace PUSPITA.Views
{
    partial class Kelola_Produksi
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnHapusProduk = new PictureBox();
            btnUpdateProduk = new PictureBox();
            btnTambahProduk = new PictureBox();
            btnLihatProduk = new PictureBox();
            btnKembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHapusProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTambahProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.persegi_panjang_hijau;
            pictureBox1.Location = new Point(-20, -4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1621, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.persegi_panjang_hijau;
            pictureBox2.Image = Properties.Resources.Header_Kelola_Produksi;
            pictureBox2.Location = new Point(496, 20);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(628, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnHapusProduk
            // 
            btnHapusProduk.BackgroundImage = Properties.Resources.Background;
            btnHapusProduk.Image = Properties.Resources.Button_Hapus_Produk;
            btnHapusProduk.Location = new Point(901, 221);
            btnHapusProduk.Margin = new Padding(3, 2, 3, 2);
            btnHapusProduk.Name = "btnHapusProduk";
            btnHapusProduk.Size = new Size(534, 109);
            btnHapusProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHapusProduk.TabIndex = 2;
            btnHapusProduk.TabStop = false;
            btnHapusProduk.Click += btnHapusProduk_Click;
            // 
            // btnUpdateProduk
            // 
            btnUpdateProduk.BackgroundImage = Properties.Resources.Background;
            btnUpdateProduk.Image = Properties.Resources.Button_Update_Produk;
            btnUpdateProduk.Location = new Point(79, 391);
            btnUpdateProduk.Margin = new Padding(3, 2, 3, 2);
            btnUpdateProduk.Name = "btnUpdateProduk";
            btnUpdateProduk.Size = new Size(534, 107);
            btnUpdateProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnUpdateProduk.TabIndex = 3;
            btnUpdateProduk.TabStop = false;
            btnUpdateProduk.Click += btnUpdateProduk_Click;
            // 
            // btnTambahProduk
            // 
            btnTambahProduk.BackgroundImage = Properties.Resources.Background;
            btnTambahProduk.Image = Properties.Resources.Button_Tambah_Produk;
            btnTambahProduk.Location = new Point(79, 221);
            btnTambahProduk.Margin = new Padding(3, 2, 3, 2);
            btnTambahProduk.Name = "btnTambahProduk";
            btnTambahProduk.Size = new Size(534, 109);
            btnTambahProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnTambahProduk.TabIndex = 4;
            btnTambahProduk.TabStop = false;
            btnTambahProduk.Click += btnTambahProduk_Click;
            // 
            // btnLihatProduk
            // 
            btnLihatProduk.BackgroundImage = Properties.Resources.Background;
            btnLihatProduk.Image = Properties.Resources.Button_Lihat_Produk;
            btnLihatProduk.Location = new Point(901, 391);
            btnLihatProduk.Margin = new Padding(3, 2, 3, 2);
            btnLihatProduk.Name = "btnLihatProduk";
            btnLihatProduk.Size = new Size(534, 107);
            btnLihatProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLihatProduk.TabIndex = 5;
            btnLihatProduk.TabStop = false;
            // 
            // btnKembali
            // 
            btnKembali.BackgroundImage = Properties.Resources.Background;
            btnKembali.Image = Properties.Resources.Button_Kembali;
            btnKembali.Location = new Point(1322, 709);
            btnKembali.Margin = new Padding(3, 2, 3, 2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(237, 87);
            btnKembali.SizeMode = PictureBoxSizeMode.AutoSize;
            btnKembali.TabIndex = 6;
            btnKembali.TabStop = false;
            // 
            // Kelola_Produksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1584, 791);
            Controls.Add(btnKembali);
            Controls.Add(btnLihatProduk);
            Controls.Add(btnTambahProduk);
            Controls.Add(btnUpdateProduk);
            Controls.Add(btnHapusProduk);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Kelola_Produksi";
            Text = "Kelola_Produksi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHapusProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTambahProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btnHapusProduk;
        private PictureBox btnUpdateProduk;
        private PictureBox btnTambahProduk;
        private PictureBox btnLihatProduk;
        private PictureBox btnKembali;
    }
}