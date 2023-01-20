using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTaskPlanner.Entity
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? Deadline { get; set; }

        public string Prority { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
        
    }
}
