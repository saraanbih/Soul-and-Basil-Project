using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Soul_and_Basil_Project.Properties;
using NAudio.Wave;

namespace Soul_and_Basil_Project
{
    public partial class FrmQuran : Form
    {
        public FrmQuran()
        {
            InitializeComponent();
        }

        private PictureBox activePictureBox = null;
        private SoundPlayer soundPlayer;
        private void HandlePictureBoxClick(PictureBox clickedPictureBox, string soundFilePath)
        {
            // If another PictureBox is active, reset its image to the "play" icon
            if (activePictureBox != null && activePictureBox != clickedPictureBox)
            {
                activePictureBox.Image = Resources.play_video_button_icon_vector_23205383;
                activePictureBox.Tag = false; // Reset the state of the previously active PictureBox
            }

            activePictureBox = clickedPictureBox;

            bool isPlaying = clickedPictureBox.Tag is bool playing && playing;

            if (isPlaying)
            {
                clickedPictureBox.Image = Resources.play_video_button_icon_vector_23205383;
                clickedPictureBox.Tag = false; // Set state to "paused"
                StopSound();
            }
            else
            {
                clickedPictureBox.Image = Resources.pause;
                clickedPictureBox.Tag = true; // Set state to "playing"
                PlaySound(soundFilePath);
            }
        }

        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;

        private void PlaySound(string soundFilePath)
        {
            try
            {
                StopSound(); // Stop any currently playing sound

                waveOutDevice = new WaveOutEvent();
                audioFileReader = new AudioFileReader(soundFilePath);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }

        private void StopSound()
        {
            try
            {
                if (waveOutDevice != null)
                {
                    waveOutDevice.Stop();
                    waveOutDevice.Dispose();
                    waveOutDevice = null;
                }
                if (audioFileReader != null)
                {
                    audioFileReader.Dispose();
                    audioFileReader = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping sound: " + ex.Message);
            }
        }

        private void الفاتحه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الفاتحه, @"C:\001_1_.wav");
        }

        private void البقره_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(البقره, @"C:\002.mp3");
        }

        private void ال_عمران_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(ال_عمران, @"C:\003.mp3");
        }

        private void النساء_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(النساء, @"C:\004.mp3");
        }

        private void المائده_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(المائده, @"C:\005.mp3");
        }

        private void الأعراف_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الأعراف, @"C:\007.mp3");
        }

        private void الأنفال_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الأنفال, @"C:\008.mp3");
        }

        private void التوبه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(التوبه, @"C:\009.mp3");
        }

        private void يونس_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(يونس, @"C:\010.mp3");
        }

        private void هود_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(هود, @"C:\011.mp3");
        }

        private void الرعد_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الرعد, @"C:\013.mp3");
        }

        private void إبراهيم_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(إبراهيم, @"C:\014.mp3");
        }

        private void الحجر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الحجر, @"C:\015.mp3");
        }

        private void النحل_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(النحل, @"C:\016.mp3");
        }

        private void الأسراء_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الإسراء, @"C:\017.mp3");
        }

        private void الكهف_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الكهف, @"C:\018.mp3");
        }

        private void مريم_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(مريم, @"C:\019.mp3");
        }

        private void طه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(طه, @"C:\020.mp3");
        }

        private void الأنبياء_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الأنبياء, @"C:\021.mp3");
        }

        private void الحج_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الحج, @"C:\022.mp3");
        }

        private void المؤمنون_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(المؤمنون, @"C:\023.wav");
        }

        private void النور_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(النور, @"C:\024.mp3");
        }

        private void الفرقان_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الفرقان, @"C:\025.mp3");
        }

        private void الشعراء_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الشعراء, @"C:\026.mp3");
        }

        private void النمل_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(النمل, @"C:\027.mp3");
        }

        private void القصص_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(القصص, @"C:\028.mp3");
        }

        private void العنكبوت_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(العنكبوت, @"C:\029.mp3");
        }

        private void الروم_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الروم, @"C:\030.mp3");
        }

        private void لقمان_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(لقمان, @"C:\031.mp3");
        }

        private void السجده_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(السجده, @"C:\032.mp3");
        }

        private void الأحزاب_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الأحزاب, @"C:\033.mp3");
        }

        private void سبأ_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(سبأ, @"C:\034.mp3");
        }

        private void فاطر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(فاطر, @"C:\035.mp3");
        }

        private void يس_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(يس, @"C:\036.mp3");
        }

        private void الصافات_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الصافات, @"C:\037.mp3");
        }

        private void ص_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(ص, @"C:\038.mp3");
        }

        private void الزمر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الزمر, @"C:\039.mp3");
        }

        private void غافر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(غافر, @"C:\040.mp3");
        }

        private void فصلت_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(فصلت, @"C:\041.mp3");
        }

        private void الشورى_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الشورى, @"C:\042.mp3");
        }

        private void الزخرف_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الزخرف, @"C:\043.mp3");
        }

        private void الدخان_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الدخان, @"C:\044.mp3");
        }

        private void الجاثيه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الجاثيه, @"C:\045.mp3");
        }

        private void الأحقاف_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الأحقاف, @"C:\046.mp3");
        }

        private void محمد_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(محمد, @"C:\047.mp3");
        }

        private void الفتح_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الفتح, @"C:\048.mp3");
        }

        private void الحجرات_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الحجرات, @"C:\049.mp3");
        }

        private void ق_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(ق, @"C:\050.mp3");
        }

        private void الذاريات_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الذاريات, @"C:\051.mp3");
        }

        private void الطور_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الطور, @"C:\052.mp3");
        }

        private void النجم_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(النجم, @"C:\053.mp3");
        }

        private void القمر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(القمر, @"C:\054.mp3");
        }

        private void الرحمن_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الرحمن, @"C:\055.mp3");
        }

        private void الواقعه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الواقعه, @"C:\056.mp3");
        }

        private void الحديد_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الحديد, @"C:\057.mp3");
        }

        private void المجادله_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(المجادله, @"C:\058.mp3");
        }

        private void الحشر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الحشر, @"C:\059.mp3");
        }

        private void الممتحنه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الممتحنه, @"C:\060.mp3");
        }

        private void الصف_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الصف, @"C:\061.mp3");
        }

        private void الجمعه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الجمعه, @"C:\062.mp3");
        }

        private void المنافقون_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(المنافقون, @"C:\063.mp3");
        }

        private void التغابن_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(التغابن, @"C:\064.mp3");
        }

        private void الطلاق_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الطلاق, @"C:\065.mp3");
        }

        private void التحريم_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(التحريم, @"C:\066.mp3");
        }

        private void الملك_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الملك, @"C:\067.mp3");
        }

        private void القلم_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(القلم, @"C:\068.mp3");
        }

        private void الحاقه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الحاقه, @"C:\069.mp3");
        }

        private void المعارج_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(المعارج, @"C:\070.mp3");
        }

        private void نوح_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(نوح, @"C:\071.mp3");
        }

        private void الجن_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الجن, @"C:\072.mp3");
        }

        private void المزمل_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(المزمل, @"C:\073.mp3");
        }

        private void المدثر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(المدثر, @"C:\074.mp3");
        }

        private void القيامه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(القيامه, @"C:\075.mp3");
        }

        private void الإنسان_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الإنسان, @"C:\076.mp3");
        }

        private void المرسلات_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(المرسلات, @"C:\077.mp3");
        }

        private void النبأ_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(النبأ, @"C:\078.mp3");
        }

        private void النازعات_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(النازعات, @"C:\079.mp3");
        }

        private void عبس_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(عبس, @"C:\080.mp3");
        }

        private void التكوير_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(التكوير, @"C:\081.mp3");
        }


        private void الأنفطار_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الإنفطار, @"C:\082.mp3");
        }

        private void المطففين_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(المطففين, @"C:\083.wav");
        }

        private void الأنشقاق_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الأنشقاق, @"C:\084.wav");
        }

        private void البروج_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(البروج, @"C:\085.wav");
        }

        private void الطارق_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الطارق, @"C:\086.wav");
        }

        private void الأعلى_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الأعلى, @"C:\087.wav");
        }

        private void الغاشيه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الغاشيه, @"C:\088.wav");
        }

        private void الفجر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الفجر, @"C:\089.wav");
        }

        private void البلد_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(البلد, @"C:\090.wav");
        }

        private void الشمس_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الشمس, @"C:\091.wav");
        }

        private void الليل_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الليل, @"C:\092.wav");
        }

        private void الضحى_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الضحى, @"C:\093.wav");
        }

        private void الشرح_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الشرح, @"C:\094.wav");
        }

        private void التين_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(التين, @"C:\095.wav");
        }

        private void العلق_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(العلق, @"C:\096.wav");
        }

        private void القدر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(القدر, @"C:\097.wav");
        }

        private void البينه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(البينه, @"C:\098.wav");
        }

        private void الزلزله_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الزلزله, @"C:\099.wav");
        }

        private void العاديات_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(العاديات, @"C:\100.wav");
        }

        private void القارعه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(القارعه, @"C:\101.wav");
        }

        private void التكاثر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(التكاثر, @"C:\102.wav");
        }

        private void العصر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(العصر, @"C:\103.wav");
        }

        private void الهمزه_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الهمزه, @"C:\104.wav");
        }

        private void الفيل_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الفيل, @"C:\105.wav");
        }

        private void قريش_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(قريش, @"C:\106.wav");
        }

        private void الماعون_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الماعون, @"C:\107.wav");
        }

        private void الكوثر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الكوثر, @"C:\108.wav");
        }

        private void الكافرون_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الكافرون, @"C:\109.wav");
        }

        private void النصر_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(النصر, @"C:\110_1.wav");
        }

        private void المسد_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(المسد, @"C:\111.wav");
        }

        private void الإخلاص_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الإخلاص, @"C:\112.wav");
        }

        private void الفلق_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الفلق, @"C:\113.wav");
        }

        private void الناس_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الناس, @"C:\114.wav");
        }

        private void يوسف_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(يوسف, @"C:\012.mp3");
        }

        private void الأنعام_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(الأنعام, @"C:\006.mp3");
        }
    }
}
