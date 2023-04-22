using BookApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookApplication.Pages
{
    public class PhoModel : PageModel
    {
        public List<PhosModel> fakePhoDB = new List<PhosModel>()
        {
            new PhosModel()
            {
                ImageTitle="Bunbo", PhoName="Bunbo", BasePrice=2,HotSauce= true, Hoisin=true,Pepper = true, Onion = true, FinalPrice=4
            },
            new PhosModel()
            {
                ImageTitle="Hutieu", PhoName="Hutieu", BasePrice=5,HotSauce= true, Hoisin=true,Pepper = true, Onion = true, FinalPrice=10
            },
            new PhosModel()
            {
                ImageTitle="Pho", PhoName="Pho", BasePrice=9,HotSauce= true, Hoisin=true,Pepper = true, Onion = true, FinalPrice=20
            }
        };
        public void OnGet()
        {
        }
    }
}
