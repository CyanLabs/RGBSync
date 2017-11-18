using System;
using System.Linq;
using System.Windows.Forms;
using RGB.NET.Core;
using RGB.NET.Devices.Corsair;
using RGB.NET.Devices.Logitech;
using RGB.NET.Devices.Asus;
using RGB.NET.Devices.CorsairLink;
using RGB.NET.Devices.Philips;
using RGB.NET.Groups;
using RGB.NET.Brushes;
using RGB.NET.Devices.CoolerMaster;
using RGB.NET.Devices.Novation;
using RGB.NET.Devices.Msi;
using System.Diagnostics;
using System.Threading;

namespace RGBSync
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Process.Start("C:\\Program Files (x86)\\ASUS\\AURA\\AURA.exe");
            Thread.Sleep(1000);
           Process.GetProcessesByName("Aura")[0].Kill();

            tabCorsairLink.Enabled = false;
            tabPhilips.Enabled = false;
            try
            {
                
                RGBSurface surface = RGBSurface.Instance;
                //surface.Exception += args => Dispatcher.Invoke(() => Log.AppendText(GetExceptionString(args.Exception) + "\r\n"));

                if (chkAura.Checked) {surface.LoadDevices(AsusDeviceProvider.Instance);}
                if (chkCorsairCue.Checked) { surface.LoadDevices(CorsairDeviceProvider.Instance);}
                if (chkLogitech.Checked) { surface.LoadDevices(LogitechDeviceProvider.Instance); }
                if (chkCM.Checked) { surface.LoadDevices(CoolerMasterDeviceProvider.Instance); }
                if (chkNovation.Checked) { surface.LoadDevices(NovationDeviceProvider.Instance); }
                if (chkPhilips.Checked) { surface.LoadDevices(new PhilipsDeviceProvider(TxtPhilipsIP.Text)); }
                if (chkCorsairLink.Checked) { surface.LoadDevices(CorsairLinkDeviceProvider.Instance); }
                if (chkMSI.Checked) { surface.LoadDevices(MsiDeviceProvider.Instance); }
                surface.AlignDevies();

                AsusMainboardRGBDevice syncDevice = surface.Devices.FirstOrDefault(x => x is AsusMainboardRGBDevice) as AsusMainboardRGBDevice;
                if (syncDevice != null)
                {
                    // this will be easier if the syncback stuff is done;
                    ListLedGroup background = new ListLedGroup(surface.Leds);
                    background.Exclude(syncDevice.ToArray());
                    background.Brush = new SolidColorBrush(new RGB.NET.Core.Color(0, 0, 0)); ;

                    SyncAuraBrush syncAuraBrush = new SyncAuraBrush(syncDevice);
                    ListLedGroup syncGroup = new ListLedGroup(surface.Leds);
                    syncGroup.Exclude(syncDevice.ToArray());
                    syncGroup.Brush = syncAuraBrush;
                }

                surface.UpdateFrequency = 1 / 30.0;
                surface.UpdateMode = UpdateMode.Continuous;
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

        private void chkPhilips_CheckedChanged(object sender, EventArgs e)
        {
            tabPhilips.Enabled = (chkPhilips.CheckState == CheckState.Checked);
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
