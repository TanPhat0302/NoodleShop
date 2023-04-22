using BookApplication.Data;
using BookApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookApplication.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        
        public string PhoName { get; set; }

        public float PhoPrice { get; set; }

        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context= context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PhoName))
            {
                PhoName = "Custom";
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PhoOrder phoOrder = new PhoOrder();
            phoOrder.PhoName = PhoName;
            phoOrder.BasePrice = PhoPrice;

            _context.PhoOrders.Add(phoOrder);
            _context.SaveChanges();
        }
    }
}
