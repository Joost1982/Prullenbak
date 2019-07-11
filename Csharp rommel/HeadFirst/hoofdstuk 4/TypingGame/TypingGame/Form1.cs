using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        Stats stats = new Stats();

        private void timer1_Tick(object sender, EventArgs e)
        {
            //add random key to the ListBox
            //listBox1.Items.Add((Keys)67); //voegt de letter C toe
            listBox1.Items.Add((Keys)random.Next(65, 90)); 
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over!");
                timer1.Stop();
                
                //toevoeging om opnieuw te kunnen spelen
                MessageBox.Show("Click ok to play again");
                listBox1.Items.Clear();
                stats.Accuracy = 0;
                stats.Correct = 0;
                stats.Missed = 0;
                stats.Total = 0;
                timer1.Interval = 800;
                correctLabel.Text = "Correct: 0";
                missedLabel.Text = "Missed: 0";
                totalLabel.Text = "Total: 0";
                accuracyLabel.Text = "Accuracy: 0";
                difficultyProgressBar.Value = 0;

                timer1.Start();
            }
        }

  
         private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //als gebruiker een letter indrukt die in de listbox zit
            //dan moet deze letter verdwijnen
            //en het spel moet sneller worden

            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();

                if (timer1.Interval > 400)
                {
                    timer1.Interval -= 10;
                }
                if (timer1.Interval > 250)
                {
                    timer1.Interval -= 8;
                }
                if (timer1.Interval > 100)
                {
                    timer1.Interval -= 2;
                }

                difficultyProgressBar.Value = 800 - timer1.Interval;

                // de letter zat in de listbox, dus stats moeten geupdate worden met true
                stats.Update(true);

            }
            else
            {
                // letter zit niet in listbox, dus stats updaten met false
                stats.Update(false);
            }

            //Update labels in form
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy;


        }
    }
}
