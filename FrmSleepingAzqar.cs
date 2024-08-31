﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soul_and_Basil_Project
{
    public partial class FrmSleepingAzqar : Form
    {
        public FrmSleepingAzqar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSleepingAzqar_Load(object sender, EventArgs e)
        {
            textBox1.Text = "بِاسْمِكَ رَبِّـي وَضَعْـتُ جَنْـبي ،" +
                " وَبِكَ أَرْفَعُـه، فَإِن أَمْسَـكْتَ نَفْسـي فارْحَـمْها ، وَإِنْ أَرْسَلْتَـها فاحْفَظْـها بِمـا تَحْفَـظُ بِه عِبـادَكَ الصّـالِحـين."
                + new string(' ', 40) + "مره واحده";

            textBox2.Text = "اللّهُـمَّ إِنَّـكَ خَلَـقْتَ نَفْسـي وَأَنْـتَ تَوَفّـاهـا لَكَ ممَـاتـها وَمَحْـياها ، " +
                "إِنْ أَحْيَيْـتَها فاحْفَظْـها ، وَإِنْ أَمَتَّـها فَاغْفِـرْ لَـها . اللّهُـمَّ إِنَّـي أَسْـأَلُـكَ العـافِـيَة. " +
                new string(' ', 40) + "مره واحده";

            textBox3.Text = "اللّهُـمَّ قِنـي عَذابَـكَ يَـوْمَ تَبْـعَثُ عِبـادَك." + new string(' ', 40) + "ثلاث مرات";

            textBox4.Text = "بِاسْـمِكَ اللّهُـمَّ أَمـوتُ وَأَحْـيا. " + new string(' ', 40) + "مره واحده";

            textBox5.Text = "الـحَمْدُ للهِ الَّذي أَطْـعَمَنا وَسَقـانا، وَكَفـانا، وَآوانا، فَكَـمْ مِمَّـنْ لا كـافِيَ لَـهُ وَلا مُـؤْوي."
                + new string(' ', 40) + "مره واحده";

            textBox6.Text = "اللّهُـمَّ عالِـمَ الغَـيبِ وَالشّـهادةِ فاطِـرَ السّماواتِ وَالأرْضِ رَبَّ كُـلِّ شَـيءٍ وَمَليـكَه، " +
                "أَشْهـدُ أَنْ لا إِلـهَ إِلاّ أَنْت، أَعـوذُ بِكَ مِن شَـرِّ نَفْسـي، " +
                "وَمِن شَـرِّ الشَّيْـطانِ وَشِـرْكِه، وَأَنْ أَقْتَـرِفَ عَلـى نَفْسـي سوءاً أَوْ أَجُـرَّهُ إِلـى مُسْـلِم . " +
                new string(' ', 40) + "مره واحده";

            textBox7.Text = "اللّهُـمَّ أَسْـلَمْتُ نَفْـسي إِلَـيْكَ، وَفَوَّضْـتُ أَمْـري إِلَـيْكَ، وَوَجَّـهْتُ وَجْـهي " +
                "إِلَـيْكَ، وَأَلْـجَـاْتُ ظَهـري إِلَـيْكَ، رَغْبَـةً وَرَهْـبَةً إِلَـيْكَ،" +
                " لا مَلْجَـأَ وَلا مَنْـجـا مِنْـكَ إِلاّ إِلَـيْكَ، آمَنْـتُ بِكِتـابِكَ الّـذي أَنْزَلْـتَ وَبِنَبِـيِّـكَ الّـذي أَرْسَلْـت. "
                + new string(' ',40) + "مره واحده";

            textBox8.Text = "سُبْحَانَ اللَّهِ." + new string(' ', 40) + "ثلاث وثلاثون";

            textBox9.Text = "الْحَمْدُ لِلَّهِ." + new string(' ', 40) + "ثلاث وثلاثون";

            textBox10.Text = "اللَّهُ أَكْبَرُ. " + new string(' ', 40) + "أربعه وثلاثون";

            textBox11.Text = "يجمع كفيه ثم ينفث فيهما والقراءة فيهما‏:‏ ‏{‏قل هو الله أحد‏}‏ " +
                "و‏{‏قل أعوذ برب الفلق‏}‏ و‏{‏قل أعوذ برب الناس‏}‏ ومسح ما استطاع من " +
                "الجسد يبدأ بهما على رأسه ووجه وما أقبل من جسده."
                + new string(' ', 40) + "ثلاث مرات";

            textBox13.Text = "آية الكرسى: أَعُوذُ بِاللهِ مِنْ الشَّيْطَانِ الرَّجِيمِ\r\nاللّهُ لاَ إِلَـهَ إِلاَّ هُوَ الْحَيُّ الْقَيُّومُ لاَ تَأْخُذُهُ" +
                " سِنَةٌ وَلاَ نَوْمٌ لَّهُ مَا فِي السَّمَاوَاتِ وَمَا فِي الأَرْضِ مَن ذَا الَّذِي يَشْفَعُ عِنْدَهُ إِلاَّ بِإِذْنِهِ يَعْلَمُ مَا بَيْنَ أَيْدِيهِمْ وَمَا خَلْفَهُمْ" +
                " وَلاَ يُحِيطُونَ بِشَيْءٍ مِّنْ عِلْمِهِ إِلاَّ بِمَا شَاء وَسِعَ كُرْسِيُّهُ السَّمَاوَاتِ وَالأَرْضَ وَلاَ يَؤُودُهُ حِفْظُهُمَا وَهُوَ الْعَلِيُّ الْعَظِيمُ." +
                " [البقرة 255]\r\nأجير من الجن حتى يصبح." + new string(' ', 40) + "مره واحده";

            textBox12.Text = "أذكار الأحلام\r\nعن أبي قتادة رضي الله عنه قال‏:‏ قال رسول الله صلى الله عليه وسلم" +
                "‏:‏ ‏\"‏الرؤيا الصالحة‏\"‏ وفي رواية ‏\"‏الرؤيا الحسنة من الله، والحلم من الشيطان، " +
                "فمن رأى شيئا يكرهه فلينفث عن شماله" +
                " ثلاثا وليتعوذ من الشيطان، فإنها لا تضره‏\"." + new string(' ', 31) + "مره واحده";

            textBox14.Text = "أذكار من قلق في فراشه ولم ينم\r\nعن بريدة رضي الله عنه، قال‏:‏ شكا خالد بن الوليد رضي الله عنه إلى النبي صلى الله عليه وسلم" +
                " فقال‏:‏ يا رسول الله‏!‏ ما " +
                "أنام الليل من الأرق، فقال النبي صلى الله عليه وسلم‏:‏ ‏\"‏إذا أويت إلى فراشك فقل‏:‏ " +
                "اللهم رب السموات السبع وما أظلت، ورب الأرضين وما أقلت، ورب الشياطين وما أضلت، كن لي جارا من خلقك كلهم جميعا " +
                "أن يفرط علي أحد منهم أو أن يبغي علي، عز جارك، وجل" +
                " ثناؤك ولا إله غيرك، ولا إله إلا أنت‏\"\r\n\r\nعن عمرو بن شعيب، عن أبيه، عن جده: أن رسول الله صلى الله عليه " +
                "وسلم كان يعلمهم من الفزع كلمات‏:‏ ‏\"‏أعوذ بكلمات الله التامة من غضبه وشر عباده، ومن همزات الشياطين وأن" +
                " يحضرون‏\" " + new string(' ', 30) + "مره واحده";

            textBox15.Text = "من قرأ آيتين من آخر سورة البقرة في ليلة كفتاه." + new string(' ', 30) + "مره واحده";
        }
    }
}