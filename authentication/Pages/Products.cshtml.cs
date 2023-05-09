using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using authentication.Models;
using authentication.Model;
using Microsoft.AspNetCore.Authorization;

namespace authentication.Pages
{
    [Authorize]
	public class ProductsModel : PageModel
    {
        private readonly AuthDbContext _authDbContext;

        public ProductsModel(AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
        }

        [BindProperty]
        public Product p { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var prod = new Product
            {
                name = p.name,
                category = p.category,
                desc = p.desc,
                price = p.price,
                discount = p.discount,
                pAfterD = (p.price - ((p.discount / 100) * p.price))
            };
            _authDbContext.Products.Add(prod);
            await _authDbContext.SaveChangesAsync();
            return Page();
        }
    }
}
