using CarManagementAPI.Models;

namespace CarManagementAPI.Services.Interface
{
    public interface ICarModelService
    {
        List<CarModel> GetAll();
        CarModel GetById(int id);
        void Create(CarModel model);
        void Update(CarModel model);
        void Delete(int id);
    }
}
