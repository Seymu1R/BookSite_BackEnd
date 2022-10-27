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

namespace Aplication.Features.Queries.GetAllBook
{
    public class GetAllBookHandler : IRequestHandler<GetAllBookQuery,  List<AllBookView>>
    {
        private Ibook _bookrepository;
        private IMapper _mapper;
        public GetAllBookHandler(Ibook bookrepository, IMapper mapper)
        {
            _bookrepository = bookrepository;
            _mapper = mapper;
        }

      

        async Task<List<AllBookView>> IRequestHandler<GetAllBookQuery, List<AllBookView>>.Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookrepository.GetAllItemAsync();
            var book2=  _mapper.Map<List<AllBookView>>(books);
            return book2;

        }
    }
}
