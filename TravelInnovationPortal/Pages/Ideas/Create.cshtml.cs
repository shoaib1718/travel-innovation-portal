using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TravelInnovationPortal.ViewModels;
using TravelInnovationPortal.Data;
using TravelInnovationPortal.Models;

namespace TravelInnovationPortal.Pages.Ideas
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SubmitIdeaViewModel Idea { get; set; } = new();

        public List<SelectListItem> Services { get; set; } = new();

        [TempData]
        public string SuccessMessage { get; set; } = string.Empty;

        public void OnGet()
        {
            LoadServices();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            LoadServices();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var idea = new Idea
            {
                EmployeeName = "Test User",
                EmployeeEmail = "test@company.com",
                ServiceId = Idea.ServiceId,
                ServiceName = Services
                    .FirstOrDefault(x => x.Value == Idea.ServiceId.ToString())
                    ?.Text ?? "",
                IdeaTitle = Idea.IdeaTitle,
                IdeaDescription = Idea.IdeaDescription,
                CreatedDate = DateTime.Now
            };

            _context.Ideas.Add(idea);
            await _context.SaveChangesAsync();

            SuccessMessage = "Idea submitted successfully!";

            return RedirectToPage();
        }

        private void LoadServices()
        {
            Services = new List<SelectListItem>()
            {
                new SelectListItem("Flights","1"),
                new SelectListItem("Visa","2"),
                new SelectListItem("JETT","3"),
                new SelectListItem("TraveBiz","4"),
                new SelectListItem("MB","5")
            };
        }
    }
}