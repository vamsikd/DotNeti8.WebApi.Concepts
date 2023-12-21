namespace WebApi8.FisstApp.Dto.Base
{
    public abstract class GetAuditable
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
