using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class ProfessorsWriter : EntityWriter<Professors>
    {
        public ProfessorsWriter(int operation, Professors entity) : base(operation, entity)
        {
        }

        public ProfessorsWriter(int operation, Professors entity, Professors entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
