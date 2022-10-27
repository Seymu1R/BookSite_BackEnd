using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Book:BaseClass
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ProductCode { get; set; }
        public int PageCount { get; set; }
        public int WheightWithGram { get; set; }
        public string Description { get; set; }
        public string InformationPaymentsAndOthers { get; set; }
        public int Isbn { get; set; }
    }
}
