using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class AcademiesRepository : EntityRepository<Academies>, IEntityContract<Academies>
    {
        public static readonly string TABLE = "Academias";

        public IEnumerable<Academies> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Academies> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Academies SelectWithId(object id)
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
