using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerse.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }

        //limt characters
        [MaxLength(255)] // part of System.ComponentModel.DataAnnotations
        public string ImageUrl { get ; set; }
        public decimal Price { get; set; }
    }
}
