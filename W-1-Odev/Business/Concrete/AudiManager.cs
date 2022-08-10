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
        List<Audi> _audi;
        public AudiManager(List<Audi> audi )
        {
            _audi = audi;
        }
        public void Creat(ICar car)
        {
       
        }

        public List<Audi> GetAll()
        {
            return _audi ;
        }
    }
}
