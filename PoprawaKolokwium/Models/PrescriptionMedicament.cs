using System.ComponentModel.DataAnnotations;

namespace PoprawaKolokwium.Models
{
    public class PrescriptionMedicament
    {
        [Required] public int IdPrescription { get; set; }
        [Required] public int IdMedicament {get; set;}
        [Required] public int Dose {get; set;}
        [Required] public string Details { get; set; }
        [Required] public Prescription Prescription { get; set; }
        [Required] public Medicament Medicament { get; set; }
    }
}