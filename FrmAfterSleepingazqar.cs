using System;
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
    public partial class FrmAfterSleepingazqar : Form
    {
        public FrmAfterSleepingazqar()
        {
            InitializeComponent();
            // Create and configure TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.ColumnCount = 1;

            // Add rows with percentage size
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));

            // Add controls to TableLayoutPanel
            textBox1.Dock = DockStyle.Fill;
            textBox2.Dock = DockStyle.Fill;
            textBox3.Dock = DockStyle.Fill;

            tableLayoutPanel.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel.Controls.Add(textBox3, 0, 2);

            // Add TableLayoutPanel to the form
            this.Controls.Add(tableLayoutPanel);
        }

        private void FrmAfterSleepingazqar_Load(object sender, EventArgs e)
        {
            textBox1.Text = "الحَمْـدُ لِلّهِ الّذي أَحْـيانا بَعْـدَ ما أَماتَـنا وَإليه النُّـشور. " + new string(' ', 40) + "مره واحده";

            textBox2.Text = "الحمدُ للهِ الذي عافاني في جَسَدي وَرَدّ عَليّ روحي وَأَذِنَ لي بِذِكْرِه." + new string(' ', 40) + "مره واحده";

            textBox3.Text = "لا إلهَ إلاّ اللّهُ وَحْـدَهُ لا شَـريكَ له، لهُ المُلـكُ ولهُ الحَمـد، وهوَ على كلّ شيءٍ قدير، سُـبْحانَ اللهِ، " +
                "\r\nوالحمْـدُ لله ، ولا إلهَ إلاّ اللهُ واللهُ أكبَر، وَلا حَولَ وَلا قوّة إلاّ باللّهِ العليّ العظيم. رَبِّ اغْفرْ لي." + new string(' ', 72) + "مره واحده";
        }
    }
}
