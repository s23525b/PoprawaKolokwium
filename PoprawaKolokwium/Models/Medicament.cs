using System;
using System.ComponentModel.DataAnnotations;

namespace PoprawaKolokwium.Models
{
    public class Medicament
    {
        [Required] 
        public int IdMedicament { get; set; }
        [Required]
        public string Name {get; set;}
        [Required]
        public string Description {get; set;}

        [Required] public string Type { get; set; }
        [Required] public string PrescriptionMedicament { get; set; }
        
            // [Required] 
        // public int IdPrescription { get; set; }
        // [Required]
        // public DateTime Date {get; set;}
        // [Required]
        // public string DueDate {get; set;}
    }
}