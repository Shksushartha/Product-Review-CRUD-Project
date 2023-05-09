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
    public class addReviewModel : PageModel
    {
        private readonly AuthDbContext _authDbContext;

        [BindProperty]
        public Review r { get; set; }

        [BindProperty]
        public Product p { get; set; }

        public addReviewModel(AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
        }

        public void OnGet(int id)
        {
            p = (_authDbContext.Products.Where(item => item.Id == id).First());
        }
       

        public async Task<IActionResult> OnPostAsync()
        {
            p = _authDbContext.Products.Where(item => item.Id == p.Id).First();
            if (p == null)
            {
                return Page();
            }
            var r1 = new Review
            {

                reviewerName = r.reviewerName,
                star = r.star,
                review = r.review,
                
            };
            
            _authDbContext.Reviews.Add(r1);           
            r1.product = p;
            await _authDbContext.SaveChangesAsync();

            return Page();
        }
    }
}
