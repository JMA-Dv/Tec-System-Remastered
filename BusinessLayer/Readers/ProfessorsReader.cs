using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class ProfessorsReader : EntityReader<Professors>
    {
        public override Professors Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Professors> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
