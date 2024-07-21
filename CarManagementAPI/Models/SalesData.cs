namespace CarManagementAPI.Models
{
    public class SalesData
    {
        public int Id { get; set; }
        public string Salesman { get; set; }
        public string Class { get; set; }
        public string Brand { get; set; }
        public int NumberOfCarsSold { get; set; }

        public double ModelPrice { get; set; }
    }
}
