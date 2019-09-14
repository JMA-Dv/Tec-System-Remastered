using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class JobsReader : EntityReader<Jobs>
    {
        public override Jobs Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Jobs> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
