using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiControlStock.Validations
{
    public class LineaProductoCorrectaAtributte:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string valor = value as string;
            if (valor == "H")
            {
                return ValidationResult.Success;
            }
            if (valor == "S")
            {
                return ValidationResult.Success;
            } 
            if(valor != "H" && valor !="S")
            {
                return new ValidationResult("Solo se aceptan valores H y S");
            }
            return ValidationResult.Success;
        }
    }
}
