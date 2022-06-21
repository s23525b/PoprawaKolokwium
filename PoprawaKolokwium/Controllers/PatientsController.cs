using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoprawaKolokwium.Models;
using PoprawaKolokwium.Services;

namespace PoprawaKolokwium.Controllers
{
 

        [ApiController]
        [Route("/api/patients")]
        public class PatientsController : ControllerBase
        {
            private readonly IMedicaments _service;

            public PatientsController(IMedicaments service)
            {
                _service = service;
            }
            [HttpDelete("{idPatient}")]
            public async Task<ActionResult<Patient>> DeletePatients(int idPatient)
            {
                try
                {
                    var patientToDelete =  _service.GetPatients(idPatient);

                    if (patientToDelete == null)
                    {
                        return NotFound($"Employee with Id = {idPatient} not found");
                    }

                    return  _service.DeletePatient(idPatient);
                }
                catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error deleting Patient");
                }
            }

        }
    }