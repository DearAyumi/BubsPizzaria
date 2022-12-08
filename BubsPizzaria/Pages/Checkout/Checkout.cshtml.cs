using BubsPizzaria.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BubsPizzaria.Models;

namespace BubsPizzaria.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string CustomerName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context) {
            _context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(CustomerName))
            {
                CustomerName = "Custom";
            }
            if(string.IsNullOrEmpty(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaOrders pizzaOrders = new PizzaOrders();
            pizzaOrders.PizzaName = CustomerName;
            pizzaOrders.BasePrice = PizzaPrice;

            _context.PizzaOrder.Add(pizzaOrders);
            _context.SaveChanges();

        }
    }
}
