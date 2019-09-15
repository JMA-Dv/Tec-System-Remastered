using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class LocationsRepository : EntityRepository<Locations>, IEntityContract<Locations>
    {
        public static readonly string TABLE = "Localidades";

        public IEnumerable<Locations> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Locations> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Locations SelectWithId(object id)
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
