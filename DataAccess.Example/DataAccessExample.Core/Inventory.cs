using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessExample.Core
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        public Color Color { get; set; }

        public Vehicle Vehicle { get; set; }

        [Required]
        public Decimal Price { get; set; }
    }
}
