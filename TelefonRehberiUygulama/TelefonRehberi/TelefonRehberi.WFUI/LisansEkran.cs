using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi.WFUI
{
    public partial class LisansEkran : Form
    {
        public LisansEkran()
        {
            InitializeComponent();
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            if (txt_lisanskey.Text == "39b9b38d-c17a-4d02-bff7-d7396d74503e")
            {
                string HarddiskSeriNumarasi = string.Empty;
                string MacAddress = string.Empty;

                string surucu = "C";
                ManagementObject Disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + surucu + ":\"");
                Disk.Get();

                HarddiskSeriNumarasi = Disk["VolumeSerialNumber"].ToString();
                ManagementClass MACADD = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection NAL = MACADD.GetInstances();
                foreach (ManagementObject item in NAL)
                {
                    if ((bool)item["IPEnabled"])
                    {
                        MacAddress = item["MacAddress"].ToString();
                    }
                }
                if (!string.IsNullOrEmpty(HarddiskSeriNumarasi) && !string.IsNullOrEmpty(MacAddress))
                {
                    RegistryKey Key = Registry.CurrentUser.CreateSubKey("TelefonRehberi", true);
                    Key.SetValue("HardDiskSeriNumarasi", HarddiskSeriNumarasi);
                    Key.SetValue("MACAddress", MacAddress);

                    MessageBox.Show("Lisanslama işleminiz tamamlanmıştır.Lütfen Uygulamayı Kapatıp Açınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz lisans numarası hatalıdır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
