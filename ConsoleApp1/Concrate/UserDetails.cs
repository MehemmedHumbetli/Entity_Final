namespace ConsoleApp1.Concrate;

public class UserDetails:BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDay { get; set; }
    public enum Role { admin = 0, user = 1}
}
