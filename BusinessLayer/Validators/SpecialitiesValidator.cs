using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class SpecialitiesValidator : EntityValidator<Specialties>
    {
        public SpecialitiesValidator(Specialties entity) : base(entity)
        {
        }

        protected override void DefinePropertyValidations()
        {
            // Career
            AddPropertyValidation(() =>
            {
                if (entity.Career <= 0)
                    return false;

                return true;
            });

            // Name
            AddPropertyValidation(() =>
            {
                if (IsNullEmptyOrWhitespace(entity.Name))
                    return false;

                return true;
            });
        }
    }
}
