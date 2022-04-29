using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TelefonRehberi.Entities;

namespace TelefonRehberi.BLL
{
    public class BusinessLogicLayer
    {
        TelefonRehberi.Core.DataBaseLogicLayer DLL;
        public BusinessLogicLayer()
        {
            DLL = new Core.DataBaseLogicLayer();

        }
        public int KullaniciKontrol(string KullaniciAdi, string Sifre)
        {
            int sonuc = 0;
            if (!string.IsNullOrEmpty(KullaniciAdi) && !string.IsNullOrEmpty(Sifre))
            {
                Kullanici kullanici = new Kullanici();
                kullanici.KullaniciAdi = KullaniciAdi;
                kullanici.Sifre = Sifre;
                sonuc = DLL.KullaniciKontrol(kullanici);
            }
            else
            {
                sonuc = -100; //Eksik Parametre Hatası
            }
            return sonuc;
        }
        public int YeniKayit(Guid ID, string Isim, string Soyisim, string TelefonI, string TelefonII, string TelefonIII, string Adres, string EmailAdres, string Website, string Aciklama)
        {
            int sonuc = 0;
            if (ID != null && !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim) && !string.IsNullOrEmpty(TelefonI))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.ID = ID;
                Kayit.Isim = Isim;
                Kayit.Soyisim = Soyisim;
                Kayit.TelefonI = TelefonI;
                Kayit.TelefonII = TelefonII;
                Kayit.TelefonIII = TelefonIII;
                Kayit.Adres = Adres;
                Kayit.EmailAdres = EmailAdres;
                Kayit.Website = Website;
                Kayit.Aciklama = Aciklama;

                sonuc = DLL.YeniKayit(Kayit);//dll içerisindeki yenikayit metodunu kullanarak kayıt ettik 

            }
            else
            {
                sonuc = -100;// Eksik parametre hatası
            }
            return sonuc;
        }
        public int KayitGuncelle(Guid ID, string Isim, string Soyisim, string TelefonI, string TelefonII, string TelefonIII, string Adres, string EmailAdres, string Website, string Aciklama)
        {
            int sonuc = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim) && !string.IsNullOrEmpty(TelefonI))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.ID = ID;
                Kayit.Isim = Isim;
                Kayit.Soyisim = Soyisim;
                Kayit.TelefonI = TelefonI;
                Kayit.TelefonII = TelefonII;
                Kayit.TelefonIII = TelefonIII;
                Kayit.Adres = Adres;
                Kayit.EmailAdres = EmailAdres;
                Kayit.Website = Website;
                Kayit.Aciklama = Aciklama;

                sonuc = DLL.KayitGuncelle(Kayit);//dll içerisindeki yenikayit metodunu kullanarak kayıt ettik 
            }
            else
            {
                sonuc = -100;//eksik parametre hatası
            }



            return sonuc;
        }
        public int KayitSil(Guid ID)
        {
            return DLL.KayitSil(ID);
        }


        public List<RehberKayit> RehberKayitGetir()
        {
            return DLL.RehberKayitlariGetir();//İstersem burada işlem yapabilirdim 
        }
        public int XMLDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();
                XDocument Doc = new XDocument(new XDeclaration("1.0", "UTF-8", "yes"), new XElement("RehberKayitlar", Kayitlarim.Select(i => new XElement("Kayit", ("ID", i.ID), new XElement("Isim", i.Isim), new XElement("Soyisim", i.Soyisim), new XElement("TelefonI", i.TelefonI), new XElement("TelefonII", i.TelefonII), new XElement("TelefonIII", i.TelefonIII), new XElement("EmailAdres", i.EmailAdres), new XElement("Adres", i.Adres), new XElement("WebSite", i.Website), new XElement("Aciklama", i.Aciklama)))));
                Doc.Save(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\DataVerXML.xml");
                sonuc = 1;

            }
            catch (Exception ex)
            {
                sonuc = 0;

            }
            return sonuc;
        }
        public int CSVDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();
                StreamWriter SW = new StreamWriter(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\DataVerCSV.csv");
                CsvHelper.CsvWriter Write = new CsvHelper.CsvWriter(SW);
                foreach (var item in Kayitlarim)
                {
                    Write.WriteRecord(item);
                }
                SW.Close();
                sonuc = 1;


            }
            catch (Exception ex)
            {
                sonuc = 0;

            }
            return sonuc;
        }
        public int JsonDataVer()
        {
            int sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlar = DLL.RehberKayitlariGetir();
                string JsonText = Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlar);
                File.WriteAllText(@"C:\Users\enes_\OneDrive\Masaüstü\C#\TelefonRehberiUygulama\TelefonRehberiDB\DataVerJSON.json", JsonText);
                sonuc = 1;
            }
            catch (Exception ex)
            {


            }
            return sonuc;
        }


    }
}

