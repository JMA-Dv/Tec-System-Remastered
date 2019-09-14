using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class CareersValidator : EntityValidator<Careers>
    {
        public CareersValidator(Careers entity) : base(entity)
        {
        }

        protected override void DefinePropertyValidations()
        {
            // Coordinator
            AddPropertyValidation(() =>
            {
                if (entity.Coordinator <= 0)
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
