namespace PUSPITA.Views
{
    partial class UpdateProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduk));
            BtnPupuk = new PictureBox();
            Header = new Label();
            BtnKembali = new PictureBox();
            pictureBox1 = new PictureBox();
            BtnPestisida = new PictureBox();
            DGVProduk = new DataGridView();
            TBIDProduk = new TextBox();
            pictureBox2 = new PictureBox();
            ID = new Label();
            Jenis = new Label();
            Harga = new Label();
            Dosis = new Label();
            TBNama = new TextBox();
            Nama = new Label();
            TBHarga = new TextBox();
            TBDosis = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            RBKetiga = new RadioButton();
            RBKedua = new RadioButton();
            RBPertama = new RadioButton();
            BtnUpdate = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BtnPupuk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnPestisida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnUpdate).BeginInit();
            SuspendLayout();
            // 
            // BtnPupuk
            // 
            BtnPupuk.BackgroundImage = Properties.Resources.Background_Header_;
            BtnPupuk.Image = Properties.Resources.PupukBtn;
            BtnPupuk.Location = new Point(820, 37);
            BtnPupuk.Margin = new Padding(3, 4, 3, 4);
            BtnPupuk.Name = "BtnPupuk";
            BtnPupuk.Size = new Size(207, 84);
            BtnPupuk.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnPupuk.TabIndex = 28;
            BtnPupuk.TabStop = false;
            BtnPupuk.Visible = false;
            BtnPupuk.Click += BtnPupuk_Click;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.White;
            Header.Image = Properties.Resources.Background_Header_;
            Header.Location = new Point(320, 46);
            Header.Name = "Header";
            Header.Size = new Size(405, 62);
            Header.TabIndex = 27;
            Header.Text = "Update Pupuk";
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
            BtnKembali.TabIndex = 26;
            BtnKembali.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Background_Header_;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1061, 153);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // BtnPestisida
            // 
            BtnPestisida.BackgroundImage = Properties.Resources.Background_Header_;
            BtnPestisida.Image = (Image)resources.GetObject("BtnPestisida.Image");
            BtnPestisida.Location = new Point(820, 37);
            BtnPestisida.Margin = new Padding(3, 4, 3, 4);
            BtnPestisida.Name = "BtnPestisida";
            BtnPestisida.Size = new Size(207, 84);
            BtnPestisida.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnPestisida.TabIndex = 29;
            BtnPestisida.TabStop = false;
            BtnPestisida.Click += BtnPestisida_Click;
            // 
            // DGVProduk
            // 
            DGVProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProduk.Location = new Point(12, 173);
            DGVProduk.Name = "DGVProduk";
            DGVProduk.RowHeadersWidth = 51;
            DGVProduk.Size = new Size(499, 494);
            DGVProduk.TabIndex = 30;
            // 
            // TBIDProduk
            // 
            TBIDProduk.BorderStyle = BorderStyle.None;
            TBIDProduk.Location = new Point(530, 239);
            TBIDProduk.Name = "TBIDProduk";
            TBIDProduk.Size = new Size(403, 20);
            TBIDProduk.TabIndex = 37;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Inputan;
            pictureBox2.Location = new Point(517, 225);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(430, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.BackColor = Color.Transparent;
            ID.Font = new Font("Times New Roman", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ID.ForeColor = Color.Black;
            ID.Location = new Point(517, 173);
            ID.Name = "ID";
            ID.Size = new Size(182, 48);
            ID.TabIndex = 35;
            ID.Text = "ID Pupuk";
            // 
            // Jenis
            // 
            Jenis.AutoSize = true;
            Jenis.BackColor = Color.Transparent;
            Jenis.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Jenis.Location = new Point(517, 608);
            Jenis.Name = "Jenis";
            Jenis.Size = new Size(222, 48);
            Jenis.TabIndex = 47;
            Jenis.Text = "Jenis Pupuk";
            // 
            // Harga
            // 
            Harga.AutoSize = true;
            Harga.BackColor = Color.Transparent;
            Harga.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Harga.Location = new Point(517, 499);
            Harga.Name = "Harga";
            Harga.Size = new Size(240, 48);
            Harga.TabIndex = 45;
            Harga.Text = "Harga Pupuk";
            // 
            // Dosis
            // 
            Dosis.AutoSize = true;
            Dosis.BackColor = Color.Transparent;
            Dosis.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dosis.Location = new Point(517, 390);
            Dosis.Name = "Dosis";
            Dosis.Size = new Size(232, 48);
            Dosis.TabIndex = 43;
            Dosis.Text = "Dosis Pupuk";
            // 
            // TBNama
            // 
            TBNama.BorderStyle = BorderStyle.None;
            TBNama.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBNama.Location = new Point(529, 349);
            TBNama.Margin = new Padding(3, 4, 3, 4);
            TBNama.Name = "TBNama";
            TBNama.Size = new Size(406, 22);
            TBNama.TabIndex = 38;
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.BackColor = Color.Transparent;
            Nama.Font = new Font("Times New Roman", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nama.Location = new Point(517, 281);
            Nama.Name = "Nama";
            Nama.Size = new Size(239, 48);
            Nama.TabIndex = 42;
            Nama.Text = "Nama Pupuk";
            // 
            // TBHarga
            // 
            TBHarga.BorderStyle = BorderStyle.None;
            TBHarga.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBHarga.Location = new Point(529, 567);
            TBHarga.Margin = new Padding(3, 4, 3, 4);
            TBHarga.Name = "TBHarga";
            TBHarga.Size = new Size(406, 22);
            TBHarga.TabIndex = 40;
            // 
            // TBDosis
            // 
            TBDosis.BorderStyle = BorderStyle.None;
            TBDosis.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBDosis.Location = new Point(529, 458);
            TBDosis.Margin = new Padding(3, 4, 3, 4);
            TBDosis.Name = "TBDosis";
            TBDosis.Size = new Size(406, 22);
            TBDosis.TabIndex = 39;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Inputan;
            pictureBox3.Location = new Point(517, 334);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(430, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Inputan;
            pictureBox4.Location = new Point(517, 443);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(430, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Inputan;
            pictureBox5.Location = new Point(517, 552);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(430, 52);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 46;
            pictureBox5.TabStop = false;
            // 
            // RBKetiga
            // 
            RBKetiga.BackColor = Color.Transparent;
            RBKetiga.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBKetiga.Location = new Point(529, 753);
            RBKetiga.Margin = new Padding(3, 4, 3, 4);
            RBKetiga.Name = "RBKetiga";
            RBKetiga.Size = new Size(141, 39);
            RBKetiga.TabIndex = 50;
            RBKetiga.TabStop = true;
            RBKetiga.Text = "Insectisida";
            RBKetiga.UseVisualStyleBackColor = false;
            RBKetiga.Visible = false;
            // 
            // RBKedua
            // 
            RBKedua.BackColor = Color.Transparent;
            RBKedua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBKedua.Location = new Point(529, 707);
            RBKedua.Margin = new Padding(3, 4, 3, 4);
            RBKedua.Name = "RBKedua";
            RBKedua.Size = new Size(141, 39);
            RBKedua.TabIndex = 49;
            RBKedua.TabStop = true;
            RBKedua.Text = "Anorganik";
            RBKedua.UseVisualStyleBackColor = false;
            // 
            // RBPertama
            // 
            RBPertama.BackColor = Color.Transparent;
            RBPertama.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RBPertama.Location = new Point(529, 660);
            RBPertama.Margin = new Padding(3, 4, 3, 4);
            RBPertama.Name = "RBPertama";
            RBPertama.Size = new Size(141, 39);
            RBPertama.TabIndex = 48;
            RBPertama.TabStop = true;
            RBPertama.Text = "Organik";
            RBPertama.UseVisualStyleBackColor = false;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Image = (Image)resources.GetObject("BtnUpdate.Image");
            BtnUpdate.Location = new Point(115, 707);
            BtnUpdate.Margin = new Padding(3, 4, 3, 4);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(238, 76);
            BtnUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnUpdate.TabIndex = 51;
            BtnUpdate.TabStop = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // UpdateProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1059, 862);
            Controls.Add(BtnUpdate);
            Controls.Add(RBKetiga);
            Controls.Add(RBKedua);
            Controls.Add(RBPertama);
            Controls.Add(Jenis);
            Controls.Add(Harga);
            Controls.Add(Dosis);
            Controls.Add(TBNama);
            Controls.Add(Nama);
            Controls.Add(TBHarga);
            Controls.Add(TBDosis);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(TBIDProduk);
            Controls.Add(pictureBox2);
            Controls.Add(ID);
            Controls.Add(DGVProduk);
            Controls.Add(BtnPestisida);
            Controls.Add(BtnPupuk);
            Controls.Add(Header);
            Controls.Add(BtnKembali);
            Controls.Add(pictureBox1);
            Name = "UpdateProduk";
            Text = "UpdateProduk";
            Load += UpdateProduk_Load;
            ((System.ComponentModel.ISupportInitialize)BtnPupuk).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnPestisida).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnUpdate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BtnPupuk;
        private Label Header;
        private PictureBox BtnKembali;
        private PictureBox pictureBox1;
        private PictureBox BtnPestisida;
        private DataGridView DGVProduk;
        private TextBox TBIDProduk;
        private PictureBox pictureBox2;
        private Label ID;
        private Label Jenis;
        private Label Harga;
        private Label Dosis;
        private TextBox TBNama;
        private Label Nama;
        private TextBox TBHarga;
        private TextBox TBDosis;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private RadioButton RBKetiga;
        private RadioButton RBKedua;
        private RadioButton RBPertama;
        private PictureBox BtnUpdate;
    }
}