using Aplication.Features.Comands.CreateBookComand;
using Aplication.Features.Comands.CreateDeleteComand;
using Aplication.Features.Comands.UpdateBookComand;
using Aplication.Features.Queries.GetAllBook;
using Aplication.Features.Queries.GetBook;
using Aplication.Interfaces.Repository;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookSiteWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpGet]
        [Route("GetAllBook")]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBook() 
        {
            var query = new GetAllBookQuery();
            return Ok(await _mediator.Send(query));
            
        }
        [HttpGet]
        [Route("GetBook/{id:int}")]
        public async Task<ActionResult<Book>> GetBookk(int id)
        {
            var query = new GetBookByIdQuery { Id = id };
            return Ok(await _mediator.Send(query));

        }
        [HttpPost]
        [Route("AddBook")]
        public async Task<ActionResult<bool>> AddBook(CreateBookComand comand)
        {
            return Ok(await _mediator.Send(comand));
        }
        [HttpDelete]
        [Route("DeleteBook/{id:int}")]
        public async Task<ActionResult<bool>> DeleteBook([FromRoute]int id) {
            var comand = new DeleteBookComand() { Id = id };
            return Ok(await _mediator.Send(comand));
        }
        [HttpPut]
        [Route("UpdateBook/{id:int}")]
        public async Task<ActionResult<bool>> UpdateBook([FromRoute] int id,UpdateBookComand comand) 
        {
            comand.id = id;
            return Ok(await _mediator.Send(comand));
        }
    }
}
