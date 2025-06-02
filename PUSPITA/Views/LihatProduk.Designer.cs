namespace PUSPITA.Views
{
    partial class LihatProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LihatProduk));
            BtnPestisida = new PictureBox();
            Header = new Label();
            pictureBox2 = new PictureBox();
            BtnPupuk = new PictureBox();
            DGVProduk = new DataGridView();
            BtnKembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BtnPestisida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnPupuk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVProduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnKembali).BeginInit();
            SuspendLayout();
            // 
            // BtnPestisida
            // 
            BtnPestisida.BackgroundImage = Properties.Resources.Background_Header_;
            BtnPestisida.Image = (Image)resources.GetObject("BtnPestisida.Image");
            BtnPestisida.Location = new Point(823, 38);
            BtnPestisida.Margin = new Padding(3, 4, 3, 4);
            BtnPestisida.Name = "BtnPestisida";
            BtnPestisida.Size = new Size(207, 84);
            BtnPestisida.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnPestisida.TabIndex = 32;
            BtnPestisida.TabStop = false;
            BtnPestisida.Click += BtnPestisida_Click;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.White;
            Header.Image = Properties.Resources.Background_Header_;
            Header.Location = new Point(323, 47);
            Header.Name = "Header";
            Header.Size = new Size(401, 62);
            Header.TabIndex = 31;
            Header.Text = "Daftar Pupuk";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Background_Header_;
            pictureBox2.Location = new Point(1, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1061, 153);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // BtnPupuk
            // 
            BtnPupuk.BackgroundImage = Properties.Resources.Background_Header_;
            BtnPupuk.Image = Properties.Resources.PupukBtn;
            BtnPupuk.Location = new Point(823, 38);
            BtnPupuk.Margin = new Padding(3, 4, 3, 4);
            BtnPupuk.Name = "BtnPupuk";
            BtnPupuk.Size = new Size(207, 84);
            BtnPupuk.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnPupuk.TabIndex = 33;
            BtnPupuk.TabStop = false;
            BtnPupuk.Visible = false;
            BtnPupuk.Click += BtnPupuk_Click;
            // 
            // DGVProduk
            // 
            DGVProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProduk.Location = new Point(188, 178);
            DGVProduk.Name = "DGVProduk";
            DGVProduk.RowHeadersWidth = 51;
            DGVProduk.Size = new Size(664, 499);
            DGVProduk.TabIndex = 34;
            // 
            // BtnKembali
            // 
            BtnKembali.BackColor = Color.Transparent;
            BtnKembali.Image = (Image)resources.GetObject("BtnKembali.Image");
            BtnKembali.Location = new Point(424, 718);
            BtnKembali.Margin = new Padding(3, 4, 3, 4);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(207, 84);
            BtnKembali.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnKembali.TabIndex = 35;
            BtnKembali.TabStop = false;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // LihatProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1059, 841);
            Controls.Add(BtnKembali);
            Controls.Add(DGVProduk);
            Controls.Add(BtnPupuk);
            Controls.Add(BtnPestisida);
            Controls.Add(Header);
            Controls.Add(pictureBox2);
            Name = "LihatProduk";
            Text = "LihatProduk";
            Load += LihatProduk_Load;
            ((System.ComponentModel.ISupportInitialize)BtnPestisida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnPupuk).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVProduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnKembali).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox BtnPestisida;
        private Label Header;
        private PictureBox pictureBox2;
        private PictureBox BtnPupuk;
        private DataGridView DGVProduk;
        private PictureBox BtnKembali;
    }
}