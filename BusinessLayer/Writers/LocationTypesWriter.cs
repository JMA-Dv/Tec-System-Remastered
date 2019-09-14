using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class LocationTypesWriter : EntityWriter<LocationTypes>
    {
        public LocationTypesWriter(int operation, LocationTypes entity) : base(operation, entity)
        {
        }

        public LocationTypesWriter(int operation, LocationTypes entity, LocationTypes entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
