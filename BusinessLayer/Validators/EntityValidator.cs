using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    abstract class EntityValidator<Entity>
    {
        protected Entity entity;
        public delegate bool ValidateProperty();
        private List<ValidateProperty> propertyValidations = new List<ValidateProperty>();

        protected EntityValidator(Entity entity)
        {
            this.entity = entity;
            DefinePropertyValidations();
        }

        protected abstract void DefinePropertyValidations();

        protected void AddPropertyValidation(ValidateProperty validation)
        {
            propertyValidations.Add(validation);
        }

        protected bool IsNullEmptyOrWhitespace(string property)
        {
            if (property == null)
                return true;

            if (String.IsNullOrEmpty(property))
                return true;

            if (String.IsNullOrWhiteSpace(property))
                return true;

            return false;
        }

        public bool Validate()
        {
            foreach (ValidateProperty validateProperty in propertyValidations)
                if (!validateProperty.Invoke())
                    return false;

            return true;
        }
    }
}
