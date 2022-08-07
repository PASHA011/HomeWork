using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mercedes : ICar
    {
        public string Brand { get { return "Mercedes"; } }
        public int Doors { get { return 2; } }
        public int Engine { get { return 2; } }
        public int Wheel { get { return 8; } }

        public void Creat()
        {
            Console.WriteLine("");
        }
    }
}
