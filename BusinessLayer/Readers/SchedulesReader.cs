using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class SchedulesReader : EntityReader<Schedules>
    {
        public override Schedules Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Schedules> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
