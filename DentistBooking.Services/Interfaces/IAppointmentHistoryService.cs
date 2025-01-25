using DentistBooking.Data.Entities;

namespace DentistBooking.Services.Interfaces
{
    public interface IAppointmentHistoryService
    {
        void AddToAppointmentsHistory(AppointmentHistory history);
        ICollection<AppointmentHistory> GetHistoryByPatient(int patientId);
        ICollection<AppointmentHistory> GetHistoryByPeriod(DateTime startDate, DateTime endDate);
    }
}