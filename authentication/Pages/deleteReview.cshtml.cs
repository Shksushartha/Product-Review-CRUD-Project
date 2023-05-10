 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using authentication.Model;
using authentication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace authentication.Pages
{
	public class deleteReviewModel : PageModel
    {
        private readonly AuthDbContext _authDbContext;

        [BindProperty]
        public int Id { get; set; }

        public deleteReviewModel(AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
        }

        public IActionResult OnGet(int id)
        {
            var r = _authDbContext.Reviews.Where(item => item.Id == id).First();
            _authDbContext.Reviews.Remove(r);
            _authDbContext.SaveChanges();
            return RedirectToPage("viewProducts") ;
        }
    }
    
}
