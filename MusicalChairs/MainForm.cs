using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MusicalChairs
{
    public partial class MainForm : Form
    {
        private Random _RNG;
        private Timer _Timer;

        public MainForm()
        {
            InitializeComponent();

            int minDuration = (Registry.GetValue("HKEY_CURRENT_USER\\Software\\MusicalChairs", "MinDuration", null) as int?) ?? 5;
            int maxDuration = (Registry.GetValue("HKEY_CURRENT_USER\\Software\\MusicalChairs", "MaxDuration", null) as int?) ?? 60;

            textBoxMinDuration.Text = minDuration.ToString();
            textBoxMaxDuration.Text = maxDuration.ToString();

            _RNG = new Random();
            _Timer = new Timer();
            _Timer.Tick += Timer_Tick;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (int.TryParse(textBoxMinDuration.Text, out int minDuration))
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\MusicalChairs", "MinDuration", minDuration);

            if (int.TryParse(textBoxMaxDuration.Text, out int maxDuration))
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\MusicalChairs", "MaxDuration", maxDuration);

            _Timer.Dispose();
            base.OnClosing(e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _Timer.Stop();
            PlayPause();
            buttonStart.Text = Properties.Strings.START;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxMinDuration.Text, out int minDuration) || minDuration < 0)
            {
                MessageBox.Show(Properties.Strings.INVALID_MIN_DURATION, Properties.Strings.ERROR_OCCURED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxMaxDuration.Text, out int maxDuration) || maxDuration < 0)
            {
                MessageBox.Show(Properties.Strings.INVALID_MAX_DURATION, Properties.Strings.ERROR_OCCURED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (maxDuration <= minDuration)
            {
                MessageBox.Show(Properties.Strings.MAX_MUST_BE_GREATER, Properties.Strings.ERROR_OCCURED, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Timer.Enabled)
            {
                _Timer.Stop();
                PlayPause();
                buttonStart.Text = Properties.Strings.START;
            }
            else
            {
                PlayPause();
                buttonStart.Text = Properties.Strings.STOP;
                _Timer.Interval = _RNG.Next(minDuration, maxDuration) * 1000;
                _Timer.Start();
            }
        }

        private bool PlayPause()
        {
            var inputs = new WinAPI.INPUT[1];
            inputs[0].type = 1;
            inputs[0].ki.wVk = 0xB3;
            return WinAPI.SendInput(1, inputs, Marshal.SizeOf(typeof(WinAPI.INPUT))) == 1;
        }
    }
}
