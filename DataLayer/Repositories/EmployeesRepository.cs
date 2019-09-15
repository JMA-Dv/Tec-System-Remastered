using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class EmployeesRepository : EntityRepository<Employees>, IEntityContract<Employees>
    {
        public static readonly string TABLE = "Empleados";

        public IEnumerable<Employees> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employees> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Employees SelectWithId(object id)
        {
            throw new NotImplementedException();
        }

        internal override string DefineSelectAll()
        {
            throw new NotImplementedException();
        }

        internal override string DefineSelectAllWithId()
        {
            throw new NotImplementedException();
        }

        internal override string DefineSelectWithId()
        {
            throw new NotImplementedException();
        }
    }
}
