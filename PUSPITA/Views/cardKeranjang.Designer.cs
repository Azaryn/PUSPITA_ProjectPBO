namespace PUSPITA.Views
{
    partial class cardKeranjang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bgCard = new PictureBox();
            lblHarga = new Label();
            lblNamaProduk = new Label();
            tbQuantity = new TextBox();
            panel1 = new Panel();
            pbGambarProduk = new PictureBox();
            btnKurang = new PictureBox();
            btnTambah = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bgCard).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGambarProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKurang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTambah).BeginInit();
            SuspendLayout();
            // 
            // bgCard
            // 
            bgCard.Image = Properties.Resources.BG_cardproduk;
            bgCard.Location = new Point(0, 0);
            bgCard.Name = "bgCard";
            bgCard.Size = new Size(277, 373);
            bgCard.SizeMode = PictureBoxSizeMode.StretchImage;
            bgCard.TabIndex = 1;
            bgCard.TabStop = false;
            // 
            // lblHarga
            // 
            lblHarga.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.FromArgb(190, 224, 199);
            lblHarga.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.ForeColor = SystemColors.ActiveCaptionText;
            lblHarga.Location = new Point(104, 276);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(62, 24);
            lblHarga.TabIndex = 6;
            lblHarga.Text = "Harga";
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.BackColor = Color.FromArgb(190, 224, 199);
            lblNamaProduk.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.ForeColor = SystemColors.ActiveCaptionText;
            lblNamaProduk.Location = new Point(72, 232);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(127, 24);
            lblNamaProduk.TabIndex = 5;
            lblNamaProduk.Text = "Nama Produk";
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Segoe UI", 13F);
            tbQuantity.Location = new Point(72, 325);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(127, 36);
            tbQuantity.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbGambarProduk);
            panel1.Location = new Point(0, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 206);
            panel1.TabIndex = 8;
            // 
            // pbGambarProduk
            // 
            pbGambarProduk.BackgroundImage = Properties.Resources.Background_hijua_muda;
            pbGambarProduk.Location = new Point(0, 0);
            pbGambarProduk.Name = "pbGambarProduk";
            pbGambarProduk.Size = new Size(277, 206);
            pbGambarProduk.TabIndex = 9;
            pbGambarProduk.TabStop = false;
            // 
            // btnKurang
            // 
            btnKurang.BackColor = Color.FromArgb(240, 104, 56);
            btnKurang.Image = Properties.Resources.Group_103;
            btnKurang.Location = new Point(33, 325);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(43, 36);
            btnKurang.SizeMode = PictureBoxSizeMode.StretchImage;
            btnKurang.TabIndex = 10;
            btnKurang.TabStop = false;
            btnKurang.Click += btnKurang_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(240, 104, 56);
            btnTambah.Image = Properties.Resources._;
            btnTambah.Location = new Point(193, 325);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(43, 36);
            btnTambah.SizeMode = PictureBoxSizeMode.Zoom;
            btnTambah.TabIndex = 11;
            btnTambah.TabStop = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // cardKeranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnTambah);
            Controls.Add(btnKurang);
            Controls.Add(panel1);
            Controls.Add(tbQuantity);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaProduk);
            Controls.Add(bgCard);
            Name = "cardKeranjang";
            Size = new Size(277, 373);
            ((System.ComponentModel.ISupportInitialize)bgCard).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbGambarProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKurang).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTambah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bgCard;
        private Label lblHarga;
        private Label lblNamaProduk;
        private TextBox tbQuantity;
        private Panel panel1;
        private PictureBox pbGambarProduk;
        private PictureBox btnKurang;
        private PictureBox btnTambah;
    }
}
