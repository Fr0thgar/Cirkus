using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    class Cirkus
    {
        public int diameter;
        public int seating;
        public int elephants;

        public Princess princess;

        public Clown clown;

        public Cirkus(int diameter, int seating, int elephants)
        {
            this.diameter = diameter;
            this.seating = seating;
            this.elephants = elephants;
        }
    }
}
