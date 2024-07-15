using Business.Abstract;
using Business.Concrete;
using Business.FluentValidation;
using DataAccess.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class UrunIslemleri : Form
    {
        public UrunIslemleri()
        {
            InitializeComponent();
        }
        UrunManager _urunManager= new UrunManager(new EfUrunDal());
        KategoriManager _kategoriManager = new KategoriManager(new EfKategoriDal());
        public Decimal _ortalis;
        public int _UrunId;
        public string comboboxtext;// comboboxdan seçili değeri içine atamak için oluşturuldu
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numeric_EkleAdet.Text) || string.IsNullOrEmpty(numeric_EkleSatis.Text))
            {
                MessageBox.Show("hiçbir satır boş geçilemez");
            }
            else
            {
                BirimFiyatHesapla(Convert.ToDecimal(numeric_EkleSatis.Text), Convert.ToDecimal(numeric_EkleAdet.Text));
                Urun urun = new Urun
                {
                    UrunAd = txt_EkleAd.Text,
                    CategoryID = Convert.ToInt32(cmb_EkleKategori.SelectedValue),
                    UrunAdetIcerigi = Convert.ToDecimal(numeric_EkleAdet.Text),
                    SatisFiyat = Convert.ToDecimal(numeric_EkleSatis.Text),
                    BirimSatisFiyat = BirimFiyatHesapla(Convert.ToDecimal(numeric_EkleSatis.Text), Convert.ToDecimal(numeric_EkleAdet.Text)),
                    OrtAlisFiyat = 0,
                    UrunState = true

                };

                UrunValidator validator = new UrunValidator();
                ValidationResult result = validator.Validate(urun);
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

                    _urunManager.UrunEkle(urun);
                    MessageBox.Show("Eklendi");
                    Doldur();
                }

                var nesneler = groupBox1.Controls.OfType<NumericUpDown>();

                foreach (var nesne in nesneler)
                {
                    nesne.Value = 0;
                }
                txt_EkleAd.Clear();

            }
           
            
        }
        private decimal BirimFiyatHesapla(decimal satis_fiyat,decimal ürünadet)
        {
            if (ürünadet==0)
            {
                return 0;
            }
            else
            {
                return (satis_fiyat / ürünadet);

            }
        }

        private void Doldur()
        {
            dataGridView1.DataSource = _urunManager.UrunListele();
            cmb_EkleKategori.DataSource = _kategoriManager.KategoriListele();
            cmb_EkleKategori.DisplayMember = "CategoryAd";
            cmb_EkleKategori.ValueMember = "CategoryID";

            cmb_UpdKategori.DataSource = _kategoriManager.KategoriListele();
            cmb_UpdKategori.DisplayMember = "CategoryAd";
            cmb_UpdKategori.ValueMember = "CategoryID";
            
            cmb_ara.DataSource = _kategoriManager.KategoriListele();
            cmb_ara.DisplayMember = "CategoryAd";
            cmb_ara.ValueMember = "CategoryID";
            dataGridView1.Columns[2].Visible = false;

        }

        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numeric_UpdİcerikAdet.Text) || string.IsNullOrEmpty(numeric_UpdSatis.Text))
            {
                MessageBox.Show("Güncellem Bölümünde hiçbir satır boş geçilemez");
            }
            else
            {
                Urun urun = new Urun
                {
                    UrunID = _UrunId,
                    UrunAd = txt_UpdAd.Text,
                    CategoryID = Convert.ToInt32(cmb_UpdKategori.SelectedValue),
                    UrunAdetIcerigi = Convert.ToDecimal(numeric_UpdİcerikAdet.Text),
                    SatisFiyat = Convert.ToDecimal(numeric_UpdSatis.Text),
                    BirimSatisFiyat = BirimFiyatHesapla(Convert.ToDecimal(numeric_UpdSatis.Text), Convert.ToDecimal(numeric_UpdİcerikAdet.Text)),
                    OrtAlisFiyat = _ortalis,
                    UrunState = true

                };

                UrunValidator validator = new UrunValidator();
                ValidationResult result = validator.Validate(urun);
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

                    _urunManager.UrunGuncelle(urun);
                    MessageBox.Show("Guncellendi");
                    Doldur();
                }

                var nesneler = groupBox2.Controls.OfType<NumericUpDown>();

                
                txt_UpdAd.Clear();
            
            }
            
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _UrunId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txt_UpdAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            numeric_UpdİcerikAdet.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            _ortalis = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value);
            numeric_UpdSatis.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[7].Value);


        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            if (txt_ara.Text==null && checkBox1.Checked==false)
            {
                Doldur();
            }
            //else if(txt_ara.Text==null && cmb_ara.SelectedValue!=null)
            //{
            //    dataGridView1.DataSource=_urunManager.UrunKategoriGoreAra(comboboxtext);
            //}
            else if (txt_ara.Text != null && checkBox1.Checked==false)
            {
                dataGridView1.DataSource = _urunManager.UrunAdaGoreAra(txt_ara.Text);
            }
            else
            {
                dataGridView1.DataSource = _urunManager.UrunKategoriveAdGoreAra(txt_ara.Text ,comboboxtext);

            }
        }

        private void cmb_ara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                comboboxtext = cmb_ara.Text;
                dataGridView1.DataSource = _urunManager.UrunKategoriGoreAra(comboboxtext);
            }
            
               
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false && txt_ara==null)
            {
                Doldur();
            }
            else
            {
                dataGridView1.DataSource = _urunManager.UrunAdaGoreAra(txt_ara.Text);
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
                    _urunManager.UrunGuncelle(new Urun
                    {
                        UrunID = numara,
                        UrunAd= item.Cells[1].Value.ToString(),
                        CategoryID = Convert.ToInt32(item.Cells[2].Value),
                        UrunAdetIcerigi= Convert.ToInt32(item.Cells[4].Value),
                        OrtAlisFiyat=Convert.ToDecimal(item.Cells[5].Value),
                        BirimSatisFiyat = Convert.ToDecimal(item.Cells[6].Value),
                        SatisFiyat = Convert.ToDecimal(item.Cells[7].Value),
                        UrunState=false
                        
                        
                        
                        
                        });
                }
                Doldur();
            }
            else
            {
                MessageBox.Show("Silinmedi");
            }
        }
    }
    
}
