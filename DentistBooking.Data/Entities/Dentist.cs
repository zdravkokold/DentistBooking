using System.ComponentModel.DataAnnotations;

namespace DentistBooking.Data.Entities
{
    public class Dentist : ApplicationUser
    {
        [StringLength(30, MinimumLength = 2)]
        public string Specialization { get; set; }
    }
}