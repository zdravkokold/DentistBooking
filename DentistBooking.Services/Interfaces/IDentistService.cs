using DentistBooking.Data.Entities;

namespace DentistBooking.Services.Interfaces
{
    public interface IDentistService
    {
        ICollection<Dentist> GetAllDentists();
        Dentist GetDentistById(int id);
        void AddDentist(Dentist dentist);
        void EditDentist(Dentist dentist);
        void DeleteDentist(int id);
    }
}