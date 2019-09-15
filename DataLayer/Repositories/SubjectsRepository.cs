using DataLayer.Contracts;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    class SubjectsRepository : EntityRepository<Subjects>, IEntityContract<Subjects>
    {
        public readonly string TABLE = "Materias";

        public IEnumerable<Subjects> SelectAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subjects> SelectAllWithId(object id)
        {
            throw new NotImplementedException();
        }

        public Subjects SelectWithId(object id)
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
