using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    public class Log
    {
        public int TaskId { get; set; }
        public string? Label { get; set; }
        [ForeignKey("Person")]
        public int PersonID { get; set; }
        public Person TaskFor { get; set; }
    }
}
