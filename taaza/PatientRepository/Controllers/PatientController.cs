using Microsoft.AspNetCore.Mvc;
using PatientRepository.Models;
using PatientRepository.DataAccess;

namespace PatientRepository.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PatientController:ControllerBase
    {
        IPatientsRepository IpatientsRepository;
        public PatientController(IPatientsRepository _IpatientsRepository)
        {
            IpatientsRepository=_IpatientsRepository;
        }
        [HttpPost("Add")]
        public IActionResult AddPatient(Patient patient)
        {
            IpatientsRepository.AddPatientRecord(patient);
            return Ok("Record Added Successfully");
        }
        //[httpDelete]
       /*  public IActionResult DeleteRecord(Patient patient)
        {
            
        } */
    }                                                    
}