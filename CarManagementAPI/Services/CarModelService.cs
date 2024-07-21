using CarManagementAPI.DbContext;
using CarManagementAPI.Models;
using CarManagementAPI.Services.Interface;

namespace CarManagementAPI.Services
{
    public class CarModelService : ICarModelService
    {
        private readonly CarDbContext _context;

        public CarModelService(CarDbContext context)
        {
            _context = context;
        }

        public List<CarModel> GetAll() {
            return _context.CarModels.Where(x=>x.Active == true).ToList();
        }

        public CarModel GetById(int id)
        {
            return _context.CarModels.FirstOrDefault(x => x.Id == id);
        }

        public bool Create(CarModel model)
        {
            try
            {
                _context.CarModels.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(CarModel model)
        {
            try
            {
                var existingModel = GetById(model.Id);
                if (existingModel != null)
                {
                    existingModel.Brand = model.Brand;
                    existingModel.Features = model.Features;
                    existingModel.Price = model.Price;
                    existingModel.SortOrder = model.SortOrder;
                    existingModel.Description = model.Description;
                    existingModel.DateOfManufacturing = model.DateOfManufacturing;
                    existingModel.ModelCode = model.ModelCode;
                    existingModel.ModelName = model.ModelName;
                    existingModel.Class = model.Class;

                    _context.CarModels.Update(existingModel);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

        public bool Delete(int id)
        {
            try
            {
                var model = GetById(id);
                if (model != null)
                {
                    model.Active = false;
                    _context.CarModels.Update(model);
                    _context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}
