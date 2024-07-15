using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MessagingToolkit.QRCode.Codec;

namespace WindowsFormsApp
{
    public partial class AlimIslemleri : Form
    {
        public AlimIslemleri()
        {
            InitializeComponent();

        }
        public string Kullanici_Adi;
        IAlisFaturaService _alisFaturaService = new AlisFaturaManager(new EfAlisFaturaDal());
        UrunManager _urunManager = new UrunManager(new EfUrunDal());
        FirmaManager _firmaManager = new FirmaManager(new EfFirmaDal());

        public string urunAdı;
        private void btn_FaturaAc_Click(object sender, EventArgs e)   /// faturanın açılmasını sağlar
        {
            AlisFatura alisFatura = new AlisFatura
            {
                AlisTarih=DateTime.Now
            };
            btn_Ekle.Enabled = true;
            _alisFaturaService.AlisFaturaEkle(alisFatura);

            AlisFatura faturano=_alisFaturaService.AlisFaturaListele();
            lbl_FaturaNo.Text = faturano.FaturaNo.ToString();
            lbl_FaturaTarih.Text = faturano.AlisTarih.ToString();
            txt_EkleFaturaNo.Text= faturano.FaturaNo.ToString();
            QRCodeEncoder enc =new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(lbl_FaturaNo.Text+"&"+lbl_FaturaTarih.Text);
            btn_yazdir.Enabled = true;

        }

        private void AlimIslemleri_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Fatura No", 70);
            listView1.Columns.Add("Urun Adı",200);
            listView1.Columns.Add("Birim Fiyatı", 100);
            listView1.Columns.Add("Adet Sayısı", 150);
            listView1.Columns.Add("Tutar",100);
            listView1.Columns.Add("Firma Adı",100);
            listView1.Columns.Add("Fatura Tarih", 100);


            cmb_EkleUrunAdı.DataSource = _urunManager.UrunListele();
            cmb_EkleUrunAdı.DisplayMember = "UrunAd";
            cmb_EkleFirma.ValueMember = "UrunID";

            cmb_EkleFirma.DataSource = _firmaManager.FirmaListele();
            cmb_EkleFirma.DisplayMember = "FirmaAd";
            cmb_EkleFirma.ValueMember = "FirmaID";
            kayitsayisi();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            string Faturan_no = txt_EkleFaturaNo.Text;
            string AlisFiyatı=numeric_EkleAlisFiyat.Text.ToString();
            string urunAdı = cmb_EkleUrunAdı.Text;
            string Adet = numeric_EkleAdet.Text.ToString();
            string FirmaAdı = cmb_EkleFirma.Text;
            string FaturaTarih = lbl_FaturaTarih.Text;
            string urunId = cmb_EkleUrunAdı.SelectedValue.ToString();
            string firmaId=cmb_EkleFirma.SelectedValue.ToString();
            decimal tutar = Convert.ToDecimal(numeric_EkleAdet.Text.ToString()) * Convert.ToDecimal(numeric_EkleAlisFiyat.Text);
            string[] bilgiler = {Faturan_no,urunAdı,AlisFiyatı,Adet,tutar.ToString(),FirmaAdı,FaturaTarih,urunId,firmaId};
            ListViewItem satir = new ListViewItem(bilgiler);
            listView1.Items.Add(satir);
            kayitsayisi();

        }
        private void kayitsayisi()
        {
            lbl_kayitsayisi.Text = listView1.Items.Count.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            lbl_FaturaNo.Text = listView1.Items[0].SubItems[7].Text;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {

            try
            {
                int secilensayisi = listView1.CheckedItems.Count;
                foreach (ListViewItem secilenkayitbilgisi in listView1.CheckedItems)
                {
                    secilenkayitbilgisi.Remove();
                }
                MessageBox.Show(secilensayisi.ToString() + "Adet Kayıt Silindi");
                kayitsayisi();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Listeden bir seçim yapmalısınız.");
            }
          
        }

        private void btn_tumsil_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            kayitsayisi();
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
        //    DialogResult yazdirmaislemi;

        //    yazdirmaislemi = printDialog1.ShowDialog();


        //    printDocument1.PrintPage += PrintDocument1_PrintPage;
        //    if (yazdirmaislemi==DialogResult.OK)
        //    {
        //        printDocument1.Print();
        //    }
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("paperA4", 840, 1180);
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            
            printPreviewDialog1.ShowDialog();

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            SolidBrush kalem = new SolidBrush(Color.Black);
            SolidBrush siyahbrush = new SolidBrush(Color.Black);

            Font myFont = new Font("Calibri", 16);
            Font myFont2 = new Font("Calibri", 9, FontStyle.Bold);
            Pen KırmızıKalem = new Pen(Color.Red);
            Pen SiyahKalem = new Pen(Color.Black);

            e.Graphics.DrawString(Kullanici_Adi, myFont2, siyahbrush, 300, 30);

            e.Graphics.DrawString("Tarih: "+lbl_FaturaTarih.Text, myFont2, siyahbrush, 665, 30);
            e.Graphics.DrawLine(KırmızıKalem, 100, 160, 700, 160);
            e.Graphics.DrawLine(KırmızıKalem, 100, 220, 700, 220);
            e.Graphics.DrawString("SİPARİŞ FORMU", myFont, kalem, 360,180);

            //e.Graphics.DrawString(yazı, YazıAilesi, kalem, 10, 20);
            e.Graphics.DrawString("Fatura No", myFont2, siyahbrush, 120, 260);
            e.Graphics.DrawString("Ürün Adı", myFont2, siyahbrush, 220, 260);
            e.Graphics.DrawString("Fiyat", myFont2, siyahbrush, 345, 260);
            e.Graphics.DrawString("Adet Sayısı", myFont2, siyahbrush, 420, 260);
            e.Graphics.DrawString("Tutar", myFont2, siyahbrush, 520, 260);
            e.Graphics.DrawString("Firma", myFont2, siyahbrush, 600, 260);

            e.Graphics.DrawImage(pictureBox1.Image, 30, 30);

            Font myFont3 = new Font("Calibri", 6);


            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Near;
            int y = 290;
            decimal gTotal = 0;

            foreach (ListViewItem lvi in listView1.Items)
            {
                e.Graphics.DrawString(lvi.SubItems[0].Text, myFont3, siyahbrush, 130, y, myStringFormat);
                e.Graphics.DrawString(lvi.SubItems[1].Text, myFont3, siyahbrush, 200, y, myStringFormat);
                Decimal fiyat = Convert.ToDecimal(lvi.SubItems[2].Text);
                Decimal tutar = Convert.ToDecimal(lvi.SubItems[4].Text);
                gTotal+=tutar;
                e.Graphics.DrawString(fiyat.ToString("c"), myFont3, siyahbrush, 345, y, myStringFormat);
                e.Graphics.DrawString(lvi.SubItems[3].Text, myFont3, siyahbrush, 435, y, myStringFormat);
                e.Graphics.DrawString(tutar.ToString("c"), myFont3, siyahbrush, 525, y, myStringFormat);
                e.Graphics.DrawString(lvi.SubItems[5].Text, myFont3, siyahbrush, 605, y, myStringFormat);

                //e.Graphics.DrawString(lvi.Text, myFont3, siyahbrush, 220, y);
                //decimal bFiyat = Convert.ToDecimal(lvi.SubItems[2].Text);
                //decimal fiyat = Convert.ToDecimal(lvi.SubItems[1].Text) * Convert.ToDecimal(lvi.SubItems[2].Text);
                //gTotal += fiyat;
                //e.Graphics.DrawString(bFiyat.ToString("c"), myFont3, siyahbrush, 530, y, myStringFormat);
                //e.Graphics.DrawString(fiyat.ToString("c"), myFont3, siyahbrush, 700, y, myStringFormat);

                y += 20;

            }

            e.Graphics.DrawLine(KırmızıKalem, 100, y, 700, y);
            e.Graphics.DrawString("TOPLAM TUTAR :", myFont3, siyahbrush, 90, y+20, myStringFormat);
            e.Graphics.DrawString(gTotal.ToString("c"), myFont3, siyahbrush, 510, y+20, myStringFormat);



        }


    }

   
    
}
