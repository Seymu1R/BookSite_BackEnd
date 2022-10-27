using Aplication.Interfaces.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Features.Comands.CreateDeleteComand
{
    public class DeleteBookComandHandler : IRequestHandler<DeleteBookComand, bool>
    {
      
        private Ibook _bookrepository;

        public DeleteBookComandHandler( Ibook bookrepository)
        {
            
            _bookrepository = bookrepository;
        }
        public Task<bool> Handle(DeleteBookComand request, CancellationToken cancellationToken)
        {
            return _bookrepository.DeleteItemAsync(request.Id);
        }
    }
}
