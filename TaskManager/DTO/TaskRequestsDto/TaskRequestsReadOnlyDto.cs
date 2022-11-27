using TaskManager.Models;

namespace TaskManager.DTO.TaskRequestsDto
{
    public class TaskRequestsReadOnlyDto : BaseDtoTask
    {
        public string Label { get; set; }
        public string Description { get; set; }
        public virtual Person? TaskFor { get; set; }
        public DateTime? DueTime { get; set; }
        public bool? IsCompleted { get; set; }

    }
}
