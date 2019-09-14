using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class StreetsWriter : EntityWriter<Streets>
    {
        public StreetsWriter(int operation, Streets entity) : base(operation, entity)
        {
        }

        public StreetsWriter(int operation, Streets entity, Streets entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
