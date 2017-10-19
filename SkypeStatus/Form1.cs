using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Lync.Model;
using System.Media;
using System.IO;
using System.Diagnostics;
using static SkypeStatus.Common;
using Microsoft.Lync.Model.Conversation;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;

namespace SkypeStatus
{
    public partial class SkypeStatus : Form
    {
        Timer timer = new Timer();

        //Allow click+drag on anywhere in the form
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }

                    return;
            }

            base.WndProc(ref m);
        }

        public SkypeStatus()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.FromPoint(new Point(Cursor.Position.X, Cursor.Position.Y));
            this.Top = screen.Bounds.Y + (screen.Bounds.Height / 10);
            this.Left = screen.Bounds.X + (screen.Bounds.Width / 10);

            this.TopMost = true;
        }

        private void pictureBoxAway_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxAway.BackColor = Color.LightGray;

            setStatus(ContactAvailability.Busy);

            startTimer();
            toggleFingWork(false);
            toggleSlack(true);
        }

        private void pictureBoxAway_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxAway.BackColor = SystemColors.ControlDark;
        }

        private void pictureBoxReturn_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxReturn.BackColor = Color.LightGray;

            setStatus(ContactAvailability.Free);

            stopTimer();
            toggleFingWork(true);
            toggleSlack(false);
            this.BackColor = SystemColors.ControlDark;
            pictureBoxAway.BackColor = SystemColors.ControlDark;
            labelClock.ForeColor = SystemColors.ControlText;
        }

        private void pictureBoxReturn_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxReturn.BackColor = SystemColors.ControlDark;
        }

        private void setStatus(ContactAvailability newStatus)
        {
            var infoToPublish = new Dictionary<PublishableContactInformationType, object>();
            infoToPublish.Add(PublishableContactInformationType.Availability, newStatus);

            var theClient = LyncClient.GetClient();
            var self = theClient.Self;
            self.BeginPublishContactInformation(infoToPublish, EndPublishContactInformation, self);
        }

        private void EndPublishContactInformation(IAsyncResult ar)
        {
            var self = ar.AsyncState as Self;
            self.EndPublishContactInformation(ar);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            time.hours = 0;
            time.minutes = 0;
            time.seconds = 0;
            displayTime(time);

            labelClock.ForeColor = SystemColors.ControlText;
        }

        private void startTimer()
        {
            timer.Enabled = true;
            timer.Start();
        }

        public void stopTimer()
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time.seconds++;

            if (time.seconds > 59)
            {
                time.seconds = 0;
                time.minutes++;
            }

            if (time.minutes > 59)
            {
                time.minutes = 0;
                time.hours++;
            }

            displayTime(time);
            new System.Threading.Thread(() => beep(time)).Start();

            if (time.hours == Limit.Hour && time.minutes == Limit.Minute && time.seconds == Limit.Second)
            {
                this.Show();
                this.Top = Cursor.Position.Y - this.Height / 2;
                this.Left = Cursor.Position.X - this.Width / 2;
                this.BackColor = Color.Red;
                pictureBoxAway.BackColor = Color.Red;
                pictureBoxReturn.BackColor = Color.Red;
                labelClock.ForeColor = Color.White;
            }
        }

        private void displayTime(Time time)
        {
            labelClock.Text = time.hours.ToString("D2") + ":" + time.minutes.ToString("D2") + ":" + time.seconds.ToString("D2");
        }

        private void toggleFingWork(bool on)
        {
            if (Directory.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Local\Google\Chrome\User Data\Default\Extensions\hibmkkpfegfiinilnlabbfnjcopdiiig") && Properties.Settings.Default.GFW) //Check to see if GO F**KING WORK is installed
            {
                if (on)
                    Process.Start("https://www.gofuckingwork.com/start");
                else
                    Process.Start("https://www.gofuckingwork.com/stop");
            }
        }

        private void toggleSlack(bool away)
        {
            string apiEndpoint = "https://slack.com/api/";
            string method = "users.profile.set";
            string completeUrl = apiEndpoint + method;
            string token = "SLACKTOKEN";

            JObject profile;

            if (away)
            {
                profile = new JObject()
                {
                    {"status_text", "lunch" },
                    {"status_emoji", "" }
                };
            }
            else
            {
                profile = new JObject()
                {
                    {"status_text", "" },
                    {"status_emoji", "" }
                };
            }

            NameValueCollection payload = new NameValueCollection()
            {
                {"token", token },
                {"user", "USERID" },
                {"profile", profile.ToString() }
            };

            using (WebClient client = new WebClient())
            {
                var response = client.UploadValues(completeUrl, "POST", payload);
                string responseText = (new UTF8Encoding()).GetString(response);
            }
        }

        private void beep(Time time)
        {
            if (!Properties.Settings.Default.Beep)
                return;

            if (time.minutes >= Limit.AddMinutes(-10).Minute)
            {
                labelClock.ForeColor = Color.Red;

                if (time.minutes <= Limit.AddMinutes(-3).Minute && time.seconds == 0)
                    Console.Beep(1500, 1500);
                else if (time.minutes > Limit.AddMinutes(-3).Minute && time.minutes < Limit.AddMinutes(-1).Minute && time.seconds % 10 == 0)
                    Console.Beep(1500, 1500);
                else if (time.minutes == Limit.AddMinutes(-1).Minute && time.seconds % 2 == 0)
                    Console.Beep(1500, 750);
            }

            if (time.hours > Limit.Hour && time.seconds % 2 == 0)
                Console.Beep(1500, 750);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            stopTimer();
            this.TopMost = false;

            Settings settings = new Settings();
            settings.ShowDialog();

            displayTime(time);
            this.TopMost = true;
        }
    }
}
