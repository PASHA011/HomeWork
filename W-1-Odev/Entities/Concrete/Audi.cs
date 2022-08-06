
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Audi:Car
    {
      
        public string Brand { get; set ; }
        public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Engine { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Wheel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
