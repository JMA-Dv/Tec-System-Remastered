using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class ActivitiesValidator : EntityValidator<Activities>
    {
        public ActivitiesValidator(Activities entity) : base(entity)
        {
        }

        protected override void DefinePropertyValidations()
        {
            // Name
            AddPropertyValidation(() =>
            {
                if (IsNullEmptyOrWhitespace(entity.Name))
                    return false;

                if (IsNullEmptyOrWhitespace(entity.Description))
                    return false;

                if (IsNullEmptyOrWhitespace(entity.Topic))
                    return false;

                return true;
            });
        }
    }
}
