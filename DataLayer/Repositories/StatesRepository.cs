using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class StatesRepository : EntityRepository<States>, IEntityContract<States>
    {
        public static readonly string TABLE = "Estados";

        public IEnumerable<States> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<States> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public States SelectWithId(object id)
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
