using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class CalificationsWriter : EntityWriter<Califications>
    {
        public CalificationsWriter(int operation, Califications entity) : base(operation, entity)
        {
        }

        public CalificationsWriter(int operation, Califications entity, Califications entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
