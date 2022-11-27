using TaskManager.Models;

namespace TaskManager.DTO.PersonDto
{
    public class PersonReadOnlyDto : BaseDtoPerson
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<TaskRequests> Tasks { get; set; }
    }
}
