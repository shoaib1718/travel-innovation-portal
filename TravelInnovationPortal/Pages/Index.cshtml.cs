using Microsoft.AspNetCore.Mvc.RazorPages;
using TravelInnovationPortal.Data;

namespace TravelInnovationPortal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public int TotalIdeas { get; set; }

        public int TotalServices { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            TotalIdeas = _context.Ideas.Count();

            TotalServices = _context.Services.Count();
        }
    }
}