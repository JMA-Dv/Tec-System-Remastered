using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class LocationsReader : EntityReader<Locations>
    {
        public override Locations Find(object id)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<Locations> FindAll()
    {
        throw new NotImplementedException();
    }
}
}
