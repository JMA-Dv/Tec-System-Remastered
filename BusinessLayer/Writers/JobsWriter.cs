using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class JobsWriter : EntityWriter<Jobs>
    {
        public JobsWriter(int operation, Jobs entity) : base(operation, entity)
        {
        }

        public JobsWriter(int operation, Jobs entity, Jobs entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
