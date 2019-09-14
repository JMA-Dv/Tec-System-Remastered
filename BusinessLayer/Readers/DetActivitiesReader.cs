using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class DetActivitiesReader : EntityReader<DetActivities>
    {
        public override DetActivities Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<DetActivities> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
