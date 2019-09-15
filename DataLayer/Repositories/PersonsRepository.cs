using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class PersonsRepository : EntityRepository<Persons>, IEntityContract<Persons>
    {
        public static readonly string TABLE = "Personas";

        public IEnumerable<Persons> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persons> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Persons SelectWithId(object id)
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
