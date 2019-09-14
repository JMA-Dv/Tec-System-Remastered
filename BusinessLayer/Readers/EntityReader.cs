using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Readers
{
    abstract class EntityReader<Entity>
    {
        public abstract Entity Find(object id);
        public abstract IEnumerable<Entity> FindAll();
    }
}
