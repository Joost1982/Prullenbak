using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mileageCalculator
{
    public partial class Form1 : Form
    {
        int kmStandBegin = 0;
        int kmStandEind = 0;
        int gereisd = 0;
        decimal vergoeding = 0M;
        decimal vergoedingPerKM = 0.39M;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           kmStandBegin = (int) numericUpDown1.Value;
           kmStandEind = (int)numericUpDown2.Value;
           vergoeding = vergoedingPerKM * (kmStandEind - kmStandBegin);
           bedragLabel.Text = "Bedrag: " + vergoeding;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kmStandBegin = (int) numericUpDown1.Value;
            kmStandEind = (int)numericUpDown2.Value;
            gereisd = (kmStandEind - kmStandBegin);

            MessageBox.Show("Aantal km: " + gereisd);
        }
    }
}
