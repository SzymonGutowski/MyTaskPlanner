using Microsoft.EntityFrameworkCore;

namespace MyTaskPlanner.Entity
{
    public class MyTaskPlannerContext : DbContext
    {
        public MyTaskPlannerContext(DbContextOptions<MyTaskPlannerContext> options) : base(options)
        {

        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<UserDetails> Statuses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(wb =>
            {
                wb.Property(x => x.Id).IsRequired();
                wb.Property(x => x.CreatedDate).HasDefaultValueSql("getutcdate()");
            });
            modelBuilder.Entity<Task>(wb =>
            {
                wb.Property(x => x.Title).IsRequired();
                wb.Property(x => x.Title).HasMaxLength(250);
                wb.Property(x => x.Content).HasColumnType("varchar(45)");
                wb.Property(x => x.Prority).HasDefaultValue(1);
                wb.Property(x => x.CreatedDate).HasDefaultValueSql("getutcdate()");
                wb.HasMany(y => y.Comments).WithOne(z => z.Tasks).HasForeignKey(w => w.TaskId);
            });

            modelBuilder.Entity<User>(u =>
                {
                    u.Property(x => x.CreatedDate).HasDefaultValueSql("getutcdate()");
                });
            modelBuilder.Entity<UserDetails>().HasKey(y => y.JobId).HasName("Job_ID");

            modelBuilder.Entity<User>().HasOne(x => x.UserDetails).WithOne(y => y.User).HasForeignKey<UserDetails>(z => z.JobId);

        }
    }
}
