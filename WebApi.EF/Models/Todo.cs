using WebApi8.FisstApp.Models.Base;

namespace WebApi8.FisstApp.Models
{
    public class Todo : Auditable
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public bool RemidMe { get; set; }
        public DateTime? DueDate { get; set; }
        public IList<string>? Tags { get; set; }
        public SubTask? SubTask { get; set; }
    }

    public class SubTask
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }

    }
}
