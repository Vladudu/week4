using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4.Models
{
    public class Movie
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
