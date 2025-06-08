namespace PUSPITA.Views
{
    partial class cardproduk
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
            panel1 = new Panel();
            pbGambrProduk = new PictureBox();
            lblNamaProduk = new Label();
            lblDosis = new Label();
            lblHarga = new Label();
            btnTambah = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bgCard).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGambrProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTambah).BeginInit();
            SuspendLayout();
            // 
            // bgCard
            // 
            bgCard.Image = Properties.Resources.BG_cardproduk;
            bgCard.Location = new Point(0, 3);
            bgCard.Name = "bgCard";
            bgCard.Size = new Size(277, 373);
            bgCard.SizeMode = PictureBoxSizeMode.StretchImage;
            bgCard.TabIndex = 0;
            bgCard.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbGambrProduk);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 206);
            panel1.TabIndex = 1;
            // 
            // pbGambrProduk
            // 
            pbGambrProduk.BackColor = Color.White;
            pbGambrProduk.BackgroundImage = Properties.Resources.Background_hijua_muda;
            pbGambrProduk.Location = new Point(0, 0);
            pbGambrProduk.Name = "pbGambrProduk";
            pbGambrProduk.Size = new Size(277, 206);
            pbGambrProduk.SizeMode = PictureBoxSizeMode.Zoom;
            pbGambrProduk.TabIndex = 0;
            pbGambrProduk.TabStop = false;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.BackColor = Color.FromArgb(190, 224, 199);
            lblNamaProduk.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.ForeColor = SystemColors.ActiveCaptionText;
            lblNamaProduk.Location = new Point(77, 224);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(127, 24);
            lblNamaProduk.TabIndex = 2;
            lblNamaProduk.Text = "Nama Produk";
            // 
            // lblDosis
            // 
            lblDosis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDosis.AutoSize = true;
            lblDosis.BackColor = Color.FromArgb(190, 224, 199);
            lblDosis.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDosis.ForeColor = SystemColors.ActiveCaptionText;
            lblDosis.Location = new Point(110, 256);
            lblDosis.Name = "lblDosis";
            lblDosis.Size = new Size(55, 24);
            lblDosis.TabIndex = 3;
            lblDosis.Text = "Dosis";
            // 
            // lblHarga
            // 
            lblHarga.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.FromArgb(190, 224, 199);
            lblHarga.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.ForeColor = SystemColors.ActiveCaptionText;
            lblHarga.Location = new Point(109, 287);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(62, 24);
            lblHarga.TabIndex = 4;
            lblHarga.Text = "Harga";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(190, 224, 199);
            btnTambah.BackgroundImage = Properties.Resources.Background_hijua_muda;
            btnTambah.Image = Properties.Resources.btnTambah;
            btnTambah.Location = new Point(77, 314);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(125, 62);
            btnTambah.SizeMode = PictureBoxSizeMode.Zoom;
            btnTambah.TabIndex = 5;
            btnTambah.TabStop = false;
            btnTambah.Click += btnTambah_clickup;
            // 
            // cardproduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnTambah);
            Controls.Add(lblHarga);
            Controls.Add(lblDosis);
            Controls.Add(lblNamaProduk);
            Controls.Add(panel1);
            Controls.Add(bgCard);
            Name = "cardproduk";
            Size = new Size(278, 374);
            ((System.ComponentModel.ISupportInitialize)bgCard).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbGambrProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTambah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bgCard;
        private Panel panel1;
        private PictureBox pbGambrProduk;
        private Label lblNamaProduk;
        private Label lblDosis;
        private Label lblHarga;
        private PictureBox btnTambah;
    }
}
