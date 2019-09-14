using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class SpecialitiesWriter : EntityWriter<Specialties>
    {
        public SpecialitiesWriter(int operation, Specialties entity) : base(operation, entity)
        {
        }

        public SpecialitiesWriter(int operation, Specialties entity, Specialties entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
