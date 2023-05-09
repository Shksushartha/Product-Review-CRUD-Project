using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using authentication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace authentication.Pages
{
	public class deleteReviewModel : PageModel
    {
        private readonly AuthDbContext _authDbContext;

        public deleteReviewModel(AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
        }

        public void OnGet()
        {
        }
    }
}
