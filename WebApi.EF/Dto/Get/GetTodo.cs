

using WebApi8.FisstApp.Dto.Base;

namespace WebApi8.FisstApp.Dto.Get
{
    public class GetTodo : GetAuditable
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool RemidMe { get; set; }
        public DateTime DueDate { get; set; }
        public IList<string> Tags { get; set; }
        public GetSubTask SubTask { get; set; }
    }

    public class GetSubTask
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }

    }
}
