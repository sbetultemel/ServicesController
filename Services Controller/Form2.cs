using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Services_Controller
{
    public partial class Form2 : Form
    {
        public int saniye;
        public int dakika;

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Her Tick olayında saniye sayacını bir azaltıyoruz
            if (saniye !=0)
                saniye--;

            // Timer'ın kaldığı süreyi gösteriyoruz (dakika ve saniye formatında)
            int dakikaGosterim = saniye / 60;
            int saniyeGosterim = saniye % 60;

            txttime.Text = $"{dakikaGosterim:D2}:{saniyeGosterim:D2}";

            // Eğer saniye sıfır olduğunda timer'ı durduruyoruz ve yapılacak işlemleri çağırıyoruz
            if (saniye <= 0)
            {
                timer1.Stop();

                // Sayaç sıfırlandığında yapılacak işlemler
                ServiceController servicecontrl = new ServiceController(txtServiceName.Text);

                if (comboBoxEdit1.SelectedText.ToString().ToLower() == "durdur")
                {
                    if (servicecontrl.CanStop && servicecontrl.Status != ServiceControllerStatus.Stopped)
                    {
                        servicecontrl.Stop();
                        servicecontrl.Refresh(); // Status değerini güncelle

                        if (servicecontrl.Status == ServiceControllerStatus.Stopped)
                        {
                            MessageBox.Show("Hizmet başarıyla durduruldu. Durum: Stopped", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(" Mevcut Durum: " + servicecontrl.Status.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu hizmet durdurulamaz veya zaten durdurulmuş durumda.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (comboBoxEdit1.SelectedText.ToString().ToLower() == "başlat")
                {
                    if (servicecontrl.Status == ServiceControllerStatus.Stopped)
                    {
                        servicecontrl.Start();
                        servicecontrl.Refresh(); // Status değerini güncelle

                        if (servicecontrl.Status == ServiceControllerStatus.Running)
                        {
                            MessageBox.Show("Hizmet başarıyla başlatıldı. Durum: Running", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(" Mevcut Durum: " + servicecontrl.Status.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu hizmet başlatılamaz veya zaten çalışır durumda.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (comboBoxEdit1.SelectedText.ToString().ToLower() == "kill")
                {

                    string serviceName = txtServiceName.Text.ToString();
                    ServiceController controller = new ServiceController(serviceName);

                    // İşlem nesnelerini al
                    Process[] processes = Process.GetProcessesByName(controller.ServiceName);


                    // İlk bulunan işlemi al (birden fazla işlem olabilir)
                    if (processes.Any())
                    {
                        Process process = processes[0]; // İlk bulunan işlem
                        process.Kill(); // İşlemi sonlandır
                    }
                }
            }
        }

        private void Missioncomp_Click(object sender, EventArgs e)
        {
            
            // Dakika değerini saniyeye çeviriyoruz
            dakika = Convert.ToInt32(txttime.Text);
            saniye = dakika * 60;

            // Timer'ı başlatıyoruz
            timer1.Interval = 1000; // 1 saniye

            // MessageBox gösteriliyor ve sonucu kontrol ediliyor
            DialogResult result = MessageBox.Show($"{txttime.Text} dakika olarak ayarlandı, onaylıyor musunuz?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                // Eğer "Tamam" butonuna basılırsa timer başlatılıyor
                timer1.Start();
                
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        public void pidsonuc(int pID, string serviceName)
        {
            pid.Text = pID.ToString();
            txtServiceName.Text = serviceName;
        }
    }
}