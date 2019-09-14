using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class AcademiesValidator : EntityValidator<Academies>
    {
        public AcademiesValidator(Academies entity) : base(entity)
        {
        }

        protected override void DefinePropertyValidations()
        {
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
