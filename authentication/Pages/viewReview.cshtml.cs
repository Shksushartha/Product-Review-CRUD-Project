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
	public class viewReviewModel : PageModel
    {
        private readonly AuthDbContext _authDbContext;

        public viewReviewModel(AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
        }

        //[BindProperty]
        public int Id { get; set; }
        public List<Review>? reviews { get; set; }
        public void OnGet(int id)
        {
            
            var r = (from re in _authDbContext.Reviews
                     where re.product.Id == id
                     select re);
            reviews = r.ToList();
            Id = id;
            //_authDbContext.Reviews.;
        }

        public void OnPost()
        {
            //var r = (from re in _authDbContext.Reviews                     
            //         where re.product.Id == Id
            //         select re);
            //reviews = r.ToList();
        }
    }
}
