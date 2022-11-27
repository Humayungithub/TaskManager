using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    [Table("Person")]
    public partial class Person
    {
        public Person()
        {
            Tasks = new HashSet<TaskRequests>();
        }
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public virtual ICollection<TaskRequests> Tasks { get; set; }
    }
}
