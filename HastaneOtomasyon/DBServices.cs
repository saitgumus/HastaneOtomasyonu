using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using HastaneOtomasyon.Models;
using System.Data;

namespace HastaneOtomasyon
{
    public class DBServices
    {
        SqlConnection conSOHATS;
        SqlDataAdapter dr;
        DataSet ds;
        private DBServices dbService;

        private DBServices()
        {
            dr = new SqlDataAdapter();
            ds = new DataSet();
        }

        public DBServices ConnectToService()
        {
            if(dbService == null)
            {
                dbService = new DBServices();
                Common.WriteLog("database", "veri tabanına bağlanıldı.");
            }

          return dbService;
        }

        #region baglanti islemleri

        /// <summary>
        /// veri tabanına bağlanır
        /// </summary>
        private void ConnectDB()
        {
            conSOHATS = new SqlConnection(Common.ConnectionString);

            try
            {
                conSOHATS.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }

        }

        /// <summary>
        /// veri tabanı bağlantısınık sonlandırır
        /// </summary>
        public void endConnectDB()
        {
            try
            {
                conSOHATS.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }
        #endregion


        #region kayıt işlemleri

        #region kullanıcı kaydet
        /// <summary>
        /// kullanıcı kayıtları yapılır
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public GenericResponse<bool> InsertUser(User user)
        {
            var returnObject = new GenericResponse<Boolean>();
           
            ConnectDB();
            var cmd = new SqlCommand(Common.kullanıcıKaydet, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("kodu",user.Kodu);
            cmd.Parameters.AddWithValue("ad", user.Ad);
            cmd.Parameters.AddWithValue("soyad", user.Soyad);
            cmd.Parameters.AddWithValue("sifre", user.Sifre);
            cmd.Parameters.AddWithValue("Yetki", user.Yetki);
            cmd.Parameters.AddWithValue("Evtel", user.Evtel);
            cmd.Parameters.AddWithValue("CepTel", user.CepTel);
            cmd.Parameters.AddWithValue("Adres", user.Adres);
            cmd.Parameters.AddWithValue("Unvan", user.Unvan);
            cmd.Parameters.AddWithValue("IseBaslama", user.IseBaslama);
            cmd.Parameters.AddWithValue("Maas", user.Maas);
            cmd.Parameters.AddWithValue("DogumYeri", user.DogumYeri);
            cmd.Parameters.AddWithValue("AnneAd", user.AnneAd);
            cmd.Parameters.AddWithValue("BabaAd", user.BabaAd);
            cmd.Parameters.AddWithValue("Cinsiyet", user.Cinsiyet);
            cmd.Parameters.AddWithValue("KanGrubu", user.KanGrubu);
            cmd.Parameters.AddWithValue("MedeniHal", user.MedeniHal);
            cmd.Parameters.AddWithValue("DogumTarihi", user.DogumTarihi);
            cmd.Parameters.AddWithValue("TcKimlikNo", user.TcKimlikNo);
            cmd.Parameters.AddWithValue("UserName", user.UserName);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        #endregion

        #region hasta kaydet
        /// <summary>
        /// hasta tablosuna kayıt yapar
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GenericResponse<bool> InsertPatient(Patient data)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.hastaKaydet, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tcKimlikNo", data.TcKimlikNo);
            cmd.Parameters.AddWithValue("DosyaNo", data.DosyaNo);
            cmd.Parameters.AddWithValue("ad", data.Ad);
            cmd.Parameters.AddWithValue("soyad", data.Soyad);
            cmd.Parameters.AddWithValue("DogumYeri", data.DogumYeri);
            cmd.Parameters.AddWithValue("DogumTarihi", data.DogumTarihi);
            cmd.Parameters.AddWithValue("Adres", data.Adres);
            cmd.Parameters.AddWithValue("Tel", data.Tel);
            cmd.Parameters.AddWithValue("KurumSicilNo", data.KurumSicilNo);
            cmd.Parameters.AddWithValue("KurumAdi", data.KurumAdi);
            cmd.Parameters.AddWithValue("YakinTel", data.YakinTel);
            cmd.Parameters.AddWithValue("YakinKurumSicilNo", data.YakinKurumSicilNo);
            cmd.Parameters.AddWithValue("YakinKurumAdi", data.YakinKurumAdi);
            cmd.Parameters.AddWithValue("DogumYeri", data.DogumYeri);
            cmd.Parameters.AddWithValue("AnneAdi", data.AnneAdi);
            cmd.Parameters.AddWithValue("BabaAdi", data.BabaAdi);
            cmd.Parameters.AddWithValue("Cinsiyet", data.Cinsiyet);
            cmd.Parameters.AddWithValue("KanGrubu", data.KanGrubu);
            cmd.Parameters.AddWithValue("MedeniHal", data.MedeniHal);
            cmd.Parameters.AddWithValue("TcKimlikNo", data.TcKimlikNo);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        #endregion

        #region cıkıs kaydet
        /// <summary>
        /// cıkıs tablosuna kayıt yapar
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GenericResponse<bool> InsertDischarged(Discharged data)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.cikisKaydet, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DosyaNo", data.DosyaNo);
            cmd.Parameters.AddWithValue("SevkTarihi", data.SevkTarihi);
            cmd.Parameters.AddWithValue("CikisTarihi", data.CikisTarihi);
            cmd.Parameters.AddWithValue("Odeme", data.Odeme);
            cmd.Parameters.AddWithValue("ToplamTutar", data.ToplamTutar);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }
        #endregion

        #region sevk kaydet
        /// <summary>
        /// sevk tablosuna kayıt atar
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GenericResponse<bool> InsertTransfer(Transfer data)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.sevkKaydet, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("SevkTarihi", data.SevkTarihi);
            cmd.Parameters.AddWithValue("DosyaNo", data.DosyaNo);
            cmd.Parameters.AddWithValue("Poliklinik", data.Poliklinik);
            cmd.Parameters.AddWithValue("Saat", data.Saat);
            cmd.Parameters.AddWithValue("YapilanIslem", data.YapilanIslem);
            cmd.Parameters.AddWithValue("DrKod", data.DrKod);
            cmd.Parameters.AddWithValue("Miktar", data.Miktar);
            cmd.Parameters.AddWithValue("BirimFiyat", data.BirimFiyat);
            cmd.Parameters.AddWithValue("Sira", data.Sira);
            cmd.Parameters.AddWithValue("ToplamTutar", data.ToplamTutar);
            cmd.Parameters.AddWithValue("Taburcu", data.Taburcu);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        #endregion

        #region poliklinik kayıt
        /// <summary>
        /// poliklinik tablosuna yeni kayıt atar
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GenericResponse<bool> InsertPolyclinic(Polyclinic data)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.poliklinikKaydet, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PoliklinikAdi", data.PoliklinikAdi);
            cmd.Parameters.AddWithValue("Durum", data.Durum);
            cmd.Parameters.AddWithValue("Aciklama", data.Aciklama);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        #endregion


        #endregion


        #region güncelleme işlemleri
        /// <summary>
        /// hasta kaydını günceller
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GenericResponse<bool> UpdatePatient(Patient data)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.hastaGuncelle, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tcKimlikNo", data.TcKimlikNo);
            cmd.Parameters.AddWithValue("DosyaNo", data.DosyaNo);
            cmd.Parameters.AddWithValue("ad", data.Ad);
            cmd.Parameters.AddWithValue("soyad", data.Soyad);
            cmd.Parameters.AddWithValue("DogumYeri", data.DogumYeri);
            cmd.Parameters.AddWithValue("DogumTarihi", data.DogumTarihi);
            cmd.Parameters.AddWithValue("Adres", data.Adres);
            cmd.Parameters.AddWithValue("Tel", data.Tel);
            cmd.Parameters.AddWithValue("KurumSicilNo", data.KurumSicilNo);
            cmd.Parameters.AddWithValue("KurumAdi", data.KurumAdi);
            cmd.Parameters.AddWithValue("YakinTel", data.YakinTel);
            cmd.Parameters.AddWithValue("YakinKurumSicilNo", data.YakinKurumSicilNo);
            cmd.Parameters.AddWithValue("YakinKurumAdi", data.YakinKurumAdi);
            cmd.Parameters.AddWithValue("DogumYeri", data.DogumYeri);
            cmd.Parameters.AddWithValue("AnneAdi", data.AnneAdi);
            cmd.Parameters.AddWithValue("BabaAdi", data.BabaAdi);
            cmd.Parameters.AddWithValue("Cinsiyet", data.Cinsiyet);
            cmd.Parameters.AddWithValue("KanGrubu", data.KanGrubu);
            cmd.Parameters.AddWithValue("MedeniHal", data.MedeniHal);
            cmd.Parameters.AddWithValue("TcKimlikNo", data.TcKimlikNo);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        /// <summary>
        /// kullanıcı kaydını günceller
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public GenericResponse<bool> UpdateUser(User user)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.kullanıcıGüncelle, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("kodu", user.Kodu);
            cmd.Parameters.AddWithValue("ad", user.Ad);
            cmd.Parameters.AddWithValue("soyad", user.Soyad);
            cmd.Parameters.AddWithValue("sifre", user.Sifre);
            cmd.Parameters.AddWithValue("Yetki", user.Yetki);
            cmd.Parameters.AddWithValue("Evtel", user.Evtel);
            cmd.Parameters.AddWithValue("CepTel", user.CepTel);
            cmd.Parameters.AddWithValue("Adres", user.Adres);
            cmd.Parameters.AddWithValue("Unvan", user.Unvan);
            cmd.Parameters.AddWithValue("IseBaslama", user.IseBaslama);
            cmd.Parameters.AddWithValue("Maas", user.Maas);
            cmd.Parameters.AddWithValue("DogumYeri", user.DogumYeri);
            cmd.Parameters.AddWithValue("AnneAd", user.AnneAd);
            cmd.Parameters.AddWithValue("BabaAd", user.BabaAd);
            cmd.Parameters.AddWithValue("Cinsiyet", user.Cinsiyet);
            cmd.Parameters.AddWithValue("KanGrubu", user.KanGrubu);
            cmd.Parameters.AddWithValue("MedeniHal", user.MedeniHal);
            cmd.Parameters.AddWithValue("DogumTarihi", user.DogumTarihi);
            cmd.Parameters.AddWithValue("TcKimlikNo", user.TcKimlikNo);
            cmd.Parameters.AddWithValue("UserName", user.UserName);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        /// <summary>
        /// sevk günceller
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GenericResponse<bool> UpdateTransfer(Transfer data)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.sevkGuncelle, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("SevkTarihi", data.SevkTarihi);
            cmd.Parameters.AddWithValue("DosyaNo", data.DosyaNo);
            cmd.Parameters.AddWithValue("Poliklinik", data.Poliklinik);
            cmd.Parameters.AddWithValue("Saat", data.Saat);
            cmd.Parameters.AddWithValue("YapilanIslem", data.YapilanIslem);
            cmd.Parameters.AddWithValue("DrKod", data.DrKod);
            cmd.Parameters.AddWithValue("Miktar", data.Miktar);
            cmd.Parameters.AddWithValue("BirimFiyat", data.BirimFiyat);
            cmd.Parameters.AddWithValue("Sira", data.Sira);
            cmd.Parameters.AddWithValue("ToplamTutar", data.ToplamTutar);
            cmd.Parameters.AddWithValue("Taburcu", data.Taburcu);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        /// <summary>
        /// poliklinik günceller
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GenericResponse<bool> UpdatePolyclinic(Polyclinic data)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.poliklinikGuncelle, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PoliklinikAdi", data.PoliklinikAdi);
            cmd.Parameters.AddWithValue("Durum", data.Durum);
            cmd.Parameters.AddWithValue("Aciklama", data.Aciklama);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        #endregion

        #region Silme işlemleri
        /// <summary>
        /// hasta kaydı siler
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GenericResponse<bool> DeletePatient(Patient data)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.hastasil, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("tcKimlikNo", data.TcKimlikNo);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        /// <summary>
        /// kullanıcı kaydı siler
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public GenericResponse<bool> DeleteUser(User user)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.kullanıcısil, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("kodu", user.Kodu);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        /// <summary>
        /// poliklinik kaydı siler
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GenericResponse<bool> DeletePolyclinic(Polyclinic data)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.polikliniksil, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PoliklinikAdi", data.PoliklinikAdi);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        /// <summary>
        /// sevk kaydı siler
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public GenericResponse<bool> DeleteTransfer(Transfer data)
        {
            var returnObject = new GenericResponse<Boolean>();

            ConnectDB();
            var cmd = new SqlCommand(Common.sevksil, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("DosyaNo", data.DosyaNo);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                throw;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        #endregion

        #region Select işlemleri



        #endregion
    }
}
