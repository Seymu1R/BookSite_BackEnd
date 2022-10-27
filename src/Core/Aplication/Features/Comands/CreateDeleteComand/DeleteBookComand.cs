using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Features.Comands.CreateDeleteComand
{
    public class DeleteBookComand:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
