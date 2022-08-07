using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface ICar
    {
        public void GetAll()
        {
            Console.WriteLine("brand : " + Brand + " , doors : " + Doors +
                " , engine : " + Engine + " , wheel : " + Wheel);
        }
        public void Creat();


        public string Brand { get; }
        public int Doors { get; }
        public int Engine { get; }
        public int Wheel { get; }
    }
}
