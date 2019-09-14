using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class SubjectsReader : EntityReader<Subjects>
    {
        public override Subjects Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Subjects> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
