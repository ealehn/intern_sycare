using System;
using System.ComponentModel.DataAnnotations;

namespace Project.Entities
{
    public class Item
    {
        public string id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public double quantity { get; set; }
        [Required]
        public double net_amount { get; set; }
        [Required]
        public double gross_amount { get; set; }
        public string description { get; set; }
        [Required]
        public string item_category { get; set; }
        [Required]
        public string item_unit { get; set; }
        [Required]
        public double tax { get; set; }
        [Required]
        public double discount { get; set; }

        public bool isdeleted {get;set;}
    }
}