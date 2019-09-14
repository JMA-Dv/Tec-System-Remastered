using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class AbsencesWriter : EntityWriter<Absences>
    {
        public AbsencesWriter(int operation, Absences entity) : base(operation, entity)
        {
        }

        public AbsencesWriter(int operation, Absences entity, Absences entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
