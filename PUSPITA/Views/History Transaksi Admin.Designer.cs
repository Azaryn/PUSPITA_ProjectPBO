﻿namespace PUSPITA.Views
{
    partial class History_Transaksi_Admin
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
            DGVHistory = new DataGridView();
            NamaPembeli = new DataGridViewTextBoxColumn();
            Pembelian = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            pictureBox5 = new PictureBox();
            BtnKembali = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DGVHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // DGVHistory
            // 
            DGVHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVHistory.BackgroundColor = Color.White;
            DGVHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVHistory.Location = new Point(325, 242);
            DGVHistory.Name = "DGVHistory";
            DGVHistory.RowHeadersWidth = 51;
            DGVHistory.Size = new Size(1222, 240);
            DGVHistory.TabIndex = 14;
            // 
            // NamaPembeli
            // 
            NamaPembeli.HeaderText = "Nama Pembeli";
            NamaPembeli.MinimumWidth = 10;
            NamaPembeli.Name = "NamaPembeli";
            NamaPembeli.Width = 300;
            // 
            // Pembelian
            // 
            Pembelian.HeaderText = "Pembelian";
            Pembelian.MinimumWidth = 10;
            Pembelian.Name = "Pembelian";
            Pembelian.Width = 300;
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
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.persegi_panjang_hijau;
            pictureBox5.Image = Properties.Resources.Header__History_Transaksi__1_;
            pictureBox5.Location = new Point(544, 25);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(730, 90);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // BtnKembali
            // 
            BtnKembali.BackgroundImage = Properties.Resources.Background_hijua_muda;
            BtnKembali.Image = Properties.Resources.Kembali1;
            BtnKembali.Location = new Point(828, 625);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(237, 87);
            BtnKembali.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnKembali.TabIndex = 12;
            BtnKembali.TabStop = false;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.persegi_panjang_hijau;
            pictureBox3.Image = Properties.Resources.Logo_Puspita;
            pictureBox3.Location = new Point(13, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(202, 197);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.persegi_panjang_hijau;
            pictureBox1.Location = new Point(-8, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1827, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Persegi_panjang__Hijau_muda;
            pictureBox2.Location = new Point(221, -11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1449, 1076);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.Persegi_panjang__Hijau_muda;
            pictureBox7.Image = Properties.Resources.text_Deskripsi______2_;
            pictureBox7.Location = new Point(828, 718);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(215, 47);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.garis_hitam;
            pictureBox6.Location = new Point(221, 707);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1449, 5);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // History_Transaksi_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1810, 1055);
            Controls.Add(DGVHistory);
            Controls.Add(pictureBox5);
            Controls.Add(BtnKembali);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Name = "History_Transaksi_Admin";
            Text = "History_Transaksi_Admin";
            Load += History_Transaksi_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)DGVHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVHistory;
        private DataGridViewTextBoxColumn NamaPembeli;
        private DataGridViewTextBoxColumn Pembelian;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn Total;
        private PictureBox pictureBox5;
        private PictureBox BtnKembali;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
    }
}