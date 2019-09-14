using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class PersonReader : EntityReader<Persons>
    {
        public override Persons Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Persons> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
