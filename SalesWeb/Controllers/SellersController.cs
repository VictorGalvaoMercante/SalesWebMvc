using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;
using SalesWeb.Services;

namespace SalesWeb.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        // GET: Sellers/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sellers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {

            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));

        }



    }
}
