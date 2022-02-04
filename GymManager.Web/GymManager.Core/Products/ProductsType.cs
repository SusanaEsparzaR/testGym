using GymManager.Core.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Products
{
    public class ProductsType
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public MeasureType MeasureType { get; set; }

        public List<Sale> Sales { get; set; }

        public List<Inventory> Inventory { get; set; }

        public ProductsType()
        {
            Sales = new List<Sale>();
            Inventory = new List<Inventory>();
        }
    }
}
