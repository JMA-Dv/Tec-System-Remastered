using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class ProfessorsValidator : EntityValidator<Professors>
    {
        public ProfessorsValidator(Professors entity) : base(entity)
        {
        }

        protected override void DefinePropertyValidations()
        {
            AddPropertyValidation(() =>
            {
                // IdProfessor
                if (IsNullEmptyOrWhitespace(entity.IdProfessor))
                    return false;

                return true;
            });
        }
    }
}
