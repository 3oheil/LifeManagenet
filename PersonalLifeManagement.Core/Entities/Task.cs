using Domain.Enums;

namespace Domain.Entities
{
    public class Task : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Domain.Enums.TaskStatus Status { get; set; }
        public TaskPriority Priority{ get; set; }
        public DateTime? DeadLine { get; set; }


    }
}
