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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kelola_Produksi));
            pictureBox1 = new PictureBox();
            btnHapusProduk = new PictureBox();
            btnUpdateProduk = new PictureBox();
            btnTambahProduk = new PictureBox();
            btnLihatProduk = new PictureBox();
            btnKembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHapusProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTambahProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-23, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1853, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnHapusProduk
            // 
            btnHapusProduk.BackgroundImage = Properties.Resources.Background;
            btnHapusProduk.Image = (Image)resources.GetObject("btnHapusProduk.Image");
            btnHapusProduk.Location = new Point(967, 297);
            btnHapusProduk.Name = "btnHapusProduk";
            btnHapusProduk.Size = new Size(737, 181);
            btnHapusProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHapusProduk.TabIndex = 2;
            btnHapusProduk.TabStop = false;
            btnHapusProduk.Click += btnHapusProduk_Click;
            // 
            // btnUpdateProduk
            // 
            btnUpdateProduk.BackgroundImage = Properties.Resources.Background;
            btnUpdateProduk.Image = (Image)resources.GetObject("btnUpdateProduk.Image");
            btnUpdateProduk.Location = new Point(90, 568);
            btnUpdateProduk.Name = "btnUpdateProduk";
            btnUpdateProduk.Size = new Size(737, 181);
            btnUpdateProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnUpdateProduk.TabIndex = 3;
            btnUpdateProduk.TabStop = false;
            btnUpdateProduk.Click += btnUpdateProduk_Click;
            // 
            // btnTambahProduk
            // 
            btnTambahProduk.BackgroundImage = Properties.Resources.Background;
            btnTambahProduk.Image = (Image)resources.GetObject("btnTambahProduk.Image");
            btnTambahProduk.Location = new Point(90, 297);
            btnTambahProduk.Name = "btnTambahProduk";
            btnTambahProduk.Size = new Size(737, 181);
            btnTambahProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnTambahProduk.TabIndex = 4;
            btnTambahProduk.TabStop = false;
            btnTambahProduk.Click += btnTambahProduk_Click;
            // 
            // btnLihatProduk
            // 
            btnLihatProduk.BackgroundImage = Properties.Resources.Background;
            btnLihatProduk.Image = (Image)resources.GetObject("btnLihatProduk.Image");
            btnLihatProduk.Location = new Point(967, 568);
            btnLihatProduk.Name = "btnLihatProduk";
            btnLihatProduk.Size = new Size(737, 181);
            btnLihatProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLihatProduk.TabIndex = 5;
            btnLihatProduk.TabStop = false;
            btnLihatProduk.Click += btnLihatProduk_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.Image = (Image)resources.GetObject("btnKembali.Image");
            btnKembali.Location = new Point(736, 892);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(271, 83);
            btnKembali.SizeMode = PictureBoxSizeMode.StretchImage;
            btnKembali.TabIndex = 6;
            btnKembali.TabStop = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // Kelola_Produksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1810, 1055);
            Controls.Add(btnKembali);
            Controls.Add(btnLihatProduk);
            Controls.Add(btnTambahProduk);
            Controls.Add(btnUpdateProduk);
            Controls.Add(btnHapusProduk);
            Controls.Add(pictureBox1);
            Name = "Kelola_Produksi";
            Text = "Kelola_Produksi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHapusProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdateProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTambahProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLihatProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox btnHapusProduk;
        private PictureBox btnUpdateProduk;
        private PictureBox btnTambahProduk;
        private PictureBox btnLihatProduk;
        private PictureBox btnKembali;
    }
}