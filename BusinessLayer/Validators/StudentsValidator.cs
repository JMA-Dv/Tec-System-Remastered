using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    class StudentsValidator : EntityValidator<Students>
    {
        public StudentsValidator(Students entity) : base(entity)
        {
        }

        protected override void DefinePropertyValidations()
        {
            // Enrollment
            AddPropertyValidation(() =>
            {
                if (entity.Enrollment <= 0)
                    return false;

                return true;
            });

            // IdPerson
            AddPropertyValidation(() =>
            {
                if (entity.IdPerson <= 0)
                    return false;

                return true;
            });

            // IdCareer
            AddPropertyValidation(() =>
            {
                if (entity.IdCarrer <= 0)
                    return false;

                return true;
            });

            // Tutor
            AddPropertyValidation(() =>
            {
                if (entity.Tutor <= 0)
                    return false;

                return true;
            });

            // IdSpeciality
            AddPropertyValidation(() =>
            {
                if (entity.IdSpeciality <= 0)
                    return false;

                return true;
            });

            // Status
            AddPropertyValidation(() =>
            {
                if (entity.Status <= 0)
                    return false;

                return true;
            });
        }
    }
}
