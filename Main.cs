using ScannerApp.Code;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace ScannerApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await LoadDevices();
            textBoxSaveFolder.Text = Properties.Settings.Default.LocationPath;
            comboBoxPaperSize.SelectedIndex = 0;

            if (Properties.Settings.Default.LocationPath == string.Empty)
            {
                MessageBox.Show("Сначала выберите путь сохранения отсканированных файлов! ",
                "Сохранить путь", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                SelectFolderPath();
            }

        }

        private async void linkLabelLoadDvices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await LoadDevices();
        }

        private async Task LoadDevices()
        {
            // Load Devices
            pictureBoxLoading.Visible = true;
            comboBoxDevices.DataSource = await ScannerHelper.GetDevices();
            pictureBoxLoading.Visible = false;
        }

        private void linkLabelOpenSaveFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Properties.Settings.Default.LocationPath,
                UseShellExecute = true // Gives permissions to .NET applications.
            };
            Process.Start(psi);
        }

        private void linkLabelChangeSaveFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectFolderPath();
        }

        private void SelectFolderPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.UseDescriptionForTitle = true;
            dialog.Description = "Выберите папку для сохранения";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.LocationPath = dialog.SelectedPath;
                Properties.Settings.Default.Save();
                textBoxSaveFolder.Text = Properties.Settings.Default.LocationPath;
            }
        }

        private async void buttonScan_Click(object sender, EventArgs e)
        {
            // Check Devices
            if (comboBoxDevices.Items.Count == 0)
            {
                MessageBox.Show("Выберите устройство для сканирования в первую очередь! ",
                "Выбора устройства", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                string deviceName = comboBoxDevices.SelectedItem.ToString();
                int dpi = Convert.ToInt32(comboBoxDPI.Text);
                string paperSize = comboBoxPaperSize.SelectedItem.ToString();

                // Set Color Mode
                int color = 0;
                if (radioButtonColor.Checked)
                {
                    color = 1;
                }
                if (radioButtonColor.Checked)
                {
                    color = 2;
                }

                pictureBoxLoading.Show();
                // Scanning : Start

                for (int i = 1; i <= numericUpDownScannerPapperCont.Value; i++)
                {
                    pictureBoxShow.Image = Properties.Resources.Scanner_doc_gif;

                    var scanedImage = pictureBoxShow.Image = await ScannerHelper.ScanAsImageAsync(deviceName, dpi,
                        paperSize, color);
                    if(scanedImage != null)
                    {
                        pictureBoxShow.Image = scanedImage;
                        SaveImage(scanedImage, textBoxSaveFolder.Text);
                    }

                    await Task.Delay(1000);
                }

                numericUpDownScannerPapperCont.Value = 1;

                // End
                pictureBoxLoading.Hide();
            }
        }

        private void SaveImage(Image image, string path)
        {
            try
            {
                string fileName = Path.Combine(path, $"{Guid.NewGuid()}.jpg");
                using (var Imagefile = new Bitmap(image))
                {
                    Imagefile.Save(fileName, ImageFormat.Jpeg);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.Description = "Выберите папку для сохранения изображения.";
            var result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                SaveImage(pictureBoxShow.Image,dialog.SelectedPath);
                MessageBox.Show("Изображение успешно сохранено.");
            }
        }
    }
}
