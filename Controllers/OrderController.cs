using Microsoft.AspNetCore.Mvc;
using Lab_06.Models;
using System.Threading.Tasks;
using System.Linq;
namespace Lab_06.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository _context;
        private Cart _cart;
        public OrderController(IOrderRepository orderRepository, Cart cart)
        {
            _context = orderRepository;
            _cart = cart;
        }
        public IActionResult Checkout()
        {
            return View(new Order());
        }
        [HttpPost]
        public async Task<IActionResult> Checkout (Order order)
        {
            if(_cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry your cart is empty");
            }
            if (ModelState.IsValid)
            {
                order.CartLines = _cart.Lines.ToArray();
                await _context.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }
        public ViewResult Completed ()
        {
            _cart.ClearCart();
            return View();
        }
    }
}
