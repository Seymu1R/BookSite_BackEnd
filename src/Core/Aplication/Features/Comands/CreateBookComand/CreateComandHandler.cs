using Aplication.Interfaces.Repository;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Features.Comands.CreateBookComand
{
    public class CreateComandHandler : IRequestHandler<CreateBookComand, bool>
    {
        private Ibook _bookrepository;
        private IMapper _mapper;

        public CreateComandHandler(Ibook bookrepository,IMapper mapper)
        {
            _bookrepository = bookrepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreateBookComand request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request);  
            return await _bookrepository.AddItemAsync(book);

        }
    }
}
