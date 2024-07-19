using CarManagementAPI.Models;
using CarManagementAPI.Services.Interface;

namespace CarManagementAPI.Services
{
    public class CommissionService : ICommissionService
    {
        public decimal CalculateCommission(Salesman salesman, List<Sale> sales)
        {
            decimal totalCommission = 0;

            foreach (var sale in sales)
            {
                var commission = CalculateSaleCommission(salesman, sale);
                totalCommission += commission;
            }

            return totalCommission;
        }


        private decimal CalculateSaleCommission(Salesman salesman, Sale sale)
        {
            decimal baseCommission = GetBrandCommission(sale.Brand, sale.Class, sale.NumberOfCarsSold);
            decimal additionalCommission = GetClassCommission(sale.Class, sale.NumberOfCarsSold);
            decimal totalCommission = baseCommission + additionalCommission;

            if (sale.Class == "A" && salesman.PreviousYearSales > 500000)
            {
                totalCommission += 0.02m * totalCommission;
            }

            return totalCommission;
        }

        private decimal GetBrandCommission(string brand, string carClass, int numberOfCarsSold)
        {
            decimal commission = brand switch
            {
                "Audi" => carClass == "A" ? 800m : 0,
                "Jaguar" => carClass == "A" ? 750m : 0,
                "Land Rover" => carClass == "A" ? 850m : 0,
                "Renault" => carClass == "A" ? 400m : 0,
                _ => 0
            };

            return commission * numberOfCarsSold;
        }

        private decimal GetClassCommission(string carClass, int numberOfCarsSold)
        {
            decimal percentage = carClass switch
            {
                "A" => 0.08m,
                "B" => 0.06m,
                "C" => 0.04m,
                _ => 0
            };

            return percentage * numberOfCarsSold;
        }
    }
}
