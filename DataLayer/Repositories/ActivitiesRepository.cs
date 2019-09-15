using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class ActivitiesRepository : EntityRepository<Activities>, IEntityContract<Activities>
    {
        public static readonly string TABLE = "Actividades";

        public IEnumerable<Activities> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activities> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Activities SelectWithId(object id)
        {
            throw new NotImplementedException();
        }

        internal override string DefineSelectAll()
        {
            return $"select * from {TABLE}";
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
