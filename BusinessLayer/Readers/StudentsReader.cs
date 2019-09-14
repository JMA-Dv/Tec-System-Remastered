using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class StudentsReader : EntityReader<Students>
    {
        public override Students Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Students> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
