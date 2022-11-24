using TaskManager.Models;

namespace TaskManager.DTO
{
    public class PersonReadOnlyDto : BaseDto
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public virtual ICollection<TaskRequests> Tasks { get; set; }
    }
}
