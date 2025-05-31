namespace PUSPITA.Views
{
    partial class Lihat_Pupuk
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnPestisida = new PictureBox();
            pictureBox3 = new PictureBox();
            btnKembali = new PictureBox();
            pictureBox4 = new PictureBox();
            dataGridView1 = new DataGridView();
            NamaPupuk = new DataGridViewTextBoxColumn();
            JenisPupuk = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPestisida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Background_hijua_muda;
            pictureBox1.Location = new Point(145, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1528, 954);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Background_Header_;
            pictureBox2.Location = new Point(-10, -11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1829, 207);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnPestisida
            // 
            btnPestisida.BackgroundImage = Properties.Resources.Background;
            btnPestisida.Image = Properties.Resources.button_pestisida__2_;
            btnPestisida.Location = new Point(-5, 334);
            btnPestisida.Name = "btnPestisida";
            btnPestisida.Size = new Size(150, 66);
            btnPestisida.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPestisida.TabIndex = 5;
            btnPestisida.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Background_Header_;
            pictureBox3.Image = Properties.Resources.Logo_Puspita;
            pictureBox3.Location = new Point(-5, -4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(222, 186);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btnKembali
            // 
            btnKembali.BackgroundImage = Properties.Resources.Background_Header_;
            btnKembali.Image = Properties.Resources.Button_Kembali;
            btnKembali.Location = new Point(1540, 55);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(237, 87);
            btnKembali.SizeMode = PictureBoxSizeMode.AutoSize;
            btnKembali.TabIndex = 7;
            btnKembali.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.Background_Header_;
            pictureBox4.Image = Properties.Resources.header___Pupuk_PUSPITA;
            pictureBox4.Location = new Point(606, 42);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(614, 89);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NamaPupuk, JenisPupuk, Stock, Harga });
            dataGridView1.Location = new Point(184, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1427, 506);
            dataGridView1.TabIndex = 10;
            // 
            // NamaPupuk
            // 
            NamaPupuk.HeaderText = "Nama Pupuk";
            NamaPupuk.MinimumWidth = 6;
            NamaPupuk.Name = "NamaPupuk";
            NamaPupuk.Width = 125;
            // 
            // JenisPupuk
            // 
            JenisPupuk.HeaderText = "Jenis Pupuk";
            JenisPupuk.MinimumWidth = 6;
            JenisPupuk.Name = "JenisPupuk";
            JenisPupuk.Width = 125;
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
            // Lihat_Pupuk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1810, 1055);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox4);
            Controls.Add(btnKembali);
            Controls.Add(pictureBox3);
            Controls.Add(btnPestisida);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Lihat_Pupuk";
            Text = "Lihat_Pupuk";
            Load += Lihat_Pupuk_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPestisida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox btnPestisida;
        private PictureBox pictureBox3;
        private PictureBox btnKembali;
        private PictureBox pictureBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NamaPupuk;
        private DataGridViewTextBoxColumn JenisPupuk;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Harga;
    }
}