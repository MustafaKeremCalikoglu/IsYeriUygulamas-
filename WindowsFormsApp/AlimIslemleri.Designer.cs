namespace WindowsFormsApp
{
    partial class AlimIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlimIslemleri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_EkleFirma = new System.Windows.Forms.ComboBox();
            this.cmb_EkleUrunAdı = new System.Windows.Forms.ComboBox();
            this.numeric_EkleAdet = new System.Windows.Forms.NumericUpDown();
            this.numeric_EkleAlisFiyat = new System.Windows.Forms.NumericUpDown();
            this.txt_EkleFaturaNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FaturaNo = new System.Windows.Forms.Label();
            this.btn_FaturaAc = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_FaturaTarih = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_kayitsayisi = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_tumsil = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_EkleAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_EkleAlisFiyat)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_EkleFirma);
            this.groupBox1.Controls.Add(this.cmb_EkleUrunAdı);
            this.groupBox1.Controls.Add(this.numeric_EkleAdet);
            this.groupBox1.Controls.Add(this.numeric_EkleAlisFiyat);
            this.groupBox1.Controls.Add(this.txt_EkleFaturaNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmb_EkleFirma
            // 
            this.cmb_EkleFirma.FormattingEnabled = true;
            this.cmb_EkleFirma.Location = new System.Drawing.Point(171, 198);
            this.cmb_EkleFirma.Name = "cmb_EkleFirma";
            this.cmb_EkleFirma.Size = new System.Drawing.Size(226, 24);
            this.cmb_EkleFirma.TabIndex = 10;
            // 
            // cmb_EkleUrunAdı
            // 
            this.cmb_EkleUrunAdı.FormattingEnabled = true;
            this.cmb_EkleUrunAdı.Location = new System.Drawing.Point(171, 86);
            this.cmb_EkleUrunAdı.Name = "cmb_EkleUrunAdı";
            this.cmb_EkleUrunAdı.Size = new System.Drawing.Size(226, 24);
            this.cmb_EkleUrunAdı.TabIndex = 9;
            // 
            // numeric_EkleAdet
            // 
            this.numeric_EkleAdet.Location = new System.Drawing.Point(171, 160);
            this.numeric_EkleAdet.Name = "numeric_EkleAdet";
            this.numeric_EkleAdet.Size = new System.Drawing.Size(226, 22);
            this.numeric_EkleAdet.TabIndex = 8;
            // 
            // numeric_EkleAlisFiyat
            // 
            this.numeric_EkleAlisFiyat.DecimalPlaces = 2;
            this.numeric_EkleAlisFiyat.Location = new System.Drawing.Point(171, 122);
            this.numeric_EkleAlisFiyat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_EkleAlisFiyat.Name = "numeric_EkleAlisFiyat";
            this.numeric_EkleAlisFiyat.Size = new System.Drawing.Size(226, 22);
            this.numeric_EkleAlisFiyat.TabIndex = 7;
            // 
            // txt_EkleFaturaNo
            // 
            this.txt_EkleFaturaNo.Enabled = false;
            this.txt_EkleFaturaNo.Location = new System.Drawing.Point(171, 56);
            this.txt_EkleFaturaNo.Name = "txt_EkleFaturaNo";
            this.txt_EkleFaturaNo.Size = new System.Drawing.Size(226, 22);
            this.txt_EkleFaturaNo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Firma Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alıs Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Urun Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fatura No";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Ekle.Enabled = false;
            this.btn_Ekle.Location = new System.Drawing.Point(322, 228);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 49);
            this.btn_Ekle.TabIndex = 0;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Guncelle);
            this.groupBox2.Location = new System.Drawing.Point(439, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(303, 228);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(75, 49);
            this.btn_Guncelle.TabIndex = 0;
            this.btn_Guncelle.Text = "Guncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 485);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1865, 386);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1499, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Faturan No:";
            // 
            // lbl_FaturaNo
            // 
            this.lbl_FaturaNo.AutoSize = true;
            this.lbl_FaturaNo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lbl_FaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_FaturaNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_FaturaNo.Location = new System.Drawing.Point(1653, 22);
            this.lbl_FaturaNo.Name = "lbl_FaturaNo";
            this.lbl_FaturaNo.Size = new System.Drawing.Size(149, 22);
            this.lbl_FaturaNo.TabIndex = 5;
            this.lbl_FaturaNo.Text = "Fatura Açılmadı";
            // 
            // btn_FaturaAc
            // 
            this.btn_FaturaAc.BackColor = System.Drawing.Color.Teal;
            this.btn_FaturaAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_FaturaAc.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_FaturaAc.Location = new System.Drawing.Point(1736, 414);
            this.btn_FaturaAc.Name = "btn_FaturaAc";
            this.btn_FaturaAc.Size = new System.Drawing.Size(176, 46);
            this.btn_FaturaAc.TabIndex = 6;
            this.btn_FaturaAc.Text = "YENİ FATURA";
            this.btn_FaturaAc.UseVisualStyleBackColor = false;
            this.btn_FaturaAc.Click += new System.EventHandler(this.btn_FaturaAc_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1499, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "Faturan Tarih:";
            // 
            // lbl_FaturaTarih
            // 
            this.lbl_FaturaTarih.AutoSize = true;
            this.lbl_FaturaTarih.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lbl_FaturaTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_FaturaTarih.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_FaturaTarih.Location = new System.Drawing.Point(1653, 62);
            this.lbl_FaturaTarih.Name = "lbl_FaturaTarih";
            this.lbl_FaturaTarih.Size = new System.Drawing.Size(149, 22);
            this.lbl_FaturaTarih.TabIndex = 8;
            this.lbl_FaturaTarih.Text = "Fatura Açılmadı";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(859, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1174, 272);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1707, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kayıt Sayısı =>";
            // 
            // lbl_kayitsayisi
            // 
            this.lbl_kayitsayisi.AutoSize = true;
            this.lbl_kayitsayisi.BackColor = System.Drawing.Color.Turquoise;
            this.lbl_kayitsayisi.Location = new System.Drawing.Point(1819, 380);
            this.lbl_kayitsayisi.Name = "lbl_kayitsayisi";
            this.lbl_kayitsayisi.Size = new System.Drawing.Size(0, 16);
            this.lbl_kayitsayisi.TabIndex = 10;
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Sil.Location = new System.Drawing.Point(859, 380);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(93, 29);
            this.btn_Sil.TabIndex = 11;
            this.btn_Sil.Text = "Seçili Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_tumsil
            // 
            this.btn_tumsil.BackColor = System.Drawing.Color.Red;
            this.btn_tumsil.Location = new System.Drawing.Point(958, 380);
            this.btn_tumsil.Name = "btn_tumsil";
            this.btn_tumsil.Size = new System.Drawing.Size(131, 29);
            this.btn_tumsil.TabIndex = 12;
            this.btn_tumsil.Text = "Tümünü Sil";
            this.btn_tumsil.UseVisualStyleBackColor = false;
            this.btn_tumsil.Click += new System.EventHandler(this.btn_tumsil_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Enabled = false;
            this.btn_yazdir.Location = new System.Drawing.Point(1138, 380);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(138, 29);
            this.btn_yazdir.TabIndex = 13;
            this.btn_yazdir.Text = "pdf Kaydet";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.dunyanin_en_bilinen_markalari;
            this.pictureBox1.Location = new System.Drawing.Point(859, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // AlimIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1924, 1053);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.btn_tumsil);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.lbl_kayitsayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_FaturaTarih);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_FaturaAc);
            this.Controls.Add(this.lbl_FaturaNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlimIslemleri";
            this.Text = "Guncelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AlimIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_EkleAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_EkleAlisFiyat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_FaturaNo;
        private System.Windows.Forms.Button btn_FaturaAc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_FaturaTarih;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_EkleFirma;
        private System.Windows.Forms.ComboBox cmb_EkleUrunAdı;
        private System.Windows.Forms.NumericUpDown numeric_EkleAdet;
        private System.Windows.Forms.NumericUpDown numeric_EkleAlisFiyat;
        private System.Windows.Forms.TextBox txt_EkleFaturaNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_kayitsayisi;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_tumsil;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}