using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Repositories
{
    public enum Items
    {
        Ruti,
        Dal,
        Vaji,
        Bread,
        Butter,
        jelly,
        cake,
        Singara,
        Samocha,
        Khichuri,
        omlet,
        burger,
        sandwich,
        roll,
        pitha,
        soup,
        noodles,
    }
    [Table("TaskRequests")]
    public class TaskRequests
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Items ItemsDescription { get; set; }
        public DateTime Date { get; set; }
        public virtual Person Person { get; set; }
        public bool IsCompleted { get; set; }
    }
}
