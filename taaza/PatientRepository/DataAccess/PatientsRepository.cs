using System.Collections.Generic;
using PatientRepository.Models;

namespace PatientRepository.DataAccess
{
    public class PatientsRepository : IPatientsRepository
    {
        PatientsDbContext patientsDbContext;
        public PatientsRepository(PatientsDbContext _patientsDbContext)
        {
            patientsDbContext=_patientsDbContext;
        }
        void IPatientsRepository.AddPatientRecord(Patient patient)
        {
            patientsDbContext.Add(patient);
            patientsDbContext.SaveChanges();// Commit and save record in db
        }

        void IPatientsRepository.DeletePatientRecord(string Id)
        {
           /* var recordtodelete=ctr=>ctr.id=Id;
           if(recordtodelete!=null)
           {
               patientsDbContext.remove(recordtodelete);
           } */
        }

        IEnumerable<Patient> IPatientsRepository.GetPatientRecords()
        {
            throw new System.NotImplementedException();
        }

        Patient IPatientsRepository.GetPatientSingleRecord(string id)
        {
            throw new System.NotImplementedException();
        }

        void IPatientsRepository.UpdatePatientRecord(Patient patient)
        {
            throw new System.NotImplementedException();
        }
    }
}