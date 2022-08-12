using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AudiManager : ICarService
    {
        Audi _audi;
        public AudiManager(Audi audi )
        {
            _audi = audi;
        }
       

        public string GetAll()
        {
            return _audi.Doors+"/"+_audi.Brand+"/"+_audi.Engine+"/"+_audi.Wheel ;
        }
    }
}
