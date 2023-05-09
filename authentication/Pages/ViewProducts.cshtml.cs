using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using authentication.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using authentication.Models;

namespace authentication.Pages
{
	public class ViewProductsModel : PageModel
    {
        private readonly AuthDbContext _authDbContext;
        public List<Product> Products { get; set; }

        public ViewProductsModel(AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
        }

        public void OnGet()
        {
            Products = _authDbContext.Products.ToList(); 
        }

        
    }
}
