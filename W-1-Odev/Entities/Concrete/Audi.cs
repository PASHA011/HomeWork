
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Audi : ICar
    {

        public string Brand { get { return "Audi"; } }
        public int Doors { get { return 5; } }
        public int Engine { get { return 1; } }
        public int Wheel { get { return 4; } }

        public void Creat()
        {
            Console.WriteLine("new car has been created(Audi) ");
        }

      public void Getall()
        {
            //return Brand;
        }
    }
}
