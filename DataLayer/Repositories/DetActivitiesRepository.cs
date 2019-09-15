using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class DetActivitiesRepository : EntityRepository<DetActivities>, IEntityContract<DetActivities>
    {
        public static readonly string TABLE = "DetActividades";

        public IEnumerable<DetActivities> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetActivities> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public DetActivities SelectWithId(object id)
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
