using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class MunicipalitiesReader : EntityReader<Municipalities>
    {
        public override Municipalities Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Municipalities> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
