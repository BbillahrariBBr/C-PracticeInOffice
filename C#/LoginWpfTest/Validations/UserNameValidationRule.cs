using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace LoginWpfTest.Validations
{
   public class UserNameValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex regex = new Regex("^[A_Za-z0-9!@#$%^&]{2,25}$");
            string input = value.ToString();
            if (!regex.IsMatch(input))
            {
                if(input.Length < 2 && input.Length >25)
                {
                    return new ValidationResult(false, "UserName have at least 2 char and max 25 char");
                }
                return new ValidationResult(false, "Please a valid User Name");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }

    
}
