namespace PUSPITA.Views
{
    partial class History_Transaksi_cs
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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnKembali = new PictureBox();
            dataGridView1 = new DataGridView();
            NamaPembeli = new DataGridViewTextBoxColumn();
            Pembeli = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Background;
            pictureBox3.Image = Properties.Resources.background_Transaksi__2_;
            pictureBox3.Location = new Point(197, 239);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1422, 849);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGO_PUSPITA_BG_Kuning;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.Background;
            pictureBox4.Image = Properties.Resources.Header_History_Transaksi___1_;
            pictureBox4.Location = new Point(569, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(730, 90);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            btnKembali.BackgroundImage = Properties.Resources.Background;
            btnKembali.Image = Properties.Resources.Button_Kembali;
            btnKembali.Location = new Point(1518, 34);
            btnKembali.Name = "pictureBox1";
            btnKembali.Size = new Size(237, 87);
            btnKembali.SizeMode = PictureBoxSizeMode.AutoSize;
            btnKembali.TabIndex = 7;
            btnKembali.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NamaPembeli, Pembeli, Jumlah, Total });
            dataGridView1.Location = new Point(276, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1249, 188);
            dataGridView1.TabIndex = 8;
            // 
            // NamaPembeli
            // 
            NamaPembeli.HeaderText = "Nama Pembeli";
            NamaPembeli.MinimumWidth = 10;
            NamaPembeli.Name = "NamaPembeli";
            NamaPembeli.Width = 300;
            // 
            // Pembeli
            // 
            Pembeli.HeaderText = "Pembeli";
            Pembeli.MinimumWidth = 10;
            Pembeli.Name = "Pembeli";
            Pembeli.Width = 300;
            // 
            // Jumlah
            // 
            Jumlah.HeaderText = "Jumlah";
            Jumlah.MinimumWidth = 10;
            Jumlah.Name = "Jumlah";
            Jumlah.Width = 300;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 10;
            Total.Name = "Total";
            Total.Width = 300;
            // 
            // History_Transaksi_cs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1810, 1055);
            Controls.Add(dataGridView1);
            Controls.Add(btnKembali);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Name = "History_Transaksi_cs";
            Text = "History_Transaksi_cs";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox btnKembali;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NamaPembeli;
        private DataGridViewTextBoxColumn Pembeli;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn Total;
    }
}