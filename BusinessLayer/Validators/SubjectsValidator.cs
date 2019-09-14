using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class SubjectsValidator : EntityValidator<Subjects>
    {
        public SubjectsValidator(Subjects entity) : base(entity)
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

            // TheoreticalHours
            AddPropertyValidation(() =>
            {
                if (entity.TheoricalHours <= 0)
                    return false;

                return true;
            });

            // PracticalHours
            AddPropertyValidation(() =>
            {
                if (entity.PracticalHours <= 0)
                    return false;

                return true;
            });

            // Credits
            AddPropertyValidation(() =>
            {
                if (entity.Credits < 0)
                    return false;

                return true;
            });

            // Career
            AddPropertyValidation(() =>
            {
                if (entity.Career <= 0)
                    return false;

                return true;
            });
        }
    }
}
