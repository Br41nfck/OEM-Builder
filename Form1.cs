using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace oembuild
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadRegistrySettings();
            pc_name_tb.Text = Environment.MachineName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(logo_tb.Text))
            {
                LoadImageByLocation(logo_pb, logo_tb.Text);
            }

            if (!string.IsNullOrEmpty(wallpaper_tb.Text))
            {
                LoadImageByLocation(wallpaper_pb, wallpaper_tb.Text);
            }
        }

        private void LoadImageByLocation(PictureBox pb, string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pb.ImageLocation = imagePath;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pb.ImageLocation = null;
                    pb.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Error");
                pb.ImageLocation = null;
                pb.Image = null;
            }
        }


        private void LoadImageFromFile(PictureBox pb, string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    if (pb.Image != null)
                    {
                        pb.Image.Dispose();
                        pb.Image = null;
                    }

                    pb.Image = Image.FromFile(imagePath);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    if (pb.Image != null)
                    {
                        pb.Image.Dispose();
                        pb.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Error");
                if (pb.Image != null)
                {
                    pb.Image.Dispose();
                    pb.Image = null;
                }
            }
        }

        private void LoadRegistrySettings()
        {
            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation"))
                    {
                        if (key != null)
                        {
                            ReadRegistryValues(key);
                            return;
                        }
                    }
                }
            }
            catch { }

            try
            {
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation"))
                    {
                        if (key != null)
                        {
                            ReadRegistryValues(key);
                            return;
                        }
                    }
                }
            }
            catch { }

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation"))
            {
                if (key != null)
                {
                    ReadRegistryValues(key);
                }
                else
                {
                    MessageBox.Show("Cannot read REGISTRY SETTINGS!", "Error");
                }
            }
        }

        private void ReadRegistryValues(RegistryKey key)
        {
            company_name_tb.Text = key.GetValue("Manufacturer")?.ToString() ?? "Not found!";
            model_name_tb.Text = key.GetValue("Model")?.ToString() ?? "Not found!";
            suphours_tb.Text = key.GetValue("SupportHours")?.ToString() ?? "Not found!";
            supphone_tb.Text = key.GetValue("SupportPhone")?.ToString() ?? "Not found!";
            supurl_tb.Text = key.GetValue("SupportURL")?.ToString() ?? "Not found!";
            logo_tb.Text = key.GetValue("Logo")?.ToString() ?? "Not found!";
        }

        private void Apply_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateSettings()) return;

            SetWallpaper(wallpaper_tb.Text);

            try
            {
                bool success = false;
                string errorMessages = "";

                try
                {
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                    {
                        using (RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", true))
                        {
                            if (key != null)
                            {
                                WriteRegistryValues(key);
                                success = true;
                            }
                            else
                            {
                                using (RegistryKey newKey = baseKey.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation"))
                                {
                                    WriteRegistryValues(newKey);
                                    success = true;
                                }
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    errorMessages += $"64-bit: {ex.Message}\n";
                }

                try
                {
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                    {
                        using (RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", true))
                        {
                            if (key != null)
                            {
                                WriteRegistryValues(key);
                                success = true;
                            }
                            else
                            {
                                using (RegistryKey newKey = baseKey.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation"))
                                {
                                    WriteRegistryValues(newKey);
                                    success = true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    errorMessages += $"32-bit: {ex.Message}\n";
                }

                try
                {
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation", true))
                    {
                        if (key != null)
                        {
                            WriteRegistryValues(key);
                            success = true;
                        }
                        else
                        {
                            using (RegistryKey newKey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation"))
                            {
                                WriteRegistryValues(newKey);
                                success = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    errorMessages += $"Default: {ex.Message}\n";
                }

                if (!success)
                {
                    MessageBox.Show($"Failed to write to registry!\n\nErrors:\n{errorMessages}", "Error");
                    return;
                }

                string currentName = Environment.MachineName;
                if (!string.IsNullOrEmpty(pc_name_tb.Text) && pc_name_tb.Text != currentName)
                {
                    ChangeComputerName(pc_name_tb.Text);
                }

                if (reb_pc_cb.Checked)
                {
                    DialogResult result = MessageBox.Show("The computer will restart in 5 seconds. Continue?",
                        "Restart Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Process.Start("shutdown.exe", "/r /t 5 /c \"System settings have been updated. Please save your work.\"");
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied! Please run the application as Admin.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying registry settings: {ex.Message}", "Error");
            }
        }

        private void WriteRegistryValues(RegistryKey key)
        {
            key.SetValue("Manufacturer", company_name_tb.Text, RegistryValueKind.String);
            key.SetValue("Model", model_name_tb.Text, RegistryValueKind.String);
            key.SetValue("SupportHours", suphours_tb.Text, RegistryValueKind.String);
            key.SetValue("SupportPhone", supphone_tb.Text, RegistryValueKind.String);
            key.SetValue("SupportURL", supurl_tb.Text, RegistryValueKind.String);
            key.SetValue("Logo", logo_tb.Text, RegistryValueKind.String);
        }

        private bool ValidateSettings()
        {
            if (string.IsNullOrWhiteSpace(company_name_tb.Text))
            {
                MessageBox.Show("Company name cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                company_name_tb.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(logo_tb.Text) && !File.Exists(logo_tb.Text))
            {
                DialogResult result = MessageBox.Show($"Logo file not found at:\n{logo_tb.Text}\n\nContinue without logo?", "File Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    logo_tb.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ChangeComputerName(string newName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(newName))
                {
                    MessageBox.Show("Computer name cannot be empty!", "Warning");
                    return;
                }

                if (newName.Length > 15)
                {
                    MessageBox.Show("Computer name cannot more than 15 characters!", "Warning");
                    return;
                }

                using (ManagementClass mc = new ManagementClass("Win32_ComputerSystem"))
                {
                    using (ManagementObjectCollection moc = mc.GetInstances())
                    {
                        foreach (ManagementObject mo in moc.Cast<ManagementObject>())
                        {
                            object[] args = { newName, null, null };
                            object result = mo.InvokeMethod("Rename", args);

                            int returnValue = Convert.ToInt32(result);
                            if (returnValue == 0)
                            {
                                MessageBox.Show($"Computer name will be changed to '{newName}' after reboot.", "Rename PC");
                            }
                            else
                            {
                                MessageBox.Show($"Failed to rename computer. Error code: {returnValue}", "Error");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing computer name: {ex.Message}", "Error");
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);
        private const uint SPI_SETDESKTOPWALLPAPER = 0x14;
        private const uint SPIF_UPDATEINIFILE = 0x01;
        private const uint SPIF_SENDWININICHANGE = 0x02;

        public static void SetWallpaper(string path)
        {
            SystemParametersInfo(SPI_SETDESKTOPWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Save_cfg_btn_Click(object sender, EventArgs e)
        {
            string filepath = "settings.cfg";
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.WriteLine($"CompanyName={company_name_tb.Text}");
                writer.WriteLine($"Model={model_name_tb.Text}");
                writer.WriteLine($"SupportHours={suphours_tb.Text}");
                writer.WriteLine($"SupportPhone={supphone_tb.Text}");
                writer.WriteLine($"SupportURL={supurl_tb.Text}");
                writer.WriteLine($"Logo={logo_tb.Text}");
                writer.WriteLine($"PCName={pc_name_tb.Text}");
                writer.WriteLine($"Wallpaper={wallpaper_tb.Text}");
            }
        }

        private void Load_cfg_btn_Click_1(object sender, EventArgs e)
        {
            string filepath = "settings.cfg";
            if (File.Exists(filepath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filepath);
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line) || !line.Contains("="))
                            continue;

                        string[] parts = line.Split('=');
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();

                        switch (key)
                        {
                            case "CompanyName":
                                company_name_tb.Text = value;
                                break;
                            case "Model":
                                model_name_tb.Text = value;
                                break;
                            case "SupportHours":
                                suphours_tb.Text = value;
                                break;
                            case "SupportPhone":
                                supphone_tb.Text = value;
                                break;
                            case "SupportURL":
                                supurl_tb.Text = value;
                                break;
                            case "Logo":
                                logo_tb.Text = value;
                                LoadImageByLocation(logo_pb, value);
                                break;
                            case "PCName":
                                pc_name_tb.Text = value;
                                break;
                            case "Wallpaper":
                                wallpaper_pb.Text = value;
                                LoadImageByLocation(wallpaper_pb, value);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading settings: {ex.Message}", "Error");
                }
            }
            else
            {
                MessageBox.Show("Settings file not found!", "Warning");
            }
        }
      
        private void Fd_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "Bitmap Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    logo_tb.Text = filePath;
                    LoadImageByLocation(logo_pb, filePath);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "Изображения (*.jpg;*.jpeg;*.png;*.bmp;*.dib;*.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.dib;*.webp|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    wallpaper_tb.Text = filePath;
                    LoadImageByLocation(wallpaper_pb, filePath);
                }
            }
        }

        private void Show_info_btn_Click(object sender, EventArgs e)
        {
            string info = $"OS: {Environment.OSVersion}\n" +
                  $"Architecture: {(Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit")}\n" +
                  $"Process: {(Environment.Is64BitProcess ? "64-bit" : "32-bit")}\n" +
                  $"Current Registry Access: {(Environment.Is64BitProcess ? "Native" : "WOW6432Node")}";

            MessageBox.Show(info, "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            try
            {
                pc_name_tb.Text = "";
                company_name_tb.Text = "";
                model_name_tb.Text = "";
                suphours_tb.Text = "";
                supphone_tb.Text = "";
                supurl_tb.Text = "";
                logo_tb.Text = "";
                wallpaper_tb.Text = "";

                LoadImageByLocation(logo_pb, null);
                LoadImageByLocation(wallpaper_pb, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing settings: {ex.Message}", "Error");
            }
        }
    }
}