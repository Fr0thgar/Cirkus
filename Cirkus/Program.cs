using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    class Program
    {
        static void Main(string[] args)
        {
            Cirkus cirkusTwats = new Cirkus(25, 500,5 );
            Clown c = new Clown(52, "Green", "Mr Giggles");
            cirkusTwats.clown = c;

            cirkusTwats.princess = new Princess("Princess Tinkels", "Yellow", "Red");
        }
    }
}
