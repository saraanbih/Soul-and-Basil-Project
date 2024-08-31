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
    public partial class FrmAzqar : Form
    {
        public FrmAzqar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAfterPrayingAzqar frmAfterPrayingAzqar = new FrmAfterPrayingAzqar();
            frmAfterPrayingAzqar.ShowDialog();
        }

        private void btnMorningAzqar_Click(object sender, EventArgs e)
        {
            FrmMorningAzqar frmMorningAzqar = new FrmMorningAzqar();
            frmMorningAzqar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEveningAzqar frmEveningAzqar = new FrmEveningAzqar();
            frmEveningAzqar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAfterSleepingazqar frmAfterSleepingAzqar = new FrmAfterSleepingazqar();
            frmAfterSleepingAzqar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSleepingAzqar frmSleepingAzqar = new FrmSleepingAzqar();
            frmSleepingAzqar.ShowDialog();
        }

        
    }
}
