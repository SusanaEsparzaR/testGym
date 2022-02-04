using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Products
{
    public class MeasureType
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Measure { get; set; }

        public List<ProductsType> ProductsType { get; set; }

        public MeasureType()
        {
            ProductsType = new List<ProductsType>();
        }
    }
}
