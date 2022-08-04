using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Mercedes:Car,IEntity
    {
        public Mercedes()
        {
            Brand = "Merceds";
            Doors = 2;
            Engine = 2;
            Wheel = 8;
        }

    }
}
