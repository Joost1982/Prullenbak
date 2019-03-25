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
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            MessageBox.Show("Tik zo snel mogelijk de toetsen in die in beeld komen!");
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //zet een random lettertje op de ListBox
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over!");
                
                timer1.Stop();

                DialogResult dialogResult = MessageBox.Show("Nog een keer?", "Game Over!", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                    timer1.Start();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }



            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // als ingedrukte toets in listbox staat, dan verwijderen uit listbox en spel sneller maken
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;

                // correcte toets, dus Update method van Stats callen met true argument
                stats.Update(true);
            }
            else
            {
                //niet correcte toets, dus Update metho van Stats callen met false argument
                stats.Update(false);
            }
            //Update de StatusStrip labels
            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";

            
        }
    }
}
