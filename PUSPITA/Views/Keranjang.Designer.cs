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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnKembali = new PictureBox();
            btnCheckout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCheckout).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.persegi_panjang_hijau;
            pictureBox1.Location = new Point(-8, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1829, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.persegi_panjang_hijau;
            pictureBox2.Image = Properties.Resources.Header_Keranjang;
            pictureBox2.Location = new Point(635, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(550, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnKembali
            // 
            btnKembali.BackgroundImage = Properties.Resources.persegi_panjang_hijau;
            btnKembali.Image = Properties.Resources.Kembali1;
            btnKembali.Location = new Point(40, 49);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(237, 87);
            btnKembali.SizeMode = PictureBoxSizeMode.StretchImage;
            btnKembali.TabIndex = 2;
            btnKembali.TabStop = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackgroundImage = Properties.Resources.persegi_panjang_hijau;
            btnCheckout.Image = Properties.Resources.BtnCheckout;
            btnCheckout.Location = new Point(1491, 55);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(267, 81);
            btnCheckout.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCheckout.TabIndex = 3;
            btnCheckout.TabStop = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // Keranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1810, 1055);
            Controls.Add(btnCheckout);
            Controls.Add(btnKembali);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Keranjang";
            Text = "Keranjang";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCheckout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btnKembali;
        private PictureBox btnCheckout;
    }
}