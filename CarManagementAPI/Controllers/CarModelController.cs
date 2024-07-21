using CarManagementAPI.Models;
using CarManagementAPI.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CarManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarModelController : ControllerBase
    {
        private readonly ICarModelService _carModelService;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CarModelController(ICarModelService carModelService, IWebHostEnvironment hostingEnvironment)
        {
            _carModelService = carModelService;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("getAllCarModel")]
        [Authorize(Roles = "Admin,User")]
        [Description("API to Get all records from car models table")]
        public IActionResult GetAll()
        {
            return Ok(_carModelService.GetAll());
        }

        [HttpGet("GetById/{id}")]
        [Authorize(Roles = "Admin,User")]
        [Description("API to Get by id from car models table for update")]
        public IActionResult GetById(int id)
        {
            var model = _carModelService.GetById(id);
            if (model == null)
                return NotFound();

            return Ok(model);
        }

        [HttpPost("insertCar")]
        [Authorize(Roles = "Admin")]
        [Description("API to insert records into car models table")]
        public IActionResult Create(CarModelDto model)
        {
            var imagePaths = new List<string>();
            foreach (var base64Image in model.Images)
            {
                var filePath = SaveImage(base64Image);
                if (!string.IsNullOrEmpty(filePath))
                {
                    imagePaths.Add(filePath);
                }
            }

            var carModel = new CarModel
            {
                Brand = model.Brand,
                Class = model.Class,
                ModelName = model.ModelName,
                ModelCode = model.ModelCode,
                Description = model.Description,
                Features = model.Features,
                Price = model.Price,
                DateOfManufacturing = model.DateOfManufacturing,
                Active = model.Active,
                SortOrder = model.SortOrder,
                Images = string.Join(",", imagePaths)
            };

            
            var success = _carModelService.Create(carModel);
            if(success)
                return StatusCode(200,"Car Model created successfully");
            else
                return StatusCode(500, "An error occurred while saving the car model.");
        }

        private string SaveImage(string base64Image)
        {
            try
            {
                var imagePath = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                if (!Directory.Exists(imagePath))
                {
                    Directory.CreateDirectory(imagePath);
                }

                var fileName = $"{Guid.NewGuid()}.jpg";
                var fullPath = Path.Combine(imagePath, fileName);
                var imageBytes = Convert.FromBase64String(base64Image.Split(',')[1]);
                System.IO.File.WriteAllBytes(fullPath, imageBytes);

                return $"images/{fileName}";
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPut("Update")]
        [Authorize(Roles = "Admin")]
        [Description("API to update exisitng record in car models table")]
        public IActionResult Update(CarModel model)
        {
            var existingModel = _carModelService.GetById(model.Id);
            if (existingModel == null)
                return NotFound();

            var success = _carModelService.Update(model);
            if (success)
                return StatusCode(200, "Car Model updated successfully");
            else
                return StatusCode(500, "An error occurred while updating the car model.");
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        [Description("API to delete exisitng record in car models table")]
        public IActionResult Delete(int id)
        {
            var existingModel = _carModelService.GetById(id);
            if (existingModel == null)
                return NotFound();

            var success = _carModelService.Delete(id);
            if (success)
                return StatusCode(200, "Car Model delete successfully");
            else
                return StatusCode(500, "An error occurred while deleting the car model.");
        }
    }
}
