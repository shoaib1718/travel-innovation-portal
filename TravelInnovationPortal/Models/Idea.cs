using System.ComponentModel.DataAnnotations;

namespace TravelInnovationPortal.Models
{
    public class Idea
    {
        public int Id { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string EmployeeEmail { get; set; }

        [Required]
        public string ServiceName { get; set; }

        [Required]
        public string IdeaTitle { get; set; }

        [Required]
        public string IdeaDescription { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}