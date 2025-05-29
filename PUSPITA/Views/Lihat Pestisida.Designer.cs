namespace PUSPITA.Views
{
    partial class Lihat_Pestisida
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
            dataGridView1 = new DataGridView();
            pictureBox4 = new PictureBox();
            btnKembali = new PictureBox();
            pictureBox3 = new PictureBox();
            btnPupuk = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            NamaPestisida = new DataGridViewTextBoxColumn();
            JenisPestisda = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPupuk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NamaPestisida, JenisPestisda, Stock, Harga });
            dataGridView1.Location = new Point(185, 218);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1427, 506);
            dataGridView1.TabIndex = 17;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.Background_Header_;
            pictureBox4.Image = Properties.Resources.Header__Pestisida_PUSPITA__2_;
            pictureBox4.Location = new Point(607, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(736, 89);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // btnKembali
            // 
            btnKembali.BackgroundImage = Properties.Resources.Background_Header_;
            btnKembali.Image = Properties.Resources.Button_Kembali;
            btnKembali.Location = new Point(1541, 42);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(237, 87);
            btnKembali.SizeMode = PictureBoxSizeMode.AutoSize;
            btnKembali.TabIndex = 15;
            btnKembali.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Background_Header_;
            pictureBox3.Image = Properties.Resources.Logo_Puspita;
            pictureBox3.Location = new Point(-4, -17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(222, 186);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // btnPupuk
            // 
            btnPupuk.BackgroundImage = Properties.Resources.Background;
            btnPupuk.Image = Properties.Resources.button_pupuk;
            btnPupuk.Location = new Point(-4, 321);
            btnPupuk.Name = "btnPupuk";
            btnPupuk.Size = new Size(150, 66);
            btnPupuk.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPupuk.TabIndex = 13;
            btnPupuk.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Background_Header_;
            pictureBox2.Location = new Point(-9, -24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1829, 207);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Background_hijua_muda;
            pictureBox1.Location = new Point(146, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1528, 954);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // NamaPestisida
            // 
            NamaPestisida.HeaderText = "Nama Pestisida";
            NamaPestisida.MinimumWidth = 6;
            NamaPestisida.Name = "NamaPestisida";
            NamaPestisida.Width = 125;
            // 
            // JenisPestisda
            // 
            JenisPestisda.HeaderText = "Jenis Pestisida";
            JenisPestisda.MinimumWidth = 6;
            JenisPestisda.Name = "JenisPestisda";
            JenisPestisda.Width = 125;
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
            // Lihat_Pestisida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1810, 1055);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox4);
            Controls.Add(btnKembali);
            Controls.Add(pictureBox3);
            Controls.Add(btnPupuk);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Lihat_Pestisida";
            Text = "Lihat_Pestisida";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPupuk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NamaPupuk;
        private DataGridViewTextBoxColumn JenisPupuk;
        private PictureBox pictureBox4;
        private PictureBox btnKembali;
        private PictureBox pictureBox3;
        private PictureBox btnPupuk;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn NamaPestisida;
        private DataGridViewTextBoxColumn JenisPestisda;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Harga;
    }
}