using insaatfirmasi.DL;
using insaatfirmasi.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insaatfirmasi.BL
{
    public static class BLogic
    {
        public static bool MüşteriEkle(Musteri m)

        {
            try
            {
                int res = DataLayer.MüşteriEkle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
                return false;
            }

        }

        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MüşteriGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
                return null;
            }
        }

        internal static bool MüşteriGüncelle(Musteri m)
        {

            try
            {
                int res = DataLayer.MüşteriGüncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
                return false;
            }

        }


        public static bool MüşteriSil(String id)
        {
            try
            {
                int res = DataLayer.MüşteriSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }


        internal static bool EvEkle(FrmEv ev)
        {

            try
            {
                int res = DataLayer.EvEkle(ev);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
                return false;
            }
        }

        internal static DataSet EvGetir(string filtre)
        {
            try
            {
                DataSet ds2 = DataLayer.EvGetir(filtre);
                return ds2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
                return null;
            }
        }

        internal static bool EvSil(string id)
        {
            try
            {
                int res = DataLayer.EvSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }


    }
}