namespace Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
