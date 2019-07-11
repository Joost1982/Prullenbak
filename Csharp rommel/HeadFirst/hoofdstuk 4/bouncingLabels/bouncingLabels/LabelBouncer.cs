using System.Windows.Forms;

namespace bouncingLabels
{
    class LabelBouncer
    {
        public Label MyLabel;
        public bool GoingForward = true;

        public void Move()
        {
            if (MyLabel != null)
            { if (GoingForward == true)
                {
                    MyLabel.Left += 3;
                    if (MyLabel.Left >= MyLabel.Parent.Width - MyLabel.Width)
                    {
                        GoingForward = false;
                    }
                }
            else
                {
                    MyLabel.Left -= 3;
                    if (MyLabel.Left <= 0)
                    {
                        GoingForward = true;
                    }
                }
            }
        }



    }
}
