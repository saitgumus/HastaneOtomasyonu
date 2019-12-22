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
        private static DBServices dbService;

        private DBServices()
        {
            dr = new SqlDataAdapter();
            ds = new DataSet();
        }

        public static DBServices ConnectToService()
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
            cmd.Parameters.AddWithValue("@kodu",         user.Kodu);
            cmd.Parameters.AddWithValue("@ad",           user.Ad);
            cmd.Parameters.AddWithValue("@soyad",        user.Soyad);
            cmd.Parameters.AddWithValue("@sifre",        user.Sifre);
            cmd.Parameters.AddWithValue("@Yetki",        user.Yetki);
            cmd.Parameters.AddWithValue("@Evtel",        user.Evtel);
            cmd.Parameters.AddWithValue("@CepTel",       user.CepTel);
            cmd.Parameters.AddWithValue("@Adres",        user.Adres);
            cmd.Parameters.AddWithValue("@Unvan",        user.Unvan);
            cmd.Parameters.AddWithValue("@IseBaslama",   user.IseBaslama);
            cmd.Parameters.AddWithValue("@Maas",         user.Maas);
            cmd.Parameters.AddWithValue("@DogumYeri",    user.DogumYeri);
            cmd.Parameters.AddWithValue("@AnneAd",       user.AnneAd);
            cmd.Parameters.AddWithValue("@BabaAd",       user.BabaAd);
            cmd.Parameters.AddWithValue("@Cinsiyet",     user.Cinsiyet);
            cmd.Parameters.AddWithValue("@KanGrubu",     user.KanGrubu);
            cmd.Parameters.AddWithValue("@MedeniHal",    user.MedeniHal);
            cmd.Parameters.AddWithValue("@DogumTarihi",  user.DogumTarihi);
            cmd.Parameters.AddWithValue("@TcKimlikNo",   user.TcKimlikNo);
            cmd.Parameters.AddWithValue("@UserName",     user.UserName);
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
            var cmd = new SqlCommand(Common.hastaKaydet, conSOHATS)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@tcKimlikNo", data.TcKimlikNo);
            cmd.Parameters.AddWithValue("@DosyaNo", data.DosyaNo);
            cmd.Parameters.AddWithValue("@ad", data.Ad);
            cmd.Parameters.AddWithValue("@soyad", data.Soyad);
            cmd.Parameters.AddWithValue("@DogumYeri", data.DogumYeri);
            cmd.Parameters.AddWithValue("@DogumTarihi", data.DogumTarihi);
            cmd.Parameters.AddWithValue("@Adres", data.Adres);
            cmd.Parameters.AddWithValue("@Tel", data.Tel);
            cmd.Parameters.AddWithValue("@KurumSicilNo", data.KurumSicilNo);
            cmd.Parameters.AddWithValue("@KurumAdi", data.KurumAdi);
            cmd.Parameters.AddWithValue("@YakinTel", data.YakinTel);
            cmd.Parameters.AddWithValue("@YakinKurumSicilNo", data.YakinKurumSicilNo);
            cmd.Parameters.AddWithValue("@YakinKurumAdi", data.YakinKurumAdi);
            cmd.Parameters.AddWithValue("@DogumYeri", data.DogumYeri);
            cmd.Parameters.AddWithValue("@AnneAdi", data.AnneAdi);
            cmd.Parameters.AddWithValue("@BabaAdi", data.BabaAdi);
            cmd.Parameters.AddWithValue("@Cinsiyet", data.Cinsiyet);
            cmd.Parameters.AddWithValue("@KanGrubu", data.KanGrubu);
            cmd.Parameters.AddWithValue("@MedeniHal", data.MedeniHal);
            cmd.Parameters.AddWithValue("@TcKimlikNo", data.TcKimlikNo);
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
            cmd.Parameters.AddWithValue("@DosyaNo", data.DosyaNo);
            cmd.Parameters.AddWithValue("@SevkTarihi", data.SevkTarihi);
            cmd.Parameters.AddWithValue("@CikisTarihi", data.CikisTarihi);
            cmd.Parameters.AddWithValue("@Odeme", data.Odeme);
            cmd.Parameters.AddWithValue("@ToplamTutar", data.ToplamTutar);
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
            cmd.Parameters.AddWithValue("@SevkTarihi", data.SevkTarihi);
            cmd.Parameters.AddWithValue("@DosyaNo", data.DosyaNo);
            cmd.Parameters.AddWithValue("@Poliklinik", data.Poliklinik);
            cmd.Parameters.AddWithValue("@Saat", data.Saat);
            cmd.Parameters.AddWithValue("@YapilanIslem", data.YapilanIslem);
            cmd.Parameters.AddWithValue("@DrKod", data.DrKod);
            cmd.Parameters.AddWithValue("@Miktar", data.Miktar);
            cmd.Parameters.AddWithValue("@BirimFiyat", data.BirimFiyat);
            cmd.Parameters.AddWithValue("@Sira", data.Sira);
            cmd.Parameters.AddWithValue("@Taburcu", data.Taburcu);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                endConnectDB();
                return returnObject;
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
            cmd.Parameters.AddWithValue("@PoliklinikAdi", data.PoliklinikAdi);
            cmd.Parameters.AddWithValue("@Durum", data.Durum);
            cmd.Parameters.AddWithValue("@Aciklama", data.Aciklama);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                return returnObject;
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
            cmd.Parameters.AddWithValue("@tcKimlikNo", data.TcKimlikNo);
            cmd.Parameters.AddWithValue("@DosyaNo", data.DosyaNo);
            cmd.Parameters.AddWithValue("@ad", data.Ad);
            cmd.Parameters.AddWithValue("@soyad", data.Soyad);
            cmd.Parameters.AddWithValue("@DogumYeri", data.DogumYeri);
            cmd.Parameters.AddWithValue("@DogumTarihi", data.DogumTarihi);
            cmd.Parameters.AddWithValue("@Adres", data.Adres);
            cmd.Parameters.AddWithValue("@Tel", data.Tel);
            cmd.Parameters.AddWithValue("@KurumSicilNo", data.KurumSicilNo);
            cmd.Parameters.AddWithValue("@KurumAdi", data.KurumAdi);
            cmd.Parameters.AddWithValue("@YakinTel", data.YakinTel);
            cmd.Parameters.AddWithValue("@YakinKurumSicilNo", data.YakinKurumSicilNo);
            cmd.Parameters.AddWithValue("@YakinKurumAdi", data.YakinKurumAdi);
            cmd.Parameters.AddWithValue("@DogumYeri", data.DogumYeri);
            cmd.Parameters.AddWithValue("@AnneAdi", data.AnneAdi);
            cmd.Parameters.AddWithValue("@BabaAdi", data.BabaAdi);
            cmd.Parameters.AddWithValue("@Cinsiyet", data.Cinsiyet);
            cmd.Parameters.AddWithValue("@KanGrubu", data.KanGrubu);
            cmd.Parameters.AddWithValue("@MedeniHal", data.MedeniHal);
            cmd.Parameters.AddWithValue("@TcKimlikNo", data.TcKimlikNo);
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
            cmd.Parameters.AddWithValue("@kodu", user.Kodu);
            cmd.Parameters.AddWithValue("@ad", user.Ad);
            cmd.Parameters.AddWithValue("@soyad", user.Soyad);
            cmd.Parameters.AddWithValue("@sifre", user.Sifre);
            cmd.Parameters.AddWithValue("@Yetki", user.Yetki);
            cmd.Parameters.AddWithValue("@Evtel", user.Evtel);
            cmd.Parameters.AddWithValue("@CepTel", user.CepTel);
            cmd.Parameters.AddWithValue("@Adres", user.Adres);
            cmd.Parameters.AddWithValue("@Unvan", user.Unvan);
            cmd.Parameters.AddWithValue("@IseBaslama", user.IseBaslama);
            cmd.Parameters.AddWithValue("@Maas", user.Maas);
            cmd.Parameters.AddWithValue("@DogumYeri", user.DogumYeri);
            cmd.Parameters.AddWithValue("@AnneAd", user.AnneAd);
            cmd.Parameters.AddWithValue("@BabaAd", user.BabaAd);
            cmd.Parameters.AddWithValue("@Cinsiyet", user.Cinsiyet);
            cmd.Parameters.AddWithValue("@KanGrubu", user.KanGrubu);
            cmd.Parameters.AddWithValue("@MedeniHal", user.MedeniHal);
            cmd.Parameters.AddWithValue("@DogumTarihi", user.DogumTarihi);
            cmd.Parameters.AddWithValue("@TcKimlikNo", user.TcKimlikNo);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
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
            cmd.Parameters.AddWithValue("@SevkTarihi", data.SevkTarihi);
            cmd.Parameters.AddWithValue("@DosyaNo", data.DosyaNo);
            cmd.Parameters.AddWithValue("@Poliklinik", data.Poliklinik);
            cmd.Parameters.AddWithValue("@Saat", data.Saat);
            cmd.Parameters.AddWithValue("@YapilanIslem", data.YapilanIslem);
            cmd.Parameters.AddWithValue("@DrKod", data.DrKod);
            cmd.Parameters.AddWithValue("@Miktar", data.Miktar);
            cmd.Parameters.AddWithValue("@BirimFiyat", data.BirimFiyat);
            cmd.Parameters.AddWithValue("@Sira", data.Sira);
            cmd.Parameters.AddWithValue("@ToplamTutar", data.ToplamTutar);
            cmd.Parameters.AddWithValue("@Taburcu", data.Taburcu);
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
            cmd.Parameters.AddWithValue("@PoliklinikAdi", data.PoliklinikAdi);
            cmd.Parameters.AddWithValue("@Durum", data.Durum);
            cmd.Parameters.AddWithValue("@Aciklama", data.Aciklama);
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
            cmd.Parameters.AddWithValue("@tcKimlikNo", data.TcKimlikNo);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                return returnObject;
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
            cmd.Parameters.AddWithValue("@kodu", user.Kodu);
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

        /// <summary>
        /// kullanıcıları getirir
        /// </summary>
        /// <returns></returns>
        public GenericResponse<List<User>> SelectUser()
        {
            var returnObject = new GenericResponse<List<User>>();

            ConnectDB();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = Common.CreateProcedureText(Common.userTable,null, null );
            sqlCommand.Connection = conSOHATS;
            SqlDataReader dr = sqlCommand.ExecuteReader();

            List<User> data = new List<User>();
            User user;
            while (dr.Read())
            {
                user = new User
                {
                    Kodu = SQLDBHelper.GetIntValue(dr["kodu"]),
                    Ad = SQLDBHelper.GetStringValue(dr["ad"]),
                    Soyad = SQLDBHelper.GetStringValue(dr["soyad"]),
                    Sifre = SQLDBHelper.GetStringValue(dr["sifre"]),
                    Yetki = SQLDBHelper.GetStringValue(dr["yetki"]),
                    Evtel = SQLDBHelper.GetStringValue(dr["evtel"]),
                    CepTel = SQLDBHelper.GetStringValue(dr["ceptel"]),
                    Adres = SQLDBHelper.GetStringValue(dr["adres"]),
                    Unvan = SQLDBHelper.GetStringValue(dr["unvan"]),
                    IseBaslama = SQLDBHelper.GetDateTimeValue(dr["isebaslama"]),
                    Maas = SQLDBHelper.GetIntValue(dr["maas"]),
                    DogumYeri = SQLDBHelper.GetStringValue(dr["dogumyeri"]),
                    AnneAd = SQLDBHelper.GetStringValue(dr["annead"]),
                    BabaAd = SQLDBHelper.GetStringValue(dr["babaad"]),
                    Cinsiyet = SQLDBHelper.GetStringValue(dr["cinsiyet"]),
                    KanGrubu = SQLDBHelper.GetStringValue(dr["kangrubu"]),
                    MedeniHal = SQLDBHelper.GetStringValue(dr["medenihal"]),
                    DogumTarihi = SQLDBHelper.GetDateTimeValue(dr["dogumtarihi"]),
                    TcKimlikNo = SQLDBHelper.GetStringValue(dr["tckimlikno"]),
                    UserName = SQLDBHelper.GetStringValue(dr["username"])
                };

                data.Add(user);
            }
            endConnectDB();
            returnObject.Value = data;
            returnObject.Success = true;

            return returnObject;
        }

        /// <summary>
        /// hasta kayıtlarını getirir
        /// </summary>
        /// <returns></returns>
        public GenericResponse<List<Patient>> SelectPatient(string[] fields, string filter)
        {
            var returnObject = new GenericResponse<List<Patient>>();
            ConnectDB();
            var sqlCommand = new SqlCommand
            {
                CommandText = Common.CreateProcedureText(Common.patientTable, fields, filter),
                Connection = conSOHATS
            };
           
            var dr = sqlCommand.ExecuteReader();

            var data = new List<Patient>();
            var patient = new Patient();
            while (dr.Read())
            {
                patient = new Patient
                {
                    TcKimlikNo = SQLDBHelper.GetStringValue(dr["tckimlikno"]),
                    DosyaNo = SQLDBHelper.GetIntValue(dr["dosyano"]),
                        Ad = SQLDBHelper.GetStringValue(dr["ad"]),
                    Soyad = SQLDBHelper.GetStringValue(dr["soyad"]),
                    DogumYeri = SQLDBHelper.GetStringValue(dr["dogumyeri"]),
                    DogumTarihi = SQLDBHelper.GetDateTimeValue(dr["dogumtarihi"]),
                    BabaAdi = SQLDBHelper.GetStringValue(dr["babaadi"]),
                    AnneAdi = SQLDBHelper.GetStringValue(dr["anneadi"]),
                    Cinsiyet = SQLDBHelper.GetStringValue(dr["cinsiyet"]),
                    KanGrubu = SQLDBHelper.GetStringValue(dr["kangrubu"]),
                    MedeniHal = SQLDBHelper.GetStringValue(dr["medenihal"]),
                    Adres = SQLDBHelper.GetStringValue(dr["adres"]),
                    Tel = SQLDBHelper.GetStringValue(dr["tel"]),
                    KurumSicilNo = SQLDBHelper.GetStringValue(dr["kurumsicilno"]),
                    KurumAdi = SQLDBHelper.GetStringValue(dr["kurumadi"]),
                    YakinTel = SQLDBHelper.GetStringValue(dr["yakintel"]),
                    YakinKurumSicilNo = SQLDBHelper.GetStringValue(dr["yakinkurumsicilno"]),
                    YakinKurumAdi = SQLDBHelper.GetStringValue(dr["yakinkurumadi"])
                };
                data.Add(patient);
            }
            endConnectDB();
            returnObject.Value = data;
            returnObject.Success = true;

            return returnObject;
        }

        /// <summary>
        /// dosya numarası ile kayıt getirir.
        /// </summary>
        /// <param name="dosyaNo"></param>
        /// <returns></returns>
        public GenericResponse<Patient> SelectPatientByKey(int dosyaNo)
        {
            var returnObject = new GenericResponse<Patient>();

            ConnectDB();
            var cmd = new SqlCommand(Common.dosyanoilehastagetir, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dosyano",dosyaNo);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var data = new Patient
                {
                    TcKimlikNo = SQLDBHelper.GetStringValue(dr["tckimlikno"]),
                    DosyaNo = SQLDBHelper.GetIntValue(dr["dosyano"]),
                    Ad = SQLDBHelper.GetStringValue(dr["ad"]),
                    Soyad = SQLDBHelper.GetStringValue(dr["soyad"]),
                    DogumYeri = SQLDBHelper.GetStringValue(dr["dogumyeri"]),
                    DogumTarihi = SQLDBHelper.GetDateTimeValue(dr["dogumtarihi"]),
                    BabaAdi = SQLDBHelper.GetStringValue(dr["babaadi"]),
                    AnneAdi = SQLDBHelper.GetStringValue(dr["anneadi"]),
                    Cinsiyet = SQLDBHelper.GetStringValue(dr["cinsiyet"]),
                    KanGrubu = SQLDBHelper.GetStringValue(dr["kangrubu"]),
                    MedeniHal = SQLDBHelper.GetStringValue(dr["medenihal"]),
                    Adres = SQLDBHelper.GetStringValue(dr["adres"]),
                    Tel = SQLDBHelper.GetStringValue(dr["tel"]),
                    KurumSicilNo = SQLDBHelper.GetStringValue(dr["kurumsicilno"]),
                    KurumAdi = SQLDBHelper.GetStringValue(dr["kurumadi"]),
                    YakinTel = SQLDBHelper.GetStringValue(dr["yakintel"]),
                    YakinKurumSicilNo = SQLDBHelper.GetStringValue(dr["yakinkurumsicilno"]),
                    YakinKurumAdi = SQLDBHelper.GetStringValue(dr["yakinkurumadi"])
                };
                returnObject.Value = data;
            }

            returnObject.Success = true;
            endConnectDB();
            return returnObject;
        }

        /// <summary>
        /// taburcu kayıtları
        /// </summary>
        /// <returns></returns>
        public GenericResponse<List<Discharged>> SelectDischarged()
        {
            var returnObject = new GenericResponse<List<Discharged>>();

            ConnectDB();
            var sqlCommand = new SqlCommand();
            sqlCommand.CommandText = Common.CreateProcedureText(Common.patientTable, null, null);
            sqlCommand.Connection = conSOHATS;
            var dr = sqlCommand.ExecuteReader();

            var data = new List<Discharged>();
            var patient = new Discharged();
            while (dr.Read())
            {
                patient = new Discharged
                {
                    DosyaNo = (dr[0] != DBNull.Value) ? dr.GetInt32(0) : 0,
                    SevkTarihi = (dr[1] != DBNull.Value) ? Convert.ToDateTime(dr[1]) : DateTime.MinValue,
                    CikisTarihi = (dr[2] != DBNull.Value) ? Convert.ToDateTime(dr[2]) : DateTime.MinValue,
                    Odeme = (dr[3] != DBNull.Value) ? dr.GetInt32(3) : 0,
                    ToplamTutar = (dr[4] != DBNull.Value) ? dr.GetInt32(4) : 0
            };

                data.Add(patient);
            }
            endConnectDB();
            returnObject.Value = data;
            returnObject.Success = true;

            return returnObject;
        }

        /// <summary>
        /// poliklinik kayıtları getirir
        /// </summary>
        /// <returns></returns>
        public GenericResponse<List<Polyclinic>> SelectPolyclinic()
        {
            var returnObject = new GenericResponse<List<Polyclinic>>();

            ConnectDB();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = Common.CreateProcedureText(Common.polyclinicTable, null, null);
            sqlCommand.Connection = conSOHATS;
            SqlDataReader dr = sqlCommand.ExecuteReader();

            List<Polyclinic> data = new List<Polyclinic>();
            Polyclinic pol = new Polyclinic();
            while (dr.Read())
            {
                pol = new Polyclinic();
                pol.PoliklinikAdi = dr[0].ToString();
                pol.Durum = dr[1].ToString();
                pol.Aciklama = dr[2].ToString();
                data.Add(pol);
            }
            endConnectDB();
            returnObject.Value = data;
            returnObject.Success = true;

            return returnObject;
        }

        /// <summary>
        /// işlem kayıtlarını getirir
        /// </summary>
        /// <returns></returns>
        public GenericResponse<List<Operation>> SelectOperation()
        {
            var returnObject = new GenericResponse<List<Operation>>();

            ConnectDB();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = Common.CreateProcedureText(Common.operationTable, null, null);
            sqlCommand.Connection = conSOHATS;
            SqlDataReader dr = sqlCommand.ExecuteReader();

            var data = new List<Operation>();
            var dt = new Operation();
            while (dr.Read())
            {
                dt = new Operation
                {
                    IslemAdi = dr.GetString(0),
                    BirimFiyat = (dr[1] != DBNull.Value) ? dr.GetInt32(1): 0
                };
                data.Add(dt);
            }
            endConnectDB();
            returnObject.Value = data;
            returnObject.Success = true;

            return returnObject;
        }

       
        /// <summary>
        /// sevk select sorgusu
        /// </summary>
        /// <param name="alanlar"></param>
        /// <param name="filtre"></param>
        /// <returns></returns>
        public GenericResponse<List<Transfer>> SelectTransfer(string[] alanlar, string filtre)
        {
            var returnObject = new GenericResponse<List<Transfer>>();

            ConnectDB();
            var sqlCommand = new SqlCommand
            {
                CommandText = Common.CreateProcedureText(Common.transferTable, alanlar, filtre),
                Connection = conSOHATS
            };
            var dr = sqlCommand.ExecuteReader();

            var data = new List<Transfer>();
            var dt = new Transfer();
            while (dr.Read())
            {
                dt = new Transfer
                {
                    Poliklinik = SQLDBHelper.GetStringValue(dr["poliklinik"]),
                    SevkTarihi = SQLDBHelper.GetDateTimeValue(dr["sevktarihi"]),
                    DosyaNo = SQLDBHelper.GetIntValue(dr["dosyano"]),
                    Sira = SQLDBHelper.GetIntValue(dr["sira"]),
                    Saat = SQLDBHelper.GetStringValue(dr["saat"]),
                    YapilanIslem = SQLDBHelper.GetStringValue(dr["yapilanislem"]),
                    DrKod = SQLDBHelper.GetIntValue(dr["drkod"]),
                    Miktar = SQLDBHelper.GetIntValue(dr["miktar"]),
                    BirimFiyat = SQLDBHelper.GetIntValue(dr["birimfiyat"]),
                    ToplamTutar = SQLDBHelper.GetIntValue(dr["toplamtutar"]),
                    Taburcu = SQLDBHelper.GetStringValue(dr["taburcu"])
                };
                data.Add(dt);
            }
            endConnectDB();
            returnObject.Value = data;
            returnObject.Success = true;

            return returnObject;
        }

        /// <summary>
        /// dosya numarasına göre değer döndürür
        /// </summary>
        /// <param name="dosyano"></param>
        /// <returns></returns>
        public GenericResponse<List<Transfer>> SelectTransferByDosyaNo(int dosyano)
        {
            var returnObject = new GenericResponse<List<Transfer>>();

            ConnectDB();
            var cmd = new SqlCommand(Common.dosyanoilesevkgetir, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dosyano", dosyano);
            var dr = cmd.ExecuteReader();

            var data = new List<Transfer>();
            var dt = new Transfer();
            while (dr.Read())
            {
                dt = new Transfer
                {
                    Poliklinik = SQLDBHelper.GetStringValue(dr["poliklinik"]),
                    SevkTarihi = SQLDBHelper.GetDateTimeValue(dr["sevktarihi"]),
                    DosyaNo = SQLDBHelper.GetIntValue(dr["dosyano"]),
                    Sira = SQLDBHelper.GetIntValue(dr["sira"]),
                    Saat = SQLDBHelper.GetStringValue(dr["saat"]),
                    YapilanIslem = SQLDBHelper.GetStringValue(dr["yapilanislem"]),
                    DrKod = SQLDBHelper.GetIntValue(dr["drkod"]),
                    Miktar = SQLDBHelper.GetIntValue(dr["miktar"]),
                    BirimFiyat = SQLDBHelper.GetIntValue(dr["birimfiyat"]),
                    ToplamTutar = SQLDBHelper.GetIntValue(dr["toplamtutar"]),
                    Taburcu = SQLDBHelper.GetStringValue(dr["taburcu"])
                };
                data.Add(dt);
            }
            endConnectDB();
            returnObject.Value = data;
            returnObject.Success = true;

            return returnObject;
        }

        /// <summary>
        /// ünvan tablosu kayıtlarını getirir.
        /// </summary>
        /// <returns></returns>
        public GenericResponse<List<string>> SelectUnvan()
        {
            var returnObject = new GenericResponse<List<string>>();

            ConnectDB();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = Common.CreateProcedureText(Common.unvanTable, null, null);
            sqlCommand.Connection = conSOHATS;
            SqlDataReader dr = sqlCommand.ExecuteReader();

            var data = new List<string>();
            while (dr.Read())
            {
                var dt = SQLDBHelper.GetStringValue(dr["unvanadı"]);
                data.Add(dt);
            }

            returnObject.Success = true;
            returnObject.Value = data;
            endConnectDB();

            return returnObject;
        }

        /// <summary>
        /// odeme türlerini getirir
        /// </summary>
        /// <returns></returns>
        public GenericResponse<List<string>> SelectOdeme()
        {
            var returnObject = new GenericResponse<List<string>>();

            ConnectDB();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = Common.CreateProcedureText(Common.odemeTable, null, null);
            sqlCommand.Connection = conSOHATS;
            SqlDataReader dr = sqlCommand.ExecuteReader();

            var data = new List<string>();
            while (dr.Read())
            {
                var dt = SQLDBHelper.GetStringValue(dr["odemeSekli"]);
                data.Add(dt);
            }

            returnObject.Success = true;
            returnObject.Value = data;
            endConnectDB();

            return returnObject;
        }

        /// <summary>
        /// son dosya numarasını döndürür
        /// </summary>
        /// <returns></returns>
        public GenericResponse<int> SelectDosyaNo()
        {
            var returnObject = new GenericResponse<Int32>();

            ConnectDB();

            var cmd = new SqlCommand(Common.sondosyanumarasıgetir, conSOHATS);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Common.WriteLog("error", e.Message);
                returnObject.Success = false;
                returnObject.ErrorMessage = e.Message;
                return returnObject;
            }
            SqlDataReader dr = cmd.ExecuteReader();

            var data = new List<string>();
            while (dr.Read())
            {
                returnObject.Value = SQLDBHelper.GetIntValue(dr["dosyano"]);
            }

            returnObject.Success = true;
            endConnectDB();

            return returnObject;
        }
        #endregion
    }
}
