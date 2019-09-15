using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class CalificationsRepository : EntityRepository<Califications>, IEntityContract<Califications>
    {
        public static readonly string TABLE = "Calificaciones";

        public IEnumerable<Califications> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Califications> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Califications SelectWithId(object id)
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
