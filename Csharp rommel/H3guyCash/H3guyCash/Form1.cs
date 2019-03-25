using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3guyCash
{
    public partial class Form1 : Form
    {

        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {

            joesLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsLabel.Text = bob.Name + " has $" + bob.Cash;
            bankLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();
            // initialize joe en bob hier!
            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;

            //dit is hetzelfde, maar efficienter:
            joe = new Guy() { Cash = 50, Name = "Joe" };

            UpdateForm();
       }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                joe.Cash -= bob.ReceiveCash(10);
                UpdateForm();
                    }
            else
            {
                MessageBox.Show("Joe heeft niet genoeg geld meer!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                bob.Cash -= joe.ReceiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob heeft niet genoeg geld meer!");
            }

        }
    }
}
