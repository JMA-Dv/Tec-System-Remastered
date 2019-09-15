using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class StudentsRepository : EntityRepository<Students>, IEntityContract<Students>
    {
        public static readonly string TABLE = "Alumnos";

        public IEnumerable<Students> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Students> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Students SelectWithId(object id)
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
