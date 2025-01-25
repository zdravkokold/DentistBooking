using DentistBooking.Data;
using DentistBooking.Data.Entities;
using DentistBooking.Services.Interfaces;

namespace DentistBooking.Services.Implementation
{
    public class DentistScheduleService : IDentistScheduleService
    {
        private readonly ApplicationDbContext db;

        public DentistScheduleService(ApplicationDbContext context)
        {
            db = context;
        }

        public void AddSchedule(DentistSchedule schedule)
        {
            db.DentistSchedules.Add(schedule);
            db.SaveChanges();
        }

        public ICollection<DentistSchedule> GetScheduleByDentist(int dentistId)
        {
            return db.DentistSchedules
                .Where(ds => ds.DentistId == dentistId)
                .ToList();
        }

        public bool IsAvailable(int dentistId, DateTime date, TimeSpan timeSlot)
        {
            var schedule = db.DentistSchedules
                .FirstOrDefault(ds => ds.DentistId == dentistId && ds.WorkDate.Date == date.Date);

            if (schedule == null) return false;

            return schedule.StartTime <= timeSlot && schedule.EndTime >= timeSlot;
        }
    }
}