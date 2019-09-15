using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class CareersRepository : EntityRepository<Careers>, IEntityContract<Careers>
    {
        public static readonly string TABLE = "Carreras";

        public IEnumerable<Careers> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Careers> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Careers SelectWithId(object id)
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
