using System.ComponentModel.DataAnnotations;
using System;

namespace WebApiControlStock.Validations
{
    public class MayorCeroAtributte : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            double precio = (double)value;

            if (precio <= 0)
            {
                return new ValidationResult("Solo se aceptan precios mayores a cero");
            }
            return ValidationResult.Success;

        }
    }
}
