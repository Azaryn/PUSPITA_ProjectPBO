namespace PUSPITA.Views
{
    partial class Keranjang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keranjang));
            pictureBox1 = new PictureBox();
            FLPproduk = new FlowLayoutPanel();
            btnKembali = new PictureBox();
            BtnCheckout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnCheckout).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Background;
            pictureBox1.Image = Properties.Resources.HeaderKeranjang;
            pictureBox1.Location = new Point(-10, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1828, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FLPproduk
            // 
            FLPproduk.AutoScroll = true;
            FLPproduk.Location = new Point(21, 321);
            FLPproduk.Name = "FLPproduk";
            FLPproduk.Size = new Size(1758, 740);
            FLPproduk.TabIndex = 22;
            // 
            // btnKembali
            // 
            btnKembali.BackgroundImage = Properties.Resources.persegi_panjang_hijau;
            btnKembali.Image = Properties.Resources.Kembali;
            btnKembali.Location = new Point(94, 48);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(175, 74);
            btnKembali.SizeMode = PictureBoxSizeMode.StretchImage;
            btnKembali.TabIndex = 23;
            btnKembali.TabStop = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // BtnCheckout
            // 
            BtnCheckout.BackgroundImage = Properties.Resources.persegi_panjang_hijau;
            BtnCheckout.Image = (Image)resources.GetObject("BtnCheckout.Image");
            BtnCheckout.Location = new Point(1559, 48);
            BtnCheckout.Name = "BtnCheckout";
            BtnCheckout.Size = new Size(175, 74);
            BtnCheckout.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnCheckout.TabIndex = 24;
            BtnCheckout.TabStop = false;
            BtnCheckout.Click += BtnCheckout_Click;
            // 
            // Keranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1810, 1055);
            Controls.Add(BtnCheckout);
            Controls.Add(btnKembali);
            Controls.Add(FLPproduk);
            Controls.Add(pictureBox1);
            Name = "Keranjang";
            Text = "Keranjang";
            Load += Keranjang_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnCheckout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel FLPproduk;
        private PictureBox btnKembali;
        private PictureBox BtnCheckout;
    }
}