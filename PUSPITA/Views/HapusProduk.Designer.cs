namespace PUSPITA.Views
{
    partial class HapusProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HapusProduk));
            BtnPupuk = new PictureBox();
            Header = new Label();
            BtnKembali = new PictureBox();
            pictureBox1 = new PictureBox();
            BtnPestisida = new PictureBox();
            DGVProduk = new DataGridView();
            Nama = new Label();
            pictureBox2 = new PictureBox();
            BtnHapus = new PictureBox();
            TBIDProduk = new TextBox();
            ((System.ComponentModel.ISupportInitialize)BtnPupuk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnPestisida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnHapus).BeginInit();
            SuspendLayout();
            // 
            // BtnPupuk
            // 
            BtnPupuk.BackgroundImage = Properties.Resources.Background_Header_;
            BtnPupuk.Image = Properties.Resources.PupukBtn;
            BtnPupuk.Location = new Point(827, 39);
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
            Header.Location = new Point(356, 49);
            Header.Name = "Header";
            Header.Size = new Size(373, 62);
            Header.TabIndex = 27;
            Header.Text = "Hapus Pupuk";
            // 
            // BtnKembali
            // 
            BtnKembali.BackgroundImage = Properties.Resources.Background_Header_;
            BtnKembali.Image = (Image)resources.GetObject("BtnKembali.Image");
            BtnKembali.Location = new Point(29, 39);
            BtnKembali.Margin = new Padding(3, 4, 3, 4);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(207, 84);
            BtnKembali.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnKembali.TabIndex = 26;
            BtnKembali.TabStop = false;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Background_Header_;
            pictureBox1.Location = new Point(0, 0);
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
            BtnPestisida.Location = new Point(827, 39);
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
            DGVProduk.Location = new Point(29, 178);
            DGVProduk.Name = "DGVProduk";
            DGVProduk.RowHeadersWidth = 51;
            DGVProduk.Size = new Size(455, 501);
            DGVProduk.TabIndex = 30;
            // 
            // Nama
            // 
            Nama.AutoSize = true;
            Nama.BackColor = Color.Transparent;
            Nama.Font = new Font("Times New Roman", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nama.ForeColor = Color.Black;
            Nama.Location = new Point(505, 178);
            Nama.Name = "Nama";
            Nama.Size = new Size(182, 48);
            Nama.TabIndex = 31;
            Nama.Text = "ID Pupuk";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Inputan;
            pictureBox2.Location = new Point(505, 230);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(430, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // BtnHapus
            // 
            BtnHapus.Image = Properties.Resources.NewBtnHapus;
            BtnHapus.Location = new Point(423, 721);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(208, 68);
            BtnHapus.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnHapus.TabIndex = 33;
            BtnHapus.TabStop = false;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // TBIDProduk
            // 
            TBIDProduk.BorderStyle = BorderStyle.None;
            TBIDProduk.Location = new Point(518, 244);
            TBIDProduk.Name = "TBIDProduk";
            TBIDProduk.Size = new Size(403, 20);
            TBIDProduk.TabIndex = 34;
            // 
            // HapusProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1059, 841);
            Controls.Add(TBIDProduk);
            Controls.Add(BtnHapus);
            Controls.Add(pictureBox2);
            Controls.Add(Nama);
            Controls.Add(DGVProduk);
            Controls.Add(BtnPestisida);
            Controls.Add(BtnPupuk);
            Controls.Add(Header);
            Controls.Add(BtnKembali);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HapusProduk";
            Text = "HapusProduk";
            Load += HapusProduk_Load;
            ((System.ComponentModel.ISupportInitialize)BtnPupuk).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnPestisida).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnHapus).EndInit();
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
        private Label Nama;
        private PictureBox pictureBox2;
        private PictureBox BtnHapus;
        private TextBox TBIDProduk;
    }
}