namespace CarManagementAPI.Models
{
    public class CommissionData
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int FixedCommission { get; set; }
        public int Threshold { get; set; }
        public double ClassACommission { get; set; }
        public double ClassBCommission { get; set; }
        public double ClassCCommission { get; set; }
    }
}
