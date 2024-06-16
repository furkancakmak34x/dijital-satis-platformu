using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uygulama.Model;

namespace Uygulama.DAL
{
    public class SabitIslemler
    {
        public static int Fiyat { get; set; }

        public static string OturumAcanKullanıcı;

        public static string TarihSaat = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString(); 

        public static string con_str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True";

        public static SqlConnection _conn = new SqlConnection(SabitIslemler.con_str);
        public static void Connect()
        {
            try
            {
                _conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Kritik bir hata oluştu. (Hata Kodu: 0001) " + e.Message);
            }

        }
        public static void Disconnect(SqlConnection conn)
        {
            try
            {
                conn.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show("Kritik bir hata oluştu. (Hata Kodu: 0002) " + e.Message);
            }
        }
        public static bool OturumAc(string kullanici, string sifre)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("@kullanici", kullanici);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.CommandText = "SELECT COUNT(1) FROM Musteri WHERE KULLANICI = @kullanici AND SIFRE = @sifre";
                cmd.ExecuteNonQuery();
                int count = (int)cmd.ExecuteScalar();
                Disconnect(_conn);
                return count > 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Kodu: 1015", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static bool KullaniciDenetle(string kullanici)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("@kullanici", kullanici);
                cmd.CommandText = "SELECT COUNT(1) FROM Musteri WHERE KULLANICI = @kullanici";
                cmd.ExecuteNonQuery();
                int count = (int)cmd.ExecuteScalar();
                Disconnect(_conn);
                return count > 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Kodu: 1015", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static List<Tablo> AdminRaporla()
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "SELECT * FROM Rapor";
                SqlDataReader reader = cmd.ExecuteReader();

                List<Tablo> list = new List<Tablo>();
                while (reader.Read())
                {
                    Tablo tbl = new Tablo();
                    tbl.Id = Convert.ToInt32(reader["ID"]);
                    tbl.Musteri = reader["MUSTERI"].ToString();
                    tbl.Urun = reader["URUN"].ToString();
                    tbl.Tutar = Convert.ToInt32(reader["TUTAR"]);
                    tbl.Tarih = reader["TARIH"].ToString();
                    list.Add(tbl);
                }

                Disconnect(_conn);
                return list;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Disconnect(_conn);
                return null;
            }
        }
        public static List<Tablo> Raporla()
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.Parameters.AddWithValue("@musteri", OturumAcanKullanıcı);
                cmd.CommandText = "SELECT * FROM Rapor WHERE MUSTERI=@musteri";
                SqlDataReader reader = cmd.ExecuteReader();

                List<Tablo> list = new List<Tablo>();
                while (reader.Read())
                {
                    Tablo tbl = new Tablo();
                    tbl.Id = Convert.ToInt32(reader["ID"]);
                    tbl.Musteri = reader["MUSTERI"].ToString();
                    tbl.Urun = reader["URUN"].ToString();
                    tbl.Tutar = Convert.ToInt32(reader["TUTAR"]);
                    tbl.Tarih = reader["TARIH"].ToString();
                    list.Add(tbl);
                }

                Disconnect(_conn);
                return list;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Kodu: 1015", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disconnect(_conn);
                return null;
            }
        }
        public static bool IletisimFormDenetle()
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "SELECT COUNT(*) FROM Iletisim";
                cmd.ExecuteNonQuery();
                int count = (int)cmd.ExecuteScalar();
                Disconnect(_conn);
                return count > 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Kodu: 1015", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public static bool SatisRaporDenetle()
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "SELECT COUNT(*) FROM Rapor";
                cmd.ExecuteNonQuery();
                int count = (int)cmd.ExecuteScalar();
                Disconnect(_conn);
                return count > 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Kodu: 1015", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
