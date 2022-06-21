using System;
using System.ComponentModel.DataAnnotations;

namespace PoprawaKolokwium.Models
{
    public class Prescription
    {
        [Required] public int IdPrescription { get; set; }
        [Required] public DateTime Date {get; set;}
        [Required] public string DueDate {get; set;}
    
        
    }
}