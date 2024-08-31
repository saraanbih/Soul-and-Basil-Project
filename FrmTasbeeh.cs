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
    public partial class FrmTasbeeh : Form
    {
        public FrmTasbeeh()
        {
            InitializeComponent();
        }

        private int Countسبحان_الله = 0;
        private int Countالحمد_لله = 0;
        private int Countلا_إله_الا_الله = 0;
        private int Countأستغفر_الله = 0;
        private int Countالله_أكبر = 0;
        private int Countلاحول_ولا_قوة_إلا_بالله = 0;
        private int Countاللهم_صلى_وسلم_على_سيدنا_محمد_وعلى_آاله_وصحبه_أجمعين = 0;

        private void FrmTasbeeh_Load(object sender, EventArgs e)
        {
            Countسبحان_الله = 0;
            Countالحمد_لله = 0;
            Countلا_إله_الا_الله = 0;
            Countأستغفر_الله = 0;
            Countالله_أكبر = 0;
            Countلاحول_ولا_قوة_إلا_بالله = 0;
            Countاللهم_صلى_وسلم_على_سيدنا_محمد_وعلى_آاله_وصحبه_أجمعين = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Countسبحان_الله++;
            textBox1.Text = Countسبحان_الله.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Countالحمد_لله++;
            textBox2.Text = Countالحمد_لله.ToString();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Countلا_إله_الا_الله++;
            textBox3.Text = Countلا_إله_الا_الله.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Countأستغفر_الله++;
            textBox4.Text = Countأستغفر_الله.ToString(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Countالله_أكبر++;
            textBox5.Text = Countالله_أكبر.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Countلاحول_ولا_قوة_إلا_بالله++;
            textBox6.Text = Countلاحول_ولا_قوة_إلا_بالله.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Countاللهم_صلى_وسلم_على_سيدنا_محمد_وعلى_آاله_وصحبه_أجمعين++;
            textBox7.Text = Countاللهم_صلى_وسلم_على_سيدنا_محمد_وعلى_آاله_وصحبه_أجمعين.ToString();
        }
    }
}
