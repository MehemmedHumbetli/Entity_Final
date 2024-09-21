using ClassLibrary.Abstract;

namespace ClassLibrary.Concrate;

public class User:BaseEntity
{
    public int Id { get; set; }

    //Foreign key
    public int UserDetailsId { get; set; }

    //Navigation property
    public UserDetails UserDetails { get; set; }
    public ICollection<Post> Posts { get; set; }
}
