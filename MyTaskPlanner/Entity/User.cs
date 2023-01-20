namespace MyTaskPlanner.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }

        public long PhoneNumber { get; set; }
        public UserDetails UserDetails { get; set; }


    }
}
