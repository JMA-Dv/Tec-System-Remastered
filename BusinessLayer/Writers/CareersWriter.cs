using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class CareersWriter : EntityWriter<Careers>
    {
        public CareersWriter(int operation, Careers entity) : base(operation, entity)
        {
        }

        public CareersWriter(int operation, Careers entity, Careers entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
