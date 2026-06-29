using Microsoft.AspNetCore.Mvc.RazorPages;
using TravelInnovationPortal.Data;
using TravelInnovationPortal.Models;

namespace TravelInnovationPortal.Pages.Ideas
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Idea> Ideas { get; set; } = new();

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Ideas = _context.Ideas
                            .OrderByDescending(x => x.CreatedDate)
                            .ToList();
        }
    }
}