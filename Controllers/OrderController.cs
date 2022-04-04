using Microsoft.AspNetCore.Mvc;
using Lab_06.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ViewResult> OutstandingOrders ()
        {
            return View(await _context.Orders.Where(el => el.IsShipped == false).ToListAsync());
        } 
        
        [HttpPost]
        public async Task<RedirectToActionResult> OutstandingOrders(int orderId)
        {
            Order order = await _context.Orders.FirstOrDefaultAsync(el => el.OrderId == orderId);
            if(order != null)
            {
                order.IsShipped = true;
                await _context.SaveOrder(order);
                TempData["message"] = "Order has been marked shipped";
            }
            return RedirectToAction("index", "Admin");
        }
    }
}
