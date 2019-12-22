using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyon.Models;
using System.IO;
using System.Drawing;
using System.Reflection;

namespace HastaneOtomasyon
{
    /// <summary>
    /// mesaj bilgileri tutar
    /// </summary>
    public class Messaging
    {
        #region message texts

        public const string msg_zorunluAlanWarning = "Zorunlu alanları doldurunuz.";
        public const string msg_kullaniciBulunamadı = "Kullanıcı adı veya şifre hatalı.";
        public const string msg_yetkiliDegil = "Yetkiniz bulunmamaktadır.";
        public const string msg_kayıtHata = "Kayıt yapılamadı.";
        public const string msg_güncellemeHata = "Güncelleme Yapılamadı.";
        public const string msg_güncellemeOk = "Güncellendi.";
        public const string msg_silmeHata = "Silme işlemi Yapılamadı.";
        public const string msg_silmeOk = "Silindi.";
        public const string msg_selectRecordWarning = "Lütfen bir kayıt seçiniz.";
        public const string msg_silmeIslemiSoru = "Seçili kayıt silisin mi?";
        public const string msg_selectHata = "Kayıtlar getirilemedi.";
        public const string msg_kayıtOk = "Kaydedildi";
        public const string msg_hastaBulunamadı = "Hasta bulunamadı";

        public const string msg_seciniz = "Seçiniz";
        public const string msg_hepsi = "Hepsi";

        #endregion

        #region message metods

        /// <summary>
        /// uyarı mesajı
        /// </summary>
        /// <param name="message"></param>
        public static void DialogWarningMessage(string message)
        {
            MessageBox.Show(message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// hata mesajı verir
        /// </summary>
        /// <param name="message"></param>
        public static void DialogErrorMessage(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// bilgi mesajı verir
        /// </summary>
        /// <param name="message"></param>
        public static void DialogInfoMessage(string message)
        {
            MessageBox.Show(message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// deger döndüren mesaj verir
        /// </summary>
        /// <param name="message"></param>
        public static bool DialogExamMessage(string message)
        {
            var result = MessageBox.Show(message, "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        #endregion
    }

    /// <summary>
    /// ünvanları tutar
    /// </summary>
    public static class Unvan
    {
        public const string Doktor = "Doktor";
        public const string Calisan = "Çalışan";
    }
    /// <summary>
    /// control metodları ve DB type stringleri tutar
    /// </summary>
    public class Common
    {
        #region LoginUser
        // ReSharper disable once InconsistentNaming
        private static User loginUser;

        public static User LoginUser
        {
            get
            {
                return loginUser;
            }
            set
            {
                loginUser = value;
                WriteLog("Giriş", "giriş yapıldı.");
            }
        }

        #endregion

        #region methods
     
    
        #region Log
        /// <summary>
        /// Loglama Metodu
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        public static void WriteLog(string subject, string message)
        {
            StreamWriter streamWriter = new StreamWriter(LogPath, true);

            streamWriter.WriteLine(
                String.Format("Time:{0} \t Subject:{1} \n\t message: {2}",
                                DateTime.Now,
                                subject,
                                message)
                );

            streamWriter.Close();
        }


        #endregion

        /// <summary>
        /// string boş değil ise true döner
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool SpaceControl(string s)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(s))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// boş bırakılan text alanlarını işaretler
        /// boş değer/ler varsa false döner
        /// </summary>
        /// <param name="control"></param>
        public static bool SpaceControlAll(ref Panel control)
        {
            bool ret = true;
            foreach (var item in control.Controls.OfType<TextBox>())
            {
                if (!SpaceControl(item.Text))
                {
                    item.BackColor = Color.LightCoral;
                    ret = false;
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }

            foreach (var item in control.Controls.OfType<MaskedTextBox>())
            {
                if (!SpaceControl(item.Text))
                {
                    item.BackColor = Color.LightCoral;
                    ret = false;
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }

            foreach (var item in control.Controls.OfType<ComboBox>())
            {
                if (item.SelectedIndex < 0)
                {
                    item.BackColor = Color.LightCoral;
                    ret = false;
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }

            return ret;
        }

        /// <summary>
        /// tek bir kontrol için (textb,mask,combo)
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static bool SpaceControlOne(ref Control control)
        {
            bool returnObject = true;
            if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(MaskedTextBox))
            {
                if (!SpaceControl(control.Text))
                {
                    control.BackColor = Color.LightCoral;
                    returnObject = false;
                }
                else
                {
                    control.BackColor = Color.White;
                }
            }

            if (control.GetType() == typeof(ComboBox))
            {
                if ((control as ComboBox).SelectedIndex < 0 )
                {
                    control.BackColor = Color.LightCoral;
                    returnObject = false;
                }
                else
                {
                    control.BackColor = Color.White;
                }
            }

            return returnObject;
        }

        /// <summary>
        /// değerin numeric olma durumu
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool NumericControl(string s)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(s, "[^0-9]"))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// işaret edilen control içerisindeki textleri temizler
        /// </summary>
        /// <param name="parent"></param>
        public static void CleanTextControls(ref Panel parent)
        {
            foreach (var item in parent.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }

            foreach (var item in parent.Controls.OfType<MaskedTextBox>())
            {
                item.Text = "";
            }

            foreach (var item in parent.Controls.OfType<ComboBox>())
            {
                if (item.Items.Count > 0)
                {
                    item.SelectedIndex = 0;
                }
            }
        }


        #endregion



        #region types
        public const string ConnectionString = @"Server=.\; Database= SOHATS; Integrated Security = SSPI";
        public const string LogPath = @"./SOHATS_LOG.txt";
        public const string AdminText = "Evet";
        public const string PolyclinicStatusAktif = "Aktif";
        public const string PolyclinicStatusPasif = "Pasif";
        public const string TaburcuTxt = "Taburcu";
        public const string TaburcuDegilTxt = "Taburcu Degil";

        #region procedure names
        public const string hastasil = "delete_hasta";
        public const string kullanıcısil = "delete_kullanici";
        public const string polikliniksil = "delete_poliklinik";
        public const string sevksil = "delete_sevk";
        public const string dosyanobul = "dosyano_ile_bul";
        public const string hasthastaadbul = "hastaAdı_ile_bul";
        public const string cikisKaydet = "insert_cikis";
        public const string hastaKaydet = "insert_hasta";
        public const string kullanıcıKaydet = "insert_kullanici";
        public const string poliklinikKaydet = "insert_poliklinik";
        public const string sevkKaydet = "insert_sevk";
        public const string hastaGuncelle = "update_hasta";
        public const string kullanıcıGüncelle = "update_kullanıcı";
        public const string poliklinikGuncelle = "update_poliklinik";
        public const string sevkGuncelle = "update_sevk";
        public const string dosyanoilehastagetir = "dosyano_ile_bul";
        public const string dosyanoilesevkgetir = "sel_sevkByDosyaNo";
        public const string sondosyanumarasıgetir = "sel_sondosyanumarası";


        public const string userTable = "kullanici";
        public const string patientTable = "hasta";
        public const string polyclinicTable = "poliklinik";
        public const string operationTable = "islem";
        public const string dischargedTable = "cikis";
        public const string transferTable = "sevk";
        public const string unvanTable = "unvan";
        public const string odemeTable = "odeme";


        /// <summary>
        /// procedure için commandtext oluşturur
        /// alanlar null bırakılırsa bütün alanlar dahil olur
        /// filtre null bırakılırsa filtresiz varsayılır
        /// </summary>
        /// <param name="tablo"></param>
        /// <param name="filter"></param>
        /// <param name="alanlar"></param>
        /// <returns></returns>
        public static string CreateProcedureText(string tablo, string[] alanlar, string filter)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("SELECT ");
            if (alanlar != null && alanlar.Length > 0)
            {
                bool first = true;
                foreach (var item in alanlar)
                {
                    stringBuilder.Append((first) ? item : " ," + item);
                    first = false;
                }
            }
            else
            {
                stringBuilder.Append(" * ");
            }
            stringBuilder.Append(" FROM " + tablo);
            if (filter != null && filter.Length > 1)
            {
                stringBuilder.Append(" WHERE " + filter);
            }

            return stringBuilder.ToString();
        }


        /// <summary>
        /// verilen sınıfın public değerlerni döndürür.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<string> GetClassProperties<T>()
        {
            var returnObject = new List<string>();

            var pross = typeof(T).GetProperties();

            foreach (var propertyInfo in pross)
            {
                returnObject.Add(propertyInfo.Name);
            }

            return returnObject;
        }

        /// <summary>
        /// verilen sınıfın public değerlerni döndürür.
        /// her değerin tipini value olarak girer
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Type> GetClassPropertyDictionary<T>()
        {
            var returnObject = new Dictionary<string, Type>();

            Type t = typeof(T);

            foreach (PropertyInfo info in t.GetProperties())
            {
                returnObject.Add(info.Name,info.PropertyType);
            }

            return returnObject;
        }

        /// <summary>
        /// eğer sadece alfabetik veya silme tuşu ise true döner.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool ControlAlphabetic(KeyPressEventArgs e)
        {
            return (char.IsLetter(e.KeyChar) || e.KeyChar == (char) Keys.Back);
        }

        /// <summary>
        /// eğer sadece numeric veya silme tuşu ise true döner.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool ControlNumeric(KeyPressEventArgs e)
        {
            return (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        #endregion

        #endregion
    }

    public static class Sira
    {
        private static Dictionary<string,KeyValuePair<DateTime,int>> sequenceDictionary = new Dictionary<string, KeyValuePair<DateTime, int>>();
      
        /// <summary>
        /// verilen poliklinik ismine göre son sırayı verir.
        /// </summary>
        /// <param name="polyclinic"></param>
        /// <returns></returns>
        public static int GetNumber(string polyclinic)
        {
            if (!sequenceDictionary.Keys.Contains(polyclinic))
            {
                sequenceDictionary.Add(polyclinic, new KeyValuePair<DateTime, int>(DateTime.Today, 0));
            }

            var date = sequenceDictionary[polyclinic].Key;
            var seq = sequenceDictionary[polyclinic].Value;
            if (date.Date != DateTime.Today.Date)
            {
                date = DateTime.Today;
                seq = 1;
            }

            if (seq <= 0)
            {
                seq = 1;
            }

            return seq;
        }

        /// <summary>
        /// sıra bilgisi kaydeder.
        /// </summary>
        /// <param name="polName"></param>
        /// <param name="date"></param>
        /// <param name="seq"></param>
        public static void SetSequenceData(string polName, DateTime date, int seq)
        {
            if (!sequenceDictionary.Keys.Contains(polName))
            {
                sequenceDictionary.Add(polName, new KeyValuePair<DateTime, int>(date,seq) );
            }
        }

    }

    /// <summary>
    /// dosya numarası işlemleri
    /// </summary>
    public static class Dosya
    { 
        public static int SonDosyaNumarası = 0;
    }


}
