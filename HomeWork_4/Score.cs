using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite
{
    class Score
    {
        int score;

        public int _Score   
        {
            get { return score; }
            set
            {
                if (value >= 0 && value <= 12)
                {
                    score = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }
    }
}
