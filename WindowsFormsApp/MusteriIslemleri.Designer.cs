namespace WindowsFormsApp
{
    partial class MusteriIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picbox_Ekle = new System.Windows.Forms.PictureBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_EkleMail = new System.Windows.Forms.TextBox();
            this.txt_EkleTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_EkleUnvan = new System.Windows.Forms.TextBox();
            this.txt_EkleSoyad = new System.Windows.Forms.TextBox();
            this.txt_EkleAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_GuncelleId = new System.Windows.Forms.Label();
            this.Guncelle = new System.Windows.Forms.Button();
            this.picboxUpd = new System.Windows.Forms.PictureBox();
            this.linklabelResimGuncelle = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_UpdMail = new System.Windows.Forms.TextBox();
            this.txt_UpdTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txt_UpdUnvan = new System.Windows.Forms.TextBox();
            this.txt_UpdSoyad = new System.Windows.Forms.TextBox();
            this.txt_UpdAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_isimegoreara = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_ToplamSayı = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Ekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUpd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.picbox_Ekle);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.txt_EkleMail);
            this.groupBox1.Controls.Add(this.txt_EkleTelefon);
            this.groupBox1.Controls.Add(this.txt_EkleUnvan);
            this.groupBox1.Controls.Add(this.txt_EkleSoyad);
            this.groupBox1.Controls.Add(this.txt_EkleAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(53, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MÜŞTERİ EKLE";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(254, 244);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 16);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Resim Ekle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // picbox_Ekle
            // 
            this.picbox_Ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbox_Ekle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox_Ekle.Location = new System.Drawing.Point(27, 203);
            this.picbox_Ekle.Name = "picbox_Ekle";
            this.picbox_Ekle.Size = new System.Drawing.Size(172, 188);
            this.picbox_Ekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_Ekle.TabIndex = 12;
            this.picbox_Ekle.TabStop = false;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Ekle.Location = new System.Drawing.Point(427, 321);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(131, 60);
            this.btn_Ekle.TabIndex = 11;
            this.btn_Ekle.Text = "KAYDET";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_EkleMail
            // 
            this.txt_EkleMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_EkleMail.Location = new System.Drawing.Point(257, 163);
            this.txt_EkleMail.MaxLength = 30;
            this.txt_EkleMail.Name = "txt_EkleMail";
            this.txt_EkleMail.Size = new System.Drawing.Size(318, 27);
            this.txt_EkleMail.TabIndex = 10;
            // 
            // txt_EkleTelefon
            // 
            this.txt_EkleTelefon.Location = new System.Drawing.Point(257, 130);
            this.txt_EkleTelefon.Mask = "09990000000";
            this.txt_EkleTelefon.Name = "txt_EkleTelefon";
            this.txt_EkleTelefon.Size = new System.Drawing.Size(113, 22);
            this.txt_EkleTelefon.TabIndex = 9;
            // 
            // txt_EkleUnvan
            // 
            this.txt_EkleUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_EkleUnvan.Location = new System.Drawing.Point(257, 96);
            this.txt_EkleUnvan.MaxLength = 30;
            this.txt_EkleUnvan.Name = "txt_EkleUnvan";
            this.txt_EkleUnvan.Size = new System.Drawing.Size(318, 27);
            this.txt_EkleUnvan.TabIndex = 8;
            // 
            // txt_EkleSoyad
            // 
            this.txt_EkleSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_EkleSoyad.Location = new System.Drawing.Point(257, 64);
            this.txt_EkleSoyad.MaxLength = 30;
            this.txt_EkleSoyad.Name = "txt_EkleSoyad";
            this.txt_EkleSoyad.Size = new System.Drawing.Size(318, 27);
            this.txt_EkleSoyad.TabIndex = 7;
            // 
            // txt_EkleAd
            // 
            this.txt_EkleAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_EkleAd.Location = new System.Drawing.Point(257, 30);
            this.txt_EkleAd.MaxLength = 30;
            this.txt_EkleAd.Name = "txt_EkleAd";
            this.txt_EkleAd.Size = new System.Drawing.Size(318, 27);
            this.txt_EkleAd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(254, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Müşteri Resim Dosyası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Müşteri Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müşteri Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Müşteri Ünvanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(216)))), ((int)(((byte)(240)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(747, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 639);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Red;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(656, 792);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(70, 62);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_GuncelleId);
            this.groupBox2.Controls.Add(this.Guncelle);
            this.groupBox2.Controls.Add(this.picboxUpd);
            this.groupBox2.Controls.Add(this.linklabelResimGuncelle);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_UpdMail);
            this.groupBox2.Controls.Add(this.txt_UpdTelefon);
            this.groupBox2.Controls.Add(this.txt_UpdUnvan);
            this.groupBox2.Controls.Add(this.txt_UpdSoyad);
            this.groupBox2.Controls.Add(this.txt_UpdAd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(53, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 408);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÜNCELLE";
            // 
            // lbl_GuncelleId
            // 
            this.lbl_GuncelleId.AutoSize = true;
            this.lbl_GuncelleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GuncelleId.Location = new System.Drawing.Point(263, 370);
            this.lbl_GuncelleId.Name = "lbl_GuncelleId";
            this.lbl_GuncelleId.Size = new System.Drawing.Size(0, 9);
            this.lbl_GuncelleId.TabIndex = 24;
            // 
            // Guncelle
            // 
            this.Guncelle.BackColor = System.Drawing.Color.Aqua;
            this.Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncelle.Location = new System.Drawing.Point(427, 326);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(131, 60);
            this.Guncelle.TabIndex = 23;
            this.Guncelle.Text = "GÜNCELLE";
            this.Guncelle.UseVisualStyleBackColor = false;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // picboxUpd
            // 
            this.picboxUpd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxUpd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxUpd.Location = new System.Drawing.Point(28, 196);
            this.picboxUpd.Name = "picboxUpd";
            this.picboxUpd.Size = new System.Drawing.Size(171, 201);
            this.picboxUpd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxUpd.TabIndex = 14;
            this.picboxUpd.TabStop = false;
            // 
            // linklabelResimGuncelle
            // 
            this.linklabelResimGuncelle.AutoSize = true;
            this.linklabelResimGuncelle.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linklabelResimGuncelle.Location = new System.Drawing.Point(254, 238);
            this.linklabelResimGuncelle.Name = "linklabelResimGuncelle";
            this.linklabelResimGuncelle.Size = new System.Drawing.Size(116, 16);
            this.linklabelResimGuncelle.TabIndex = 22;
            this.linklabelResimGuncelle.TabStop = true;
            this.linklabelResimGuncelle.Text = "Resim Güncelle";
            this.linklabelResimGuncelle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelResimGuncelle_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(254, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Müşteri Resim Dosyası";
            // 
            // txt_UpdMail
            // 
            this.txt_UpdMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdMail.Location = new System.Drawing.Point(257, 161);
            this.txt_UpdMail.MaxLength = 30;
            this.txt_UpdMail.Name = "txt_UpdMail";
            this.txt_UpdMail.Size = new System.Drawing.Size(318, 27);
            this.txt_UpdMail.TabIndex = 20;
            // 
            // txt_UpdTelefon
            // 
            this.txt_UpdTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdTelefon.Location = new System.Drawing.Point(257, 127);
            this.txt_UpdTelefon.Mask = "09990000000";
            this.txt_UpdTelefon.Name = "txt_UpdTelefon";
            this.txt_UpdTelefon.Size = new System.Drawing.Size(114, 27);
            this.txt_UpdTelefon.TabIndex = 19;
            // 
            // txt_UpdUnvan
            // 
            this.txt_UpdUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdUnvan.Location = new System.Drawing.Point(257, 95);
            this.txt_UpdUnvan.MaxLength = 30;
            this.txt_UpdUnvan.Name = "txt_UpdUnvan";
            this.txt_UpdUnvan.Size = new System.Drawing.Size(318, 27);
            this.txt_UpdUnvan.TabIndex = 18;
            // 
            // txt_UpdSoyad
            // 
            this.txt_UpdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdSoyad.Location = new System.Drawing.Point(257, 62);
            this.txt_UpdSoyad.MaxLength = 30;
            this.txt_UpdSoyad.Name = "txt_UpdSoyad";
            this.txt_UpdSoyad.Size = new System.Drawing.Size(318, 27);
            this.txt_UpdSoyad.TabIndex = 17;
            // 
            // txt_UpdAd
            // 
            this.txt_UpdAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_UpdAd.Location = new System.Drawing.Point(257, 25);
            this.txt_UpdAd.MaxLength = 30;
            this.txt_UpdAd.Name = "txt_UpdAd";
            this.txt_UpdAd.Size = new System.Drawing.Size(318, 27);
            this.txt_UpdAd.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Müşteri Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Müşteri Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(25, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Müşteri Ünvanı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(25, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Müşteri Soyadı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(25, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Müşteri Adı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(742, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "ARA";
            // 
            // txt_isimegoreara
            // 
            this.txt_isimegoreara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isimegoreara.Location = new System.Drawing.Point(843, 87);
            this.txt_isimegoreara.Name = "txt_isimegoreara";
            this.txt_isimegoreara.Size = new System.Drawing.Size(302, 27);
            this.txt_isimegoreara.TabIndex = 5;
            this.txt_isimegoreara.TextChanged += new System.EventHandler(this.txt_isimegoreara_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(742, 880);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(239, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "Toplam Müşteri Sayısı :";
            // 
            // lbl_ToplamSayı
            // 
            this.lbl_ToplamSayı.AutoSize = true;
            this.lbl_ToplamSayı.BackColor = System.Drawing.Color.Bisque;
            this.lbl_ToplamSayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ToplamSayı.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_ToplamSayı.Location = new System.Drawing.Point(1005, 880);
            this.lbl_ToplamSayı.Name = "lbl_ToplamSayı";
            this.lbl_ToplamSayı.Size = new System.Drawing.Size(0, 25);
            this.lbl_ToplamSayı.TabIndex = 7;
            // 
            // MusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1924, 1053);
            this.Controls.Add(this.lbl_ToplamSayı);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_isimegoreara);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MusteriIslemleri";
            this.Text = "Müşteri İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Ekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUpd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_EkleMail;
        private System.Windows.Forms.MaskedTextBox txt_EkleTelefon;
        private System.Windows.Forms.TextBox txt_EkleUnvan;
        private System.Windows.Forms.TextBox txt_EkleSoyad;
        private System.Windows.Forms.TextBox txt_EkleAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picbox_Ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.PictureBox picboxUpd;
        private System.Windows.Forms.LinkLabel linklabelResimGuncelle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_UpdMail;
        private System.Windows.Forms.MaskedTextBox txt_UpdTelefon;
        private System.Windows.Forms.TextBox txt_UpdUnvan;
        private System.Windows.Forms.TextBox txt_UpdSoyad;
        private System.Windows.Forms.TextBox txt_UpdAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_GuncelleId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_isimegoreara;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_ToplamSayı;
    }
}

