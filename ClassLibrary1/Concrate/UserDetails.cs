using ClassLibrary.Abstract;

namespace ClassLibrary.Concrate;
public class UserDetails:BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDay { get; set; }
    public Role UserRole { get; set; }

    // Enum
    public enum Role
    {
        Admin = 0,
        User = 1
    }
}
