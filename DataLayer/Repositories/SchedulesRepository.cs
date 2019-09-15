using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class SchedulesRepository : EntityRepository<Schedules>, IEntityContract<Schedules>
    {
        public static readonly string TABLE = "Horarios";

        public IEnumerable<Schedules> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Schedules> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Schedules SelectWithId(object id)
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
