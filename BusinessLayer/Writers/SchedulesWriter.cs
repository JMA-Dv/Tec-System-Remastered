using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class SchedulesWriter : EntityWriter<Schedules>
    {
        public SchedulesWriter(int operation, Schedules entity) : base(operation, entity)
        {
        }

        public SchedulesWriter(int operation, Schedules entity, Schedules entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
