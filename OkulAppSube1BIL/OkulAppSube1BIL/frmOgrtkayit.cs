using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgrtkayit : Form
    {
        public frmOgrtkayit()
        {
            InitializeComponent();
        }

        public int OgretmenID;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                bool sonuc = obl.Ogretmenkydet(new Ogretmen { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Tckimlik = txtTckimlik.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu tc kimlikli öğretmen daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.Ogretmenguncelle(new Ogretmen { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Tckimlik = txtTckimlik.Text.Trim(), OgretmenID = OgretmenID }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.Ogretmensil(OgretmenID) ? "Silme Başarılı" : "Başarısız!");
                txtAd.Clear();
                txtSoyad.Clear();
                txtTckimlik.Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Bul_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmOgrtbul(this);
                frm.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
    


