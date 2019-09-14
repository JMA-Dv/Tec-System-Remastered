using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class SpecialitiesReader : EntityReader<Specialties>
    {
        public override Specialties Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Specialties> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
