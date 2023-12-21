using WebApi8.FisstApp.Models;

namespace WebApi8.FisstApp.Dto.Create
{
    public class CreateTodo
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public bool RemidMe { get; set; }
        public DateTime DueDate { get; set; }
        public IList<string>? Tags { get; set; }
        public CreateSubTask SubTask { get; set; }
    }

    public class CreateSubTask
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
    }
}
