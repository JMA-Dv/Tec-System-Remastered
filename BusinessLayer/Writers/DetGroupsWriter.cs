using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class DetGroupsWriter : EntityWriter<DetGroups>
    {
        public DetGroupsWriter(int operation, DetGroups entity) : base(operation, entity)
        {
        }

        public DetGroupsWriter(int operation, DetGroups entity, DetGroups entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
