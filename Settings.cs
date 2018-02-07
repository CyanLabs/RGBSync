using System;
using System.Linq;
using System.Windows.Forms;
using RGB.NET.Core;
using RGB.NET.Devices.Corsair;
using RGB.NET.Devices.Logitech;
using RGB.NET.Devices.Asus;
using RGB.NET.Devices.CorsairLink;
using RGB.NET.Groups;
using RGB.NET.Devices.CoolerMaster;
using RGB.NET.Devices.Novation;
using RGB.NET.Devices.Msi;
using System.Diagnostics;
using System.Threading;

namespace RGBSync
{
    public partial class Settings : Form
    {
        private ILedGroup _ledGroup;
        private const LedId SYNC_LED = LedId.Mainboard1;

        public Settings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (chkShowNotification.Checked) notifyIcon1.ShowBalloonTip(5000, "RGBSync", "Click the notification icon to configure RGB Devices.", ToolTipIcon.Info);
            Process.Start("C:\\Program Files (x86)\\ASUS\\AURA\\AURA.exe");
            Thread.Sleep(1000);
            Process.GetProcessesByName("Aura")[0].Kill();

            tabCorsairLink.Enabled = false;
            try
            {

                RGBSurface.Instance.LoadDevices(AsusDeviceProvider.Instance, RGBDeviceType.Mainboard, throwExceptions: true);
                if (chkCorsairCue.Checked) { RGBSurface.Instance.LoadDevices(CorsairDeviceProvider.Instance, exclusiveAccessIfPossible: true, throwExceptions: true); }
                if (chkLogitech.Checked) { RGBSurface.Instance.LoadDevices(LogitechDeviceProvider.Instance, exclusiveAccessIfPossible: true, throwExceptions: true); }
                if (chkCM.Checked) { RGBSurface.Instance.LoadDevices(CoolerMasterDeviceProvider.Instance, exclusiveAccessIfPossible: true, throwExceptions: true); }
                if (chkNovation.Checked) { RGBSurface.Instance.LoadDevices(NovationDeviceProvider.Instance, exclusiveAccessIfPossible: true, throwExceptions: true); }
                if (chkCorsairLink.Checked) { RGBSurface.Instance.LoadDevices(CorsairLinkDeviceProvider.Instance, exclusiveAccessIfPossible: false, throwExceptions: true); }
                if (chkMSI.Checked) { RGBSurface.Instance.LoadDevices(MsiDeviceProvider.Instance, exclusiveAccessIfPossible: true, throwExceptions: true); }


                AsusMainboardRGBDevice mainboard = RGBSurface.Instance.GetDevices<AsusMainboardRGBDevice>().FirstOrDefault();
                if (mainboard == null)
                    throw new ApplicationException("No mainboard to sync with is loaded.");

                mainboard.UpdateMode = DeviceUpdateMode.SyncBack;

                _ledGroup = new ListLedGroup(RGBSurface.Instance.Leds).Exclude(mainboard.ToArray());
                _ledGroup.Brush = new SyncBrush(((IRGBDevice)mainboard)[SYNC_LED]);

                RGBSurface.Instance.UpdateFrequency = 1 / 60.0;
                RGBSurface.Instance.UpdateMode = UpdateMode.Continuous;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Opacity = 100;
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.Focus();
            this.BringToFront();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        bool allowClosing = false;

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!allowClosing)
                {
                    notifyIcon1.ShowBalloonTip(3000);
                    this.Hide();
                    e.Cancel = true;
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowClosing = true;
            Application.Exit();
        }

        private void settiingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 100;
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.Focus();
            this.BringToFront();
        }
    }
}
