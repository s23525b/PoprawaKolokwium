using System;
using System.ComponentModel.DataAnnotations;

namespace PoprawaKolokwium.Models
{
    public class Patient
    {
        [Required] 
        public int IdPatient { get; set; }
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        public DateTime Birthdate {get; set;}
    }
}