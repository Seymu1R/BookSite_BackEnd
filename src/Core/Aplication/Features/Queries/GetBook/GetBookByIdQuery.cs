using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Features.Queries.GetBook
{
    public class GetBookByIdQuery:IRequest<BookView>
    {
        public int Id { get; set; }
    }
}
