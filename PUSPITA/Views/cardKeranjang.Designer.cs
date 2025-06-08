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
            ((System.ComponentModel.ISupportInitialize)bgCard).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGambarProduk).BeginInit();
            SuspendLayout();
            // 
            // bgCard
            // 
            bgCard.Image = Properties.Resources.BG_cardproduk;
            bgCard.Location = new Point(0, 0);
            bgCard.Name = "bgCard";
            bgCard.Size = new Size(277, 348);
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
            tbQuantity.Location = new Point(72, 317);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(127, 27);
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
            // cardKeranjang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
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
    }
}
