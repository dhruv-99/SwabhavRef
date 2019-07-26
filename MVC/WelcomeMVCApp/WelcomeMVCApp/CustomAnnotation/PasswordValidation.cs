using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WelcomeMVCApp.CustomAnnotation
{
    public class PasswordValidation : ValidationAttribute
    {
        private readonly int _minWords;
        public PasswordValidation(int minWords)  
            : base("{0} length should be greater than 8.")  
        {
            _minWords = minWords;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //if (value == null) return ValidationResult.Success;
            var textValue = value.ToString();
            if (textValue.Split(' ').Length >= _minWords) return ValidationResult.Success;
            var errorMessage = FormatErrorMessage((validationContext.DisplayName));
            return new ValidationResult(errorMessage);
        }
    }
}