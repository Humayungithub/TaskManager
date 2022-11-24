using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Repositories
{
    [Table("Person")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public int? Phone { get; set; }
        public virtual  ICollection<TaskRequests> Tasks { get; set; }
    }
}
