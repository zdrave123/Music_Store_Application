using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Service.Interface;

namespace MusicStore.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }
        public IActionResult Index()
        {
            var orders = orderService.GetAllOrders();

            return View(orders);
        }

        public IActionResult Details(Guid id)
        {
            var order = orderService.GetOrderDetails(id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order); 
        }


        [HttpPost]
        public IActionResult DeleteOrder(Guid id)
        {
            var order = orderService.DeleteOrder(id);
            if (order == null)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }
        
        
        public IActionResult DeleteAllOrders()
        {
            orderService.DeleteAllOrders();

            return RedirectToAction("Index");
        }
    }
}
