using Microsoft.EntityFrameworkCore;
using PatientRepository.Models;

namespace PatientRepository.DataAccess
{
    public class PatientsDbContext:DbContext
    {
       public PatientsDbContext(DbContextOptions dbContextOptions):base (dbContextOptions)
       {
           
       } 
       public DbSet<Patient> patients{get;set;} //For Local MANIPULATION.
    }
}