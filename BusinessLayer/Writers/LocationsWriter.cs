using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class LocationsWriter : EntityWriter<Locations>
    {
        public LocationsWriter(int operation, Locations entity) : base(operation, entity)
        {
        }

        public LocationsWriter(int operation, Locations entity, Locations entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
