using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class StatesWriter : EntityWriter<States>
    {
        public StatesWriter(int operation, States entity) : base(operation, entity)
        {
        }

        public StatesWriter(int operation, States entity, States entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
