using AZ_datapage.Models;
using Microsoft.AspNetCore.Mvc;

namespace AZ_datapage.Controllers
{
    public class FirstController : Controller
    {
        private readonly WebDBContext _DB;
        public FirstController(WebDBContext dB)
        {
            _DB = dB;
        }

        public IActionResult Index()
        {
            var datalist = _DB.Datamodeler.ToList();
            return View(datalist);
        }
        [HttpGet]
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DataModel model) {
            
            _DB.Datamodeler.Add(model);
            _DB.SaveChanges();
            return View();
        }
    }
}
