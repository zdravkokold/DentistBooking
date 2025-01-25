using DentistBooking.Data;
using DentistBooking.Data.Entities;
using DentistBooking.Services.Interfaces;

namespace DentistBooking.Services.Implementation
{
    public class DentistService : IDentistService
    {
        private readonly ApplicationDbContext db;

        public DentistService(ApplicationDbContext context)
        {
            db = context;
        }

        public ICollection<Dentist> GetAllDentists()
        {
            return db.Dentists.ToList();
        }

        public Dentist GetDentistById(int id)
        {
            return db.Dentists.Find(id);
        }

        public void AddDentist(Dentist dentist)
        {
            db.Dentists.Add(dentist);
            db.SaveChanges();
        }

        public void EditDentist(Dentist dentist)
        {
            db.Dentists.Update(dentist);
            db.SaveChanges();
        }

        public void DeleteDentist(int id)
        {
            Dentist dentist = db.Dentists.Find(id);
            if (dentist != null)
            {
                db.Dentists.Remove(dentist);
                db.SaveChanges();
            }
        }
    }
}