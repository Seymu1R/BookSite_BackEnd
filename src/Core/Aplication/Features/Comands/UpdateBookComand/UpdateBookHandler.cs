using Aplication.Interfaces.Repository;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Features.Comands.UpdateBookComand
{
    public class UpdateBookHandler : IRequestHandler<UpdateBookComand, bool>
    {
        private IMapper _mapper;
        private Ibook _bookrepository;

        public UpdateBookHandler(IMapper mapper , Ibook bookrepository)
        {
            _mapper = mapper;
            _bookrepository = bookrepository;
        }

        public async Task<bool> Handle(UpdateBookComand request, CancellationToken cancellationToken)
        {
            var requestmap =  _mapper.Map<Book>(request); 
            var bookf=await _bookrepository.UpdateItemAsync(request.id);
            bookf.Description = requestmap.Description;
            bookf.Price=requestmap.Price; 
            bookf.Quantity=requestmap.Quantity;
            bookf.Isbn = requestmap.Isbn;
            bookf.Name = requestmap.Name;
            bookf.PageCount = requestmap.PageCount;
            bookf.WheightWithGram = requestmap.WheightWithGram;
            bookf.InformationPaymentsAndOthers = requestmap.InformationPaymentsAndOthers;
            bool result = await _bookrepository.Successing();
            return result;
           
        }
    }
}
