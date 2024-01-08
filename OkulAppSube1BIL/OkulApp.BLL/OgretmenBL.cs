using DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool Ogretmenkydet(Ogretmen ogrt)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogrt.Ad),
                             new SqlParameter("@Soyad",ogrt.Soyad),
                             new SqlParameter("@Tckimlik",ogrt.Tckimlik)
                         };

            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into tblOgretmenler values(@Ad,@Soyad,@Tckimlik)", p) > 0;

        }
        public Ogretmen Ogretmenbul(string Tckimlik)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Tckimlik", Tckimlik) };
                Helper hlp = new Helper();
                var dr = hlp.ExecuteReader("Select Ogrtid,Ad,Soyad,Tc from tblOgretmen where Tc=@Tc", p);
                Ogretmen ogrt = null;
                if (dr.Read())
                {
                    ogrt = new Ogretmen();
                    ogrt.OgretmenID = Convert.ToInt32(dr["OgretmenID"]);
                    ogrt.Ad = dr["Ad"].ToString();
                    ogrt.Soyad = dr["Soyad"].ToString();
                    ogrt.Tckimlik = dr["Tckimlik"].ToString();
                }
                dr.Close();
                return ogrt;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool Ogretmenguncelle(Ogretmen ogr)
        {
            try
            {
                SqlParameter[] p = {
                new SqlParameter("@Ad",ogr.Ad),
                new SqlParameter("@Soyad",ogr.Soyad),
                new SqlParameter("@TCKimlik",ogr.Tckimlik),
                new SqlParameter("@Ogrtid",ogr.OgretmenID)};

                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Update TblOgretmenler set Ad=@Ad,Soyad=@Soyad,Tckimlik=@TCKimlik where OgretmenID=@OgretmenID", p) > 0;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public bool Ogretmensil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@OgretmenID", id) };
                Helper hlp = new Helper();
                return hlp.ExecuteNonQuery("Delete from tblOgretmen where OgretmenID=@OgretmenID", p) > 0;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}