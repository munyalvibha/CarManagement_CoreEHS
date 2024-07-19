using CarManagementAPI.Models;

namespace CarManagementAPI.Services.Interface
{
    public interface ICommissionService
    {
        decimal CalculateCommission(Salesman salesman, List<Sale> sales);
    }
}
