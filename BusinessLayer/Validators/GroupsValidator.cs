using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class GroupsValidator : EntityValidator<Groups>
    {
        public GroupsValidator(Groups entity) : base(entity)
        {
        }

        protected override void DefinePropertyValidations()
        {
            // Professor
            AddPropertyValidation(() =>
            {
                if (IsNullEmptyOrWhitespace(entity.Professor))
                    return false;

                return true;
            });
        }
    }
}
