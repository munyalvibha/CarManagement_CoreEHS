using System.ComponentModel.DataAnnotations;

namespace CarManagementAPI.Models
{
    public class CarModelDto
    {
        [Required]
        public string Brand { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string ModelName { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string ModelCode { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Features { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public DateTime DateOfManufacturing { get; set; }

        public bool Active { get; set; }

        public int SortOrder { get; set; }

        [Required]
        public List<string> Images { get; set; }
    }
}
