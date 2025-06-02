namespace PUSPITA.Views
{
    partial class TambahProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahProduk));
            pictureBox1 = new PictureBox();
            BtnKembali = new PictureBox();
            BtnPestisida = new PictureBox();
            BtnTambah = new PictureBox();
            Gambar = new PictureBox();
            RBPertama = new RadioButton();
            RBKedua = new RadioButton();
            TBNama = new TextBox();
            TBDosis = new TextBox();
            TBHarga = new TextBox();
            pictureBox2 = new PictureBox();
            Nama = new Label();
            Dosis = new Label();
            pictureBox3 = new PictureBox();
            Harga = new Label();
            pictureBox4 = new PictureBox();
            Jenis = new Label();
            RBKetiga = new RadioButton();
            Header = new Label();
            BtnPupuk = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnPestisida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnTambah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gambar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnPupuk).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Background_Header_;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1061, 153);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnKembali
            // 
            BtnKembali.BackgroundImage = Properties.Resources.Background_Header_;
            BtnKembali.Image = (Image)resources.GetObject("BtnKembali.Image");
            BtnKembali.Location = new Point(26, 37);
            BtnKembali.Margin = new Padding(3, 4, 3, 4);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(207, 84);
            BtnKembali.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnKembali.TabIndex = 1;
            BtnKembali.TabStop = false;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // BtnPestisida
            // 
            BtnPestisida.BackgroundImage = Properties.Resources.Background_Header_;
            BtnPestisida.Image = (Image)resources.GetObject("BtnPestisida.Image");
            BtnPestisida.Location = new Point(825, 37);
            BtnPestisida.Margin = new Padding(3, 4, 3, 4);
            BtnPestisida.Name = "BtnPestisida";
            BtnPestisida.Size = new Size(207, 84);
            BtnPestisida.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnPestisida.TabIndex = 2;
            BtnPestisida.TabStop = false;
            BtnPestisida.Click += BtnPestisida_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.Image = (Image)resources.GetObject("BtnTambah.Image");
            BtnTambah.Location = new Point(645, 709);
            BtnTambah.Margin = new Padding(3, 4, 3, 4);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(238, 76);
            BtnTambah.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnTambah.TabIndex = 7;
            BtnTambah.TabStop = false;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // Gambar
            // 
            Gambar.BackColor = Color.Transparent;
            Gambar.Image = Properties.Resources.FertilizerHand;
            Gambar.Location = new Point(645, 172);
            Gambar.Margin = new Padding(3, 4, 3, 4);
            Gambar.Name = "Gambar";
            Gambar.Size = new Size(427, 519);
            Gambar.SizeMode = PictureBoxSizeMode.StretchImage;
            Gambar.TabIndex = 8;
            Gambar.TabStop = false;
            // 
            // RBPertama
            // 
            RBPertama.BackColor = Color.Transparent;
            RBPertama.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBPertama.Location = new Point(26, 628);
            RBPertama.Margin = new Padding(3, 4, 3, 4);
            RBPertama.Name = "RBPertama";
            RBPertama.Size = new Size(141, 39);
            RBPertama.TabIndex = 9;
            RBPertama.TabStop = true;
            RBPertama.Text = "Organik";
            RBPertama.UseVisualStyleBackColor = false;
            // 
            // RBKedua
            // 
            RBKedua.BackColor = Color.Transparent;
            RBKedua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBKedua.Location = new Point(26, 675);
            RBKedua.Margin = new Padding(3, 4, 3, 4);
            RBKedua.Name = "RBKedua";
            RBKedua.Size = new Size(141, 39);
            RBKedua.TabIndex = 10;
            RBKedua.TabStop = true;
            RBKedua.Text = "Anorganik";
            RBKedua.UseVisualStyleBackColor = false;
            // 
            // TBNama
            // 
            TBNama.BorderStyle = BorderStyle.None;
            TBNama.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBNama.Location = new Point(38, 240);
            TBNama.Margin = new Padding(3, 4, 3, 4);
            TBNama.Name = "TBNama";
            TBNama.Size = new Size(406, 22);
            TBNama.TabIndex = 11;
            // 
            // TBDosis
            // 
            TBDosis.BorderStyle = BorderStyle.None;
            TBDosis.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBDosis.Location = new Point(38, 368);
            TBDosis.Margin = new Padding(3, 4, 3, 4);
            TBDosis.Name = "TBDosis";
            TBDosis.Size = new Size(406, 22);
            TBDosis.TabIndex = 12;
            // 
            // TBHarga
            // 
            TBHarga.BorderStyle = BorderStyle.None;
            TBHarga.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBHarga.Location = new Point(38, 503);
            TBHarga.Margin = new Padding(3, 4, 3, 4);
            TBHarga.Name = "TBHarga";
            TBHarga.Size = new Size(406, 22);
            TBHarga.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Inputan;
            pictureBox2.Location = new Point(26, 225);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(430, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.BackColor = Color.Transparent;
            Nama.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nama.Location = new Point(26, 172);
            Nama.Name = "Nama";
            Nama.Size = new Size(239, 48);
            Nama.TabIndex = 15;
            Nama.Text = "Nama Pupuk";
            // 
            // Dosis
            // 
            Dosis.AutoSize = true;
            Dosis.BackColor = Color.Transparent;
            Dosis.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dosis.Location = new Point(26, 300);
            Dosis.Name = "Dosis";
            Dosis.Size = new Size(232, 48);
            Dosis.TabIndex = 16;
            Dosis.Text = "Dosis Pupuk";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Inputan;
            pictureBox3.Location = new Point(26, 353);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(430, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // Harga
            // 
            Harga.AutoSize = true;
            Harga.BackColor = Color.Transparent;
            Harga.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Harga.Location = new Point(26, 435);
            Harga.Name = "Harga";
            Harga.Size = new Size(240, 48);
            Harga.TabIndex = 19;
            Harga.Text = "Harga Pupuk";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Inputan;
            pictureBox4.Location = new Point(26, 488);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(430, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // Jenis
            // 
            Jenis.AutoSize = true;
            Jenis.BackColor = Color.Transparent;
            Jenis.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Jenis.Location = new Point(26, 567);
            Jenis.Name = "Jenis";
            Jenis.Size = new Size(222, 48);
            Jenis.TabIndex = 21;
            Jenis.Text = "Jenis Pupuk";
            // 
            // RBKetiga
            // 
            RBKetiga.BackColor = Color.Transparent;
            RBKetiga.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBKetiga.Location = new Point(26, 721);
            RBKetiga.Margin = new Padding(3, 4, 3, 4);
            RBKetiga.Name = "RBKetiga";
            RBKetiga.Size = new Size(141, 39);
            RBKetiga.TabIndex = 22;
            RBKetiga.TabStop = true;
            RBKetiga.Text = "Insectisida";
            RBKetiga.UseVisualStyleBackColor = false;
            RBKetiga.Visible = false;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.White;
            Header.Image = Properties.Resources.Background_Header_;
            Header.Location = new Point(336, 45);
            Header.Name = "Header";
            Header.Size = new Size(417, 62);
            Header.TabIndex = 23;
            Header.Text = "Tambah Pupuk";
            // 
            // BtnPupuk
            // 
            BtnPupuk.BackgroundImage = Properties.Resources.Background_Header_;
            BtnPupuk.Image = Properties.Resources.PupukBtn;
            BtnPupuk.Location = new Point(825, 37);
            BtnPupuk.Margin = new Padding(3, 4, 3, 4);
            BtnPupuk.Name = "BtnPupuk";
            BtnPupuk.Size = new Size(207, 84);
            BtnPupuk.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnPupuk.TabIndex = 24;
            BtnPupuk.TabStop = false;
            BtnPupuk.Visible = false;
            BtnPupuk.Click += BtnPupuk_Click;
            // 
            // TambahProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1059, 841);
            Controls.Add(BtnTambah);
            Controls.Add(BtnPupuk);
            Controls.Add(Header);
            Controls.Add(RBKetiga);
            Controls.Add(Jenis);
            Controls.Add(Harga);
            Controls.Add(Dosis);
            Controls.Add(TBNama);
            Controls.Add(Nama);
            Controls.Add(TBHarga);
            Controls.Add(TBDosis);
            Controls.Add(RBKedua);
            Controls.Add(RBPertama);
            Controls.Add(Gambar);
            Controls.Add(BtnPestisida);
            Controls.Add(BtnKembali);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TambahProduk";
            Text = "TambahProduk";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnPestisida).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnTambah).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gambar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnPupuk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox BtnKembali;
        private PictureBox BtnPestisida;
        private PictureBox BtnTambah;
        private PictureBox Gambar;
        private RadioButton RBPertama;
        private RadioButton RBKedua;
        private TextBox TBNama;
        private TextBox TBDosis;
        private TextBox TBHarga;
        private PictureBox pictureBox2;
        private Label Nama;
        private Label Dosis;
        private PictureBox pictureBox3;
        private Label Harga;
        private PictureBox pictureBox4;
        private Label Jenis;
        private RadioButton RBKetiga;
        private Label Header;
        private PictureBox BtnPupuk;
    }
}