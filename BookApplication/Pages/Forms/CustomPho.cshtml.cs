using BookApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace BookApplication.Pages.Forms
{
    public class CustomPhoModel : PageModel
    {
        [BindProperty] 
        public PhosModel Pho { get; set; }

        public float PhoPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PhoPrice = Pho.BasePrice;

            if (Pho.HotSauce) PhoPrice += 1;
            if (Pho.Hoisin) PhoPrice += 1;
            if (Pho.Onion) PhoPrice += 1;
            if (Pho.Pepper) PhoPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new { Pho.PhoName, PhoPrice });
            
        }
    }
}
