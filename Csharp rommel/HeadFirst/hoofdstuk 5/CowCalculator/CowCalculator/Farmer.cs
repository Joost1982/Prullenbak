using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowCalculator
{
    class Farmer
    {
        //public int BagsofFeed;  // i.e. field
        //public int BagsofFeed { get; private set; } // ipv field is het nu een property die alleen binnen de class te "setten" is en vanuit wel uitleesbaar ("getten").
        private int BagsofFeed;

        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }

        private int numberOfCows;
        public int NumberOfCows
        {
            get { return numberOfCows; }

            set
            {
                numberOfCows = value;
                BagsofFeed = numberOfCows * feedMultiplier;
            }
        }

        //constructor (hebben geen 'void', 'int', 'string' etc. omdat ze geen value returnen)
        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

    }
}
