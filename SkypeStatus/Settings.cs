using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SkypeStatus.Common;

namespace SkypeStatus
{
    public partial class Settings : Form
    {
        DateTime datetime = new DateTime(1753,1,1,time.hours,time.minutes,time.seconds);

        public Settings()
        {
            InitializeComponent();

            checkBoxGFW.Checked = Properties.Settings.Default.GFW;
            checkBoxBeep.Checked = Properties.Settings.Default.Beep;
            dateTimePicker.Value = datetime;
            dateTimePickerLimit.Value = Limit;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            time.hours = dateTimePicker.Value.Hour;
            time.minutes = dateTimePicker.Value.Minute;
            time.seconds = dateTimePicker.Value.Second;

            Limit = dateTimePickerLimit.Value;

            Properties.Settings.Default.GFW = checkBoxGFW.Checked;
            Properties.Settings.Default.Beep = checkBoxBeep.Checked;
            Properties.Settings.Default.Save();
        }

        private void linkLabelGFW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://chrome.google.com/webstore/detail/go-fucking-work/hibmkkpfegfiinilnlabbfnjcopdiiig");
        }
    }
}
