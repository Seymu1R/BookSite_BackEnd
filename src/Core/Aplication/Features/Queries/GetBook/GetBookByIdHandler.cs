using Aplication.Dtos;
using Aplication.Interfaces.Repository;
using AutoMapper;
using Domain.Entities;
using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Features.Queries.GetBook
{
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, BookView>
    {
        private Ibook _bookrepository;
        private IMapper _mapper;

        public GetBookByIdHandler(Ibook bookrepository,IMapper mapper)
        {
            _bookrepository = bookrepository;
            _mapper = mapper;

        }
        public async Task<BookView> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
             Book fbook= await _bookrepository.GetItemAsync(request.Id);
             var book= _mapper.Map<BookView>(fbook);
             return book;
        }
    }
}
