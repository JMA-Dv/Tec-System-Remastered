using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class StatesReader : EntityReader<States>
    {
        public override States Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<States> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
