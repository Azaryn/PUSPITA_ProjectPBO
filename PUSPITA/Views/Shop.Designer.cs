namespace PUSPITA.Views
{
    partial class Shop
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
            label1 = new Label();
            btnKembali = new PictureBox();
            BtnKeranjang = new PictureBox();
            BtnPupuk = new PictureBox();
            BtnPestisida = new PictureBox();
            FLPproduk = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnKeranjang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnPupuk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnPestisida).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.persegi_panjang_hijau;
            pictureBox1.Location = new Point(-4, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1831, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.Background_Header_;
            label1.Location = new Point(665, 41);
            label1.Name = "label1";
            label1.Size = new Size(510, 103);
            label1.TabIndex = 2;
            label1.Text = "PUSPISHOP";
            // 
            // btnKembali
            // 
            btnKembali.BackgroundImage = Properties.Resources.persegi_panjang_hijau;
            btnKembali.Image = Properties.Resources.Kembali;
            btnKembali.Location = new Point(85, 60);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(175, 74);
            btnKembali.SizeMode = PictureBoxSizeMode.StretchImage;
            btnKembali.TabIndex = 18;
            btnKembali.TabStop = false;
            //btnKembali.Click += btnKembali_Click;
            // 
            // BtnKeranjang
            // 
            BtnKeranjang.BackgroundImage = Properties.Resources.persegi_panjang_hijau;
            BtnKeranjang.Image = Properties.Resources.BtnKeranjang;
            BtnKeranjang.Location = new Point(1552, 60);
            BtnKeranjang.Name = "BtnKeranjang";
            BtnKeranjang.Size = new Size(192, 74);
            BtnKeranjang.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnKeranjang.TabIndex = 19;
            BtnKeranjang.TabStop = false;
            //BtnKeranjang.Click += BtnKeranjang_Click;
            // 
            // BtnPupuk
            // 
            BtnPupuk.BackColor = Color.Transparent;
            BtnPupuk.Image = Properties.Resources.PupukBtn;
            BtnPupuk.Location = new Point(822, 223);
            BtnPupuk.Name = "BtnPupuk";
            BtnPupuk.Size = new Size(175, 67);
            BtnPupuk.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnPupuk.TabIndex = 22;
            BtnPupuk.TabStop = false;
            BtnPupuk.Visible = false;
            BtnPupuk.Click += BtnPupuk_Click;
            // 
            // BtnPestisida
            // 
            BtnPestisida.BackgroundImage = Properties.Resources.Background;
            BtnPestisida.Image = Properties.Resources.btnPestisida_____;
            BtnPestisida.Location = new Point(809, 197);
            BtnPestisida.Name = "BtnPestisida";
            BtnPestisida.Size = new Size(225, 134);
            BtnPestisida.SizeMode = PictureBoxSizeMode.Zoom;
            BtnPestisida.TabIndex = 24;
            BtnPestisida.TabStop = false;
            BtnPestisida.Click += BtnPestisida_Click_1;
            // 
            // FLPproduk
            // 
            FLPproduk.AutoScroll = true;
            FLPproduk.Location = new Point(24, 331);
            FLPproduk.Name = "FLPproduk";
            FLPproduk.Size = new Size(1758, 712);
            FLPproduk.TabIndex = 21;
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1810, 1055);
            Controls.Add(BtnPestisida);
            Controls.Add(BtnPupuk);
            Controls.Add(FLPproduk);
            Controls.Add(BtnKeranjang);
            Controls.Add(btnKembali);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Shop";
            Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnKeranjang).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnPupuk).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnPestisida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox btnKembali;
        private PictureBox BtnKeranjang;
        private PictureBox BtnPupuk;
        private PictureBox BtnPestisida;
        private FlowLayoutPanel FLPproduk;
    }
}