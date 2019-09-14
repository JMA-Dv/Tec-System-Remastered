using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class PersonWriter : EntityWriter<Persons>
    {
        public PersonWriter(int operation, Persons entity) : base(operation, entity)
        {
        }

        public PersonWriter(int operation, Persons entity, Persons entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
