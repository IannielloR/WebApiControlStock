using System.ComponentModel.DataAnnotations;
using System;

namespace WebApiControlStock.Validations
{
    public class MayorCeroAtributte : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            double valor = (Double)value;
            if (valor > 0)
            {
                return ValidationResult.Success;
            }
            if (valor <= 0)
            {
                return new ValidationResult("El valor debe ser mayor que cero");
            }
            return ValidationResult.Success;
        }
    }
}
