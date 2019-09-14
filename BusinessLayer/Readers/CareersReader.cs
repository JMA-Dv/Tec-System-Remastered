using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class CareersReader : EntityReader<Careers>
    {
        public override Careers Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Careers> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
