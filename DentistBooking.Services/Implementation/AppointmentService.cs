using DentistBooking.Data;
using DentistBooking.Data.Entities;
using DentistBooking.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DentistBooking.Services.Implementation
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext db;

        public AppointmentService(ApplicationDbContext context)
        {
            db = context;
        }

        public ICollection<Appointment> GetAppointmentsByDate(DateTime date)
        {
            return db.Appointments
                .Include(a => a.Patient)
                .Include(a => a.Dentist)
                .Where(a => a.Date.Date == date.Date)
                .ToList();
        }

        public ICollection<Appointment> GetAppointmentsByPatient(int patientId)
        {
            return db.Appointments
                .Include(a => a.Dentist)
                .Where(a => a.PatientId == patientId)
                .ToList();
        }

        public void AddAppointment(Appointment appointment)
        {
            if (IsTimeSlotAvailable(appointment.DentistId, appointment.Date, appointment.StartTime, appointment.EndTime))
            {
                db.Appointments.Add(appointment);
                db.SaveChanges();
            }
            else
            {
                throw new Exception("The selected time slot is not available.");
            }
        }

        public void DeleteAppointment(int id)
        {
            Appointment appointment = db.Appointments.Find(id);
            if (appointment != null)
            {
                db.Appointments.Remove(appointment);
                db.SaveChanges();
            }
        }

        public bool IsTimeSlotAvailable(int dentistId, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            return !db.Appointments.Any(a =>
                a.DentistId == dentistId &&
                a.Date.Date == date.Date &&
                a.StartTime == startTime &&
                a.EndTime == endTime);
        }
    }
}