using CarManagementAPI.Models;

namespace CarManagementAPI.Services.Interface
{
    public interface ICarModelService
    {
        List<CarModel> GetAll();
        CarModel GetById(int id);
        bool Create(CarModel model);
        bool Update(CarModel model);
        bool Delete(int id);
    }
}
