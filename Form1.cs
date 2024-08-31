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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "روح وريحان هو تطبيق إسلامي شامل يهدف إلى تعزيز روحانيتك اليومية من خلال تقديم الأذكار، القرآن الكريم، والأدعية في واجهة سهلة الاستخدام. " +
                        "يتيح لك التطبيق الوصول إلى الأذكار اليومية، الاستماع إلى القرآن ، واختيار الأدعية المناسبة لمواقف حياتك المختلفة. " +
                        "بفضل التنبيهات المخصصة، يساعدك روح وريحان على البقاء على اتصال دائم بذكر الله، مما يجعل إيمانك جزءًا لا يتجزأ من حياتك اليومية.";

            MessageBox.Show(message, "حول تطبيق روح وريحان", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Linklbl.LinkVisited = true;
            System.Diagnostics.Process.Start("https://t.me/Sara_Nabih");
        }

        private void مواقيت_الأذان_Click(object sender, EventArgs e)
        {
            Form form = new FrmPrayTime(); 
            form.ShowDialog();
        }

        private void التسبيح_أونلاين_Click(object sender, EventArgs e)
        {
            FrmTasbeeh frmTasbeeh = new FrmTasbeeh();
            frmTasbeeh.ShowDialog();
        }

        private void القرآن_Click(object sender, EventArgs e)
        {
           FrmQuran quran = new FrmQuran();
           quran.ShowDialog();
        }

        private void الأذكار_Click(object sender, EventArgs e)
        {
            FrmAzqar frmAzqar = new FrmAzqar();
            frmAzqar.ShowDialog();
        }
    }
    
}
