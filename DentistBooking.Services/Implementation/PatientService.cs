using DentistBooking.Data;
using DentistBooking.Data.Entities;
using DentistBooking.Services.Interfaces;

namespace DentistBooking.Services.Implementation
{
    public class PatientService : IPatientService
    {
        private readonly ApplicationDbContext db;

        public PatientService(ApplicationDbContext context)
        {
            db = context;
        }

        public ICollection<Patient> GetAllPatients()
        {
            return db.Patients.ToList();
        }

        public Patient GetPatientById(int id)
        {
            return db.Patients.Find(id);
        }

        public void AddPatient(Patient patient)
        {
            db.Patients.Add(patient);
            db.SaveChanges();
        }

        public void EditPatient(Patient patient)
        {
            db.Patients.Update(patient);
            db.SaveChanges();
        }

        public void DeletePatient(int id)
        {
            Patient patient = db.Patients.Find(id);
            if (patient != null)
            {
                db.Patients.Remove(patient);
                db.SaveChanges();
            }
        }
    }
}
