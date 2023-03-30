using System.ComponentModel.DataAnnotations;

namespace CommeChezSwaMylanCoudeville.Models
{
    public class ExpectedValue : ValidationAttribute
    {
        public bool Checked { get; set; } = true;
        public ExpectedValue(bool isChecked)
        {
            Checked = isChecked;
        }
        public override bool IsValid(object value)
        {
            bool toValidate = (bool)value;
            return (toValidate == Checked);
        }
    }
}
