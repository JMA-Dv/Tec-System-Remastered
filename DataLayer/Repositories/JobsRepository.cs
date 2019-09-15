using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class JobsRepository : EntityRepository<Jobs>, IEntityContract<Jobs>
    {
        public static readonly string TABLE = "Empleos";

        public IEnumerable<Jobs> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jobs> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Jobs SelectWithId(object id)
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
