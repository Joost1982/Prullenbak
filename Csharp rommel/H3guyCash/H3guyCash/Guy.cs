using System.Windows.Forms;

namespace H3guyCash
{
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            } else
            {
                MessageBox.Show(
                    "Ik heb niet genoeg geld om je  " + amount + " te geven " + Name);
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            } else
            {
                MessageBox.Show(amount + " is niet een bedrag wat ik aanneem " + Name);
                return 0;
            }
        }
    }
}
