using System.ComponentModel.DataAnnotations;

namespace CommeChezSwaMylanCoudeville.Models
{
    public class IsGreaterThan : ValidationAttribute
    {
        public int MinValue { get; set; }
        public IsGreaterThan(int minValue)
        {
            MinValue = minValue;
        }
        public override bool IsValid(object value)
        {
            int toValidate = (int)value;
            return (toValidate > MinValue);
        }
    }
}
