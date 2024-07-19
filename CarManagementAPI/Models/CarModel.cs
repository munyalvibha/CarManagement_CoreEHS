﻿using System.ComponentModel.DataAnnotations;

namespace CarManagementAPI.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Class { get; set; }
        public string ModelName { get; set; }
        public string ModelCode { get; set; }
        public string Description { get; set; }
        public string Features { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfManufacturing { get; set; }
        public bool Active { get; set; }
        public int SortOrder { get; set; }
        public List<string> Images { get; set; }
    }
}
