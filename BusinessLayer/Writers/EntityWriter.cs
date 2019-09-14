using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Writers
{
    abstract class EntityWriter<Entity>
    {
        protected int operation;
        protected Entity entity;
        protected Entity entityUpdate;

        protected EntityWriter(int operation, Entity entity)
        {
            this.operation = operation;
            this.entity = entity;
        }

        protected EntityWriter(int operation, Entity entity, Entity entityUpdate)
        {
            this.operation = operation;
            this.entity = entity;
            this.entityUpdate = entityUpdate;
        }

        public abstract bool ExecuteOperation();
    }
}
