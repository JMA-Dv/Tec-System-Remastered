using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Contracts
{
    interface IEntityContract<Entity>
    {
        IEnumerable<Entity> SelectAll();
        IEnumerable<Entity> SelectAllWithId(object id);
        Entity SelectWithId(object id);
    }
}
