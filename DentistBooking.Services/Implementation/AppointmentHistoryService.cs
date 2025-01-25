using DentistBooking.Data;
using DentistBooking.Data.Entities;
using Microsoft.EntityFrameworkCore;
using DentistBooking.Services.Interfaces;

namespace DentistBooking.Services.Implementation
{
    public class AppointmentHistoryService : IAppointmentHistoryService
    {
        private readonly ApplicationDbContext db;

        public AppointmentHistoryService(ApplicationDbContext context)
        {
            db = context;
        }

        public void AddToAppointmentsHistory(AppointmentHistory history)
        {
            db.AppointmentHistories.Add(history);
            db.SaveChanges();
        }

        public ICollection<AppointmentHistory> GetHistoryByPatient(int patientId)
        {
            return db.AppointmentHistories
                .Include(ah => ah.Appointment)
                .Where(ah => ah.Appointment.PatientId == patientId)
                .ToList();
        }

        public ICollection<AppointmentHistory> GetHistoryByPeriod(DateTime startDate, DateTime endDate)
        {
            return db.AppointmentHistories
                .Include(ah => ah.Appointment)
                .Where(ah => ah.CreatedOn >= startDate && ah.CreatedOn <= endDate)
                .ToList();
        }
    }
}