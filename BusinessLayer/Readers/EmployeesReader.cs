using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    class EmployeesReader : EntityReader<Employees>
    {
        public override Employees Find(object id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Employees> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
