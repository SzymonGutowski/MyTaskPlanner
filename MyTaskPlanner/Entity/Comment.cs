namespace MyTaskPlanner.Entity
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public Task Tasks { get; set; }

        public Guid TaskId { get; set; }
    }
}
