using System.ComponentModel.DataAnnotations;

namespace DentistBooking.Data.Entities
{
    public class Patient : ApplicationUser
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string HealthStatus { get; set; }
    }
}