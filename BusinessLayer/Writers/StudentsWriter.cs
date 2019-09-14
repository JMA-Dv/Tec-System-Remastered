using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class StudentsWriter : EntityWriter<Students>
    {
        public StudentsWriter(int operation, Students entity) : base(operation, entity)
        {
        }

        public StudentsWriter(int operation, Students entity, Students entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
