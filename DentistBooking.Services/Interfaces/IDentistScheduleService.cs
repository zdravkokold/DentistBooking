using DentistBooking.Data.Entities;

namespace DentistBooking.Services.Interfaces
{
    public interface IDentistScheduleService
    {
        void AddSchedule(DentistSchedule schedule);
        ICollection<DentistSchedule> GetScheduleByDentist(int dentistId);
        bool IsAvailable(int dentistId, DateTime date, TimeSpan timeSlot);
    }
}