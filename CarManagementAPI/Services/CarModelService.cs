using CarManagementAPI.Models;
using CarManagementAPI.Services.Interface;

namespace CarManagementAPI.Services
{
    public class CarModelService : ICarModelService
    {
        private readonly List<CarModel> _carModels = new();

        public List<CarModel> GetAll() => _carModels;

        public CarModel GetById(int id) => _carModels.FirstOrDefault(m => m.Id == id);

        public void Create(CarModel model)
        {
            model.Id = _carModels.Count + 1;
            _carModels.Add(model);
        }

        public void Update(CarModel model)
        {
            var existingModel = GetById(model.Id);
            if (existingModel != null)
            {
                _carModels.Remove(existingModel);
                _carModels.Add(model);
            }
        }

        public void Delete(int id)
        {
            var model = GetById(id);
            if (model != null)
            {
                _carModels.Remove(model);
            }
        }
    }
}
