using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class DetActivitiesWriter : EntityWriter<DetActivities>
    {
        public DetActivitiesWriter(int operation, DetActivities entity) : base(operation, entity)
        {
        }

        public DetActivitiesWriter(int operation, DetActivities entity, DetActivities entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
