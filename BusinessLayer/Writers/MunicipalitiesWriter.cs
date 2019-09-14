using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class MunicipalitiesWriter : EntityWriter<Municipalities>
    {
        public MunicipalitiesWriter(int operation, Municipalities entity) : base(operation, entity)
        {
        }

        public MunicipalitiesWriter(int operation, Municipalities entity, Municipalities entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
