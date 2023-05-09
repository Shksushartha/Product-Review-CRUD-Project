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
	public class SearchProductModel : PageModel
    {
        private readonly AuthDbContext _authDbContext;
        [BindProperty]
        public int id { get; set; }

        public Product product { get; set; }

        public SearchProductModel(AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            product =  (
                        from p in _authDbContext.Products
                        where p.Id == id
                        select p
                       ).FirstOrDefault();
       
            return Page();
        }
    }
}
 