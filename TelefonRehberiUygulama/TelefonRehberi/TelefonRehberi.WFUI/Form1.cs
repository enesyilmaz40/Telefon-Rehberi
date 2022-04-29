using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi.WFUI
{

    public partial class Form1 : Form
    {
        TelefonRehberi.BLL.BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new TelefonRehberi.BLL.BusinessLogicLayer();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
           int sonuc = BLL.KullaniciKontrol(txt_kullaniciadi.Text,txt_sifre.Text);

            if (sonuc > 0)
            {
                txt_web_site form = new txt_web_site();
                form.Show();
            }
            else if(sonuc ==-100)
            {
                MessageBox.Show("Form alanlarını eksiksiz olarak doldurunuz");
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı");
            }
        }
    }
}
