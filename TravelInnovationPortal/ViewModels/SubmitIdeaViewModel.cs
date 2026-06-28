using System.ComponentModel.DataAnnotations;

namespace TravelInnovationPortal.ViewModels
{
    public class SubmitIdeaViewModel
    {
        [Required]
        public int ServiceId { get; set; }

        [Required]
        public string IdeaTitle { get; set; } = string.Empty;

        [Required]
        public string IdeaDescription { get; set; } = string.Empty;
    }
}