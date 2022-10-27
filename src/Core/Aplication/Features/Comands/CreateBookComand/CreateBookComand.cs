using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Features.Comands.CreateBookComand
{
    public class CreateBookComand:IRequest<bool>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int ProductCode { get; set; }
        public int PageCount { get; set; }
        public int WeightWithGram { get; set; }
        public string Description { get; set; }
        public string InformationPaymentsAndOthers { get; set; }
        public int Isbn { get; set; }
    }
}
