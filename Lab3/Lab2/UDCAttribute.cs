using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Lab2
{
    public class UDCAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var regex = new Regex(@"(\d{3})\.(\d{3})");
            return regex.IsMatch(value as string) == true;
        }
    }
}
