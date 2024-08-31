using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Web.UI.Design.WebControls;
using System.Web.Security;
using System.Media;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Soul_and_Basil_Project
{
    public partial class FrmPrayTime : Form
    {
        DateTime[] times;
        TextBox[] boxes;
        TextBox[] namesPrayers;
        byte nextPrayer;
        private NotifyIcon prayerNotifyIcon;
        public FrmPrayTime()
        {
            InitializeComponent();
            prayerNotifyIcon = new NotifyIcon();
            prayerNotifyIcon.Icon = SystemIcons.Information;  // You can set this to a custom icon
            prayerNotifyIcon.Visible = true;
        }
        private void FrmPrayTime_Load(object sender, EventArgs e)
        {
            boxes = new TextBox[5] { txtfajr, txtzuhr, txtasr, txtmaghrib, txtisha };
            namesPrayers = new TextBox[5] { txtBfajr, txtBzohr, txtBasr, txtBmagrib, txtBisha };
            times = GetPrayerTimes(31.0414531, 31.3416397);
            addPrayerTimesToBoxes();

        }
        private byte getNextPrayer()
        {
            for (byte i = 0; i < 5; i++)
            {
                if (times[i] > DateTime.Now)
                    return i;

            }

            NotifyIcon Noti = new NotifyIcon();
           
            return 0;
        }
        private void PrayTime_Tick(object sender, EventArgs e)
        {
            //txtTimeNow.Text = DateTime.Now.ToString("HH:mm:ss");

            //nextPrayer = getNextPrayer();
            //txtPrayTimer.Text = ((times[nextPrayer] - DateTime.Now)).ToString("hh':'mm':'ss");
            //textNextPrayer.Text = namesPrayers[nextPrayer].Text;
            //textCurrentPrayer.Text = namesPrayers[(nextPrayer == 0) ? 4 : nextPrayer - 1].Text;
            //txtHijri.Text = GetCompleteDateInArabic();
            //txtTodayMiladi.Text = GetCompleteGregorianDateWithArabicDaysAndMonths();

             txtTimeNow.Text = DateTime.Now.ToString("hh:mm:ss tt");

             nextPrayer = getNextPrayer();

             TimeSpan timeUntilNextPrayer = times[nextPrayer] - DateTime.Now;

             if (timeUntilNextPrayer.TotalSeconds < 0)
             {
                 timeUntilNextPrayer = times[nextPrayer].AddDays(1) - DateTime.Now;
             }

            
             txtPrayTimer.Text = timeUntilNextPrayer.ToString(@"hh\:mm\:ss");

             textNextPrayer.Text = namesPrayers[nextPrayer].Text;
             textCurrentPrayer.Text = namesPrayers[(nextPrayer == 0) ? 4 : nextPrayer - 1].Text;

             txtHijri.Text = GetCompleteDateInArabic();
             txtTodayMiladi.Text = GetCompleteGregorianDateWithArabicDaysAndMonths();

            if ((timeUntilNextPrayer.TotalSeconds <= 0) || (txtPrayTimer.Text == "00:00:00"))
            {
               ShowPrayerNotification();
               try
               { 
                    SoundPlayer soundPlayer = new SoundPlayer(@"C:\أذان_من_أزقة_فسطاط_القاهرة_للشيخ_نصر_الدين_طوبار_صوت_يض.wav");
                    soundPlayer.Play();
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Error playing sound: " + ex.Message);
               }
            }
        }
        private void ShowPrayerNotification()
        {
            // Show notification when it's prayer time
            prayerNotifyIcon.BalloonTipTitle = "Prayer Time";
            prayerNotifyIcon.BalloonTipText = $"It's time for {namesPrayers[nextPrayer].Text} prayer.";
            prayerNotifyIcon.ShowBalloonTip(60000); // Show for 7 seconds

            // Optionally play a sound or perform other actions here
        }

        private const string ApiUrlTemplate = "https://muslimsalat.com/mansora.json?key=259cfbf8b40dc518e5d60a68da177af7";

        public static DateTime[] GetPrayerTimes(double latitude, double longitude)
        {
            string url = ApiUrlTemplate;

            using (var client = new WebClient())
            {
                string json = client.DownloadString(url);
                JObject jsonResponse = JObject.Parse(json);

                JObject timings = (JObject)jsonResponse["items"][0];

                DateTime now = DateTime.Now;
                DateTime[] prayerTimes = new DateTime[5];

                try
                {
                    prayerTimes[0] = ParsePrayerTime(timings["fajr"].ToString(), now);
                    prayerTimes[1] = ParsePrayerTime(timings["dhuhr"].ToString(), now);
                    prayerTimes[2] = ParsePrayerTime(timings["asr"].ToString(), now);
                    prayerTimes[3] = ParsePrayerTime(timings["maghrib"].ToString(), now);
                    prayerTimes[4] = ParsePrayerTime(timings["isha"].ToString(), now);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error parsing prayer times: " + ex.Message);
                    return null;
                }

                return prayerTimes;
            }
        }

        private static DateTime ParsePrayerTime(string timeString, DateTime referenceDate)
        {
            return DateTime.ParseExact(timeString, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture)
                .AddSeconds(-referenceDate.Second)
                .AddMilliseconds(-referenceDate.Millisecond)
                .AddTicks(-(referenceDate.Ticks % TimeSpan.TicksPerSecond))
                .AddHours(1);
        }

        private void addPrayerTimesToBoxes()
        {
            for (short i = 0; i < 5; i++)
            {
                boxes[i].Text = times[i].ToString("hh:mm tt");
            }
        }

        private void txtisha_TextChanged(object sender, EventArgs e)
        {

        }
        public string GetCompleteDateInArabic()
        {
            CultureInfo arabicCulture = new CultureInfo("ar-SA");
            DateTime today = DateTime.Now;
            string completeDateInArabic = today.ToString("dddd, dd MMMM yyyy", arabicCulture);
            return completeDateInArabic;
        }
        private static readonly string[] ArabicMonths = new string[]
        {

            "يناير",
            "فبراير",
            "مارس",
            "أبريل",
            "مايو",
            "يونيو",
            "يوليو",
            "أغسطس",
            "سبتمبر",
            "أكتوبر",
            "نوفمبر",
            "ديسمبر"
        };

        private static readonly string[] ArabicDays = new string[]
        {
            "الأحد",
            "الإثنين",
            "الثلاثاء",
            "الأربعاء",
            "الخميس",
            "الجمعة",
            "السبت"
        };

        public string GetCompleteGregorianDateWithArabicDaysAndMonths()
        {
            DateTime today = DateTime.Now;
            string dayOfWeek = ArabicDays[(int)today.DayOfWeek];
            string dayOfMonth = today.Day.ToString("00");
            string monthInArabic = ArabicMonths[today.Month - 1];
            string year = today.Year.ToString();
            return $"{dayOfWeek}, {dayOfMonth} {monthInArabic} {year}";
        }

    }
}
