using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GC_CarDealership_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GC_CarDealership_API.Data.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GC_CarDealership_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CarController : ControllerBase
    {
        private readonly ICarRepository _repository;

        public CarController(ICarRepository repository)
        {
            _repository = repository;

        }

        //Get: api/car
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.GetAll());
        }

        //Get api/<CarController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _repository.Get(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Data.Model.Car model)
        {
            await _repository.Create(model);
            return Created($"api/car/{model.Id}", model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,[FromBody] Data.Model.Car model)
        {
            await _repository.Update(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
