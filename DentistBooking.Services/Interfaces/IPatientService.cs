using DentistBooking.Data.Entities;

namespace DentistBooking.Services.Interfaces
{
    public interface IPatientService
    {
        ICollection<Patient> GetAllPatients();
        Patient GetPatientById(int id);
        void AddPatient(Patient patient);
        void EditPatient(Patient patient);
        void DeletePatient(int id);
    }
}