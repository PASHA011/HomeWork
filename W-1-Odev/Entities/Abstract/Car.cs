using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Car
    {
        public void GetAll()
        {
            Console.WriteLine("brand : " + Brand + " , doors : " + Doors + " , engine : " + Engine + " , wheel : " + Wheel);
        }
        
        public string Brand { get; set; }
        public int Doors { get; set; }
        public int Engine { get; set; }
        public int Wheel { get; set; }
    }
}
