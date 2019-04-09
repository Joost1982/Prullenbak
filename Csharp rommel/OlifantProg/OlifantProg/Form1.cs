using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlifantProg
{
    public partial class Form1 : Form
    {
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 43 };
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 22 };
        Elephant temp = new Elephant();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = lloyd;
            lloyd = lucinda;
            lucinda = temp;
            MessageBox.Show("Swapped!");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            lloyd.TellMe("Wuhaaaaa", lucinda);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lloyd.SpeakTo(lucinda, "hoihoi");
        }
    }
}
