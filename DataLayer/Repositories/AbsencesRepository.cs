using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class AbsencesRepository : EntityRepository<Absences>, IEntityContract<Absences>
    {
        public static readonly string TABLE = "Inasistencias";

        public IEnumerable<Absences> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Absences> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Absences SelectWithId(object id)
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
