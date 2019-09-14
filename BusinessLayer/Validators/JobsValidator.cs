using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class JobsValidator : EntityValidator<Jobs>
    {
        public JobsValidator(Jobs entity) : base(entity)
        {
        }

        protected override void DefinePropertyValidations()
        {
            // Position
            AddPropertyValidation(() =>
            {
                if (IsNullEmptyOrWhitespace(entity.Position))
                    return false;

                return true;
            });
        }
    }
}
