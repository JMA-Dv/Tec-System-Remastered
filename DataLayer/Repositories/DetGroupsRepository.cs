using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class DetGroupsRepository : EntityRepository<DetGroups>, IEntityContract<DetGroups>
    {
        public static readonly string TABLE = "DetGrupos";

        public IEnumerable<DetGroups> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetGroups> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public DetGroups SelectWithId(object id)
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
