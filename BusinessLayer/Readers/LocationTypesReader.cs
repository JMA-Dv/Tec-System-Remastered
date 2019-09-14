using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class LocationTypesReader : EntityReader<LocationTypes>
    {
        public override LocationTypes Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<LocationTypes> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
