using Microsoft.AspNetCore.Mvc;
using MvcBestStore.Services;

namespace MvcBestStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbcontext context;
        public ProductController(ApplicationDbcontext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
