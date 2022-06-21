using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoprawaKolokwium.Models;

namespace PoprawaKolokwium.Services
{
    public interface IMedicaments
    {
        public IEnumerable<Medicament> GetMedicament(int IdMedicament);
        public IEnumerable<Patient> GetPatients(int IdPatient);
        ActionResult<Patient> DeletePatient(int idPatient);
    }
}