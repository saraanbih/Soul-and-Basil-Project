using System;
using System.Windows.Forms;

namespace Soul_and_Basil_Project
{
    public partial class FrmAfterPrayingAzqar : Form
    {
        public FrmAfterPrayingAzqar()
        {
            InitializeComponent();
            SetupLayout();
        }

        private void SetupLayout()
        {
            // Create and configure a TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 11; // Adjust this based on the number of text boxes
            tableLayoutPanel.ColumnCount = 1;

            // Set each row to a percentage of the total height
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / tableLayoutPanel.RowCount));
            }

            // Add each TextBox to a row in the TableLayoutPanel
            textBox1.Dock = DockStyle.Fill;
            textBox2.Dock = DockStyle.Fill;
            textBox3.Dock = DockStyle.Fill;
            textBox4.Dock = DockStyle.Fill;
            textBox5.Dock = DockStyle.Fill;
            textBox6.Dock = DockStyle.Fill;
            textBox7.Dock = DockStyle.Fill;
            textBox8.Dock = DockStyle.Fill;
            textBox9.Dock = DockStyle.Fill;
            textBox10.Dock = DockStyle.Fill;
            textBox11.Dock = DockStyle.Fill;

            tableLayoutPanel.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel.Controls.Add(textBox3, 0, 2);
            tableLayoutPanel.Controls.Add(textBox4, 0, 3);
            tableLayoutPanel.Controls.Add(textBox5, 0, 4);
            tableLayoutPanel.Controls.Add(textBox6, 0, 5);
            tableLayoutPanel.Controls.Add(textBox7, 0, 6);
            tableLayoutPanel.Controls.Add(textBox8, 0, 7);
            tableLayoutPanel.Controls.Add(textBox9, 0, 8);
            tableLayoutPanel.Controls.Add(textBox10, 0, 9);
            tableLayoutPanel.Controls.Add(textBox11, 0, 10);

            // Add the TableLayoutPanel to the form
            this.Controls.Add(tableLayoutPanel);
        }

        private void FrmAfterPrayingAzqar_Load(object sender, EventArgs e)
        {
            textBox1.Text = "أَسْـتَغْفِرُ الله، أَسْـتَغْفِرُ الله، أَسْـتَغْفِرُ الله.\r\nاللّهُـمَّ أَنْـتَ السَّلامُ ، وَمِـنْكَ السَّلام ، تَبارَكْتَ يا ذا الجَـلالِ وَالإِكْـرام . "
                + new string(' ', 20) + "مره واحده";

            textBox2.Text = "لا إلهَ إلاّ اللّهُ وحدَهُ لا شريكَ لهُ، لهُ المُـلْكُ ولهُ الحَمْد، وهوَ على كلّ شَيءٍ قَدير،" +
                " اللّهُـمَّ لا مانِعَ لِما أَعْطَـيْت، وَلا مُعْطِـيَ لِما مَنَـعْت، وَلا يَنْفَـعُ ذا الجَـدِّ مِنْـكَ الجَـد. "
                + new string(' ', 45) + "مره واحده";

            textBox3.Text = "لا إلهَ إلاّ اللّه, وحدَهُ لا شريكَ لهُ، لهُ الملكُ ولهُ الحَمد، وهوَ على كلّ شيءٍ قدير، لا حَـوْلَ وَلا قـوَّةَ إِلاّ بِاللهِ،" +
                " لا إلهَ إلاّ اللّـه، وَلا نَعْـبُـدُ إِلاّ إيّـاه, " +
                "لَهُ النِّعْـمَةُ وَلَهُ الفَضْل وَلَهُ الثَّـناءُ الحَـسَن، لا إلهَ إلاّ اللّهُ مخْلِصـينَ لَـهُ الدِّينَ وَلَوْ كَـرِهَ الكـافِرون"
                + new string(' ', 40) + "مره واحده";

            textBox4.Text = "سُـبْحانَ اللهِ، والحَمْـدُ لله ، واللهُ أكْـبَر."
                + new string(' ', 40) + "ثلاث وثلاثون";

            textBox5.Text = "لا إلهَ إلاّ اللّهُ وَحْـدَهُ لا شريكَ لهُ، لهُ الملكُ ولهُ الحَمْد، وهُوَ على كُلّ شَيءٍ قَـدير. "
                + new string(' ', 60) + "مره واحده";

            textBox6.Text = "لا إلهَ إلاّ اللّهُ وحْـدَهُ لا شريكَ لهُ، لهُ المُلكُ ولهُ الحَمْد، يُحيـي وَيُمـيتُ وهُوَ على كُلّ شيءٍ قدير." +
                "\r\nعَشْر مَرّات بَعْدَ المَغْرِب وَالصّـبْح.";

            textBox7.Text = "بِسْمِ اللهِ الرَّحْمنِ الرَّحِيم\r\nقُلْ هُوَ ٱللَّهُ أَحَدٌ، ٱللَّهُ ٱلصَّمَدُ، لَمْ يَلِدْ وَلَمْ يُولَدْ، وَلَمْ يَكُن لَّهُۥ كُفُوًا أَحَدٌۢ." +
                "\r\nبِسْمِ اللهِ الرَّحْمنِ الرَّحِيم\r\nقُلْ أَعُوذُ بِرَبِّ ٱلْفَلَقِ، مِن شَرِّ مَا خَلَقَ، " +
                "وَمِن شَرِّ غَاسِقٍ إِذَا وَقَبَ، وَمِن شَرِّ ٱلنَّفَّٰثَٰتِ فِى ٱلْعُقَدِ، وَمِن شَرِّ حَاسِدٍ إِذَا حَسَدَ.\r\nبِسْمِ اللهِ الرَّحْمنِ الرَّحِيم\r\n" +
                "قُلْ أَعُوذُ بِرَبِّ ٱلنَّاسِ، مَلِكِ ٱلنَّاسِ، إِلَٰهِ ٱلنَّاسِ، مِن شَرِّ ٱلْوَسْوَاسِ ٱلْخَنَّاسِ، ٱلَّذِى يُوَسْوِسُ فِى صُدُورِ ٱلنَّاسِ، مِنَ ٱلْجِنَّةِ وَٱلنَّاسِ" +
                ".\r\nثلاث مرات بعد صلاتي الفجر والمغرب. ومرة بعد الصلوات الأخرى.\r\n";

            textBox8.Text = "أَعُوذُ بِاللهِ مِنْ الشَّيْطَانِ الرَّجِيمِ\r\nاللّهُ لاَ إِلَـهَ إِلاَّ هُوَ الْحَيُّ الْقَيُّومُ لاَ تَأْخُذُهُ سِنَةٌ " +
                "وَلاَ نَوْمٌ لَّهُ مَا فِي السَّمَاوَاتِ وَمَا فِي الأَرْضِ مَن ذَا الَّذِي يَشْفَعُ عِنْدَهُ إِلاَّ بِإِذْنِهِ " +
                "يَعْلَمُ مَا بَيْنَ أَيْدِيهِمْ وَمَا خَلْفَهُمْ وَلاَ يُحِيطُونَ" +
                " [بِشَيْءٍ مِّنْ عِلْمِهِ إِلاَّ بِمَا شَاء وَسِعَ كُرْسِيُّهُ السَّمَاوَاتِ وَالأَرْضَ وَلاَ يَؤُودُهُ حِفْظُهُمَا وَهُوَ الْعَلِيُّ الْعَظِيمُ. [آية الكرسى - البقرة 255"
                + new string(' ', 40) + "مره واحده";

            textBox9.Text = "اللّهُـمَّ إِنِّـي أَسْأَلُـكَ عِلْمـاً نافِعـاً وَرِزْقـاً طَيِّـباً ، وَعَمَـلاً مُتَقَـبَّلاً.\r\nبَعْد السّلامِ من صَلاةِ الفَجْر مره واحده.";

            textBox10.Text = "اللَّهُمَّ أَجِرْنِي مِنْ النَّار.\r\nبعد صلاة الصبح والمغرب سبع مرات.";

            textBox11.Text = "اللَّهُمَّ أَعِنِّي عَلَى ذِكْرِكَ وَشُكْرِكَ وَحُسْنِ عِبَادَتِكَ. " + new string(' ', 40) + "مره واحده";
        }
    }
}
