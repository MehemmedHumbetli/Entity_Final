using ClassLibrary.Concrate;

namespace ConsoleApp1.Concrate;

public class User:BaseEntity
{
    public int Id { get; set; }
    public UserDetails UserDetails { get; set; }

    //Foreign key
    public int UserDetailsId { get; set; }

    //Navigation property
    public ICollection<Post> Posts { get; set; }
}
