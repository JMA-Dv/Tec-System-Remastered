using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class StreetsReader : EntityReader<Streets>
    {
        public override Streets Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Streets> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
