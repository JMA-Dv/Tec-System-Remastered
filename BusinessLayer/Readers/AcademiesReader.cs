using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class AcademiesReader : EntityReader<Academies>
    {
        public override Academies Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Academies> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
