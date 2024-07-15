namespace WindowsFormsApp
{
    partial class UrunIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeric_EkleSatis = new System.Windows.Forms.NumericUpDown();
            this.numeric_EkleAdet = new System.Windows.Forms.NumericUpDown();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.cmb_EkleKategori = new System.Windows.Forms.ComboBox();
            this.txt_EkleAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numeric_UpdSatis = new System.Windows.Forms.NumericUpDown();
            this.numeric_UpdİcerikAdet = new System.Windows.Forms.NumericUpDown();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.cmb_UpdKategori = new System.Windows.Forms.ComboBox();
            this.txt_UpdAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_UrunCesitSayısı = new System.Windows.Forms.Label();
            this.lbl_UrunStokSayısı = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_ara = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_EkleSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_EkleAdet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_UpdSatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_UpdİcerikAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numeric_EkleSatis);
            this.groupBox1.Controls.Add(this.numeric_EkleAdet);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.cmb_EkleKategori);
            this.groupBox1.Controls.Add(this.txt_EkleAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(71, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN EKLE";
            // 
            // numeric_EkleSatis
            // 
            this.numeric_EkleSatis.Location = new System.Drawing.Point(187, 192);
            this.numeric_EkleSatis.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numeric_EkleSatis.Name = "numeric_EkleSatis";
            this.numeric_EkleSatis.Size = new System.Drawing.Size(269, 28);
            this.numeric_EkleSatis.TabIndex = 12;
            // 
            // numeric_EkleAdet
            // 
            this.numeric_EkleAdet.Location = new System.Drawing.Point(187, 145);
            this.numeric_EkleAdet.Name = "numeric_EkleAdet";
            this.numeric_EkleAdet.Size = new System.Drawing.Size(269, 28);
            this.numeric_EkleAdet.TabIndex = 11;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Ekle.Location = new System.Drawing.Point(330, 235);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(126, 52);
            this.btn_Ekle.TabIndex = 8;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // cmb_EkleKategori
            // 
            this.cmb_EkleKategori.FormattingEnabled = true;
            this.cmb_EkleKategori.Location = new System.Drawing.Point(187, 101);
            this.cmb_EkleKategori.Name = "cmb_EkleKategori";
            this.cmb_EkleKategori.Size = new System.Drawing.Size(269, 30);
            this.cmb_EkleKategori.TabIndex = 5;
            // 
            // txt_EkleAd
            // 
            this.txt_EkleAd.Location = new System.Drawing.Point(187, 61);
            this.txt_EkleAd.Name = "txt_EkleAd";
            this.txt_EkleAd.Size = new System.Drawing.Size(269, 28);
            this.txt_EkleAd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SATIŞ FİYATI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "İÇERDİĞİ ADET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "KATEGORİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN ADI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numeric_UpdSatis);
            this.groupBox2.Controls.Add(this.numeric_UpdİcerikAdet);
            this.groupBox2.Controls.Add(this.btn_Guncelle);
            this.groupBox2.Controls.Add(this.cmb_UpdKategori);
            this.groupBox2.Controls.Add(this.txt_UpdAd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(682, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜRÜN GÜNCELLE";
            // 
            // numeric_UpdSatis
            // 
            this.numeric_UpdSatis.Location = new System.Drawing.Point(187, 192);
            this.numeric_UpdSatis.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numeric_UpdSatis.Name = "numeric_UpdSatis";
            this.numeric_UpdSatis.Size = new System.Drawing.Size(269, 28);
            this.numeric_UpdSatis.TabIndex = 14;
            // 
            // numeric_UpdİcerikAdet
            // 
            this.numeric_UpdİcerikAdet.Location = new System.Drawing.Point(187, 142);
            this.numeric_UpdİcerikAdet.Name = "numeric_UpdİcerikAdet";
            this.numeric_UpdİcerikAdet.Size = new System.Drawing.Size(269, 28);
            this.numeric_UpdİcerikAdet.TabIndex = 13;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(315, 235);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(141, 52);
            this.btn_Guncelle.TabIndex = 8;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // cmb_UpdKategori
            // 
            this.cmb_UpdKategori.FormattingEnabled = true;
            this.cmb_UpdKategori.Location = new System.Drawing.Point(187, 101);
            this.cmb_UpdKategori.Name = "cmb_UpdKategori";
            this.cmb_UpdKategori.Size = new System.Drawing.Size(269, 30);
            this.cmb_UpdKategori.TabIndex = 5;
            // 
            // txt_UpdAd
            // 
            this.txt_UpdAd.Location = new System.Drawing.Point(187, 61);
            this.txt_UpdAd.Name = "txt_UpdAd";
            this.txt_UpdAd.Size = new System.Drawing.Size(269, 28);
            this.txt_UpdAd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "SATIŞ FİYATI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "İÇERDİĞİ ADET";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(32, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "KATEGORİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(32, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "ÜRÜN ADI";
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Red;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(1068, 391);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(98, 75);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(163, 441);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "ARA";
            // 
            // txt_ara
            // 
            this.txt_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ara.Location = new System.Drawing.Point(239, 441);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(358, 28);
            this.txt_ara.TabIndex = 5;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1298, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Toplam Ürün Çeşit Sayısı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1304, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Toplam Ürün Stok Sayısı";
            // 
            // lbl_UrunCesitSayısı
            // 
            this.lbl_UrunCesitSayısı.AutoSize = true;
            this.lbl_UrunCesitSayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UrunCesitSayısı.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_UrunCesitSayısı.Location = new System.Drawing.Point(1605, 87);
            this.lbl_UrunCesitSayısı.Name = "lbl_UrunCesitSayısı";
            this.lbl_UrunCesitSayısı.Size = new System.Drawing.Size(99, 29);
            this.lbl_UrunCesitSayısı.TabIndex = 8;
            this.lbl_UrunCesitSayısı.Text = "label12";
            // 
            // lbl_UrunStokSayısı
            // 
            this.lbl_UrunStokSayısı.AutoSize = true;
            this.lbl_UrunStokSayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UrunStokSayısı.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_UrunStokSayısı.Location = new System.Drawing.Point(1605, 176);
            this.lbl_UrunStokSayısı.Name = "lbl_UrunStokSayısı";
            this.lbl_UrunStokSayısı.Size = new System.Drawing.Size(99, 29);
            this.lbl_UrunStokSayısı.TabIndex = 9;
            this.lbl_UrunStokSayısı.Text = "label12";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(240)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(168, 504);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1805, 407);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmb_ara
            // 
            this.cmb_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ara.FormattingEnabled = true;
            this.cmb_ara.Items.AddRange(new object[] {
            "BOŞ"});
            this.cmb_ara.Location = new System.Drawing.Point(643, 441);
            this.cmb_ara.Name = "cmb_ara";
            this.cmb_ara.Size = new System.Drawing.Size(251, 28);
            this.cmb_ara.TabIndex = 11;
            this.cmb_ara.SelectedIndexChanged += new System.EventHandler(this.cmb_ara_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(900, 447);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "kategoriye göre ara";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1924, 1053);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmb_ara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_UrunStokSayısı);
            this.Controls.Add(this.lbl_UrunCesitSayısı);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunIslemleri";
            this.Text = "UrunIslemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UrunIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_EkleSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_EkleAdet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_UpdSatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_UpdİcerikAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ComboBox cmb_EkleKategori;
        private System.Windows.Forms.TextBox txt_EkleAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.ComboBox cmb_UpdKategori;
        private System.Windows.Forms.TextBox txt_UpdAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_UrunCesitSayısı;
        private System.Windows.Forms.Label lbl_UrunStokSayısı;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numeric_EkleAdet;
        private System.Windows.Forms.NumericUpDown numeric_UpdİcerikAdet;
        private System.Windows.Forms.NumericUpDown numeric_EkleSatis;
        private System.Windows.Forms.NumericUpDown numeric_UpdSatis;
        private System.Windows.Forms.ComboBox cmb_ara;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}