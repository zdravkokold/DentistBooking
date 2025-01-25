using System.ComponentModel.DataAnnotations.Schema;

namespace DentistBooking.Data.Entities
{
    public class AppointmentHistory
    {
        public int Id { get; set; }

        public int AppointmentId { get; set; }

        [ForeignKey(nameof(AppointmentId))]
        public Appointment Appointment { get; set; }

        public string TreatmentDetails { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}