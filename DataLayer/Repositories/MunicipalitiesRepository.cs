using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class MunicipalitiesRepository : EntityRepository<Municipalities>, IEntityContract<Municipalities>
    {
        public static readonly string TABLE = "Municipios";

        public IEnumerable<Municipalities> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Municipalities> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Municipalities SelectWithId(object id)
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
