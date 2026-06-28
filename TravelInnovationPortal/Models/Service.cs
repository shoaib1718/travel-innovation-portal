using System.ComponentModel.DataAnnotations;

namespace TravelInnovationPortal.Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        [Required]
        public string ServiceName { get; set; } = string.Empty;

        public string ProductOwnerEmail { get; set; } = string.Empty;
    }
}