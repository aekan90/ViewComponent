using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewComponent.Models;

namespace ViewComponent.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var kitapList = new List<Kitaplar>()
            {
            new Kitaplar(){ Id=1,KitapAd="Kitap1",Yazar="Yazar1"},
            new Kitaplar(){ Id=1,KitapAd="Kitap2",Yazar="Yazar2"},
            new Kitaplar(){ Id=1,KitapAd="Kitap3",Yazar="Yazar3"},
            new Kitaplar(){ Id=1,KitapAd="Kitap4",Yazar="Yazar4"},
            new Kitaplar(){ Id=1,KitapAd="Kitap5",Yazar="Yazar5"},
            };
            return View(kitapList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}