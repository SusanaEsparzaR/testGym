using GymManager.Core.Members;
using GymManager.Core.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Sales
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public Member Member { get; set; }

        public ProductsType ProductType { get; set; }

    }
}
