using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    [Table("TaskRequests")]
    public partial class TaskRequests
    {
        [Key]
        public int TaskId { get; set; }
        public string Label { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? PersonId { get; set; }
        public virtual Person? TaskFor { get; set; }
        public DateTime? DueTime { get; set; }
        public bool? IsCompleted { get; set; }
    }
}
