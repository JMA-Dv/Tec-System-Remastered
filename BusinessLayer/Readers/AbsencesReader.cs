using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class AbsencesReader : EntityReader<Absences>
    {
        public override Absences Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Absences> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
