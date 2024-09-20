using ConsoleApp1.Concrate;

namespace ClassLibrary.Concrate;

public class Post:BaseEntity
{
    //Foreign key
    public int UserId { get; set; }

    //Navigation property
    public User User { get; set; }
    public ICollection<CommentClass> Comments { get; set;}
}
