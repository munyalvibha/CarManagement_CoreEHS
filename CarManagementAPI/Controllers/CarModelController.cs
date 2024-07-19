using CarManagementAPI.Models;
using CarManagementAPI.Services;
using CarManagementAPI.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarModelController : ControllerBase
    {
        private readonly ICarModelService _carModelService;

        public CarModelController(ICarModelService carModelService)
        {
            _carModelService = carModelService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,User")]
        public IActionResult GetAll()
        {
            return Ok(_carModelService.GetAll());
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,User")]
        public IActionResult GetById(int id)
        {
            var model = _carModelService.GetById(id);
            if (model == null)
                return NotFound();

            return Ok(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CarModel model)
        {
            _carModelService.Create(model);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id, CarModel model)
        {
            var existingModel = _carModelService.GetById(id);
            if (existingModel == null)
                return NotFound();

            model.Id = id;
            _carModelService.Update(model);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var existingModel = _carModelService.GetById(id);
            if (existingModel == null)
                return NotFound();

            _carModelService.Delete(id);
            return Ok();
        }
    }
}
