using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class DetGroupsReader : EntityReader<DetGroups>
    {
        public override DetGroups Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<DetGroups> FindAll()
        {
            IEnumerable<DetGroups> x = new List<DetGroups>();
            throw new NotImplementedException();
        }
    }
}
