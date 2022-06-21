using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoprawaKolokwium.Models;
using Microsoft.Data.SqlClient;

namespace PoprawaKolokwium.Services
{
 public class MedicamentsService : IMedicaments
    {
        public IEnumerable<Medicament> GetMedicament(int IdMedicament){

            var res = new List<Medicament>();
            using (
                var con =
                    new SqlConnection("Data Source=db-mssql;Initial Catalog=2019SBD;Integrated Security=True")
            )
            {
                var com =
                    new SqlCommand($"SELECT Medicamen, Name, Description, Type, Prescription.Date FROM Medicament" 
                                       + "INNER JOIN PrescriptionMedicament ON Medicament.IdMedicament = PrescriptionMedicament.IdMedicament"
                                       + "INNER JOIN Prescription ON PrescriptionMedicament.IdPrescription = Prescription.IdPrescription "
                                       + "ORDER BY [Date] DESC",con);
                con.Open();
                var dr = com.ExecuteReader();
                while (dr.Read())
                {
                    res
                        .Add(new Medicament() {
                            IdMedicament = int.Parse(dr["IdMedicament"].ToString()),
                            Name = dr["[Name]"].ToString(),
                            Description = dr["[Description]"].ToString(),
                            Type = dr["Type"].ToString(),
                            PrescriptionMedicament = dr["PrescriptionMedicament.IdPrescription"].ToString()
                        });
                }
            }
            return res;
        }


     

        public IEnumerable<Patient> GetPatients(int idPatient)
        {
            throw new NotImplementedException();
        }
        
        public ActionResult<Patient> DeletePatient(int IdPatient)
        {
            using (
                var con =
                new SqlConnection("Data Source=db-mssql;Initial Catalog=2019SBD;Integrated Security=True")
            )
            {   
                var check = new SqlCommand($"SELECT COUNT(*) FROM Prescription WHERE IdPrescription = {IdPatient}",con);
                var count = Convert.ToInt32(check.ExecuteScalar());
                if (count == 0)
                {
                    var com =new SqlCommand($"DELETE FROM Patient "
                                            + "(WHERE Patient.IdPatient={IdPatient}");
                }

                return null;
            }
        }

      
    }
}