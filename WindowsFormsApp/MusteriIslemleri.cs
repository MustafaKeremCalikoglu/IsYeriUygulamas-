using Business.Abstract;
using Business.Concrete;
using Business.FluentValidation;
using DataAccess.Concrete.EntityFramework;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }

        IMusteriService _musteriService = new MusteriManger(new EfMusteriDal());
        public string _dosyaYolu;
        string _hedefKlasor= @"C:\Users\malik&mustafa\source\repos\IsYeriUygulaması\Business\MusteriResimleri";
        string _dosya_yolu_guncelle;
        string _tarih_tutucu;
        public string _Toplam_Musteri_Sayısı;
        public string _idtutucu;
        public string _hedefDosyaYolu;

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(_dosyaYolu, _hedefDosyaYolu, true);
            }
            catch (Exception)
            {

                _hedefDosyaYolu = @"C:\Users\malik&mustafa\source\repos\IsYeriUygulaması\Business\MusteriResimleri\bos.png";
            }
            
            Musteri musteri = new Musteri {

                MusteriAd = txt_EkleAd.Text,
                MusteriSoyad = txt_EkleSoyad.Text,
                MusteriUnvan = txt_EkleUnvan.Text,
                MusteriTelefon = txt_EkleTelefon.Text,
                MusteriMail = txt_EkleMail.Text,
                MusteriKayıtTarihi = DateTime.Now,
                MusteriImage = _hedefDosyaYolu
                
            };
            
            MusteriValidator validator = new MusteriValidator();
            ValidationResult result = validator.Validate(musteri);
            IList<ValidationFailure> failures = result.Errors;
            if (!result.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else
            {

                _musteriService.MusteriEkle(musteri);
                MessageBox.Show("Eklendi");
                Doldur();
            }

            var nesneler = groupBox1.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            picbox_Ekle.Image = null;
            txt_EkleTelefon.Clear();
            

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.FileName = "Dosya Seç";
            openFileDialog1.InitialDirectory = @"C:\Users\malik&mustafa\Desktop";
            openFileDialog1.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            
        }
        private void Doldur()
        {   
            
            dataGridView1.DataSource = _musteriService.MusteriListele();
            dataGridView1.Columns[0].HeaderText = "#";
            dataGridView1.Columns[1].HeaderText = "İSİM";
            dataGridView1.Columns[2].HeaderText = "SOYİSİM";
            dataGridView1.Columns[3].HeaderText = "ÜNVAN";
            dataGridView1.Columns[4].HeaderText = "TELEFON";
            dataGridView1.Columns[5].HeaderText = "MAİL";
            dataGridView1.Columns[6].HeaderText = "IMAGE";
            dataGridView1.Columns[7].HeaderText = "KAYIT TARİHİ";
            _Toplam_Musteri_Sayısı =dataGridView1.RowCount.ToString();
            lbl_ToplamSayı.Text=_Toplam_Musteri_Sayısı;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[0].Visible = false;



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(_hedefKlasor))
                {
                    Directory.CreateDirectory(_hedefKlasor);
                }

                // Dosya yolunu alın
                _dosyaYolu = openFileDialog1.FileName;

                // Dosya adını alın
                string dosyaAdi = Path.GetFileName(_dosyaYolu);

                // Hedef klasör ve dosya adını birleştirerek yeni bir dosya yolunu oluşturun
                _hedefDosyaYolu = Path.Combine(_hedefKlasor, dosyaAdi);
                Image resim=ResimDondur(_dosyaYolu);
                picbox_Ekle.Image=resim;
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Eminmisiniz Seçtiğiniz Veriler Silinecek", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    int numara = Convert.ToInt32(item.Cells[0].Value);
                    _musteriService.MusteriSil(new Musteri
                    {
                        MusteriID = numara
                    });
                }
                Doldur();
            }
            else
            {
                MessageBox.Show("Silinmedi");
            }


         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_UpdAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_UpdSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_UpdUnvan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_UpdTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_UpdMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lbl_GuncelleId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            _tarih_tutucu = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            
            if (dataGridView1.CurrentRow.Cells[6].Value != null)
            {
                string gecici_yol = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                Image resim = ResimDondur(gecici_yol);
                picboxUpd.Image = resim;
            }
            else
            {
                picboxUpd.Image = null;
            } 
               
            

        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(_dosyaYolu, _hedefDosyaYolu, true);
            }
            catch (Exception)
            {

                _hedefDosyaYolu = @"C:\Users\malik&mustafa\source\repos\IsYeriUygulaması\Business\MusteriResimleri\bos.png";
            }

            Musteri musteri = new Musteri
            {
                MusteriID = Convert.ToInt32(lbl_GuncelleId.Text),
                MusteriAd = txt_UpdAd.Text,
                MusteriSoyad = txt_UpdSoyad.Text,
                MusteriUnvan = txt_UpdUnvan.Text,
                MusteriTelefon = txt_UpdTelefon.Text,
                MusteriMail = txt_UpdMail.Text,
                MusteriImage = _hedefDosyaYolu,
                MusteriKayıtTarihi=DateTime.Parse(_tarih_tutucu)
            };
        
            MusteriValidator validator = new MusteriValidator();
            ValidationResult result = validator.Validate(musteri);
            IList<ValidationFailure> failures = result.Errors;
            if (!result.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else
            {

                _musteriService.MusteriGuncelle(musteri);
                MessageBox.Show("Güncellendi");
                Doldur();
            }

            var nesneler = groupBox2.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            picboxUpd.Image = null;
            txt_UpdTelefon.Clear();
        }

        private void linklabelResimGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(_hedefKlasor))
                {
                    Directory.CreateDirectory(_hedefKlasor);
                }

                // Dosya yolunu alın
                _dosyaYolu = openFileDialog1.FileName;

                // Dosya adını alın
                string dosyaAdi = Path.GetFileName(_dosyaYolu);

                // Hedef klasör ve dosya adını birleştirerek yeni bir dosya yolunu oluşturun
                _hedefDosyaYolu = Path.Combine(_hedefKlasor, dosyaAdi);
                Image resim = ResimDondur(_dosyaYolu);
                picboxUpd.Image = resim;
            }

        }

        private void txt_isimegoreara_TextChanged(object sender, EventArgs e)
        {
            if (txt_isimegoreara.Text==null)
            {
                Doldur();
            }
            else
            {
                dataGridView1.DataSource = _musteriService.MusteriIsmeGoreGetir(txt_isimegoreara.Text);
            }
        }
        private static RotateFlipType GetExifDöndürmeTipi(string dosyaYolu)
        {
            try
            {
                using (Image resim = Image.FromFile(dosyaYolu))
                {
                    PropertyItem exifProperty = resim.GetPropertyItem(0x0112); // 0x0112 EXIF döndürme bilgisini temsil eder
                    int exifDeger = BitConverter.ToInt16(exifProperty.Value, 0);
                    if (exifDeger == 1)
                        return RotateFlipType.RotateNoneFlipNone;
                    else if (exifDeger == 3)
                        return RotateFlipType.Rotate180FlipNone;
                    else if (exifDeger == 6)
                        return RotateFlipType.Rotate90FlipNone;
                    else if (exifDeger == 8)
                        return RotateFlipType.Rotate270FlipNone;
                    else
                        return RotateFlipType.RotateNoneFlipNone;
                }
            }
            catch (Exception)
            {
                return RotateFlipType.RotateNoneFlipNone;
            }
        }

        private Image ResimDondur(string resimDosyaYolu)
        {

            //string resimDosyaYolu = @"C:\Users\malik&mustafa\Pictures\fotoğraflar\20160729_163040.jpg"; // Resmin dosya yolunu belirtin
            Image resim = Image.FromFile(resimDosyaYolu);

            // Resmi düzgün bir şekilde döndürme işlemi
            RotateFlipType döndürmeTipi = GetExifDöndürmeTipi(resimDosyaYolu);
            if (döndürmeTipi != RotateFlipType.RotateNoneFlipNone)
            {
                resim.RotateFlip(döndürmeTipi);
                // Döndürülen resmi orijinal dosyanın üzerine kaydetme
            }

            return resim;
            // Resmi görüntüleme veya başka işlemler yapma
            // Örnek olarak PictureBox veya başka bir kontrolde görüntüleme yapabilirsiniz.
        }
    }
}


