using CarManagementAPI.Models;

namespace CarManagementAPI.Services.Interface
{
    public interface ICommissionService
    {
        IEnumerable<CommissionReport> CalculateCommission();
    }
}
