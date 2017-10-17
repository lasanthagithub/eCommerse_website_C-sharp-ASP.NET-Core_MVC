using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeServer.Models
{
    public class Film
    {
        [Key] // Film_ID is the key
        public int Film_ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Release_Year { get; set; }

    }
}
