using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LoginWpfTest.Validations
{
    public class PasswordValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex("^[A_Za-z0-9!@#$%^&]{5,10}$");
            if (!regex.IsMatch(value.ToString()))
            {
                return new ValidationResult(false, "Please a valid Password");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }

     
    }
}
