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
            lblDosis = new Label();
            lblHarga = new Label();
            btnTambah = new PictureBox();
            lblNamaProduk = new Label();
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
            panel1.BackgroundImage = Properties.Resources.Background_hijua_muda;
            panel1.Controls.Add(pbGambrProduk);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 206);
            panel1.TabIndex = 1;
            // 
            // pbGambrProduk
            // 
            pbGambrProduk.BackColor = Color.White;
            pbGambrProduk.BackgroundImage = Properties.Resources.Background_hijua_muda;
            pbGambrProduk.Image = Properties.Resources.gmbrPupuk;
            pbGambrProduk.Location = new Point(43, 0);
            pbGambrProduk.Name = "pbGambrProduk";
            pbGambrProduk.Size = new Size(172, 213);
            pbGambrProduk.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGambrProduk.TabIndex = 6;
            pbGambrProduk.TabStop = false;
            // 
            // lblDosis
            // 
            lblDosis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDosis.AutoSize = true;
            lblDosis.BackColor = Color.FromArgb(190, 224, 199);
            lblDosis.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDosis.ForeColor = SystemColors.ActiveCaptionText;
            lblDosis.Location = new Point(122, 252);
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
            lblHarga.Location = new Point(95, 282);
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
            btnTambah.Location = new Point(72, 314);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(125, 62);
            btnTambah.SizeMode = PictureBoxSizeMode.Zoom;
            btnTambah.TabIndex = 5;
            btnTambah.TabStop = false;
            btnTambah.Click += btnTambah_clickup;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.BackColor = Color.FromArgb(190, 224, 199);
            lblNamaProduk.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.ForeColor = SystemColors.ActiveCaptionText;
            lblNamaProduk.Location = new Point(96, 228);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(61, 24);
            lblNamaProduk.TabIndex = 7;
            lblNamaProduk.Text = "Nama";
            // 
            // cardproduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblNamaProduk);
            Controls.Add(btnTambah);
            Controls.Add(lblHarga);
            Controls.Add(lblDosis);
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
        private Label lblDosis;
        private Label lblHarga;
        private PictureBox btnTambah;
        private PictureBox pbGambrProduk;
        private Label lblNamaProduk;
    }
}
