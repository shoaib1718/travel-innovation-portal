using System.ComponentModel.DataAnnotations;

namespace TravelInnovationPortal.Models
{
    public class Idea
    {
        public int Id { get; set; }

        [Required]
        public string EmployeeName { get; set; } = string.Empty;

        [Required]
        public string EmployeeEmail { get; set; } = string.Empty;

        [Required]
        public string ServiceName { get; set; } = string.Empty;

        public int ServiceId { get; set; }

        [Required]
        public string IdeaTitle { get; set; } = string.Empty;

        [Required]
        public string IdeaDescription { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }
    }
}