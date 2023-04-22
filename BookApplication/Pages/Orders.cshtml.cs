using BookApplication.Data;
using BookApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookApplication.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PhoOrder> PhoOrders = new List<PhoOrder>();

        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context= context;
        }
        public void OnGet()
        {
            PhoOrders = _context.PhoOrders.ToList();
        }
    }
}
