using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskRegister.Models
{
   
        public class MinAge : ValidationAttribute
        {
            private int _Limit;
            public MinAge(int Limit)
            { // The constructor which we use in modal.
                this._Limit = Limit;
            }
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                DateTime bday = DateTime.Parse(value.ToString());
                DateTime today = DateTime.Today;
                int age = today.Year - bday.Year;
                if (bday > today.AddYears(-age))
                {
                    age--;
                }
                if (age < _Limit)
                {
                    var result = new ValidationResult("Leider Sind Sie noch nicht 18 Jahre alt");
                    return result;
                }
                return null;
            }
        }
    }
