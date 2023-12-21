using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi8.FisstApp.Database;
using WebApi8.FisstApp.Dto.Create;
using WebApi8.FisstApp.Dto.Get;
using WebApi8.FisstApp.Models;

namespace WebApi8.FisstApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoDbContext _context;
        private readonly IMapper _mapper;

        public TodoController(TodoDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult<GetTodo>> Post([FromBody] CreateTodo createTodo)
        {
            Todo todo = _mapper.Map<Todo>(createTodo);
            await _context.AddAsync<Todo>(todo);
            await _context.SaveChangesAsync();
            GetTodo getTodo = _mapper.Map<GetTodo>(todo);
            return Ok(getTodo);
            
        }

        [HttpGet]
        public async Task<ActionResult<IList<GetTodo>>> Get()
        {
            var todos = await _context.Todos.AsNoTracking().ToListAsync();
            return Ok(_mapper.Map<IList<GetTodo>>(todos));
        }

        [HttpGet]
        [Route("GetByTag")]
        public async Task<ActionResult<IList<GetTodo>>> Get([FromQuery] string tag)
        {
            var todos = await _context.Todos
                .Where(t => t.Tags != null && t.Tags.Contains(tag))
                .AsNoTracking()
                .ToListAsync();
            return Ok(_mapper.Map<IList<GetTodo>>(todos));
        }
    }
}
