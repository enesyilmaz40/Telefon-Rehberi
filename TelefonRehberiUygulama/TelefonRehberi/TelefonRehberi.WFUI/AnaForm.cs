using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonRehberi.Entities;

namespace TelefonRehberi.WFUI
{
    public partial class txt_web_site : Form
    {
        TelefonRehberi.BLL.BusinessLogicLayer BLL;
        public txt_web_site()
        {
            InitializeComponent();
            BLL = new TelefonRehberi.BLL.BusinessLogicLayer();
        }

        private void btn_yeni_kayit_Click(object sender, EventArgs e)
        {
         int Sonuc=   BLL.YeniKayit(Guid.NewGuid(),txt_isim.Text,txt_soyisim.Text,txt_telefonI.Text,txt_telefonII.Text,txt_telefonIII.Text,txt_adres.Text,txt_email_adres.Text,txt_webSite.Text,txt_aciklama.Text);

            if (Sonuc >= 0)
            {
                MessageBox.Show("Kaydınız Başarılı Bir Şekilde Eklendi.");
                Doldur();
            }
            else if(Sonuc == -100)
            {
                MessageBox.Show("Eksik Parametre hatası. Lütfen Isim Soyisim TelefonI alanlarını doldurunuz.");
            }
            else
            {
                MessageBox.Show("Kayıt Ekleme İşleminde Hata Oluştu");
            }


        }
        private void Doldur()
        {
            List<RehberKayit> RehberKayilarim = BLL.RehberKayitGetir();
            if(RehberKayilarim != null && RehberKayilarim.Count > 0)
            {
                lst_liste.DataSource = RehberKayilarim;
            }
        }
        private void txt_web_site_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void lst_liste_DoubleClick(object sender, EventArgs e)
        {
            ListBox L = (ListBox)sender;
            RehberKayit SecilenDeger = (RehberKayit)L.SelectedItem;
            txt_isim.Text = SecilenDeger.Isim;
            txt_soyisim.Text= SecilenDeger.Soyisim;
            txt_telefonI.Text=SecilenDeger.TelefonI;
            txt_telefonII.Text = SecilenDeger.TelefonII;
            txt_telefonIII.Text = SecilenDeger.TelefonIII;
            txt_email_adres.Text = SecilenDeger.EmailAdres;
            txt_webSite.Text = SecilenDeger.Website;
            txt_adres.Text = SecilenDeger.Adres;
            txt_aciklama.Text=SecilenDeger.Aciklama;
            grpbox_kayit.Text = "Rehber Kayıt Güncelle";
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (lst_liste.SelectedItem != null)
            {

                //((RehberKayit)lst_liste.SelectedItem).ID Kısa olarak Kullanımı
                RehberKayit K = (RehberKayit)lst_liste.SelectedItem;
               int sonuc= BLL.KayitGuncelle(K.ID, txt_isim.Text, txt_soyisim.Text, txt_telefonI.Text, txt_telefonII.Text, txt_telefonIII.Text, txt_adres.Text, txt_email_adres.Text, txt_webSite.Text, txt_aciklama.Text);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kaydınız Başarılı Bir Şekilde Güncellendi");
                    Doldur();
                }
                else if (sonuc == -100)
                {
                    MessageBox.Show("Eksik Parametre Hatası");
                }
                else
                {
                    MessageBox.Show("Kayıt Ekleme İşleminde Hata Oluştu");
                }
                
                
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
          Guid SilinecekID =((RehberKayit)lst_liste.SelectedItem).ID;
            int Sonuc = BLL.KayitSil(SilinecekID);
            if (Sonuc > 0)
            {
                MessageBox.Show("Silme İşleminiz Başarılı Bir Şekilde Gerçekleşti");
                Doldur();
            }
            else
            {
                MessageBox.Show("Kayıt Silme İşleminde Hata Oluştu");
            }
        }

        private void btn_xml_ver_Click(object sender, EventArgs e)
        {
            int sonuc=BLL.XMLDataVer();
            if (sonuc > 0)
            {
                lbl_data_alver_durum.Text = "Durum: XML Data Verme İşlemi Tamamlandı";
            }
            else
            {
                lbl_data_alver_durum.Text = "Durum: Hata Oluştu";
            }
        }

        private void btn_csv_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.CSVDataVer();
            if (sonuc > 0)
            {
                lbl_data_alver_durum.Text = "Durum: CSV Data Verme İşlemi Tamamlandı";
            }
            else
            {
                lbl_data_alver_durum.Text = "Durum: Hata Oluştu";
            }

        }

        private void btn_json_ver_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.JsonDataVer();
            if (sonuc > 0)
            {
                lbl_data_alver_durum.Text = "Durum: JSON Data Verme İşlemi Tamamlandı";
            }
            else
            {
                lbl_data_alver_durum.Text = "Durum: Hata Oluştu";
            }
        }

       
    }
}
