using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoprawaKolokwium.Models;
using PoprawaKolokwium.Services;

namespace PoprawaKolokwium.Controllers
{
    [ApiController]
    [Route("/api/medicaments")]
    public class MedicamentsController : ControllerBase
    {
        private readonly IMedicaments _service;
        public MedicamentsController(IMedicaments service)
        {
            _service = service;
        }

        [HttpGet("{idMedicament}")]
        public async Task<IActionResult> GetMedicament(int idMedicament){
            // return _service.GetMedicament(idMedicament)
            // .Include(e => e.PrescriptionMedicament)
            // .FirstOrDefaultAsync(e => e.IdMedicament == idMedicament);
            try
            {
                var medicament =  _service.GetMedicament(idMedicament);

                if (medicament == null) return NotFound();

                return await Task.FromResult<IActionResult>(Ok(_service.GetMedicament(idMedicament)));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving Medicament from the database");
            }

        }
        
    }
}