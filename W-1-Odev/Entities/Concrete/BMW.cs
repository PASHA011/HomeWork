using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BMW:Car , IEntity
    {
        public BMW()
        {
            Brand = "BMW";
            Doors = 2;
            Engine = 2;
            Wheel = 6;
        } 

    }
}
