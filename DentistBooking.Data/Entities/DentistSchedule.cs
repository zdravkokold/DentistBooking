using System.ComponentModel.DataAnnotations.Schema;

namespace DentistBooking.Data.Entities
{
    public class DentistSchedule
    {
        public int Id { get; set; }

        public int DentistId { get; set; }

        [ForeignKey(nameof(DentistId))]
        public Dentist Dentist { get; set; }

        public DateTime WorkDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }
    }
}