using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class GroupsReader : EntityReader<Groups>
    {
        public override Groups Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Groups> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
