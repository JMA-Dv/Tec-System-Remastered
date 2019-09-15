using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class LocationTypesRepository : EntityRepository<LocationTypes>, IEntityContract<LocationTypes>
    {
        public static readonly string TABLE = "TiposLocalidad ";

        public IEnumerable<LocationTypes> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LocationTypes> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public LocationTypes SelectWithId(object id)
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
