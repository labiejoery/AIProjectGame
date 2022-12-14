namespace Domain.Users
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }
        public IEnumerable<User> Patienten { get; set; }

        protected User()
        {
            Patienten = new List<User>();
        }
        public User(string firstname, string lastname, RoleEnum role)
        {
            FirstName = firstname;
            LastName = lastname;
            Role = role;
        }


    }
}
