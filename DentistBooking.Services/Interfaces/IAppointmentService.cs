using DentistBooking.Data.Entities;

namespace DentistBooking.Services.Interfaces
{
    public interface IAppointmentService
    {
        ICollection<Appointment> GetAppointmentsByDate(DateTime date);
        ICollection<Appointment> GetAppointmentsByPatient(int patientId);
        void AddAppointment(Appointment appointment);
        void DeleteAppointment(int id);
        bool IsTimeSlotAvailable(int dentistId, DateTime date, TimeSpan startTime, TimeSpan endTime);
    }
}