﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskRegister.Models
{
    public class User
    {
        public readonly int? user_ID = 1;
        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name ist Erfolgreich")]
        public string name { get; set; }
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ist Erfolgreich")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Geburtsdatum")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Geburtsdatum ist Erfolgreich")]
        [DataType(DataType.Date)]
        [MinAge(18)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Geburtsdatum { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password ist Erfolgreich")]
        [DataType(DataType.Password)]
        [RegularExpression(@".*([@$!%*#?&]{2,})", ErrorMessage = "Bitte Mindest Zwei ziffer")]
        [MinLength(8, ErrorMessage = "Mindesten 8 Zeichen mit mindesten Zwei Ziffern bitte in password")]
        public string Password { get; set; }
        [Display(Name = "Confrim Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password muss abstimmen")]
        public string ConfirmPassword { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}
