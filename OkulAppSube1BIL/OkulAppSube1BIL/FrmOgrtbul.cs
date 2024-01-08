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
    public partial class FrmOgrtbul : Form
    {
        frmOgrtkayit frm;
        public FrmOgrtbul(frmOgrtkayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void Bul_Click(object sender, EventArgs e)
        {
            try
            {
                OgretmenBL obl = new OgretmenBL();
                Ogretmen ogrt = obl.Ogretmenbul(txtTckimlik.Text.Trim());
                if (ogrt != null)
                {
                    frm.txtAd.Text = ogrt.Ad;
                    frm.txtSoyad.Text = ogrt.Soyad;
                    frm.txtTckimlik.Text = ogrt.Tckimlik;
                    frm.OgretmenID = ogrt.OgretmenID;

                    this.Close();
                    frm.Sil.Enabled = true;
                    frm.Guncelle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Öğretmen bulunamadı!!");
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
