using CarManagementAPI.DbContext;
using CarManagementAPI.Models;
using CarManagementAPI.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace CarManagementAPI.Services
{
    public class CommissionService : ICommissionService
    {
        private readonly CarDbContext _context;

        public CommissionService(CarDbContext context)
        {
            _context = context;
        }
       
       public IEnumerable<CommissionReport> CalculateCommission()
       {
            List<SalesData> salesData = _context.SalesData.ToList();
            List<CommissionData> commissionData = _context.CommissionData.ToList();
            List<PreviousYearSales> previousYearSales = _context.PreviousYearSales.ToList();

            var reports = new List<CommissionReport>();

            var groupedSales = salesData.GroupBy(s => s.Salesman);

            foreach (var salesGroup in groupedSales)
            {
                var totalCommission = 0.0;
                var salesman = salesGroup.Key;

                foreach (var sale in salesGroup)
                {
                    var commission = commissionData.First(c => c.Brand == sale.Brand);

                    if (sale.ModelPrice > commission.Threshold)
                    {
                        totalCommission += commission.FixedCommission * sale.NumberOfCarsSold;
                    }

                    double classCommission = sale.Class switch
                    {
                        "A" => commission.ClassACommission,
                        "B" => commission.ClassBCommission,
                        "C" => commission.ClassCCommission,
                        _ => 0
                    };

                    totalCommission += classCommission * sale.ModelPrice * sale.NumberOfCarsSold;
                }

                var previousSales = previousYearSales.FirstOrDefault(p => p.Salesman == salesman);
                if (previousSales != null && previousSales.LastYearSales > 500000)
                {
                    var additionalCommission = salesGroup
                        .Where(s => s.Class == "A")
                        .Sum(s => s.ModelPrice * s.NumberOfCarsSold) * 0.02;
                    
                    
                    totalCommission += additionalCommission;
                }

                reports.Add(new CommissionReport
                {
                    Salesman = salesman,
                    TotalCommission = totalCommission
                });
            }

            return reports;
        }
    }
}
