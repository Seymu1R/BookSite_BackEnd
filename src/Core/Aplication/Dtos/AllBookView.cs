using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dtos
{
    public class AllBookView
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public double Price { get; set;}
        public int PageCount { get; set;}
        public int WheightWithGram { get; set;}
        public string Description { get; set;}

    }
}
