using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BMW : ICar
    {
        public string Brand { get { return "BMW"; } }
        public int Doors { get { return 2; } }
        public int Engine { get { return 2; } }
        public int Wheel { get { return 6; } }

        public void Creat()
        {
            Console.WriteLine("new car has been created (BMW)");

        }
    }
}
