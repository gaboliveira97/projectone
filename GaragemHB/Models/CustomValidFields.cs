using GaragemHB.Enums;
using GaragemHB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace GaragemHB.Enums
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB dB = new ContextDB();

        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaEmail: { return ValidaEmail(value, validationContext.DisplayName); }
                    case ValidFields.ValidaPlaca: { return ValidaPlaca(value, validationContext.DisplayName); }
                    default: { } break;
                }
            }

            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatorio.");
        }
        private ValidationResult ValidaEmail(object value, string displayField)
        {
            bool result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo {displayField} é invalido.");
        }

        private ValidationResult ValidaPlaca(object value, string displayField)
        {
            var result = Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}\-\d{4}$") ||
                Regex.IsMatch(value.ToString(), @"^[a-zA-Z]{3}\d{4}$") ||
                Regex.IsMatch(value.ToString(), @" ^[a-zA-Z]{3}\d{1}[a-zA-Z]{2}\d{1}$") ||
                Regex.IsMatch(value.ToString(), @" ^[a-zA-Z]{3}\d{1}[a-zA-Z]{1}\d{2}$");

            var exist = dB.Locacao.Any(x => x.Placa == value.ToString());

            //placa Default para bicicleta ou patinete
            if (value.ToString() == "XXX-0800")
                exist = false;

            if (result && !exist)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult($"Placa {displayField} é invalida, insira uma placa valida!");

        }
    }
}