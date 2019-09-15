using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class SpecialitiesRepository : EntityRepository<Specialties>, IEntityContract<Specialties>
    {
        public static readonly string TABLE = "Especialidades";

        public IEnumerable<Specialties> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Specialties> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Specialties SelectWithId(object id)
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
