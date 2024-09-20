namespace ClassLibrary.Concrate;

public class CommentClass:BaseEntity
{
    public int UserId { get; set; }
    public ICollection<Post> Posts { get; set; }
}
