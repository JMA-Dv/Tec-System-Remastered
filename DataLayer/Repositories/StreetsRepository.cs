using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class StreetsRepository : EntityRepository<Streets>, IEntityContract<Streets>
    {
        public static readonly string TABLE = "Calles";

        public IEnumerable<Streets> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Streets> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Streets SelectWithId(object id)
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
