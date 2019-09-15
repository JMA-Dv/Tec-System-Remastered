using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class GroupsRepository : EntityRepository<Groups>, IEntityContract<Groups>
    {
        public static readonly string TABLE = "Grupos";

        public IEnumerable<Groups> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Groups> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Groups SelectWithId(object id)
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
