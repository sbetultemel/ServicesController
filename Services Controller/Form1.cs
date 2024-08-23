using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using DevExpress.XtraEditors;
using System.IO;
using System.Diagnostics;

namespace Services_Controller
{
    
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private ToolTip toolTip = new ToolTip();
        private Dictionary<string, int> servicePids = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();

            AllServices();

            // DataGridView'in auto size columns mode özelliğini ayarlama
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // DataGridView kontrolüne MouseDown eventini bağlama
            dataGridView1.MouseDown += new MouseEventHandler(dataGridView1_MouseDown);

            // KeyDown eventini bağlama
            textEdit1.KeyDown += new KeyEventHandler(textEdit1_KeyDown);

            // Max.length ayarlandı
            textEdit1.Properties.MaxLength = 30;

            // Formun açıldığında ekranın ortasında olmasını sağla
            this.StartPosition = FormStartPosition.CenterScreen;

            // DataGridView satırları renklendirme için CellFormatting eventini bağlama
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);

            // DataGridView'in ColumnHeaderMouseClick eventini bağlama
            dataGridView1.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_ColumnHeaderMouseClick);

            // TextChanged eventini bağlama
            textEdit1.TextChanged += new EventHandler(textEdit1_TextChanged);

            // DataGridView'in MouseMove olayını bağlama
            dataGridView1.MouseMove += new MouseEventHandler(dataGridView1_MouseMove);

            textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
        }

        public int  AllServices()
        {
            int pid = 0;
            ServiceController[] serviceControllers = ServiceController.GetServices();

            // PID'leri saklayacağımız Dictionary'yi temizle
            servicePids.Clear();

            foreach (var service in serviceControllers)
            {
                Process[] processes = Process.GetProcessesByName(service.ServiceName);
                pid = processes.Any() ? processes[0].Id : -1;

                // PID bilgilerini sakla
                servicePids[service.ServiceName] = pid;
            }

            dataGridView1.DataSource = serviceControllers;
            return pid;
        }
        private void refreshList_Click(object sender, EventArgs e)
        {
            AllServices();
        }
        void deletedtextbox()
        {
            textEdit1.Text = null;
        }
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            // MouseMove olayında farenin hangi satırda olduğunu kontrol et
            var hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
            if (hitTestInfo.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[hitTestInfo.RowIndex];
                string serviceName = row.Cells["ServiceName"].Value.ToString();

                // PID'yi Dictionary'den al
                if (servicePids.TryGetValue(serviceName, out int pid))
                {
                    // ToolTip'e PID'yi ayarla
                    toolTip.SetToolTip(dataGridView1, $"PID: {pid}");
                }
            }
            else
            {
                // Eğer fare satır üzerinde değilse ToolTip'i temizle
                toolTip.SetToolTip(dataGridView1, string.Empty);
            }
        }
        private void queryService_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.SelectionBackColor;
                }

                ServiceController servicecontrol = new ServiceController(textEdit1.Text);

                bool serviceFound = false;

                // Tüm satırları kontrol et
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ServiceName"].Value.ToString().Equals(textEdit1.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(249, 64, 64);
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index; // Satıra kaydır
                        row.Selected = true; // Satırı seç
                        serviceFound = true;


                        break;
                    }
                }

                if (!serviceFound)
                {
                    XtraMessageBox.Show("YANLIŞ GİRİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    deletedtextbox();
                }
            }
            catch (InvalidOperationException)
            {
                XtraMessageBox.Show("Geçersiz hizmet adı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                deletedtextbox();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Arama kısmı boş", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                deletedtextbox();
            }

        }
        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            string filterText = textEdit1.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(filterText))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ServiceName", typeof(string));
                dt.Columns.Add("Status", typeof(string));

                // Mevcut tüm hizmetleri tekrar yükle
                ServiceController[] services = ServiceController.GetServices();
                // Mevcut hizmetlerden sadece girilen metinle eşleşenleri al
                foreach (var service in services)
                {
                    if (service.ServiceName.ToLower().Contains(filterText))
                    {
                        DataRow newRow = dt.NewRow();
                        newRow["ServiceName"] = service.ServiceName;
                        newRow["Status"] = service.Status.ToString();
                        dt.Rows.Add(newRow);
                    }
                }

                // DataGridView'in DataSource'unu yeni oluşturduğun filtrelenmiş tablo olarak ayarla
                dataGridView1.DataSource = dt;
            }
            else
            {
                // Eğer TextEdit boşsa, tüm hizmetleri tekrar göster
                AllServices();
            }
        }

        void ShowServiceNamesAndStatus()
        {
            ServiceController[] serviceControllers = ServiceController.GetServices();

            // DataTable oluştur
            DataTable dt = new DataTable();
            dt.Columns.Add("ServiceName", typeof(string));
            dt.Columns.Add("Status", typeof(string));

            // Servis bilgilerini DataTable'a ekle
            foreach (var service in serviceControllers)
            {
                DataRow row = dt.NewRow();
                row["ServiceName"] = service.ServiceName;
                row["Status"] = service.Status.ToString();
                dt.Rows.Add(row);
            }

            // DataGridView'in DataSource'unu yeni oluşturduğun tablo olarak ayarla
            dataGridView1.DataSource = dt;
        }



        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Kullanıcının "ServiceName" sütun başlığına tıklayıp tıklamadığını kontrol et
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ServiceName")
            {

                // Sadece ServiceName sütununu göstermek için yeni bir tablo oluştur
                DataTable dt = new DataTable();
                dt.Columns.Add("ServiceName", typeof(string));

                // Mevcut hizmetlerden sadece ServiceName alanını al
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ServiceName"].Value != null)
                    {
                        dt.Rows.Add(row.Cells["ServiceName"].Value.ToString());
                    }
                }

                // DataGridView'in DataSource'unu yeni oluşturduğun tablo olarak ayarla
                dataGridView1.DataSource = dt;
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status") // Status sütununu kontrol et
            {
                string status = e.Value?.ToString();
                if (status == "Running")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(202, 230, 185);
                }
                else if (status == "Stopped")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(155, 208, 123);
                }
            }
        }


        private void heuToolStripMenuItem_Click(object sender, EventArgs e)
        {//durdurkomutu
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string s = dataGridView1.SelectedRows[0].Cells["ServiceName"].Value.ToString();
                    ServiceController servicecontrl = new ServiceController(s);

                    if (servicecontrl.CanStop && servicecontrl.Status != ServiceControllerStatus.Stopped)
                    {
                        servicecontrl.Stop();
                        AllServices();
                    }
                    else
                    {
                        MessageBox.Show("Bu hizmet durdurulamaz veya zaten durdurulmuş durumda.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir servis seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Enter tuşuna basıldığında queryService_Click metodunu çağır
                queryService_Click(sender, e);
                e.SuppressKeyPress = true; // Enter tuşunun diğer varsayılan işlevlerini engelle
            }
        }
        private void baslatToolStripMenuItem_Click(object sender, EventArgs e)
        {// baslat komutu
            string s = dataGridView1.SelectedRows[0].Cells["ServiceName"].Value.ToString();
            ServiceController servicecontrl = new ServiceController(s);

            if (servicecontrl.Status != ServiceControllerStatus.Running)
            {
                servicecontrl.Start();
                AllServices();
            }
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            // Sağ tıklama tespit edildiğinde
            if (e.Button == MouseButtons.Right)
            {
                // Sağ tıklama yapılan konumdaki satırı belirle
                var hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    // Satırı seç
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hitTestInfo.RowIndex].Selected = true;

                    // ContextMenuStrip'i sağ tıklama konumunda göster
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                }
            }
        }

        private void listbutton_Click(object sender, EventArgs e)
        {

        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string serviceName = dataGridView1.SelectedRows[0].Cells["ServiceName"].Value.ToString();
                    ServiceController controller = new ServiceController(serviceName);

                    // İşlem nesnelerini al
                    Process[] processes = Process.GetProcessesByName(controller.ServiceName);


                    // İlk bulunan işlemi al (birden fazla işlem olabilir)
                    if (processes.Any())
                    {
                        Process process = processes[0]; // İlk bulunan işlem
                        int deneme = processes[0].Id;
                        process.Kill(); // İşlemi sonlandır

                        // DataGridView'deki durumu güncelle
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["ServiceName"].Value.ToString() == serviceName)
                            {
                                row.Cells["Status"].Value = "Killed";
                                break;
                            }
                        }

                        // Hizmetleri yeniden yükle
                        AllServices();
                    }
                    else
                    {
                        MessageBox.Show("Bu hizmete ait işlem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir servis seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void görevZamanlayıcıAyarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form2'yi Form1 örneği ile oluşturma
            Form2 form2 = new Form2(); // Mevcut Form1 örneğini geçiriyoruz

            string selectedServiceName = dataGridView1.SelectedRows[0].Cells["ServiceName"].Value.ToString();
            form2.pidsonuc(AllServices(), selectedServiceName);

            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }
    }
}