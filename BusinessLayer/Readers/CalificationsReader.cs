using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class CalificationsReader : EntityReader<Califications>
    {
        public override Califications Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Califications> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
