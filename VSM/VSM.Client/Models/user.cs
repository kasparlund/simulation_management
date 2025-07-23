namespace VSM.Client.Datamodel
{
    public class User
    {
        public User(string initials)
        {
            Initials = initials;
        }
        public int Id { get; set; }
        public string Initials { get; set; }
    }
}