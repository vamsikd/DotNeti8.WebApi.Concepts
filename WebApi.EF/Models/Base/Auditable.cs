using WebApi8.FisstApp.Models.Interfacess;

namespace WebApi8.FisstApp.Models.Base
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
