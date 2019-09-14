using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class SubjectsWriter : EntityWriter<Subjects>
    {
        public SubjectsWriter(int operation, Subjects entity) : base(operation, entity)
        {
        }

        public SubjectsWriter(int operation, Subjects entity, Subjects entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
