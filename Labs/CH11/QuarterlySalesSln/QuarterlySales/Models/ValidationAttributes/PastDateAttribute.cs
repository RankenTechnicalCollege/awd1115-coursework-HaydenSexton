using System;
using System.ComponentModel.DataAnnotations;

namespace QuarterlySales.Models.ValidationAttributes
{
    public class PastDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime dt) return dt < DateTime.Now;
            return false;
        }
    }

    public class CompanyFoundedAttribute : ValidationAttribute
    {
        private readonly DateTime _minDate;
        public CompanyFoundedAttribute(int year, int month, int day)
        {
            _minDate = new DateTime(year, month, day);
        }
        public override bool IsValid(object value)
        {
            if (value is DateTime dt) return dt >= _minDate;
            return false;
        }
    }
}
