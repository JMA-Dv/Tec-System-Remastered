using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class GroupsWriter : EntityWriter<Groups>
    {
        public GroupsWriter(int operation, Groups entity) : base(operation, entity)
        {
        }

        public GroupsWriter(int operation, Groups entity, Groups entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
