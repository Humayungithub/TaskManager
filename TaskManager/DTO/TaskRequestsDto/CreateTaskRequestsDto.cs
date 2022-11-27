using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskManager.Models;

namespace TaskManager.DTO.TaskRequestsDto
{
    public class CreateTaskRequestsDto
    {
        [Required]
        [StringLength(50)]
        public string Label { get; set; } = string.Empty;
        [StringLength(200)]
        public string Description { get; set; } = string.Empty;
        public int? PersonId { get; set; }
        public virtual Person? TaskFor { get; set; }
        public DateTime? DueTime { get; set; }
        public bool? IsCompleted { get; set; } = false;
    }
}
