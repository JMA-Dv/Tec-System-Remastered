using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class ProfessorsRepository : EntityRepository<Professors>, IEntityContract<Professors>
    {
        public static readonly string TABLE = "Profesores";

        public IEnumerable<Professors> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Professors> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Professors SelectWithId(object id)
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
