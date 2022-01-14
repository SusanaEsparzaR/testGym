using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessExample.Core
{
    public class Incentive
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Decimal Amount { get; set; }
    }
}
