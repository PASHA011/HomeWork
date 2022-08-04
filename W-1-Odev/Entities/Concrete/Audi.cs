
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Audi:Car,IEntity
    {
        public Audi() 
        {
            Brand = "Audi";
            Doors = 5;
            Engine = 1;
            Wheel = 4;
        }

    }
}
