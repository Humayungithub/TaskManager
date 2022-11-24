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
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public virtual  ICollection<TaskRequests> Tasks { get; set; }
    }
}
