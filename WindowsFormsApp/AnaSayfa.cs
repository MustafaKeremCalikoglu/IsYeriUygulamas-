using Business.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        
        private void FormGetir(Form frm)
        {   
            
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            
            panel2.Controls.Add(frm);
            frm.Show();
        }
        private void müşteriİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MusteriIslemleri ekle = new MusteriIslemleri();
            FormGetir(ekle);
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            AnaSayfaPart anaSayfaPart=new AnaSayfaPart();
            FormGetir(anaSayfaPart);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Saat Ve Tarih ====> "+DateTime.Now.ToString();
        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaSayfaPart anaSayfaPart = new AnaSayfaPart();
            FormGetir(anaSayfaPart);

        }

        private void programıKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programı Kapatmak İstediğinizden Emin misiniz ?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();   
            }
            else
            {
                
            }
        }

        private void firmaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmaIslem firmaIslem = new FirmaIslem();
            FormGetir(firmaIslem);
        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriIslemleri kategoriIslemleri = new KategoriIslemleri();
            FormGetir(kategoriIslemleri);
        }

        private void ürünİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunIslemleri urunIslemleri = new UrunIslemleri();
            FormGetir(urunIslemleri);

        }

        private void alımİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlimIslemleri alisIslemleri = new AlimIslemleri();
            alisIslemleri.Kullanici_Adi = "Mustafa Kerem";
            FormGetir(alisIslemleri);

        }
    }
}
