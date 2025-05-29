namespace PUSPITA.Views
{
    partial class Update_Pestisida
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
            tbIDPestisida = new TextBox();
            dgvUpdatePestisida = new DataGridView();
            Idpestisida = new DataGridViewTextBoxColumn();
            NamaPestisida = new DataGridViewTextBoxColumn();
            JenisPestisida = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnPupuk = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnKembali = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnHapus = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUpdatePestisida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPupuk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHapus).BeginInit();
            SuspendLayout();
            // 
            // tbIDPestisida
            // 
            tbIDPestisida.Font = new Font("Segoe UI", 20F);
            tbIDPestisida.Location = new Point(243, 679);
            tbIDPestisida.Name = "tbIDPestisida";
            tbIDPestisida.Size = new Size(650, 52);
            tbIDPestisida.TabIndex = 31;
            // 
            // dgvUpdatePestisida
            // 
            dgvUpdatePestisida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdatePestisida.Columns.AddRange(new DataGridViewColumn[] { Idpestisida, NamaPestisida, JenisPestisida, Stock, Harga });
            dgvUpdatePestisida.Location = new Point(204, 248);
            dgvUpdatePestisida.Name = "dgvUpdatePestisida";
            dgvUpdatePestisida.RowHeadersWidth = 51;
            dgvUpdatePestisida.Size = new Size(1427, 336);
            dgvUpdatePestisida.TabIndex = 30;
            // 
            // Idpestisida
            // 
            Idpestisida.HeaderText = "iD Pestisida";
            Idpestisida.MinimumWidth = 6;
            Idpestisida.Name = "Idpestisida";
            Idpestisida.Width = 125;
            // 
            // NamaPestisida
            // 
            NamaPestisida.HeaderText = "Nama Pestisida";
            NamaPestisida.MinimumWidth = 6;
            NamaPestisida.Name = "NamaPestisida";
            NamaPestisida.Width = 125;
            // 
            // JenisPestisida
            // 
            JenisPestisida.HeaderText = "Jenis Pestisida";
            JenisPestisida.MinimumWidth = 6;
            JenisPestisida.Name = "JenisPestisida";
            JenisPestisida.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.Width = 125;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            Harga.Width = 125;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.Background_hijua_muda;
            pictureBox6.Image = Properties.Resources.Inputan;
            pictureBox6.Location = new Point(230, 670);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(681, 71);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.Background_hijua_muda;
            pictureBox5.Image = Properties.Resources.Masukkan_ID_Peptisida_;
            pictureBox5.Location = new Point(230, 617);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(489, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // btnPupuk
            // 
            btnPupuk.BackgroundImage = Properties.Resources.Background;
            btnPupuk.Image = Properties.Resources.button_pupuk;
            btnPupuk.Location = new Point(-5, 302);
            btnPupuk.Name = "btnPupuk";
            btnPupuk.Size = new Size(158, 63);
            btnPupuk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPupuk.TabIndex = 27;
            btnPupuk.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.Background_Header_;
            pictureBox4.Image = Properties.Resources.Logo_PUSPITA_HD;
            pictureBox4.Location = new Point(-9, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(207, 180);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Background_Header_;
            pictureBox3.Image = Properties.Resources.Header_Update_Pestisida;
            pictureBox3.Location = new Point(643, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(647, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // btnKembali
            // 
            btnKembali.BackgroundImage = Properties.Resources.Background_Header_;
            btnKembali.Image = Properties.Resources.Button_Kembali;
            btnKembali.Location = new Point(1525, 54);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(237, 87);
            btnKembali.SizeMode = PictureBoxSizeMode.AutoSize;
            btnKembali.TabIndex = 24;
            btnKembali.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Background_Header_;
            pictureBox2.Location = new Point(-9, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1832, 191);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Background_hijua_muda;
            pictureBox1.Image = Properties.Resources.Background_hijua_muda;
            pictureBox1.Location = new Point(154, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1541, 1023);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnHapus
            // 
            btnHapus.BackgroundImage = Properties.Resources.Background_hijua_muda;
            btnHapus.Image = Properties.Resources.Button_Hapus_;
            btnHapus.Location = new Point(1460, 923);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(216, 133);
            btnHapus.SizeMode = PictureBoxSizeMode.Zoom;
            btnHapus.TabIndex = 32;
            btnHapus.TabStop = false;
            // 
            // Update_Pestisida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1810, 1055);
            Controls.Add(tbIDPestisida);
            Controls.Add(dgvUpdatePestisida);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(btnPupuk);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btnKembali);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnHapus);
            Name = "Update_Pestisida";
            Text = "Update_Pestisida";
            ((System.ComponentModel.ISupportInitialize)dgvUpdatePestisida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPupuk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHapus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbIDPestisida;
        private DataGridView dgvUpdatePestisida;
        private DataGridViewTextBoxColumn Idpestisida;
        private DataGridViewTextBoxColumn NamaPestisida;
        private DataGridViewTextBoxColumn JenisPestisida;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Harga;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox btnPupuk;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox btnKembali;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox btnHapus;
    }
}