using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class PersonsValidator : EntityValidator<Persons>
    {
        public PersonsValidator(Persons entity) : base(entity)
        {
        }

        protected override void DefinePropertyValidations()
        {
            // Names
            AddPropertyValidation(() =>
            {
                if (IsNullEmptyOrWhitespace(entity.Names))
                    return false;

                return true;
            });

            // FatherLastName
            AddPropertyValidation(() =>
            {
                if (IsNullEmptyOrWhitespace(entity.FatherLastName))
                    return false;

                return true;
            });

            // Mother Last Name
            AddPropertyValidation(() =>
            {
                if (IsNullEmptyOrWhitespace(entity.MatherLastName))
                    return false;

                return true;
            });
        }
    }
}
