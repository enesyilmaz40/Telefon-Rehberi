using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities;
namespace TelefonRehberi.Core
{
    public class DataBaseLogicLayer
    {
        List<RehberKayit> Kayitlarim;
        public DataBaseLogicLayer()
        {
            Kayitlarim = new List<RehberKayit>();
            VeriTabaniKontrol();
        }

        private void VeriTabaniKontrol()
        {
            bool KlasörKontrol = Directory.Exists(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\");
            if (!KlasörKontrol)
            {
                Directory.CreateDirectory(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\");

                Kullanici Demo = new Kullanici();
                Demo.ID = Guid.NewGuid();
                Demo.KullaniciAdi = "Demo";
                Demo.Sifre = "Demo";
                string JsonKullaniciText = Newtonsoft.Json.JsonConvert.SerializeObject(Demo);
                File.WriteAllText(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\kullanici.json",JsonKullaniciText);

            }

        }
        public int YeniKayit(RehberKayit K)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir(); //class seviyesinde oluşturmuş olduğum koleksiyonum içerisine datamı doldurdum (varsa ) yoksa zaten bellekte hiçbir değeri yoktu o şekilde yeni değer eklenmek üzere bekliyor..
                Kayitlarim.Add(K);//koleksiyonumuza değerimizi ekledik..
                JsonDBGuncelle(); //varsa override etti , yoksa yeni json oluşturdu
            }
            catch (Exception ex)
            {

                //Log 
                sonuc = 0;
            }
            return sonuc;
        }
        public int KayitGuncelle(RehberKayit K)
        {
            int sonuc=0;
            try
            {
                RehberKayitlariGetir();
                int Index =Kayitlarim.FindIndex(i=>i.ID==K.ID);
                if(Index > -1)
                {
                    Kayitlarim[Index].Isim=K.Isim;
                    Kayitlarim[Index].Soyisim = K.Soyisim;
                    Kayitlarim[Index].TelefonI = K.TelefonI;
                    Kayitlarim[Index].TelefonII = K.TelefonII;
                    Kayitlarim[Index].TelefonIII = K.TelefonIII;
                    Kayitlarim[Index].EmailAdres = K.EmailAdres;
                    Kayitlarim[Index].Website = K.Website;
                    Kayitlarim[Index].Adres = K.Adres;
                    Kayitlarim[Index].Aciklama = K.Aciklama;
                   

                }
                JsonDBGuncelle();
                sonuc = 1;
            }
            catch (Exception ex)
            {

                
            }
            return sonuc;
        }

        public int KayitSil(Guid ID)
        {
            int sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                RehberKayit SilinecekDeger =Kayitlarim.Find(i => i.ID ==ID);
                if (SilinecekDeger != null)
                {
                    Kayitlarim.Remove(SilinecekDeger);
                }
                JsonDBGuncelle();
                sonuc = 1;
            }
            catch ( Exception ex)
            {

                
            }
            return sonuc;
        }

        public List<RehberKayit> RehberKayitlariGetir()
        {
            //XML e çevirmek için burada çalışmıyorum zaten burada verimizi oluşturduk. BLL kısmında çalışıyorum
            if (File.Exists(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\Rehber.json"))
            {
                string JsonDBText = File.ReadAllText(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\Rehber.json");
                Kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RehberKayit>>(JsonDBText);
            }
            return Kayitlarim;
        }
        public int KullaniciKontrol(Kullanici kullanici)
        {
            int KullaniciSonuc = 0;
            if (File.Exists(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\kullanici.json"))
            {

                string JsonKullaniciText = File.ReadAllText(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\kullanici.json");
                List<Kullanici> Kullanicilar = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(JsonKullaniciText);
                KullaniciSonuc = Kullanicilar.FindAll(i => i.KullaniciAdi == kullanici.KullaniciAdi && i.Sifre == kullanici.Sifre).ToList().Count();
            }
            return KullaniciSonuc;
        }

     

        private void JsonDBGuncelle()
        {
            if (Kayitlarim != null && Kayitlarim.Count > 0)
            {
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlarim);
                File.WriteAllText(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\Rehber.json", JsonDB);
            }
        }



     






    }
}
