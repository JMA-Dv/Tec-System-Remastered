using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    class EmployeesWriter : EntityWriter<Employees>
    {
        public EmployeesWriter(int operation, Employees entity) : base(operation, entity)
        {
        }

        public EmployeesWriter(int operation, Employees entity, Employees entityUpdate) : base(operation, entity, entityUpdate)
        {
        }

        public override bool ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
