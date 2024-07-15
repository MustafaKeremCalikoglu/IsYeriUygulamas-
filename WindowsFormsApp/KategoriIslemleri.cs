using Business.Abstract;
using Business.Concrete;
using Business.FluentValidation;
using DataAccess.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
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
    public partial class KategoriIslemleri : Form
    {
        public KategoriIslemleri()
        {
            InitializeComponent();
        }
        IKategoriService _kategoriService = new KategoriManager(new EfKategoriDal());
        public int _id;
        private void btn_Ekle_Click(object sender, EventArgs e)
        {   
            Kategori kategori = new Kategori
            {
                CategoryAd=txt_EkleAd.Text.ToUpper(),
            };

            KategoriValidator validator = new KategoriValidator();
            ValidationResult result = validator.Validate(kategori);
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

                _kategoriService.KategoriEkle(kategori);
                MessageBox.Show("Eklendi");
                Doldur();
            }

            txt_EkleAd.Clear();
        }
        private void Doldur()
        {
            dataGridView1.DataSource = _kategoriService.KategoriListele();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori
            {
                CategoryID = _id,
                CategoryAd = txt_UpdAd.Text.ToUpper(),
            };

            KategoriValidator validator = new KategoriValidator();
            ValidationResult result = validator.Validate(kategori);
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

                _kategoriService.KategoriGuncelle(kategori);
                MessageBox.Show("Güncellendi");
                Doldur();
            }

            txt_EkleAd.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_UpdAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            _id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void KategoriIslemleri_Load(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
