using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class CaliicationsValidator : EntityValidator<Califications>
    {
        public CaliicationsValidator(Califications entity) : base(entity)
        {
        }

        protected override void DefinePropertyValidations()
        {
            // Calification
            AddPropertyValidation(() =>
            {
                if (entity.Calification < 0)
                    return false;

                return true;
            });
        }
    }
}
