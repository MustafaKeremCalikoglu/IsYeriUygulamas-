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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FirmaIslem : Form
    {
        public FirmaIslem()
        {
            InitializeComponent();
        }
        string _id;
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Firma firma = new Firma {

                FirmaAd = txt_EkleAd.Text,
                FirmaTelefon = txt_EkleTelefon.Text,
                FirmaMail = txt_EkleMail.Text,
                FirmaState = true
            };
            
            FirmaValidator validator = new FirmaValidator();
            ValidationResult result = validator.Validate(firma);
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

                _firmaService.FirmaEkle(firma);
                MessageBox.Show("Eklendi");
                Doldur();
            }

            var nesneler = groupBox1.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            txt_EkleTelefon.Clear();

        }
        IFirmaService _firmaService=new FirmaManager(new EfFirmaDal());
        private void Doldur() 
        {
            dataGridView1.DataSource = _firmaService.FirmaListele();
            lbl_ToplamFirma.Text = dataGridView1.RowCount.ToString();
        
        }

        private void FirmaIslem_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[1].Value!= null && dataGridView1.CurrentRow.Cells[2].Value != null && dataGridView1.CurrentRow.Cells[3].Value!=null)
            {
                _id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_UpdAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_UpdTelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_UpdMail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                _id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_UpdAd.Text = "değer okunamadı";
                txt_UpdTelefon.Text = "0000000";
                txt_UpdMail.Text = "değer okunamadı";
            }

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Firma firma = new Firma
            {
                FirmaAd = txt_UpdAd.Text,
                FirmaTelefon = txt_UpdTelefon.Text,
                FirmaID = Convert.ToInt32(_id),
                FirmaMail = txt_UpdMail.Text,
                FirmaState = true
            };
            FirmaValidator validator = new FirmaValidator();
            ValidationResult result = validator.Validate(firma);
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

                _firmaService.FirmaGuncelle(firma);
                MessageBox.Show("Güncellendi");
                Doldur();
            }
            var nesneler = groupBox2.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
            txt_UpdTelefon.Clear();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Eminmisiniz Seçtiğiniz Veriler Silinecek", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    int numara = Convert.ToInt32(item.Cells[0].Value);
                    
                    _firmaService.FirmaGuncelle(new Firma
                    {
                        FirmaID = numara,
                        FirmaAd = item.Cells[1].Value.ToString(),
                        FirmaTelefon = item.Cells[2].Value.ToString(),
                        FirmaMail = item.Cells[3].Value.ToString(),
                        FirmaState=false,
                    });
                }
                Doldur();
            }
            else
            {
                MessageBox.Show("Silinmedi");
            }
        }

        private void txt_FirmaAra_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_FirmaAra.Text == null)
            {
                Doldur();
            }
            else
            {
                dataGridView1.DataSource = _firmaService.SartlıArama(txt_FirmaAra.Text);
            }
        }
    }
}
