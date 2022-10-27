using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BookImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
