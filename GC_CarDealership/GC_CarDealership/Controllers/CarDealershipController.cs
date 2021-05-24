using System;
using System.Threading.Tasks;
using GC_CarDealership.Models;
using GC_CarDealership.Services;
using Microsoft.AspNetCore.Mvc;

namespace GC_CarDealership.Controllers
{
    public class CarDealershipController : Controller
    {
        private readonly IDealershipService _service;

        public CarDealershipController(IDealershipService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _service.QueryDealershipAsync("api/car");
            return View(response);

        }
    }
}
