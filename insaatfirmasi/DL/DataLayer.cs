


using insaatfirmasi.UI;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace insaatfirmasi.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Port = 3307,
                Database = "insaat_sirket_yonetimi1",
                UserID = "root",
                Password = "123467890"
            }.ConnectionString
        );

        // Müşteri Ekleme
        public static int MüşteriEkle(Musteri m)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (MySqlCommand komut = new MySqlCommand("MusteriEkle1", conn))
                                                                                  
                                                                                  
                {
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@id", m.ID); 
                    komut.Parameters.AddWithValue("@ad", m.Ad);
                    komut.Parameters.AddWithValue("@soyad", m.Soyad);

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int EvEkle(FrmEv ev)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (MySqlCommand komut = new MySqlCommand("EvEkle", conn)) 
                                                                             
                                                                             
                {
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@id", ev.ID); 
                    komut.Parameters.AddWithValue("@fiyat", ev.Fiyat);
                    komut.Parameters.AddWithValue("@ay", ev.Ay);
                    komut.Parameters.AddWithValue("@metrekare", ev.MetreKare);

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet EvGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("EvEHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("EvBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre); 
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);

                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int EvSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("Sil", conn);
                                                                   
                                                                  

                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id); 


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        // Müşteri Getir
        internal static DataSet MüşteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("MusteriHepsi1", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("MusteriBul1", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);

                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }

        }

        internal static int MüşteriGüncelle(Musteri m)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (MySqlCommand komut = new MySqlCommand("MusteriGuncelle1", conn)) 
                                                                                       
                                                                                        
                {
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@id", m.ID);
                    komut.Parameters.AddWithValue("@ad", m.Ad);
                    komut.Parameters.AddWithValue("@soyad", m.Soyad);

                    int res = komut.ExecuteNonQuery();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int MüşteriSil(String id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("MusteriSil1", conn);
                                                                          
                                                                       

                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }


    }
}